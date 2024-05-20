
namespace ComPort
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBoxPARITYBITS = new System.Windows.Forms.ComboBox();
            this.CBoxSTOPBITS = new System.Windows.Forms.ComboBox();
            this.CBoxDATABITS = new System.Windows.Forms.ComboBox();
            this.CBoxBAUDRATE = new System.Windows.Forms.ComboBox();
            this.CBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSendData = new System.Windows.Forms.Button();
            this.tBoxDataOut = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chBoxDtrEnable = new System.Windows.Forms.CheckBox();
            this.chBoxRtsEnable = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClearDataOut = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chBoxUsingButton = new System.Windows.Forms.CheckBox();
            this.chBoxUsingEnter = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chBoxWrite = new System.Windows.Forms.CheckBox();
            this.chBoxWriteLine = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDataOutLength = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblStatusCom = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chBoxRtsEnable);
            this.groupBox1.Controls.Add(this.chBoxDtrEnable);
            this.groupBox1.Controls.Add(this.CBoxPARITYBITS);
            this.groupBox1.Controls.Add(this.CBoxSTOPBITS);
            this.groupBox1.Controls.Add(this.CBoxDATABITS);
            this.groupBox1.Controls.Add(this.CBoxBAUDRATE);
            this.groupBox1.Controls.Add(this.CBoxCOMPORT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Control";
            // 
            // CBoxPARITYBITS
            // 
            this.CBoxPARITYBITS.FormattingEnabled = true;
            this.CBoxPARITYBITS.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.CBoxPARITYBITS.Location = new System.Drawing.Point(177, 216);
            this.CBoxPARITYBITS.Name = "CBoxPARITYBITS";
            this.CBoxPARITYBITS.Size = new System.Drawing.Size(263, 26);
            this.CBoxPARITYBITS.TabIndex = 9;
            this.CBoxPARITYBITS.Text = "None";
            // 
            // CBoxSTOPBITS
            // 
            this.CBoxSTOPBITS.FormattingEnabled = true;
            this.CBoxSTOPBITS.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.CBoxSTOPBITS.Location = new System.Drawing.Point(177, 170);
            this.CBoxSTOPBITS.Name = "CBoxSTOPBITS";
            this.CBoxSTOPBITS.Size = new System.Drawing.Size(263, 26);
            this.CBoxSTOPBITS.TabIndex = 8;
            this.CBoxSTOPBITS.Text = "One";
            // 
            // CBoxDATABITS
            // 
            this.CBoxDATABITS.FormattingEnabled = true;
            this.CBoxDATABITS.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.CBoxDATABITS.Location = new System.Drawing.Point(177, 126);
            this.CBoxDATABITS.Name = "CBoxDATABITS";
            this.CBoxDATABITS.Size = new System.Drawing.Size(263, 26);
            this.CBoxDATABITS.TabIndex = 7;
            this.CBoxDATABITS.Text = "8";
            // 
            // CBoxBAUDRATE
            // 
            this.CBoxBAUDRATE.FormattingEnabled = true;
            this.CBoxBAUDRATE.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.CBoxBAUDRATE.Location = new System.Drawing.Point(177, 85);
            this.CBoxBAUDRATE.Name = "CBoxBAUDRATE";
            this.CBoxBAUDRATE.Size = new System.Drawing.Size(263, 26);
            this.CBoxBAUDRATE.TabIndex = 6;
            this.CBoxBAUDRATE.Text = "9600";
            // 
            // CBoxCOMPORT
            // 
            this.CBoxCOMPORT.FormattingEnabled = true;
            this.CBoxCOMPORT.Location = new System.Drawing.Point(177, 42);
            this.CBoxCOMPORT.Name = "CBoxCOMPORT";
            this.CBoxCOMPORT.Size = new System.Drawing.Size(263, 26);
            this.CBoxCOMPORT.TabIndex = 5;
            this.CBoxCOMPORT.SelectedIndexChanged += new System.EventHandler(this.CBoxCOMPORT_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "PARITY BITS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "STOP BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "DATA BITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "BAUD DATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Com Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Location = new System.Drawing.Point(26, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 295);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(27, 240);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(411, 36);
            this.progressBar1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(27, 139);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 79);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(27, 37);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(129, 79);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(17, 43);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(146, 57);
            this.btnSendData.TabIndex = 3;
            this.btnSendData.Text = "Send Data";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.Location = new System.Drawing.Point(18, 27);
            this.tBoxDataOut.Multiline = true;
            this.tBoxDataOut.Name = "tBoxDataOut";
            this.tBoxDataOut.Size = new System.Drawing.Size(566, 294);
            this.tBoxDataOut.TabIndex = 4;
            this.tBoxDataOut.TextChanged += new System.EventHandler(this.tBoxDataOut_TextChanged);
            this.tBoxDataOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxDataOut_KeyDown);
            // 
            // chBoxDtrEnable
            // 
            this.chBoxDtrEnable.AutoSize = true;
            this.chBoxDtrEnable.Location = new System.Drawing.Point(49, 279);
            this.chBoxDtrEnable.Name = "chBoxDtrEnable";
            this.chBoxDtrEnable.Size = new System.Drawing.Size(138, 22);
            this.chBoxDtrEnable.TabIndex = 10;
            this.chBoxDtrEnable.Text = "DTR ENABLE";
            this.chBoxDtrEnable.UseVisualStyleBackColor = true;
            this.chBoxDtrEnable.CheckedChanged += new System.EventHandler(this.chBoxDtrEnable_CheckedChanged);
            // 
            // chBoxRtsEnable
            // 
            this.chBoxRtsEnable.AutoSize = true;
            this.chBoxRtsEnable.Location = new System.Drawing.Point(268, 279);
            this.chBoxRtsEnable.Name = "chBoxRtsEnable";
            this.chBoxRtsEnable.Size = new System.Drawing.Size(138, 22);
            this.chBoxRtsEnable.TabIndex = 11;
            this.chBoxRtsEnable.Text = "RTS ENABLE";
            this.chBoxRtsEnable.UseVisualStyleBackColor = true;
            this.chBoxRtsEnable.CheckedChanged += new System.EventHandler(this.chBoxRtsEnable_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.tBoxDataOut);
            this.groupBox3.Location = new System.Drawing.Point(511, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(599, 631);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transmitter Control";
            // 
            // btnClearDataOut
            // 
            this.btnClearDataOut.Location = new System.Drawing.Point(17, 106);
            this.btnClearDataOut.Name = "btnClearDataOut";
            this.btnClearDataOut.Size = new System.Drawing.Size(146, 57);
            this.btnClearDataOut.TabIndex = 5;
            this.btnClearDataOut.Text = "Clear Data OUT";
            this.btnClearDataOut.UseVisualStyleBackColor = true;
            this.btnClearDataOut.Click += new System.EventHandler(this.btnClearDataOut_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.btnSendData);
            this.groupBox4.Controls.Add(this.btnClearDataOut);
            this.groupBox4.Location = new System.Drawing.Point(18, 336);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(566, 276);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chBoxUsingEnter);
            this.groupBox5.Controls.Add(this.chBoxUsingButton);
            this.groupBox5.Location = new System.Drawing.Point(181, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(175, 159);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // chBoxUsingButton
            // 
            this.chBoxUsingButton.AutoSize = true;
            this.chBoxUsingButton.Location = new System.Drawing.Point(18, 51);
            this.chBoxUsingButton.Name = "chBoxUsingButton";
            this.chBoxUsingButton.Size = new System.Drawing.Size(136, 22);
            this.chBoxUsingButton.TabIndex = 0;
            this.chBoxUsingButton.Text = "Using Button";
            this.chBoxUsingButton.UseVisualStyleBackColor = true;
            this.chBoxUsingButton.CheckedChanged += new System.EventHandler(this.chBoxUsingButton_CheckedChanged);
            // 
            // chBoxUsingEnter
            // 
            this.chBoxUsingEnter.AutoSize = true;
            this.chBoxUsingEnter.Location = new System.Drawing.Point(18, 96);
            this.chBoxUsingEnter.Name = "chBoxUsingEnter";
            this.chBoxUsingEnter.Size = new System.Drawing.Size(126, 22);
            this.chBoxUsingEnter.TabIndex = 1;
            this.chBoxUsingEnter.Text = "Using Enter";
            this.chBoxUsingEnter.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chBoxWrite);
            this.groupBox6.Controls.Add(this.chBoxWriteLine);
            this.groupBox6.Location = new System.Drawing.Point(375, 16);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(175, 159);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            // 
            // chBoxWrite
            // 
            this.chBoxWrite.AutoSize = true;
            this.chBoxWrite.Location = new System.Drawing.Point(18, 96);
            this.chBoxWrite.Name = "chBoxWrite";
            this.chBoxWrite.Size = new System.Drawing.Size(73, 22);
            this.chBoxWrite.TabIndex = 1;
            this.chBoxWrite.Text = "Write";
            this.chBoxWrite.UseVisualStyleBackColor = true;
            this.chBoxWrite.CheckedChanged += new System.EventHandler(this.chBoxWrite_CheckedChanged);
            // 
            // chBoxWriteLine
            // 
            this.chBoxWriteLine.AutoSize = true;
            this.chBoxWriteLine.Location = new System.Drawing.Point(18, 51);
            this.chBoxWriteLine.Name = "chBoxWriteLine";
            this.chBoxWriteLine.Size = new System.Drawing.Size(105, 22);
            this.chBoxWriteLine.TabIndex = 0;
            this.chBoxWriteLine.Text = "WriteLine";
            this.chBoxWriteLine.UseVisualStyleBackColor = true;
            this.chBoxWriteLine.CheckedChanged += new System.EventHandler(this.chBoxWriteLine_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblDataOutLength);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Location = new System.Drawing.Point(17, 189);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(533, 72);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 14F);
            this.label6.Location = new System.Drawing.Point(54, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data Out Length : ";
            // 
            // lblDataOutLength
            // 
            this.lblDataOutLength.AutoSize = true;
            this.lblDataOutLength.Font = new System.Drawing.Font("굴림", 14F);
            this.lblDataOutLength.Location = new System.Drawing.Point(353, 24);
            this.lblDataOutLength.Name = "lblDataOutLength";
            this.lblDataOutLength.Size = new System.Drawing.Size(44, 28);
            this.lblDataOutLength.TabIndex = 1;
            this.lblDataOutLength.Text = "00";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblStatusCom);
            this.groupBox8.Location = new System.Drawing.Point(177, 43);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(261, 175);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "COM PORT STATUS";
            // 
            // lblStatusCom
            // 
            this.lblStatusCom.AutoSize = true;
            this.lblStatusCom.Font = new System.Drawing.Font("Britannic Bold", 28F);
            this.lblStatusCom.Location = new System.Drawing.Point(65, 63);
            this.lblStatusCom.Name = "lblStatusCom";
            this.lblStatusCom.Size = new System.Drawing.Size(119, 62);
            this.lblStatusCom.TabIndex = 0;
            this.lblStatusCom.Text = "OFF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 681);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "C# COM PORT SERIAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBoxPARITYBITS;
        private System.Windows.Forms.ComboBox CBoxSTOPBITS;
        private System.Windows.Forms.ComboBox CBoxDATABITS;
        private System.Windows.Forms.ComboBox CBoxBAUDRATE;
        private System.Windows.Forms.ComboBox CBoxCOMPORT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.TextBox tBoxDataOut;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox chBoxDtrEnable;
        private System.Windows.Forms.CheckBox chBoxRtsEnable;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblStatusCom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblDataOutLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chBoxWrite;
        private System.Windows.Forms.CheckBox chBoxWriteLine;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chBoxUsingEnter;
        private System.Windows.Forms.CheckBox chBoxUsingButton;
        private System.Windows.Forms.Button btnClearDataOut;
    }
}

