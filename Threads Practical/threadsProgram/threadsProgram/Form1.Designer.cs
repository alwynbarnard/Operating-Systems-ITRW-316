/*
        ALWYN BARNARD  28430093
        SCHEDULING REPORT 
        Mr Henry Foulds
        ITRW 316 Operating Systems 2019
 */

namespace threadsProgram
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
            this.gbPriority = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPPriority2 = new System.Windows.Forms.TextBox();
            this.lblPriority2 = new System.Windows.Forms.Label();
            this.txtPTCount2 = new System.Windows.Forms.TextBox();
            this.txtPPName2 = new System.Windows.Forms.TextBox();
            this.lblProcess2 = new System.Windows.Forms.Label();
            this.lblCount2 = new System.Windows.Forms.Label();
            this.txtPPriority = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPCount = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPriorityPrompt = new System.Windows.Forms.Label();
            this.gbRoundRobin = new System.Windows.Forms.GroupBox();
            this.txtRCount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbMultiple = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMCount2 = new System.Windows.Forms.TextBox();
            this.txtMName2 = new System.Windows.Forms.TextBox();
            this.lblMProcess2 = new System.Windows.Forms.Label();
            this.lblMCount2 = new System.Windows.Forms.Label();
            this.txtMCount = new System.Windows.Forms.TextBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRRAdd = new System.Windows.Forms.Button();
            this.btnRRStart = new System.Windows.Forms.Button();
            this.btnMQAdd = new System.Windows.Forms.Button();
            this.btnMQStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbPriority.SuspendLayout();
            this.gbRoundRobin.SuspendLayout();
            this.gbMultiple.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPriority
            // 
            this.gbPriority.BackColor = System.Drawing.Color.Firebrick;
            this.gbPriority.Controls.Add(this.label8);
            this.gbPriority.Controls.Add(this.txtPPriority2);
            this.gbPriority.Controls.Add(this.lblPriority2);
            this.gbPriority.Controls.Add(this.txtPTCount2);
            this.gbPriority.Controls.Add(this.txtPPName2);
            this.gbPriority.Controls.Add(this.lblProcess2);
            this.gbPriority.Controls.Add(this.lblCount2);
            this.gbPriority.Controls.Add(this.txtPPriority);
            this.gbPriority.Controls.Add(this.label4);
            this.gbPriority.Controls.Add(this.txtPCount);
            this.gbPriority.Controls.Add(this.txtPName);
            this.gbPriority.Controls.Add(this.label3);
            this.gbPriority.Controls.Add(this.label2);
            this.gbPriority.Controls.Add(this.lblPriorityPrompt);
            this.gbPriority.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPriority.Location = new System.Drawing.Point(472, 30);
            this.gbPriority.Name = "gbPriority";
            this.gbPriority.Size = new System.Drawing.Size(398, 413);
            this.gbPriority.TabIndex = 0;
            this.gbPriority.TabStop = false;
            this.gbPriority.Text = "Priority Scheduling";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(366, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "---------------------------------------";
            // 
            // txtPPriority2
            // 
            this.txtPPriority2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPPriority2.Location = new System.Drawing.Point(20, 378);
            this.txtPPriority2.Name = "txtPPriority2";
            this.txtPPriority2.Size = new System.Drawing.Size(364, 26);
            this.txtPPriority2.TabIndex = 12;
            // 
            // lblPriority2
            // 
            this.lblPriority2.AutoSize = true;
            this.lblPriority2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority2.Location = new System.Drawing.Point(14, 357);
            this.lblPriority2.Name = "lblPriority2";
            this.lblPriority2.Size = new System.Drawing.Size(113, 18);
            this.lblPriority2.TabIndex = 11;
            this.lblPriority2.Text = "Priority: (1-5)";
            // 
            // txtPTCount2
            // 
            this.txtPTCount2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPTCount2.Location = new System.Drawing.Point(20, 328);
            this.txtPTCount2.Name = "txtPTCount2";
            this.txtPTCount2.Size = new System.Drawing.Size(364, 26);
            this.txtPTCount2.TabIndex = 10;
            // 
            // txtPPName2
            // 
            this.txtPPName2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPPName2.Location = new System.Drawing.Point(20, 278);
            this.txtPPName2.Name = "txtPPName2";
            this.txtPPName2.Size = new System.Drawing.Size(364, 26);
            this.txtPPName2.TabIndex = 9;
            // 
            // lblProcess2
            // 
            this.lblProcess2.AutoSize = true;
            this.lblProcess2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcess2.Location = new System.Drawing.Point(14, 256);
            this.lblProcess2.Name = "lblProcess2";
            this.lblProcess2.Size = new System.Drawing.Size(125, 18);
            this.lblProcess2.TabIndex = 8;
            this.lblProcess2.Text = "Process name: ";
            // 
            // lblCount2
            // 
            this.lblCount2.AutoSize = true;
            this.lblCount2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount2.Location = new System.Drawing.Point(14, 307);
            this.lblCount2.Name = "lblCount2";
            this.lblCount2.Size = new System.Drawing.Size(145, 18);
            this.lblCount2.TabIndex = 7;
            this.lblCount2.Text = "Number of items: ";
            // 
            // txtPPriority
            // 
            this.txtPPriority.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPPriority.Location = new System.Drawing.Point(20, 187);
            this.txtPPriority.Name = "txtPPriority";
            this.txtPPriority.Size = new System.Drawing.Size(364, 26);
            this.txtPPriority.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Priority: (1-5)";
            // 
            // txtPCount
            // 
            this.txtPCount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPCount.Location = new System.Drawing.Point(17, 137);
            this.txtPCount.Name = "txtPCount";
            this.txtPCount.Size = new System.Drawing.Size(364, 26);
            this.txtPCount.TabIndex = 4;
            // 
            // txtPName
            // 
            this.txtPName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.Location = new System.Drawing.Point(20, 87);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(364, 26);
            this.txtPName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Process name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of items: ";
            // 
            // lblPriorityPrompt
            // 
            this.lblPriorityPrompt.AutoSize = true;
            this.lblPriorityPrompt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorityPrompt.Location = new System.Drawing.Point(17, 35);
            this.lblPriorityPrompt.Name = "lblPriorityPrompt";
            this.lblPriorityPrompt.Size = new System.Drawing.Size(367, 18);
            this.lblPriorityPrompt.TabIndex = 0;
            this.lblPriorityPrompt.Text = "Enter at least two processes to apply scheduling";
            // 
            // gbRoundRobin
            // 
            this.gbRoundRobin.BackColor = System.Drawing.Color.Chartreuse;
            this.gbRoundRobin.Controls.Add(this.panel1);
            this.gbRoundRobin.Controls.Add(this.txtRCount);
            this.gbRoundRobin.Controls.Add(this.label11);
            this.gbRoundRobin.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRoundRobin.Location = new System.Drawing.Point(30, 30);
            this.gbRoundRobin.Name = "gbRoundRobin";
            this.gbRoundRobin.Size = new System.Drawing.Size(398, 274);
            this.gbRoundRobin.TabIndex = 1;
            this.gbRoundRobin.TabStop = false;
            this.gbRoundRobin.Text = "Round Robin";
            // 
            // txtRCount
            // 
            this.txtRCount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRCount.Location = new System.Drawing.Point(20, 176);
            this.txtRCount.Name = "txtRCount";
            this.txtRCount.Size = new System.Drawing.Size(364, 26);
            this.txtRCount.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Number of items: ";
            // 
            // gbMultiple
            // 
            this.gbMultiple.BackColor = System.Drawing.Color.MediumAquamarine;
            this.gbMultiple.Controls.Add(this.label5);
            this.gbMultiple.Controls.Add(this.txtMCount2);
            this.gbMultiple.Controls.Add(this.txtMName2);
            this.gbMultiple.Controls.Add(this.lblMProcess2);
            this.gbMultiple.Controls.Add(this.lblMCount2);
            this.gbMultiple.Controls.Add(this.txtMCount);
            this.gbMultiple.Controls.Add(this.txtMName);
            this.gbMultiple.Controls.Add(this.label16);
            this.gbMultiple.Controls.Add(this.label17);
            this.gbMultiple.Controls.Add(this.label18);
            this.gbMultiple.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMultiple.Location = new System.Drawing.Point(937, 30);
            this.gbMultiple.Name = "gbMultiple";
            this.gbMultiple.Size = new System.Drawing.Size(398, 413);
            this.gbMultiple.TabIndex = 2;
            this.gbMultiple.TabStop = false;
            this.gbMultiple.Text = "Multiple Queues";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(366, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "---------------------------------------";
            // 
            // txtMCount2
            // 
            this.txtMCount2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMCount2.Location = new System.Drawing.Point(20, 328);
            this.txtMCount2.Name = "txtMCount2";
            this.txtMCount2.Size = new System.Drawing.Size(364, 26);
            this.txtMCount2.TabIndex = 10;
            // 
            // txtMName2
            // 
            this.txtMName2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMName2.Location = new System.Drawing.Point(20, 278);
            this.txtMName2.Name = "txtMName2";
            this.txtMName2.Size = new System.Drawing.Size(364, 26);
            this.txtMName2.TabIndex = 9;
            // 
            // lblMProcess2
            // 
            this.lblMProcess2.AutoSize = true;
            this.lblMProcess2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMProcess2.Location = new System.Drawing.Point(14, 256);
            this.lblMProcess2.Name = "lblMProcess2";
            this.lblMProcess2.Size = new System.Drawing.Size(125, 18);
            this.lblMProcess2.TabIndex = 8;
            this.lblMProcess2.Text = "Process name: ";
            // 
            // lblMCount2
            // 
            this.lblMCount2.AutoSize = true;
            this.lblMCount2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMCount2.Location = new System.Drawing.Point(14, 307);
            this.lblMCount2.Name = "lblMCount2";
            this.lblMCount2.Size = new System.Drawing.Size(145, 18);
            this.lblMCount2.TabIndex = 7;
            this.lblMCount2.Text = "Number of items: ";
            // 
            // txtMCount
            // 
            this.txtMCount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMCount.Location = new System.Drawing.Point(17, 137);
            this.txtMCount.Name = "txtMCount";
            this.txtMCount.Size = new System.Drawing.Size(364, 26);
            this.txtMCount.TabIndex = 4;
            // 
            // txtMName
            // 
            this.txtMName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMName.Location = new System.Drawing.Point(20, 87);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(364, 26);
            this.txtMName.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(17, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 18);
            this.label16.TabIndex = 2;
            this.label16.Text = "Process name: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(17, 116);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(145, 18);
            this.label17.TabIndex = 1;
            this.label17.Text = "Number of items: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(17, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(367, 18);
            this.label18.TabIndex = 0;
            this.label18.Text = "Enter at least two processes to apply scheduling";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightGreen;
            this.btnStart.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(472, 449);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(174, 63);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(696, 449);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(174, 63);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.LightGreen;
            this.btnStop.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(577, 552);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(193, 78);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRRAdd
            // 
            this.btnRRAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnRRAdd.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRRAdd.Location = new System.Drawing.Point(240, 358);
            this.btnRRAdd.Name = "btnRRAdd";
            this.btnRRAdd.Size = new System.Drawing.Size(174, 63);
            this.btnRRAdd.TabIndex = 7;
            this.btnRRAdd.Text = "ADD";
            this.btnRRAdd.UseVisualStyleBackColor = false;
            this.btnRRAdd.Click += new System.EventHandler(this.BtnRRAdd_Click);
            // 
            // btnRRStart
            // 
            this.btnRRStart.BackColor = System.Drawing.Color.LightGreen;
            this.btnRRStart.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRRStart.Location = new System.Drawing.Point(47, 358);
            this.btnRRStart.Name = "btnRRStart";
            this.btnRRStart.Size = new System.Drawing.Size(174, 63);
            this.btnRRStart.TabIndex = 6;
            this.btnRRStart.Text = "START";
            this.btnRRStart.UseVisualStyleBackColor = false;
            this.btnRRStart.Click += new System.EventHandler(this.BtnRRStart_Click);
            // 
            // btnMQAdd
            // 
            this.btnMQAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnMQAdd.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMQAdd.Location = new System.Drawing.Point(1161, 449);
            this.btnMQAdd.Name = "btnMQAdd";
            this.btnMQAdd.Size = new System.Drawing.Size(174, 63);
            this.btnMQAdd.TabIndex = 9;
            this.btnMQAdd.Text = "ADD";
            this.btnMQAdd.UseVisualStyleBackColor = false;
            // 
            // btnMQStart
            // 
            this.btnMQStart.BackColor = System.Drawing.Color.LightGreen;
            this.btnMQStart.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMQStart.Location = new System.Drawing.Point(937, 449);
            this.btnMQStart.Name = "btnMQStart";
            this.btnMQStart.Size = new System.Drawing.Size(174, 63);
            this.btnMQStart.TabIndex = 8;
            this.btnMQStart.Text = "START";
            this.btnMQStart.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 572);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(476, 22);
            this.textBox1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(17, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 203);
            this.panel1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(38, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(231, 26);
            this.textBox2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Number of Processes: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(77, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 63);
            this.button1.TabIndex = 11;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1381, 658);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRRStart);
            this.Controls.Add(this.btnMQAdd);
            this.Controls.Add(this.btnMQStart);
            this.Controls.Add(this.btnRRAdd);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gbMultiple);
            this.Controls.Add(this.gbRoundRobin);
            this.Controls.Add(this.gbPriority);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPriority.ResumeLayout(false);
            this.gbPriority.PerformLayout();
            this.gbRoundRobin.ResumeLayout(false);
            this.gbRoundRobin.PerformLayout();
            this.gbMultiple.ResumeLayout(false);
            this.gbMultiple.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPriority;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPPriority2;
        private System.Windows.Forms.Label lblPriority2;
        private System.Windows.Forms.TextBox txtPTCount2;
        private System.Windows.Forms.TextBox txtPPName2;
        private System.Windows.Forms.Label lblProcess2;
        private System.Windows.Forms.Label lblCount2;
        private System.Windows.Forms.TextBox txtPPriority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPCount;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPriorityPrompt;
        private System.Windows.Forms.GroupBox gbRoundRobin;
        private System.Windows.Forms.TextBox txtRCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbMultiple;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMCount2;
        private System.Windows.Forms.TextBox txtMName2;
        private System.Windows.Forms.Label lblMProcess2;
        private System.Windows.Forms.Label lblMCount2;
        private System.Windows.Forms.TextBox txtMCount;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRRAdd;
        private System.Windows.Forms.Button btnRRStart;
        private System.Windows.Forms.Button btnMQAdd;
        private System.Windows.Forms.Button btnMQStart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}

