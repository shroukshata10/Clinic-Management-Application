namespace Receptionist
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.Appbutton1 = new System.Windows.Forms.Button();
            this.FSbutton3 = new System.Windows.Forms.Button();
            this.VDIbutton4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Appbutton1
            // 
            this.Appbutton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Appbutton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Appbutton1.BackgroundImage")));
            this.Appbutton1.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appbutton1.Location = new System.Drawing.Point(211, 107);
            this.Appbutton1.Name = "Appbutton1";
            this.Appbutton1.Size = new System.Drawing.Size(299, 45);
            this.Appbutton1.TabIndex = 0;
            this.Appbutton1.Text = "Appointments";
            this.Appbutton1.UseVisualStyleBackColor = false;
            this.Appbutton1.Click += new System.EventHandler(this.Appbutton1_Click);
            // 
            // FSbutton3
            // 
            this.FSbutton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FSbutton3.BackgroundImage")));
            this.FSbutton3.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FSbutton3.Location = new System.Drawing.Point(211, 177);
            this.FSbutton3.Name = "FSbutton3";
            this.FSbutton3.Size = new System.Drawing.Size(299, 45);
            this.FSbutton3.TabIndex = 2;
            this.FSbutton3.Text = "Free Slots\r\n";
            this.FSbutton3.UseVisualStyleBackColor = true;
            this.FSbutton3.Click += new System.EventHandler(this.FSbutton3_Click);
            // 
            // VDIbutton4
            // 
            this.VDIbutton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VDIbutton4.BackgroundImage")));
            this.VDIbutton4.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VDIbutton4.Location = new System.Drawing.Point(211, 333);
            this.VDIbutton4.Name = "VDIbutton4";
            this.VDIbutton4.Size = new System.Drawing.Size(299, 73);
            this.VDIbutton4.TabIndex = 3;
            this.VDIbutton4.Text = "View Doctor \r\nInformation";
            this.VDIbutton4.UseVisualStyleBackColor = true;
            this.VDIbutton4.Click += new System.EventHandler(this.VDIbutton4_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(211, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(299, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add Medicine";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Backbutton.BackgroundImage")));
            this.Backbutton.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.Location = new System.Drawing.Point(297, 435);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(131, 45);
            this.Backbutton.TabIndex = 7;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 574);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.VDIbutton4);
            this.Controls.Add(this.FSbutton3);
            this.Controls.Add(this.Appbutton1);
            this.Name = "Main_Menu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Appbutton1;
        private System.Windows.Forms.Button FSbutton3;
        private System.Windows.Forms.Button VDIbutton4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Backbutton;
    }
}