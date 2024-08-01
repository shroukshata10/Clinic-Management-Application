
namespace Admin_Interface
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
            this.Create_Clinic_btn = new System.Windows.Forms.Button();
            this.Create_Account_btn = new System.Windows.Forms.Button();
            this.ViewClinic_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Create_Clinic_btn
            // 
            this.Create_Clinic_btn.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Clinic_btn.Location = new System.Drawing.Point(26, 13);
            this.Create_Clinic_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Create_Clinic_btn.Name = "Create_Clinic_btn";
            this.Create_Clinic_btn.Size = new System.Drawing.Size(270, 63);
            this.Create_Clinic_btn.TabIndex = 0;
            this.Create_Clinic_btn.Text = "Add Clinic";
            this.Create_Clinic_btn.UseVisualStyleBackColor = true;
            this.Create_Clinic_btn.Click += new System.EventHandler(this.Create_Clinic_btn_Click);
            // 
            // Create_Account_btn
            // 
            this.Create_Account_btn.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Account_btn.Location = new System.Drawing.Point(13, 95);
            this.Create_Account_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Create_Account_btn.Name = "Create_Account_btn";
            this.Create_Account_btn.Size = new System.Drawing.Size(364, 80);
            this.Create_Account_btn.TabIndex = 1;
            this.Create_Account_btn.Text = "Create Doctor Account";
            this.Create_Account_btn.UseVisualStyleBackColor = true;
            this.Create_Account_btn.Click += new System.EventHandler(this.Create_Account_btn_Click);
            // 
            // ViewClinic_btn
            // 
            this.ViewClinic_btn.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewClinic_btn.Location = new System.Drawing.Point(13, 297);
            this.ViewClinic_btn.Margin = new System.Windows.Forms.Padding(4);
            this.ViewClinic_btn.Name = "ViewClinic_btn";
            this.ViewClinic_btn.Size = new System.Drawing.Size(364, 70);
            this.ViewClinic_btn.TabIndex = 3;
            this.ViewClinic_btn.Text = "View Added Clinics";
            this.ViewClinic_btn.UseVisualStyleBackColor = true;
            this.ViewClinic_btn.Click += new System.EventHandler(this.ViewClinic_btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 202);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(364, 76);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create Receptionist Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 385);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(364, 70);
            this.button2.TabIndex = 5;
            this.button2.Text = "Edit-Delete Doctor Account";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(13, 476);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(369, 80);
            this.button3.TabIndex = 6;
            this.button3.Text = "Edit-Delete Receptionist Account";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(13, 574);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(369, 80);
            this.button4.TabIndex = 7;
            this.button4.Text = "Create New Admin";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Admin_Interface.Properties.Resources.back4;
            this.ClientSize = new System.Drawing.Size(627, 730);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ViewClinic_btn);
            this.Controls.Add(this.Create_Account_btn);
            this.Controls.Add(this.Create_Clinic_btn);
            this.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Create_Clinic_btn;
        private System.Windows.Forms.Button Create_Account_btn;
        private System.Windows.Forms.Button ViewClinic_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

