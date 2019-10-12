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
            this.btnReplace = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbxPT = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the page you would like to access:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtRequest);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(49, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 140);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Request";
            // 
            // btnReplace
            // 
            this.btnReplace.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReplace.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplace.Location = new System.Drawing.Point(106, 228);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(173, 76);
            this.btnReplace.TabIndex = 3;
            this.btnReplace.Text = "Find/Replace";
            this.btnReplace.UseVisualStyleBackColor = false;
            this.btnReplace.Click += new System.EventHandler(this.BtnReplace_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(764, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Page Table";
            // 
            // lbxPT
            // 
            this.lbxPT.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbxPT.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxPT.FormattingEnabled = true;
            this.lbxPT.ItemHeight = 21;
            this.lbxPT.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "A6",
            "A7",
            "A8",
            "A9",
            "A10",
            "A11",
            "A12",
            "B1",
            "B2",
            "B3",
            "B4",
            "B5",
            "B6",
            "B7",
            "B8",
            "B9",
            "B10",
            "C1",
            "C2",
            "C3",
            "C4",
            "C5",
            "C6",
            "D1",
            "D2",
            "D3",
            "D4",
            "D5",
            "D6",
            "D7",
            "D8",
            "E1",
            "E2",
            "E3",
            "E4"});
            this.lbxPT.Location = new System.Drawing.Point(482, 78);
            this.lbxPT.MultiColumn = true;
            this.lbxPT.Name = "lbxPT";
            this.lbxPT.Size = new System.Drawing.Size(719, 298);
            this.lbxPT.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(469, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(732, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "If the page is not in the page table it will be added with Random Page Replacemen" +
    "t";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1369, 776);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxPT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnReplace);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbxPT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

