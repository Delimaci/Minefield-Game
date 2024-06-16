namespace ProjectMinefield
{
    partial class Form2
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
            this.label388 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label388
            // 
            this.label388.BackColor = System.Drawing.Color.SkyBlue;
            this.label388.Location = new System.Drawing.Point(603, 548);
            this.label388.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label388.Name = "label388";
            this.label388.Size = new System.Drawing.Size(40, 38);
            this.label388.TabIndex = 389;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 949);
            this.Controls.Add(this.label388);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label388;
    }
}