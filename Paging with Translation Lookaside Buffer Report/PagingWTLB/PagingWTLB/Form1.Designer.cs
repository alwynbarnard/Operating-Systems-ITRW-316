namespace PagingWTLB
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
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbLocal = new System.Windows.Forms.CheckBox();
            this.cbGlobal = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFIFO = new System.Windows.Forms.Button();
            this.lbxTLB = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbxPT = new System.Windows.Forms.ListBox();
            this.lbAges = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRequest
            // 
            this.txtRequest.Location = new System.Drawing.Point(26, 68);
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Size = new System.Drawing.Size(242, 27);
            this.txtRequest.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the page you would like to access:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtRequest);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(48, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 140);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Request";
            // 
            // cbLocal
            // 
            this.cbLocal.AutoSize = true;
            this.cbLocal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocal.Location = new System.Drawing.Point(23, 42);
            this.cbLocal.Name = "cbLocal";
            this.cbLocal.Size = new System.Drawing.Size(200, 23);
            this.cbLocal.TabIndex = 0;
            this.cbLocal.Text = "Local Page Replacement";
            this.cbLocal.UseVisualStyleBackColor = true;
            this.cbLocal.CheckedChanged += new System.EventHandler(this.cbLocal_CheckedChanged);
            this.cbLocal.Click += new System.EventHandler(this.cbLocal_Click);
            // 
            // cbGlobal
            // 
            this.cbGlobal.AutoSize = true;
            this.cbGlobal.Checked = true;
            this.cbGlobal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGlobal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGlobal.Location = new System.Drawing.Point(23, 86);
            this.cbGlobal.Name = "cbGlobal";
            this.cbGlobal.Size = new System.Drawing.Size(207, 23);
            this.cbGlobal.TabIndex = 1;
            this.cbGlobal.Text = "Global Page Replacement";
            this.cbGlobal.UseVisualStyleBackColor = true;
            this.cbGlobal.CheckedChanged += new System.EventHandler(this.cbGlobal_CheckedChanged);
            this.cbGlobal.Click += new System.EventHandler(this.cbGlobal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.cbGlobal);
            this.groupBox1.Controls.Add(this.cbLocal);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Allocation Policies";
            // 
            // btnFIFO
            // 
            this.btnFIFO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFIFO.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFIFO.Location = new System.Drawing.Point(105, 406);
            this.btnFIFO.Name = "btnFIFO";
            this.btnFIFO.Size = new System.Drawing.Size(173, 76);
            this.btnFIFO.TabIndex = 3;
            this.btnFIFO.Text = "FIFO";
            this.btnFIFO.UseVisualStyleBackColor = false;
            this.btnFIFO.Click += new System.EventHandler(this.btnFIFO_Click);
            // 
            // lbxTLB
            // 
            this.lbxTLB.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxTLB.FormattingEnabled = true;
            this.lbxTLB.ItemHeight = 17;
            this.lbxTLB.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "A6",
            "A7",
            "B1",
            "B2",
            "B3",
            "B4",
            "B5",
            "B6",
            "C1",
            "C2",
            "C3",
            "C4",
            "C5"});
            this.lbxTLB.Location = new System.Drawing.Point(628, 63);
            this.lbxTLB.Name = "lbxTLB";
            this.lbxTLB.Size = new System.Drawing.Size(168, 412);
            this.lbxTLB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(678, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "TLB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(938, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Page Table";
            // 
            // lbxPT
            // 
            this.lbxPT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxPT.FormattingEnabled = true;
            this.lbxPT.ItemHeight = 17;
            this.lbxPT.Items.AddRange(new object[] {
            "A8",
            "A9",
            "A10",
            "A11",
            "A12",
            "B7",
            "B8",
            "B9",
            "C7",
            "C8",
            "C9",
            "C10",
            "C11",
            "C12",
            "C13",
            "D1",
            "D2",
            "D3",
            "D4",
            "D5"});
            this.lbxPT.Location = new System.Drawing.Point(931, 63);
            this.lbxPT.Name = "lbxPT";
            this.lbxPT.Size = new System.Drawing.Size(168, 344);
            this.lbxPT.TabIndex = 6;
            // 
            // lbAges
            // 
            this.lbAges.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAges.FormattingEnabled = true;
            this.lbAges.ItemHeight = 17;
            this.lbAges.Items.AddRange(new object[] {
            "16",
            "12",
            "8",
            "4",
            "2",
            "3",
            "8",
            "90",
            "42",
            "51",
            "13",
            "20",
            "48",
            "2",
            "1",
            "12",
            "4",
            "10",
            "(Ages)"});
            this.lbAges.Location = new System.Drawing.Point(683, 63);
            this.lbAges.Name = "lbAges";
            this.lbAges.Size = new System.Drawing.Size(168, 412);
            this.lbAges.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 776);
            this.Controls.Add(this.lbAges);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxPT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnFIFO);
            this.Controls.Add(this.lbxTLB);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbLocal;
        private System.Windows.Forms.CheckBox cbGlobal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFIFO;
        private System.Windows.Forms.ListBox lbxTLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbxPT;
        private System.Windows.Forms.ListBox lbAges;
    }
}

