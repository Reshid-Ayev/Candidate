namespace Candidate
{
    partial class frmCandidateExam
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
            this.btnPrevious = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSecond = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.pnlTestRadioBtn = new System.Windows.Forms.Panel();
            this.rchtxtTestVariantE = new System.Windows.Forms.RichTextBox();
            this.lblTestVariantE = new System.Windows.Forms.Label();
            this.rchtxtTestVariantD = new System.Windows.Forms.RichTextBox();
            this.lblTestVariantD = new System.Windows.Forms.Label();
            this.rchtxtTestVariantC = new System.Windows.Forms.RichTextBox();
            this.rchtxtTestVariantB = new System.Windows.Forms.RichTextBox();
            this.rchtxtTestTitle = new System.Windows.Forms.RichTextBox();
            this.lblTestVariantC = new System.Windows.Forms.Label();
            this.lblTestVariantB = new System.Windows.Forms.Label();
            this.lblTestVariantA = new System.Windows.Forms.Label();
            this.lblTestTitle = new System.Windows.Forms.Label();
            this.rchtxtTestVariantA = new System.Windows.Forms.RichTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rdbtnD = new System.Windows.Forms.RadioButton();
            this.rdbtnC = new System.Windows.Forms.RadioButton();
            this.rdbtnE = new System.Windows.Forms.RadioButton();
            this.rdbtnB = new System.Windows.Forms.RadioButton();
            this.rdbtnA = new System.Windows.Forms.RadioButton();
            this.timerExam = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.Location = new System.Drawing.Point(825, 561);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(162, 31);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "Əvvəlki";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 598);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1310, 53);
            this.panel2.TabIndex = 18;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(997, 561);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(162, 31);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "Növbəti";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(25, 598);
            this.panel5.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblSecond);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblMinute);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblHour);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(25, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 39);
            this.panel1.TabIndex = 25;
            // 
            // lblSecond
            // 
            this.lblSecond.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.ForeColor = System.Drawing.Color.Red;
            this.lblSecond.Location = new System.Drawing.Point(1215, 9);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(16, 24);
            this.lblSecond.TabIndex = 4;
            this.lblSecond.Text = ".";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(1202, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = ":";
            // 
            // lblMinute
            // 
            this.lblMinute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinute.ForeColor = System.Drawing.Color.Red;
            this.lblMinute.Location = new System.Drawing.Point(1172, 9);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(22, 24);
            this.lblMinute.TabIndex = 2;
            this.lblMinute.Text = " .";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1153, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            // 
            // lblHour
            // 
            this.lblHour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.ForeColor = System.Drawing.Color.Red;
            this.lblHour.Location = new System.Drawing.Point(1126, 9);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(16, 24);
            this.lblHour.TabIndex = 0;
            this.lblHour.Text = ".";
            // 
            // pnlTestRadioBtn
            // 
            this.pnlTestRadioBtn.AutoScroll = true;
            this.pnlTestRadioBtn.BackColor = System.Drawing.SystemColors.Info;
            this.pnlTestRadioBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTestRadioBtn.Location = new System.Drawing.Point(1165, 39);
            this.pnlTestRadioBtn.Name = "pnlTestRadioBtn";
            this.pnlTestRadioBtn.Size = new System.Drawing.Size(120, 559);
            this.pnlTestRadioBtn.TabIndex = 27;
            // 
            // rchtxtTestVariantE
            // 
            this.rchtxtTestVariantE.Location = new System.Drawing.Point(123, 426);
            this.rchtxtTestVariantE.Name = "rchtxtTestVariantE";
            this.rchtxtTestVariantE.ReadOnly = true;
            this.rchtxtTestVariantE.Size = new System.Drawing.Size(445, 58);
            this.rchtxtTestVariantE.TabIndex = 40;
            this.rchtxtTestVariantE.Text = "";
            this.rchtxtTestVariantE.TextChanged += new System.EventHandler(this.RchtxtTestVariantE_TextChanged);
            // 
            // lblTestVariantE
            // 
            this.lblTestVariantE.AutoSize = true;
            this.lblTestVariantE.Location = new System.Drawing.Point(91, 431);
            this.lblTestVariantE.Name = "lblTestVariantE";
            this.lblTestVariantE.Size = new System.Drawing.Size(23, 16);
            this.lblTestVariantE.TabIndex = 39;
            this.lblTestVariantE.Text = "E)";
            this.lblTestVariantE.Click += new System.EventHandler(this.LblTestVariantE_Click);
            // 
            // rchtxtTestVariantD
            // 
            this.rchtxtTestVariantD.Location = new System.Drawing.Point(123, 364);
            this.rchtxtTestVariantD.Name = "rchtxtTestVariantD";
            this.rchtxtTestVariantD.ReadOnly = true;
            this.rchtxtTestVariantD.Size = new System.Drawing.Size(445, 58);
            this.rchtxtTestVariantD.TabIndex = 38;
            this.rchtxtTestVariantD.Text = "";
            this.rchtxtTestVariantD.TextChanged += new System.EventHandler(this.RchtxtTestVariantD_TextChanged);
            // 
            // lblTestVariantD
            // 
            this.lblTestVariantD.AutoSize = true;
            this.lblTestVariantD.Location = new System.Drawing.Point(91, 370);
            this.lblTestVariantD.Name = "lblTestVariantD";
            this.lblTestVariantD.Size = new System.Drawing.Size(24, 16);
            this.lblTestVariantD.TabIndex = 37;
            this.lblTestVariantD.Text = "D)";
            this.lblTestVariantD.Click += new System.EventHandler(this.LblTestVariantD_Click);
            // 
            // rchtxtTestVariantC
            // 
            this.rchtxtTestVariantC.Location = new System.Drawing.Point(124, 302);
            this.rchtxtTestVariantC.Name = "rchtxtTestVariantC";
            this.rchtxtTestVariantC.ReadOnly = true;
            this.rchtxtTestVariantC.Size = new System.Drawing.Size(445, 58);
            this.rchtxtTestVariantC.TabIndex = 36;
            this.rchtxtTestVariantC.Text = "";
            // 
            // rchtxtTestVariantB
            // 
            this.rchtxtTestVariantB.Location = new System.Drawing.Point(123, 240);
            this.rchtxtTestVariantB.Name = "rchtxtTestVariantB";
            this.rchtxtTestVariantB.ReadOnly = true;
            this.rchtxtTestVariantB.Size = new System.Drawing.Size(445, 58);
            this.rchtxtTestVariantB.TabIndex = 35;
            this.rchtxtTestVariantB.Text = "";
            // 
            // rchtxtTestTitle
            // 
            this.rchtxtTestTitle.Location = new System.Drawing.Point(123, 65);
            this.rchtxtTestTitle.Name = "rchtxtTestTitle";
            this.rchtxtTestTitle.ReadOnly = true;
            this.rchtxtTestTitle.Size = new System.Drawing.Size(573, 109);
            this.rchtxtTestTitle.TabIndex = 34;
            this.rchtxtTestTitle.Text = "";
            // 
            // lblTestVariantC
            // 
            this.lblTestVariantC.AutoSize = true;
            this.lblTestVariantC.Location = new System.Drawing.Point(91, 308);
            this.lblTestVariantC.Name = "lblTestVariantC";
            this.lblTestVariantC.Size = new System.Drawing.Size(23, 16);
            this.lblTestVariantC.TabIndex = 33;
            this.lblTestVariantC.Text = "C)";
            // 
            // lblTestVariantB
            // 
            this.lblTestVariantB.AutoSize = true;
            this.lblTestVariantB.Location = new System.Drawing.Point(91, 247);
            this.lblTestVariantB.Name = "lblTestVariantB";
            this.lblTestVariantB.Size = new System.Drawing.Size(23, 16);
            this.lblTestVariantB.TabIndex = 32;
            this.lblTestVariantB.Text = "B)";
            // 
            // lblTestVariantA
            // 
            this.lblTestVariantA.AutoSize = true;
            this.lblTestVariantA.Location = new System.Drawing.Point(91, 187);
            this.lblTestVariantA.Name = "lblTestVariantA";
            this.lblTestVariantA.Size = new System.Drawing.Size(23, 16);
            this.lblTestVariantA.TabIndex = 31;
            this.lblTestVariantA.Text = "A)";
            // 
            // lblTestTitle
            // 
            this.lblTestTitle.AutoSize = true;
            this.lblTestTitle.Location = new System.Drawing.Point(56, 83);
            this.lblTestTitle.Name = "lblTestTitle";
            this.lblTestTitle.Size = new System.Drawing.Size(16, 16);
            this.lblTestTitle.TabIndex = 30;
            this.lblTestTitle.Text = "  ";
            // 
            // rchtxtTestVariantA
            // 
            this.rchtxtTestVariantA.Location = new System.Drawing.Point(123, 180);
            this.rchtxtTestVariantA.Name = "rchtxtTestVariantA";
            this.rchtxtTestVariantA.ReadOnly = true;
            this.rchtxtTestVariantA.Size = new System.Drawing.Size(445, 58);
            this.rchtxtTestVariantA.TabIndex = 41;
            this.rchtxtTestVariantA.Text = "";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.Controls.Add(this.rdbtnD);
            this.panel6.Controls.Add(this.rdbtnC);
            this.panel6.Controls.Add(this.rdbtnE);
            this.panel6.Controls.Add(this.rdbtnB);
            this.panel6.Controls.Add(this.rdbtnA);
            this.panel6.Location = new System.Drawing.Point(47, 548);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(443, 44);
            this.panel6.TabIndex = 42;
            // 
            // rdbtnD
            // 
            this.rdbtnD.AutoSize = true;
            this.rdbtnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnD.Location = new System.Drawing.Point(291, 4);
            this.rdbtnD.Name = "rdbtnD";
            this.rdbtnD.Size = new System.Drawing.Size(46, 29);
            this.rdbtnD.TabIndex = 3;
            this.rdbtnD.Text = "D";
            this.rdbtnD.UseVisualStyleBackColor = true;
            this.rdbtnD.Click += new System.EventHandler(this.RdbtnD_Click);
            // 
            // rdbtnC
            // 
            this.rdbtnC.AutoSize = true;
            this.rdbtnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnC.Location = new System.Drawing.Point(185, 4);
            this.rdbtnC.Name = "rdbtnC";
            this.rdbtnC.Size = new System.Drawing.Size(46, 29);
            this.rdbtnC.TabIndex = 2;
            this.rdbtnC.Text = "C";
            this.rdbtnC.UseVisualStyleBackColor = true;
            this.rdbtnC.CheckedChanged += new System.EventHandler(this.RdbtnC_CheckedChanged);
            this.rdbtnC.Click += new System.EventHandler(this.RdbtnC_Click);
            // 
            // rdbtnE
            // 
            this.rdbtnE.AutoSize = true;
            this.rdbtnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnE.Location = new System.Drawing.Point(385, 4);
            this.rdbtnE.Name = "rdbtnE";
            this.rdbtnE.Size = new System.Drawing.Size(45, 29);
            this.rdbtnE.TabIndex = 43;
            this.rdbtnE.Text = "E";
            this.rdbtnE.UseVisualStyleBackColor = true;
            this.rdbtnE.Click += new System.EventHandler(this.RdbtnE_Click);
            // 
            // rdbtnB
            // 
            this.rdbtnB.AutoSize = true;
            this.rdbtnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnB.Location = new System.Drawing.Point(90, 4);
            this.rdbtnB.Name = "rdbtnB";
            this.rdbtnB.Size = new System.Drawing.Size(45, 29);
            this.rdbtnB.TabIndex = 1;
            this.rdbtnB.Text = "B";
            this.rdbtnB.UseVisualStyleBackColor = true;
            this.rdbtnB.Click += new System.EventHandler(this.RdbtnB_Click);
            // 
            // rdbtnA
            // 
            this.rdbtnA.AutoSize = true;
            this.rdbtnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnA.Location = new System.Drawing.Point(3, 4);
            this.rdbtnA.Name = "rdbtnA";
            this.rdbtnA.Size = new System.Drawing.Size(45, 29);
            this.rdbtnA.TabIndex = 0;
            this.rdbtnA.Text = "A";
            this.rdbtnA.UseVisualStyleBackColor = true;
            this.rdbtnA.CheckedChanged += new System.EventHandler(this.RdbtnA_CheckedChanged);
            this.rdbtnA.Click += new System.EventHandler(this.RdbtnA_Click);
            // 
            // timerExam
            // 
            this.timerExam.Interval = 1000;
            this.timerExam.Tick += new System.EventHandler(this.TimerExam_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1285, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 598);
            this.panel3.TabIndex = 22;
            // 
            // frmCandidateExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1310, 651);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.rchtxtTestVariantA);
            this.Controls.Add(this.rchtxtTestVariantE);
            this.Controls.Add(this.lblTestVariantE);
            this.Controls.Add(this.rchtxtTestVariantD);
            this.Controls.Add(this.lblTestVariantD);
            this.Controls.Add(this.rchtxtTestVariantC);
            this.Controls.Add(this.rchtxtTestVariantB);
            this.Controls.Add(this.rchtxtTestTitle);
            this.Controls.Add(this.lblTestVariantC);
            this.Controls.Add(this.lblTestVariantB);
            this.Controls.Add(this.lblTestVariantA);
            this.Controls.Add(this.lblTestTitle);
            this.Controls.Add(this.pnlTestRadioBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPrevious);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCandidateExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İmtahan prosesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCandidateExam_FormClosed);
            this.Load += new System.EventHandler(this.FrmCandidateExam_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlTestRadioBtn;
        private System.Windows.Forms.RichTextBox rchtxtTestVariantE;
        private System.Windows.Forms.Label lblTestVariantE;
        private System.Windows.Forms.RichTextBox rchtxtTestVariantD;
        private System.Windows.Forms.Label lblTestVariantD;
        private System.Windows.Forms.RichTextBox rchtxtTestVariantC;
        private System.Windows.Forms.RichTextBox rchtxtTestVariantB;
        private System.Windows.Forms.RichTextBox rchtxtTestTitle;
        private System.Windows.Forms.Label lblTestVariantC;
        private System.Windows.Forms.Label lblTestVariantB;
        private System.Windows.Forms.Label lblTestVariantA;
        private System.Windows.Forms.Label lblTestTitle;
        private System.Windows.Forms.RichTextBox rchtxtTestVariantA;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton rdbtnB;
        private System.Windows.Forms.RadioButton rdbtnA;
        private System.Windows.Forms.RadioButton rdbtnC;
        private System.Windows.Forms.RadioButton rdbtnD;
        private System.Windows.Forms.RadioButton rdbtnE;
        private System.Windows.Forms.Timer timerExam;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Panel panel3;
    }
}