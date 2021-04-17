namespace ExchangePiHost
{
    partial class ServerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForm));
            this.panel_ews = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.input_ews = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.input_password = new System.Windows.Forms.TextBox();
            this.input_username = new System.Windows.Forms.TextBox();
            this.input_calendar = new System.Windows.Forms.TextBox();
            this.label_server_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.input_mx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.input_domain = new System.Windows.Forms.TextBox();
            this.label_exchange = new System.Windows.Forms.Label();
            this.panel_websocket = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.input_html = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.input_port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.consoleBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_opt = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_settings = new System.Windows.Forms.Panel();
            this.panel_calendar = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.numeric_end = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numeric_appoint = new System.Windows.Forms.NumericUpDown();
            this.label_cal = new System.Windows.Forms.Label();
            this.panel_ews.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_websocket.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_opt.SuspendLayout();
            this.panel_settings.SuspendLayout();
            this.panel_calendar.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_appoint)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ews
            // 
            this.panel_ews.Controls.Add(this.tableLayoutPanel1);
            this.panel_ews.Controls.Add(this.label_exchange);
            this.panel_ews.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ews.Location = new System.Drawing.Point(0, 0);
            this.panel_ews.Margin = new System.Windows.Forms.Padding(4);
            this.panel_ews.Name = "panel_ews";
            this.panel_ews.Size = new System.Drawing.Size(625, 360);
            this.panel_ews.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.input_ews, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.input_password, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.input_username, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.input_calendar, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label_server_name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.input_mx, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.input_domain, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(625, 333);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // input_ews
            // 
            this.input_ews.BackColor = System.Drawing.Color.Black;
            this.input_ews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_ews.Dock = System.Windows.Forms.DockStyle.Left;
            this.input_ews.ForeColor = System.Drawing.Color.White;
            this.input_ews.Location = new System.Drawing.Point(0, 135);
            this.input_ews.Margin = new System.Windows.Forms.Padding(0);
            this.input_ews.Name = "input_ews";
            this.input_ews.Size = new System.Drawing.Size(255, 22);
            this.input_ews.TabIndex = 10;
            this.input_ews.Text = "Exchange2010";
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(619, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Exchange Version (ExchangeYYYY SPX)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // input_password
            // 
            this.input_password.BackColor = System.Drawing.Color.Black;
            this.input_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_password.Dock = System.Windows.Forms.DockStyle.Left;
            this.input_password.ForeColor = System.Drawing.Color.White;
            this.input_password.Location = new System.Drawing.Point(0, 300);
            this.input_password.Margin = new System.Windows.Forms.Padding(0);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(255, 22);
            this.input_password.TabIndex = 8;
            this.input_password.UseSystemPasswordChar = true;
            // 
            // input_username
            // 
            this.input_username.BackColor = System.Drawing.Color.Black;
            this.input_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_username.Dock = System.Windows.Forms.DockStyle.Left;
            this.input_username.ForeColor = System.Drawing.Color.White;
            this.input_username.Location = new System.Drawing.Point(0, 245);
            this.input_username.Margin = new System.Windows.Forms.Padding(0);
            this.input_username.Name = "input_username";
            this.input_username.Size = new System.Drawing.Size(255, 22);
            this.input_username.TabIndex = 7;
            // 
            // input_calendar
            // 
            this.input_calendar.BackColor = System.Drawing.Color.Black;
            this.input_calendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_calendar.Dock = System.Windows.Forms.DockStyle.Left;
            this.input_calendar.ForeColor = System.Drawing.Color.White;
            this.input_calendar.Location = new System.Drawing.Point(0, 190);
            this.input_calendar.Margin = new System.Windows.Forms.Padding(0);
            this.input_calendar.Name = "input_calendar";
            this.input_calendar.Size = new System.Drawing.Size(255, 22);
            this.input_calendar.TabIndex = 6;
            // 
            // label_server_name
            // 
            this.label_server_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_server_name.Location = new System.Drawing.Point(3, 0);
            this.label_server_name.Name = "label_server_name";
            this.label_server_name.Size = new System.Drawing.Size(619, 25);
            this.label_server_name.TabIndex = 1;
            this.label_server_name.Text = "Autodiscover - ASMX";
            this.label_server_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(619, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lookup Email";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(619, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Admin Username";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(619, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Admin Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // input_mx
            // 
            this.input_mx.BackColor = System.Drawing.Color.Black;
            this.input_mx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_mx.Dock = System.Windows.Forms.DockStyle.Left;
            this.input_mx.ForeColor = System.Drawing.Color.White;
            this.input_mx.Location = new System.Drawing.Point(0, 25);
            this.input_mx.Margin = new System.Windows.Forms.Padding(0);
            this.input_mx.Name = "input_mx";
            this.input_mx.Size = new System.Drawing.Size(444, 22);
            this.input_mx.TabIndex = 5;
            this.input_mx.Text = "https://mail.local.host/EWS/exchange.asmx";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(619, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Domain";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // input_domain
            // 
            this.input_domain.BackColor = System.Drawing.Color.Black;
            this.input_domain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_domain.Dock = System.Windows.Forms.DockStyle.Left;
            this.input_domain.ForeColor = System.Drawing.Color.White;
            this.input_domain.Location = new System.Drawing.Point(0, 80);
            this.input_domain.Margin = new System.Windows.Forms.Padding(0);
            this.input_domain.Name = "input_domain";
            this.input_domain.Size = new System.Drawing.Size(255, 22);
            this.input_domain.TabIndex = 12;
            this.input_domain.Text = "localhost";
            // 
            // label_exchange
            // 
            this.label_exchange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label_exchange.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_exchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exchange.Location = new System.Drawing.Point(0, 0);
            this.label_exchange.Name = "label_exchange";
            this.label_exchange.Size = new System.Drawing.Size(625, 27);
            this.label_exchange.TabIndex = 0;
            this.label_exchange.Text = "Exchange Server Settings";
            this.label_exchange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_exchange.Click += new System.EventHandler(this.label_exchange_Click);
            // 
            // panel_websocket
            // 
            this.panel_websocket.Controls.Add(this.tableLayoutPanel2);
            this.panel_websocket.Controls.Add(this.label1);
            this.panel_websocket.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_websocket.Location = new System.Drawing.Point(0, 360);
            this.panel_websocket.Margin = new System.Windows.Forms.Padding(4);
            this.panel_websocket.Name = "panel_websocket";
            this.panel_websocket.Size = new System.Drawing.Size(625, 150);
            this.panel_websocket.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.input_html, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.input_port, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(625, 123);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // input_html
            // 
            this.input_html.BackColor = System.Drawing.Color.Black;
            this.input_html.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_html.Dock = System.Windows.Forms.DockStyle.Left;
            this.input_html.ForeColor = System.Drawing.Color.White;
            this.input_html.Location = new System.Drawing.Point(0, 80);
            this.input_html.Margin = new System.Windows.Forms.Padding(0);
            this.input_html.Name = "input_html";
            this.input_html.Size = new System.Drawing.Size(255, 22);
            this.input_html.TabIndex = 6;
            this.input_html.Text = ".\\calendar.html";
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(619, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Port #";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(619, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Default File:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // input_port
            // 
            this.input_port.BackColor = System.Drawing.Color.Black;
            this.input_port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_port.Dock = System.Windows.Forms.DockStyle.Left;
            this.input_port.ForeColor = System.Drawing.Color.White;
            this.input_port.Location = new System.Drawing.Point(0, 25);
            this.input_port.Margin = new System.Windows.Forms.Padding(0);
            this.input_port.Name = "input_port";
            this.input_port.Size = new System.Drawing.Size(255, 22);
            this.input_port.TabIndex = 5;
            this.input_port.Text = "38060";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Web Socket Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.consoleBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 643);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(642, 132);
            this.panel3.TabIndex = 2;
            // 
            // consoleBox
            // 
            this.consoleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.consoleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.consoleBox.Location = new System.Drawing.Point(0, 27);
            this.consoleBox.MaxLength = 2147483647;
            this.consoleBox.Multiline = true;
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ReadOnly = true;
            this.consoleBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleBox.Size = new System.Drawing.Size(642, 105);
            this.consoleBox.TabIndex = 1;
            this.consoleBox.Text = "Opening Log...";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(642, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Console / Log";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_opt
            // 
            this.panel_opt.Controls.Add(this.button3);
            this.panel_opt.Controls.Add(this.button2);
            this.panel_opt.Controls.Add(this.button1);
            this.panel_opt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_opt.Location = new System.Drawing.Point(0, 775);
            this.panel_opt.Name = "panel_opt";
            this.panel_opt.Size = new System.Drawing.Size(642, 29);
            this.panel_opt.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(391, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Test EWS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(492, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stop WS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(567, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run WS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_settings
            // 
            this.panel_settings.AutoScroll = true;
            this.panel_settings.Controls.Add(this.panel_calendar);
            this.panel_settings.Controls.Add(this.panel_websocket);
            this.panel_settings.Controls.Add(this.panel_ews);
            this.panel_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_settings.Location = new System.Drawing.Point(0, 0);
            this.panel_settings.Name = "panel_settings";
            this.panel_settings.Size = new System.Drawing.Size(642, 643);
            this.panel_settings.TabIndex = 4;
            // 
            // panel_calendar
            // 
            this.panel_calendar.Controls.Add(this.tableLayoutPanel3);
            this.panel_calendar.Controls.Add(this.label_cal);
            this.panel_calendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_calendar.Location = new System.Drawing.Point(0, 510);
            this.panel_calendar.Name = "panel_calendar";
            this.panel_calendar.Size = new System.Drawing.Size(625, 150);
            this.panel_calendar.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.numeric_end, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.numeric_appoint, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(625, 123);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // numeric_end
            // 
            this.numeric_end.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.numeric_end.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_end.Dock = System.Windows.Forms.DockStyle.Left;
            this.numeric_end.ForeColor = System.Drawing.Color.White;
            this.numeric_end.Location = new System.Drawing.Point(0, 80);
            this.numeric_end.Margin = new System.Windows.Forms.Padding(0);
            this.numeric_end.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numeric_end.Name = "numeric_end";
            this.numeric_end.Size = new System.Drawing.Size(255, 22);
            this.numeric_end.TabIndex = 4;
            this.numeric_end.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(619, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Max Appointments";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(619, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "End Time (Current+Days)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numeric_appoint
            // 
            this.numeric_appoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.numeric_appoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_appoint.Dock = System.Windows.Forms.DockStyle.Left;
            this.numeric_appoint.ForeColor = System.Drawing.Color.White;
            this.numeric_appoint.Location = new System.Drawing.Point(0, 25);
            this.numeric_appoint.Margin = new System.Windows.Forms.Padding(0);
            this.numeric_appoint.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numeric_appoint.Name = "numeric_appoint";
            this.numeric_appoint.Size = new System.Drawing.Size(255, 22);
            this.numeric_appoint.TabIndex = 3;
            this.numeric_appoint.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label_cal
            // 
            this.label_cal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label_cal.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cal.Location = new System.Drawing.Point(0, 0);
            this.label_cal.Name = "label_cal";
            this.label_cal.Size = new System.Drawing.Size(625, 27);
            this.label_cal.TabIndex = 1;
            this.label_cal.Text = "Calendar Settings";
            this.label_cal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_cal.Click += new System.EventHandler(this.label_cal_Click);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(642, 804);
            this.Controls.Add(this.panel_settings);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_opt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(658, 648);
            this.Name = "ServerForm";
            this.Text = "Pichange Host";
            this.panel_ews.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel_websocket.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_opt.ResumeLayout(false);
            this.panel_settings.ResumeLayout(false);
            this.panel_calendar.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_appoint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ews;
        private System.Windows.Forms.Label label_exchange;
        private System.Windows.Forms.Panel panel_websocket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox consoleBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_server_name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.TextBox input_username;
        private System.Windows.Forms.TextBox input_calendar;
        private System.Windows.Forms.TextBox input_mx;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox input_html;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox input_port;
        private System.Windows.Forms.Panel panel_opt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox input_ews;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox input_domain;
        private System.Windows.Forms.Panel panel_settings;
        private System.Windows.Forms.Panel panel_calendar;
        private System.Windows.Forms.Label label_cal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.NumericUpDown numeric_end;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numeric_appoint;
    }
}

