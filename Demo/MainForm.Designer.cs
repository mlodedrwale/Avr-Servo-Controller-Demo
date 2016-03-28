namespace Demo
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
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.slider12 = new Demo.Slider();
            this.slider11 = new Demo.Slider();
            this.slider10 = new Demo.Slider();
            this.slider9 = new Demo.Slider();
            this.slider8 = new Demo.Slider();
            this.slider7 = new Demo.Slider();
            this.slider6 = new Demo.Slider();
            this.slider5 = new Demo.Slider();
            this.slider4 = new Demo.Slider();
            this.slider3 = new Demo.Slider();
            this.slider2 = new Demo.Slider();
            this.slider1 = new Demo.Slider();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboPort
            // 
            this.cboPort.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(7, 19);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(86, 21);
            this.cboPort.TabIndex = 0;
            this.cboPort.SelectedIndexChanged += new System.EventHandler(this.cboPort_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboPort);
            this.groupBox1.Location = new System.Drawing.Point(618, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 49);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port";
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(625, 223);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(86, 23);
            this.btnConnect.TabIndex = 14;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // slider12
            // 
            this.slider12.Dock = System.Windows.Forms.DockStyle.Left;
            this.slider12.Location = new System.Drawing.Point(561, 0);
            this.slider12.Name = "slider12";
            this.slider12.ServoName = "A";
            this.slider12.Size = new System.Drawing.Size(51, 258);
            this.slider12.TabIndex = 12;
            this.slider12.Value = 0;
            // 
            // slider11
            // 
            this.slider11.Dock = System.Windows.Forms.DockStyle.Left;
            this.slider11.Location = new System.Drawing.Point(510, 0);
            this.slider11.Name = "slider11";
            this.slider11.ServoName = "A";
            this.slider11.Size = new System.Drawing.Size(51, 258);
            this.slider11.TabIndex = 11;
            this.slider11.Value = 0;
            // 
            // slider10
            // 
            this.slider10.Dock = System.Windows.Forms.DockStyle.Left;
            this.slider10.Location = new System.Drawing.Point(459, 0);
            this.slider10.Name = "slider10";
            this.slider10.ServoName = "A";
            this.slider10.Size = new System.Drawing.Size(51, 258);
            this.slider10.TabIndex = 10;
            this.slider10.Value = 0;
            // 
            // slider9
            // 
            this.slider9.Dock = System.Windows.Forms.DockStyle.Left;
            this.slider9.Location = new System.Drawing.Point(408, 0);
            this.slider9.Name = "slider9";
            this.slider9.ServoName = "A";
            this.slider9.Size = new System.Drawing.Size(51, 258);
            this.slider9.TabIndex = 9;
            this.slider9.Value = 0;
            // 
            // slider8
            // 
            this.slider8.Dock = System.Windows.Forms.DockStyle.Left;
            this.slider8.Location = new System.Drawing.Point(357, 0);
            this.slider8.Name = "slider8";
            this.slider8.ServoName = "A";
            this.slider8.Size = new System.Drawing.Size(51, 258);
            this.slider8.TabIndex = 8;
            this.slider8.Value = 0;
            // 
            // slider7
            // 
            this.slider7.Dock = System.Windows.Forms.DockStyle.Left;
            this.slider7.Location = new System.Drawing.Point(306, 0);
            this.slider7.Name = "slider7";
            this.slider7.ServoName = "A";
            this.slider7.Size = new System.Drawing.Size(51, 258);
            this.slider7.TabIndex = 7;
            this.slider7.Value = 0;
            // 
            // slider6
            // 
            this.slider6.Dock = System.Windows.Forms.DockStyle.Left;
            this.slider6.Location = new System.Drawing.Point(255, 0);
            this.slider6.Name = "slider6";
            this.slider6.ServoName = "A";
            this.slider6.Size = new System.Drawing.Size(51, 258);
            this.slider6.TabIndex = 6;
            this.slider6.Value = 0;
            // 
            // slider5
            // 
            this.slider5.Dock = System.Windows.Forms.DockStyle.Left;
            this.slider5.Location = new System.Drawing.Point(204, 0);
            this.slider5.Name = "slider5";
            this.slider5.ServoName = "A";
            this.slider5.Size = new System.Drawing.Size(51, 258);
            this.slider5.TabIndex = 5;
            this.slider5.Value = 0;
            // 
            // slider4
            // 
            this.slider4.Dock = System.Windows.Forms.DockStyle.Left;
            this.slider4.Location = new System.Drawing.Point(153, 0);
            this.slider4.Name = "slider4";
            this.slider4.ServoName = "A";
            this.slider4.Size = new System.Drawing.Size(51, 258);
            this.slider4.TabIndex = 4;
            this.slider4.Value = 0;
            // 
            // slider3
            // 
            this.slider3.Dock = System.Windows.Forms.DockStyle.Left;
            this.slider3.Location = new System.Drawing.Point(102, 0);
            this.slider3.Name = "slider3";
            this.slider3.ServoName = "A";
            this.slider3.Size = new System.Drawing.Size(51, 258);
            this.slider3.TabIndex = 3;
            this.slider3.Value = 0;
            // 
            // slider2
            // 
            this.slider2.Dock = System.Windows.Forms.DockStyle.Left;
            this.slider2.Location = new System.Drawing.Point(51, 0);
            this.slider2.Name = "slider2";
            this.slider2.ServoName = "A";
            this.slider2.Size = new System.Drawing.Size(51, 258);
            this.slider2.TabIndex = 2;
            this.slider2.Value = 0;
            // 
            // slider1
            // 
            this.slider1.Dock = System.Windows.Forms.DockStyle.Left;
            this.slider1.Location = new System.Drawing.Point(0, 0);
            this.slider1.Name = "slider1";
            this.slider1.ServoName = "A";
            this.slider1.Size = new System.Drawing.Size(51, 258);
            this.slider1.TabIndex = 1;
            this.slider1.Value = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 258);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.slider12);
            this.Controls.Add(this.slider11);
            this.Controls.Add(this.slider10);
            this.Controls.Add(this.slider9);
            this.Controls.Add(this.slider8);
            this.Controls.Add(this.slider7);
            this.Controls.Add(this.slider6);
            this.Controls.Add(this.slider5);
            this.Controls.Add(this.slider4);
            this.Controls.Add(this.slider3);
            this.Controls.Add(this.slider2);
            this.Controls.Add(this.slider1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Avr Servo Controller Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPort;
        private Slider slider1;
        private Slider slider2;
        private Slider slider3;
        private Slider slider4;
        private Slider slider5;
        private Slider slider6;
        private Slider slider7;
        private Slider slider8;
        private Slider slider9;
        private Slider slider10;
        private Slider slider11;
        private Slider slider12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnect;
    }
}

