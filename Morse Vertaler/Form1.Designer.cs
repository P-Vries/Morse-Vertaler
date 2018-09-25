namespace Morse_Vertaler
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
            this.rtbIO = new System.Windows.Forms.RichTextBox();
            this.btnVanMorse = new System.Windows.Forms.Button();
            this.btnNaarMorse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbIO
            // 
            this.rtbIO.Location = new System.Drawing.Point(12, 12);
            this.rtbIO.Name = "rtbIO";
            this.rtbIO.Size = new System.Drawing.Size(776, 397);
            this.rtbIO.TabIndex = 0;
            this.rtbIO.Text = "";
            // 
            // btnVanMorse
            // 
            this.btnVanMorse.Location = new System.Drawing.Point(687, 415);
            this.btnVanMorse.Name = "btnVanMorse";
            this.btnVanMorse.Size = new System.Drawing.Size(101, 23);
            this.btnVanMorse.TabIndex = 1;
            this.btnVanMorse.Text = "Vertaal van Morse";
            this.btnVanMorse.UseVisualStyleBackColor = true;
            this.btnVanMorse.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNaarMorse
            // 
            this.btnNaarMorse.Location = new System.Drawing.Point(12, 415);
            this.btnNaarMorse.Name = "btnNaarMorse";
            this.btnNaarMorse.Size = new System.Drawing.Size(104, 23);
            this.btnNaarMorse.TabIndex = 2;
            this.btnNaarMorse.Text = "Vertaal naar Morse";
            this.btnNaarMorse.UseVisualStyleBackColor = true;
            this.btnNaarMorse.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNaarMorse);
            this.Controls.Add(this.btnVanMorse);
            this.Controls.Add(this.rtbIO);
            this.Name = "Form1";
            this.Text = "Morse vertaler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbIO;
        private System.Windows.Forms.Button btnVanMorse;
        private System.Windows.Forms.Button btnNaarMorse;
    }
}

