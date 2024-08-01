
namespace NewClinic
{
    partial class Interface
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
            this.Sign_Up = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sign_Up
            // 
            this.Sign_Up.Location = new System.Drawing.Point(327, 74);
            this.Sign_Up.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sign_Up.Name = "Sign_Up";
            this.Sign_Up.Size = new System.Drawing.Size(128, 58);
            this.Sign_Up.TabIndex = 0;
            this.Sign_Up.Text = "Sign In";
            this.Sign_Up.UseVisualStyleBackColor = true;
            this.Sign_Up.Click += new System.EventHandler(this.Sign_Up_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 177);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sign_UP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Sign_Up);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Interface";
            this.Text = "Interface";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sign_Up;
        private System.Windows.Forms.Button button2;
    }
}