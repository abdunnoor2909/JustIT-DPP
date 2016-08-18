namespace TwoForms
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
            this.returnButtin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // returnButtin
            // 
            this.returnButtin.Location = new System.Drawing.Point(106, 90);
            this.returnButtin.Name = "returnButtin";
            this.returnButtin.Size = new System.Drawing.Size(225, 136);
            this.returnButtin.TabIndex = 0;
            this.returnButtin.Text = "Return to previous form";
            this.returnButtin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.returnButtin.UseMnemonic = false;
            this.returnButtin.UseVisualStyleBackColor = true;
            this.returnButtin.Click += new System.EventHandler(this.returnButtin_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 318);
            this.Controls.Add(this.returnButtin);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button returnButtin;
    }
}