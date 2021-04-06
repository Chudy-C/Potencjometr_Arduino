namespace PotencjometrArduino
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.arduinoPort = new System.IO.Ports.SerialPort(this.components);
            this.comBox = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lConnection = new System.Windows.Forms.Label();
            this.connectionText = new System.Windows.Forms.Label();
            this.progressChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lByteValue = new System.Windows.Forms.Label();
            this.lVoltageValue = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lPercentage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxReceiver = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.measurementTimer = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.progressChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // arduinoPort
            // 
            this.arduinoPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.port_DataReceived);
            // 
            // comBox
            // 
            this.comBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comBox.FormattingEnabled = true;
            this.comBox.Location = new System.Drawing.Point(13, 27);
            this.comBox.Margin = new System.Windows.Forms.Padding(4);
            this.comBox.Name = "comBox";
            this.comBox.Size = new System.Drawing.Size(104, 27);
            this.comBox.TabIndex = 0;
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.SystemColors.Control;
            this.connectButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.connectButton.FlatAppearance.BorderSize = 20;
            this.connectButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectButton.Location = new System.Drawing.Point(14, 63);
            this.connectButton.Margin = new System.Windows.Forms.Padding(5);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(103, 27);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(17, 330);
            this.progressBar.MarqueeAnimationSpeed = 10;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(465, 30);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 5;
            // 
            // lConnection
            // 
            this.lConnection.AutoSize = true;
            this.lConnection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lConnection.Location = new System.Drawing.Point(138, 30);
            this.lConnection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lConnection.Name = "lConnection";
            this.lConnection.Size = new System.Drawing.Size(60, 19);
            this.lConnection.TabIndex = 6;
            this.lConnection.Text = "STATUS:";
            // 
            // connectionText
            // 
            this.connectionText.AutoSize = true;
            this.connectionText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectionText.ForeColor = System.Drawing.Color.LimeGreen;
            this.connectionText.Location = new System.Drawing.Point(138, 63);
            this.connectionText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connectionText.Name = "connectionText";
            this.connectionText.Size = new System.Drawing.Size(13, 19);
            this.connectionText.TabIndex = 7;
            this.connectionText.Text = " ";
            // 
            // progressChart
            // 
            chartArea2.Name = "ChartArea1";
            this.progressChart.ChartAreas.Add(chartArea2);
            this.progressChart.Location = new System.Drawing.Point(17, 26);
            this.progressChart.Name = "progressChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series2.Name = "Potentiometer";
            this.progressChart.Series.Add(series2);
            this.progressChart.Size = new System.Drawing.Size(465, 229);
            this.progressChart.TabIndex = 8;
            this.progressChart.Text = "VoltageChart";
            title2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title2.Name = "Title1";
            title2.Text = "Voltage";
            this.progressChart.Titles.Add(title2);
            // 
            // lByteValue
            // 
            this.lByteValue.AutoSize = true;
            this.lByteValue.Location = new System.Drawing.Point(155, 267);
            this.lByteValue.Name = "lByteValue";
            this.lByteValue.Size = new System.Drawing.Size(220, 19);
            this.lByteValue.TabIndex = 9;
            this.lByteValue.Text = "Potentiometer Value [Byte] : 000";
            // 
            // lVoltageValue
            // 
            this.lVoltageValue.AutoSize = true;
            this.lVoltageValue.Location = new System.Drawing.Point(165, 295);
            this.lVoltageValue.Name = "lVoltageValue";
            this.lVoltageValue.Size = new System.Drawing.Size(204, 19);
            this.lVoltageValue.TabIndex = 10;
            this.lVoltageValue.Text = "Potentiometer Value [V] : 0.00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comBox);
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Controls.Add(this.lConnection);
            this.groupBox1.Controls.Add(this.connectionText);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 101);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Port";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lPercentage);
            this.groupBox3.Controls.Add(this.progressChart);
            this.groupBox3.Controls.Add(this.lByteValue);
            this.groupBox3.Controls.Add(this.lVoltageValue);
            this.groupBox3.Controls.Add(this.progressBar);
            this.groupBox3.Location = new System.Drawing.Point(365, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(497, 369);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Measurment";
            // 
            // lPercentage
            // 
            this.lPercentage.AutoSize = true;
            this.lPercentage.Location = new System.Drawing.Point(437, 308);
            this.lPercentage.Name = "lPercentage";
            this.lPercentage.Size = new System.Drawing.Size(36, 19);
            this.lPercentage.TabIndex = 11;
            this.lPercentage.Text = "00%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PotencjometrArduino.Properties.Resources.wnt_logo_92x92;
            this.pictureBox1.InitialImage = global::PotencjometrArduino.Properties.Resources.wnt_logo_92x92;
            this.pictureBox1.Location = new System.Drawing.Point(258, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 92);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxReceiver
            // 
            this.textBoxReceiver.Location = new System.Drawing.Point(12, 26);
            this.textBoxReceiver.Multiline = true;
            this.textBoxReceiver.Name = "textBoxReceiver";
            this.textBoxReceiver.Size = new System.Drawing.Size(310, 106);
            this.textBoxReceiver.TabIndex = 21;
            this.textBoxReceiver.TextChanged += new System.EventHandler(this.textBoxReceiver_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxReceiver);
            this.groupBox2.Location = new System.Drawing.Point(13, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 148);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Received";
            // 
            // measurementTimer
            // 
            this.measurementTimer.Interval = 20;
            this.measurementTimer.Tick += new System.EventHandler(this.measurementTimer_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTimer.Location = new System.Drawing.Point(41, 23);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(258, 78);
            this.labelTimer.TabIndex = 22;
            this.labelTimer.Text = "00:00.00";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelTimer);
            this.groupBox4.Location = new System.Drawing.Point(12, 275);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(338, 112);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Time elapsed";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(873, 399);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(889, 438);
            this.MinimumSize = new System.Drawing.Size(889, 438);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Arduino Potencjometr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort arduinoPort;
        private System.Windows.Forms.ComboBox comBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lConnection;
        private System.Windows.Forms.Label connectionText;
        private System.Windows.Forms.DataVisualization.Charting.Chart progressChart;
        private System.Windows.Forms.Label lByteValue;
        private System.Windows.Forms.Label lVoltageValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lPercentage;
        private System.Windows.Forms.TextBox textBoxReceiver;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer measurementTimer;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

