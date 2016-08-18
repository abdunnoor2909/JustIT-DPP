namespace TwoForms
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1Open = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.GoNext = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1Open
            // 
            this.button1Open.Location = new System.Drawing.Point(77, 82);
            this.button1Open.Name = "button1Open";
            this.button1Open.Size = new System.Drawing.Size(101, 53);
            this.button1Open.TabIndex = 0;
            this.button1Open.Text = "Open a text file";
            this.button1Open.UseVisualStyleBackColor = true;
            this.button1Open.Click += new System.EventHandler(this.button1_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(77, 157);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(101, 72);
            this.Change.TabIndex = 1;
            this.Change.Text = "Change Background Colour";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // GoNext
            // 
            this.GoNext.Location = new System.Drawing.Point(77, 253);
            this.GoNext.Name = "GoNext";
            this.GoNext.Size = new System.Drawing.Size(101, 52);
            this.GoNext.TabIndex = 2;
            this.GoNext.Text = "Go to Next Form";
            this.GoNext.UseVisualStyleBackColor = true;
            this.GoNext.Click += new System.EventHandler(this.GoNext_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(225, 82);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(427, 223);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.GoNext);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.button1Open);
            this.Name = "Form1";
            this.Text = "Two Forms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1Open;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button GoNext;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

