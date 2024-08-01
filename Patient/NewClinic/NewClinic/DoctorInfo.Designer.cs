
namespace NewClinic
{
    

    partial class Doctor_sInfo
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DoctorName = new System.Windows.Forms.TextBox();
            this.DoctorFees = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ClinicName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Clinic_City = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Clinic_Govern = new System.Windows.Forms.TextBox();
            this.Clinic_street = new System.Windows.Forms.TextBox();
            this.Clinic_Zip_Code = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor\'s Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(191, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(183, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Degree";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(242, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(188, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fees";
            // 
            // DoctorName
            // 
            this.DoctorName.BackColor = System.Drawing.Color.LightGray;
            this.DoctorName.Location = new System.Drawing.Point(331, 63);
            this.DoctorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.ReadOnly = true;
            this.DoctorName.Size = new System.Drawing.Size(296, 22);
            this.DoctorName.TabIndex = 5;
            this.DoctorName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DoctorFees
            // 
            this.DoctorFees.BackColor = System.Drawing.Color.LightGray;
            this.DoctorFees.Location = new System.Drawing.Point(331, 204);
            this.DoctorFees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoctorFees.Name = "DoctorFees";
            this.DoctorFees.ReadOnly = true;
            this.DoctorFees.Size = new System.Drawing.Size(296, 22);
            this.DoctorFees.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(112, 493);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 71);
            this.button1.TabIndex = 9;
            this.button1.Text = "Register an Appointment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(456, 493);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 71);
            this.button2.TabIndex = 10;
            this.button2.Text = "Go back to available Doctors";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(167, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Clinic_Name";
            // 
            // ClinicName
            // 
            this.ClinicName.BackColor = System.Drawing.Color.LightGray;
            this.ClinicName.Location = new System.Drawing.Point(331, 240);
            this.ClinicName.Name = "ClinicName";
            this.ClinicName.ReadOnly = true;
            this.ClinicName.Size = new System.Drawing.Size(296, 22);
            this.ClinicName.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(188, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Clinic_City";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(1452, 639);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Clinic_City
            // 
            this.Clinic_City.BackColor = System.Drawing.Color.LightGray;
            this.Clinic_City.Location = new System.Drawing.Point(331, 285);
            this.Clinic_City.Name = "Clinic_City";
            this.Clinic_City.ReadOnly = true;
            this.Clinic_City.Size = new System.Drawing.Size(296, 22);
            this.Clinic_City.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(153, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Clinic_Governorate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(167, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Clinic_Street";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(167, 445);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Clinic_Zip_Code";
            // 
            // Clinic_Govern
            // 
            this.Clinic_Govern.BackColor = System.Drawing.Color.LightGray;
            this.Clinic_Govern.Location = new System.Drawing.Point(331, 339);
            this.Clinic_Govern.Name = "Clinic_Govern";
            this.Clinic_Govern.ReadOnly = true;
            this.Clinic_Govern.Size = new System.Drawing.Size(296, 22);
            this.Clinic_Govern.TabIndex = 22;
            // 
            // Clinic_street
            // 
            this.Clinic_street.BackColor = System.Drawing.Color.LightGray;
            this.Clinic_street.Location = new System.Drawing.Point(331, 389);
            this.Clinic_street.Name = "Clinic_street";
            this.Clinic_street.ReadOnly = true;
            this.Clinic_street.Size = new System.Drawing.Size(296, 22);
            this.Clinic_street.TabIndex = 23;
            // 
            // Clinic_Zip_Code
            // 
            this.Clinic_Zip_Code.BackColor = System.Drawing.Color.LightGray;
            this.Clinic_Zip_Code.Location = new System.Drawing.Point(331, 445);
            this.Clinic_Zip_Code.Name = "Clinic_Zip_Code";
            this.Clinic_Zip_Code.ReadOnly = true;
            this.Clinic_Zip_Code.Size = new System.Drawing.Size(296, 22);
            this.Clinic_Zip_Code.TabIndex = 24;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(331, 104);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(296, 84);
            this.listBox1.TabIndex = 25;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Doctor_sInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NewClinic.Properties.Resources.clinic3;
            this.ClientSize = new System.Drawing.Size(745, 590);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Clinic_Zip_Code);
            this.Controls.Add(this.Clinic_street);
            this.Controls.Add(this.Clinic_Govern);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Clinic_City);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ClinicName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DoctorFees);
            this.Controls.Add(this.DoctorName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Doctor_sInfo";
            this.Text = "Doctor\'sInfoForm ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Doctor_sInfo_FormClosed);
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DoctorName;
        private System.Windows.Forms.TextBox DoctorFees;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ClinicName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox Clinic_City;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Clinic_Govern;
        private System.Windows.Forms.TextBox Clinic_street;
        private System.Windows.Forms.TextBox Clinic_Zip_Code;
        private System.Windows.Forms.ListBox listBox1;
    }
}