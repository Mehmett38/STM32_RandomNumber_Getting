namespace modelingTx
{
    partial class Form1
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisConnect = new System.Windows.Forms.Button();
            this.labelConnectionState = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.radioButtonChar = new System.Windows.Forms.RadioButton();
            this.radioButtonUint8 = new System.Windows.Forms.RadioButton();
            this.radioButtonUint16 = new System.Windows.Forms.RadioButton();
            this.listBoxReceive = new System.Windows.Forms.ListBox();
            this.textBoxTransmit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonYazdır = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived_1);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(92, 73);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(143, 21);
            this.comboBoxPorts.TabIndex = 1;
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(92, 44);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(143, 21);
            this.comboBoxBaudRate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "BaudRates";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ports";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(241, 42);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(94, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisConnect
            // 
            this.buttonDisConnect.Location = new System.Drawing.Point(241, 71);
            this.buttonDisConnect.Name = "buttonDisConnect";
            this.buttonDisConnect.Size = new System.Drawing.Size(94, 23);
            this.buttonDisConnect.TabIndex = 3;
            this.buttonDisConnect.Text = "Disconnect";
            this.buttonDisConnect.UseVisualStyleBackColor = true;
            this.buttonDisConnect.Click += new System.EventHandler(this.buttonDisConnect_Click);
            // 
            // labelConnectionState
            // 
            this.labelConnectionState.AutoSize = true;
            this.labelConnectionState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelConnectionState.Location = new System.Drawing.Point(10, 9);
            this.labelConnectionState.Name = "labelConnectionState";
            this.labelConnectionState.Size = new System.Drawing.Size(51, 20);
            this.labelConnectionState.TabIndex = 6;
            this.labelConnectionState.Text = "label3";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(341, 42);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(86, 52);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // radioButtonChar
            // 
            this.radioButtonChar.AutoSize = true;
            this.radioButtonChar.Location = new System.Drawing.Point(14, 147);
            this.radioButtonChar.Name = "radioButtonChar";
            this.radioButtonChar.Size = new System.Drawing.Size(73, 17);
            this.radioButtonChar.TabIndex = 8;
            this.radioButtonChar.Text = "ReadChar";
            this.radioButtonChar.UseVisualStyleBackColor = true;
            this.radioButtonChar.Click += new System.EventHandler(this.radioButtonChar_Click);
            // 
            // radioButtonUint8
            // 
            this.radioButtonUint8.AutoSize = true;
            this.radioButtonUint8.Checked = true;
            this.radioButtonUint8.Location = new System.Drawing.Point(172, 147);
            this.radioButtonUint8.Name = "radioButtonUint8";
            this.radioButtonUint8.Size = new System.Drawing.Size(76, 17);
            this.radioButtonUint8.TabIndex = 8;
            this.radioButtonUint8.TabStop = true;
            this.radioButtonUint8.Text = "ReadUint8";
            this.radioButtonUint8.UseVisualStyleBackColor = true;
            this.radioButtonUint8.Click += new System.EventHandler(this.radioButtonChar_Click);
            // 
            // radioButtonUint16
            // 
            this.radioButtonUint16.AutoSize = true;
            this.radioButtonUint16.Location = new System.Drawing.Point(345, 147);
            this.radioButtonUint16.Name = "radioButtonUint16";
            this.radioButtonUint16.Size = new System.Drawing.Size(82, 17);
            this.radioButtonUint16.TabIndex = 8;
            this.radioButtonUint16.Text = "ReadUint16";
            this.radioButtonUint16.UseVisualStyleBackColor = true;
            this.radioButtonUint16.Click += new System.EventHandler(this.radioButtonChar_Click);
            // 
            // listBoxReceive
            // 
            this.listBoxReceive.FormattingEnabled = true;
            this.listBoxReceive.Location = new System.Drawing.Point(14, 170);
            this.listBoxReceive.Name = "listBoxReceive";
            this.listBoxReceive.Size = new System.Drawing.Size(402, 160);
            this.listBoxReceive.TabIndex = 10;
            // 
            // textBoxTransmit
            // 
            this.textBoxTransmit.Location = new System.Drawing.Point(92, 113);
            this.textBoxTransmit.Name = "textBoxTransmit";
            this.textBoxTransmit.Size = new System.Drawing.Size(243, 20);
            this.textBoxTransmit.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Transmit";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(341, 108);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(86, 28);
            this.buttonSend.TabIndex = 7;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonYazdır
            // 
            this.buttonYazdır.Location = new System.Drawing.Point(138, 336);
            this.buttonYazdır.Name = "buttonYazdır";
            this.buttonYazdır.Size = new System.Drawing.Size(167, 32);
            this.buttonYazdır.TabIndex = 12;
            this.buttonYazdır.Text = "Yazdır";
            this.buttonYazdır.UseVisualStyleBackColor = true;
            this.buttonYazdır.Click += new System.EventHandler(this.buttonYazdır_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 380);
            this.Controls.Add(this.buttonYazdır);
            this.Controls.Add(this.textBoxTransmit);
            this.Controls.Add(this.listBoxReceive);
            this.Controls.Add(this.radioButtonUint16);
            this.Controls.Add(this.radioButtonUint8);
            this.Controls.Add(this.radioButtonChar);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelConnectionState);
            this.Controls.Add(this.buttonDisConnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBaudRate);
            this.Controls.Add(this.comboBoxPorts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisConnect;
        private System.Windows.Forms.Label labelConnectionState;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.RadioButton radioButtonChar;
        private System.Windows.Forms.RadioButton radioButtonUint8;
        private System.Windows.Forms.RadioButton radioButtonUint16;
        private System.Windows.Forms.ListBox listBoxReceive;
        private System.Windows.Forms.TextBox textBoxTransmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonYazdır;
    }
}

