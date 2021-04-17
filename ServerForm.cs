using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Exchange.WebServices.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace ExchangePiHost
{
    public partial class ServerForm : Form
    {
        private ExchangeService _ews;
        private HTTPServer _webSocket;
        public ServerForm()
        {
            InitializeComponent();
            Console.SetOut(new ControlWriter(this));
        }
        public class ControlWriter : TextWriter
        {
            private ServerForm textbox;
            public ControlWriter(ServerForm textbox)
            {
                this.textbox = textbox;
            }

            public override void Write(char value)
            {
                textbox.SetText(value+"");
            }

            public override void Write(string value)
            {
                textbox.SetText(value);
            }

            public override Encoding Encoding
            {
                get { return Encoding.ASCII; }
            }
        }

        public delegate void SetConsoleText(string value);

        public void SetText(string value)
        {
            if (consoleBox.InvokeRequired)
            {
                SetConsoleText del = SetText;
                consoleBox.Invoke(del, value);
            }
            else
            {
                consoleBox.Text += value;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                _ews = ConnectEWS();
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Checking Privileged Connection...");
                try
                {
                    OofSettings oof = _ews.GetUserOofSettings(input_calendar.Text);
                    Console.WriteLine("Allowed Out of Office...");
                    Console.WriteLine($"{oof.State}\r\n{oof.InternalReply}\r\n{oof.ExternalReply}\r\n");
                }
                catch (Exception)
                {
                    Console.WriteLine("Denied Out of Office...");
                }
                Console.WriteLine("Checking Appointment Connection...");
                try
                {
                    var folder = GetFolders();
                    Console.WriteLine("Allowed Calendar Views...");
                    PrintFolders(folder);
                    List<Appointment> list = GetAppointments(folder);
                    List<JSONAppointment> jsonAppointments = WriteJSON(list);
                    Console.WriteLine(@"Writing to JSON File...");
                    File.WriteAllText("appointments.json", JsonConvert.SerializeObject(jsonAppointments.ToArray()));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Denied Calendar Views...");
                }
                Console.WriteLine("EWS SUCCEEDED - OPEN THE WEB SOCKET!");
            }
            catch (Exception)
            {
                Console.WriteLine("EWS FAILED - CHECK SETTINGS!");
            }
        }

        private ExchangeService ConnectEWS()
        {
            ExchangeVersion version = ExchangeVersion.Exchange2013_SP1;
            switch (input_ews.Text)
            {
                case "Exchange2010":
                    version = ExchangeVersion.Exchange2010;
                    break;
                case "Exchange2010 SP1":
                    version = ExchangeVersion.Exchange2010_SP1;
                    break;
                case "Exchange2010 SP2":
                    version = ExchangeVersion.Exchange2010_SP2;
                    break;
                case "Exchange2013":
                    version = ExchangeVersion.Exchange2013;
                    break;
                case "Exchange2013 SP1":
                    version = ExchangeVersion.Exchange2013_SP1;
                    break;
                case "Exchange2007 SP1":
                    version = ExchangeVersion.Exchange2007_SP1;
                    break;
            }
            return new ExchangeService(version)
            {
                Url = new Uri(input_mx.Text),
                Credentials = new NetworkCredential(input_username.Text, input_password.Text, input_domain.Text),
                KeepAlive = true
            };
        }

        public FindFoldersResults GetFolders()
        {
            var folderView = new FolderView(100)
            {
                Traversal = FolderTraversal.Deep,
                PropertySet =
                    new PropertySet(FolderSchema.FolderClass, FolderSchema.DisplayName, FolderSchema.TotalCount,
                        FolderSchema.ParentFolderId)
            };

            return _ews.FindFolders(WellKnownFolderName.MsgFolderRoot, folderView);
            
        }

        public List<Appointment> GetAppointments(FindFoldersResults folders)
        {
            List<Appointment> appointments = new List<Appointment>();
            // Process each item.
            foreach (Folder myFolder in folders.Folders)
            {
                if (myFolder is CalendarFolder)
                {
                    var calendar = (myFolder as CalendarFolder);
                    // Initialize values for the start and end times, and the number of appointments to retrieve.
                    DateTime startDate = DateTime.Now;
                    DateTime endDate = startDate.AddDays((double) numeric_end.Value);

                    // Set the start and end time and number of appointments to retrieve.
                    CalendarView cView = new CalendarView(startDate, endDate, (int) numeric_appoint.Value);
                    // Limit the properties returned to the appointment's subject, start time, and end time.
                    cView.PropertySet = new PropertySet(ItemSchema.Subject, AppointmentSchema.Start, AppointmentSchema.End);
                    // Retrieve a collection of appointments by using the calendar view.
                    FindItemsResults<Appointment> appointment = calendar.FindAppointments(cView);
                    appointments.AddRange(appointment.Items);
                }
            }
            return appointments;
        }
        private void PrintFolders(FindFoldersResults folders)
        {
            // Process each item.
            foreach (Folder myFolder in folders.Folders)
            {
                if (myFolder is CalendarFolder)
                {
                    var calendar = (myFolder as CalendarFolder);
                    // Initialize values for the start and end times, and the number of appointments to retrieve.
                    DateTime startDate = DateTime.Now;
                    DateTime endDate = startDate.AddDays((double) numeric_end.Value);

                    // Set the start and end time and number of appointments to retrieve.
                    CalendarView cView = new CalendarView(startDate, endDate, (int) numeric_appoint.Value);
                    // Limit the properties returned to the appointment's subject, start time, and end time.
                    cView.PropertySet = new PropertySet(ItemSchema.Subject, AppointmentSchema.Start, AppointmentSchema.End);
                    // Retrieve a collection of appointments by using the calendar view.
                    FindItemsResults<Appointment> appointments = calendar.FindAppointments(cView);
                    foreach (Appointment a in appointments)
                    {
                        Console.Write("Subject: " + a.Subject + " ");
                        Console.Write("Start: " + a.Start + " ");
                        Console.Write("End: " + a.End);
                        Console.WriteLine("\r\n");
                    }
                }
            }
        }

        private void label_exchange_Click(object sender, EventArgs e)
        {
            panel_ews.Height = panel_ews.Height == 360 ? label_exchange.Height : 360;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel_websocket.Height = panel_websocket.Height == 150 ? label1.Height : 150;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int port = Convert.ToInt32(input_port.Text);
            _webSocket = new HTTPServer("./", port, this);
            _webSocket.SetIndexFiles(input_html.Text.Split(','));
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _webSocket.Stop();
            button1.Enabled = true;
            button2.Enabled = false;
        }

        public Stream GetData(string filename)
        {

                Console.WriteLine(@"Opening EWS...");
                _ews = ConnectEWS();
                Console.WriteLine(@"Getting Appointments...");
                List<Appointment> list = GetAppointments(GetFolders());
                Console.WriteLine(@"Writing to JSON Object...");
                List<JSONAppointment> jsonAppointments = WriteJSON(list);
                Console.WriteLine(@"Writing to JSON File...");
                //var jsonSerializerSettings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver(), };
                var json = JsonConvert.SerializeObject(jsonAppointments.ToArray(), new IsoDateTimeConverter());//jsonSerializerSettings);
                MemoryStream stream = new MemoryStream();
                StreamWriter writer = new StreamWriter(stream);
                writer.Write(json);
                writer.Flush();
                stream.Position = 0;
                return stream;
        }

        private static List<JSONAppointment> WriteJSON(List<Appointment> list)
        {
            List<JSONAppointment> jsonAppointments = new List<JSONAppointment>();
            foreach (Appointment appointment in list)
            {
                jsonAppointments.Add(new JSONAppointment(appointment));
            }

            return jsonAppointments;
        }

        [Serializable]
        [DataContract]
        public class JSONAppointment
        {
            [DataMember]
            public string id;
            [DataMember]
            public string title;
            [DataMember]
            public bool allDay;
            [DataMember]
            public string start;
            [DataMember]
            public string end;
            public JSONAppointment(Appointment appointment)
            {
                appointment.Load();
                id = appointment.ICalUid;
                title = appointment?.Subject ?? "Not Available";
                start = appointment.Start.ToString();
                end = appointment.End.ToString();
                allDay = appointment.IsAllDayEvent;
            }
        }

        public bool CheckFile(string data)
        {
            return data.Contains("appointments");
        }

        private void label_cal_Click(object sender, EventArgs e)
        {
            panel_calendar.Height = panel_calendar.Height == 150 ? label_cal.Height : 150;
        }
    }
}
