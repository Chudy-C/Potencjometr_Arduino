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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.patientBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.colonL = new System.Windows.Forms.Label();
            this.colonR = new System.Windows.Forms.Label();
            this.milisecondsText = new System.Windows.Forms.Label();
            this.secondsText = new System.Windows.Forms.Label();
            this.minutesText = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.resetTimerButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.lmilis = new System.Windows.Forms.Label();
            this.lSeconds = new System.Windows.Forms.Label();
            this.lMinutes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.measurementTimer = new System.Windows.Forms.Timer(this.components);
            this.lPercentage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.progressChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.progressBar.Maximum = 255;
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
            chartArea1.Name = "ChartArea1";
            this.progressChart.ChartAreas.Add(chartArea1);
            this.progressChart.Location = new System.Drawing.Point(17, 26);
            this.progressChart.Name = "progressChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series1.Name = "Potentiometer";
            this.progressChart.Series.Add(series1);
            this.progressChart.Size = new System.Drawing.Size(465, 229);
            this.progressChart.TabIndex = 8;
            this.progressChart.Text = "VoltageChart";
            title1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title1.Name = "Title1";
            title1.Text = "Voltage";
            this.progressChart.Titles.Add(title1);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.patientBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 102);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient";
            // 
            // patientBox
            // 
            this.patientBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patientBox.FormattingEnabled = true;
            this.patientBox.Items.AddRange(new object[] {
            "Grzegorz Brzęczyszczykiewicz",
            "Maciej Chudziński",
            "Jan Kowalski",
            "Jan Jan"});
            this.patientBox.Location = new System.Drawing.Point(14, 41);
            this.patientBox.Name = "patientBox";
            this.patientBox.Size = new System.Drawing.Size(304, 27);
            this.patientBox.TabIndex = 0;
            this.patientBox.SelectedIndexChanged += new System.EventHandler(this.patientBox_SelectedIndexChanged);
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
            // colonL
            // 
            this.colonL.AutoSize = true;
            this.colonL.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.colonL.Location = new System.Drawing.Point(181, 64);
            this.colonL.Name = "colonL";
            this.colonL.Size = new System.Drawing.Size(26, 37);
            this.colonL.TabIndex = 17;
            this.colonL.Text = ":";
            // 
            // colonR
            // 
            this.colonR.AutoSize = true;
            this.colonR.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.colonR.Location = new System.Drawing.Point(252, 65);
            this.colonR.Name = "colonR";
            this.colonR.Size = new System.Drawing.Size(26, 37);
            this.colonR.TabIndex = 18;
            this.colonR.Text = ":";
            // 
            // milisecondsText
            // 
            this.milisecondsText.AutoSize = true;
            this.milisecondsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.milisecondsText.Location = new System.Drawing.Point(274, 65);
            this.milisecondsText.Name = "milisecondsText";
            this.milisecondsText.Size = new System.Drawing.Size(53, 38);
            this.milisecondsText.TabIndex = 14;
            this.milisecondsText.Text = "00";
            // 
            // secondsText
            // 
            this.secondsText.AutoSize = true;
            this.secondsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondsText.Location = new System.Drawing.Point(203, 65);
            this.secondsText.Name = "secondsText";
            this.secondsText.Size = new System.Drawing.Size(53, 38);
            this.secondsText.TabIndex = 15;
            this.secondsText.Text = "00";
            // 
            // minutesText
            // 
            this.minutesText.AutoSize = true;
            this.minutesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minutesText.Location = new System.Drawing.Point(135, 64);
            this.minutesText.Name = "minutesText";
            this.minutesText.Size = new System.Drawing.Size(53, 38);
            this.minutesText.TabIndex = 16;
            this.minutesText.Text = "00";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.resetTimerButton);
            this.groupBox4.Controls.Add(this.stopButton);
            this.groupBox4.Controls.Add(this.startButton);
            this.groupBox4.Controls.Add(this.lmilis);
            this.groupBox4.Controls.Add(this.lSeconds);
            this.groupBox4.Controls.Add(this.lMinutes);
            this.groupBox4.Controls.Add(this.secondsText);
            this.groupBox4.Controls.Add(this.colonL);
            this.groupBox4.Controls.Add(this.minutesText);
            this.groupBox4.Controls.Add(this.colonR);
            this.groupBox4.Controls.Add(this.milisecondsText);
            this.groupBox4.Location = new System.Drawing.Point(13, 245);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(333, 138);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "START / STOP";
            // 
            // resetTimerButton
            // 
            this.resetTimerButton.BackColor = System.Drawing.SystemColors.Control;
            this.resetTimerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.resetTimerButton.FlatAppearance.BorderSize = 20;
            this.resetTimerButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resetTimerButton.Location = new System.Drawing.Point(13, 102);
            this.resetTimerButton.Margin = new System.Windows.Forms.Padding(5);
            this.resetTimerButton.Name = "resetTimerButton";
            this.resetTimerButton.Size = new System.Drawing.Size(103, 27);
            this.resetTimerButton.TabIndex = 25;
            this.resetTimerButton.Text = "Reset";
            this.resetTimerButton.UseVisualStyleBackColor = false;
            this.resetTimerButton.Click += new System.EventHandler(this.resetTimerButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.SystemColors.Control;
            this.stopButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stopButton.FlatAppearance.BorderSize = 20;
            this.stopButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopButton.Location = new System.Drawing.Point(13, 65);
            this.stopButton.Margin = new System.Windows.Forms.Padding(5);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(103, 27);
            this.stopButton.TabIndex = 24;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.Control;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startButton.FlatAppearance.BorderSize = 20;
            this.startButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(12, 28);
            this.startButton.Margin = new System.Windows.Forms.Padding(5);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(103, 27);
            this.startButton.TabIndex = 23;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // lmilis
            // 
            this.lmilis.AutoSize = true;
            this.lmilis.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lmilis.Location = new System.Drawing.Point(277, 48);
            this.lmilis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lmilis.Name = "lmilis";
            this.lmilis.Size = new System.Drawing.Size(40, 19);
            this.lmilis.TabIndex = 22;
            this.lmilis.Text = "milis";
            // 
            // lSeconds
            // 
            this.lSeconds.AutoSize = true;
            this.lSeconds.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lSeconds.Location = new System.Drawing.Point(197, 48);
            this.lSeconds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSeconds.Name = "lSeconds";
            this.lSeconds.Size = new System.Drawing.Size(62, 19);
            this.lSeconds.TabIndex = 21;
            this.lSeconds.Text = "seconds";
            // 
            // lMinutes
            // 
            this.lMinutes.AutoSize = true;
            this.lMinutes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lMinutes.Location = new System.Drawing.Point(127, 48);
            this.lMinutes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMinutes.Name = "lMinutes";
            this.lMinutes.Size = new System.Drawing.Size(61, 19);
            this.lMinutes.TabIndex = 20;
            this.lMinutes.Text = "minutes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PotencjometrArduino.Properties.Resources.wnt_logo_92x92;
            this.pictureBox1.InitialImage = global::PotencjometrArduino.Properties.Resources.wnt_logo_92x92;
            this.pictureBox1.Location = new System.Drawing.Point(254, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 92);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // measurementTimer
            // 
            this.measurementTimer.Enabled = true;
            this.measurementTimer.Interval = 10;
            this.measurementTimer.Tick += new System.EventHandler(this.measurementTimer_Tick);
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
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(873, 399);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(889, 438);
            this.MinimumSize = new System.Drawing.Size(889, 438);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Arduino Potencjometr";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label colonL;
        private System.Windows.Forms.Label colonR;
        private System.Windows.Forms.Label milisecondsText;
        private System.Windows.Forms.Label secondsText;
        private System.Windows.Forms.Label minutesText;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lmilis;
        private System.Windows.Forms.Label lSeconds;
        private System.Windows.Forms.Label lMinutes;
        private System.Windows.Forms.Button resetTimerButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer measurementTimer;
        private System.Windows.Forms.ComboBox patientBox;
        private System.Windows.Forms.Label lPercentage;
    }
}

