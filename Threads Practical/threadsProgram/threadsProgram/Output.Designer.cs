namespace threadsProgram
{
    partial class Output
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
            this.txtOut = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtOut
            // 
            this.txtOut.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtOut.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOut.ForeColor = System.Drawing.SystemColors.Window;
            this.txtOut.Location = new System.Drawing.Point(84, 41);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(601, 325);
            this.txtOut.TabIndex = 0;
            this.txtOut.Text = "";
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOut);
            this.Name = "Output";
            this.Text = "Output";
            this.Load += new System.EventHandler(this.Output_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtOut;
    }
}