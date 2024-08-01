
namespace Admin_Interface
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
            this.components = new System.ComponentModel.Container();
            this.Name_label = new System.Windows.Forms.Label();
            this.Phone_number_label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.Street_Label = new System.Windows.Forms.Label();
            this.ClinicName_txtbox = new System.Windows.Forms.TextBox();
            this.ID_txtbox = new System.Windows.Forms.TextBox();
            this.Street_txtbox = new System.Windows.Forms.TextBox();
            this.Add_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.city_label = new System.Windows.Forms.Label();
            this.City_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Governorate_txtbox = new System.Windows.Forms.TextBox();
            this.ZipCode_label = new System.Windows.Forms.Label();
            this.zipCode_txtbox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Bakc_btn = new System.Windows.Forms.Button();
            this.ClinicPhone_Masked = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.Location = new System.Drawing.Point(40, 303);
            this.Name_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(151, 35);
            this.Name_label.TabIndex = 0;
            this.Name_label.Text = "Clinic Name";
            this.Name_label.Click += new System.EventHandler(this.Name_label_Click);
            // 
            // Phone_number_label
            // 
            this.Phone_number_label.AutoSize = true;
            this.Phone_number_label.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_number_label.Location = new System.Drawing.Point(439, 194);
            this.Phone_number_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Phone_number_label.Name = "Phone_number_label";
            this.Phone_number_label.Size = new System.Drawing.Size(181, 35);
            this.Phone_number_label.TabIndex = 1;
            this.Phone_number_label.Text = "Phone Number";
            this.Phone_number_label.Click += new System.EventHandler(this.Phone_number_label_Click);
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_label.Location = new System.Drawing.Point(60, 188);
            this.ID_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(116, 35);
            this.ID_label.TabIndex = 2;
            this.ID_label.Text = "Clinic ID";
            this.ID_label.Click += new System.EventHandler(this.ID_label_Click);
            // 
            // Street_Label
            // 
            this.Street_Label.AutoSize = true;
            this.Street_Label.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Street_Label.Location = new System.Drawing.Point(475, 392);
            this.Street_Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Street_Label.Name = "Street_Label";
            this.Street_Label.Size = new System.Drawing.Size(92, 35);
            this.Street_Label.TabIndex = 3;
            this.Street_Label.Text = "Street";
            this.Street_Label.Click += new System.EventHandler(this.Street_Label_Click);
            // 
            // ClinicName_txtbox
            // 
            this.ClinicName_txtbox.Location = new System.Drawing.Point(227, 298);
            this.ClinicName_txtbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ClinicName_txtbox.Name = "ClinicName_txtbox";
            this.ClinicName_txtbox.Size = new System.Drawing.Size(172, 40);
            this.ClinicName_txtbox.TabIndex = 6;
            // 
            // ID_txtbox
            // 
            this.ID_txtbox.Location = new System.Drawing.Point(227, 191);
            this.ID_txtbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ID_txtbox.Name = "ID_txtbox";
            this.ID_txtbox.Size = new System.Drawing.Size(172, 40);
            this.ID_txtbox.TabIndex = 8;
            this.ID_txtbox.TextChanged += new System.EventHandler(this.ID_txtbox_TextChanged);
            // 
            // Street_txtbox
            // 
            this.Street_txtbox.Location = new System.Drawing.Point(646, 387);
            this.Street_txtbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Street_txtbox.Name = "Street_txtbox";
            this.Street_txtbox.Size = new System.Drawing.Size(172, 40);
            this.Street_txtbox.TabIndex = 9;
            // 
            // Add_btn
            // 
            this.Add_btn.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.Location = new System.Drawing.Point(200, 576);
            this.Add_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(186, 93);
            this.Add_btn.TabIndex = 12;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 41);
            this.label1.TabIndex = 13;
            this.label1.Text = "Clinic Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // city_label
            // 
            this.city_label.AutoSize = true;
            this.city_label.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_label.Location = new System.Drawing.Point(489, 298);
            this.city_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(61, 35);
            this.city_label.TabIndex = 14;
            this.city_label.Text = "City";
            this.city_label.Click += new System.EventHandler(this.city_label_Click);
            // 
            // City_txtbox
            // 
            this.City_txtbox.Location = new System.Drawing.Point(646, 293);
            this.City_txtbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.City_txtbox.Name = "City_txtbox";
            this.City_txtbox.Size = new System.Drawing.Size(172, 40);
            this.City_txtbox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 397);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 35);
            this.label2.TabIndex = 16;
            this.label2.Text = "Governorate";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Governorate_txtbox
            // 
            this.Governorate_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Governorate_txtbox.Location = new System.Drawing.Point(227, 392);
            this.Governorate_txtbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Governorate_txtbox.Name = "Governorate_txtbox";
            this.Governorate_txtbox.Size = new System.Drawing.Size(172, 40);
            this.Governorate_txtbox.TabIndex = 17;
            // 
            // ZipCode_label
            // 
            this.ZipCode_label.AutoSize = true;
            this.ZipCode_label.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZipCode_label.Location = new System.Drawing.Point(74, 501);
            this.ZipCode_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ZipCode_label.Name = "ZipCode_label";
            this.ZipCode_label.Size = new System.Drawing.Size(117, 35);
            this.ZipCode_label.TabIndex = 18;
            this.ZipCode_label.Text = "Zip Code";
            this.ZipCode_label.Click += new System.EventHandler(this.ZipCode_label_Click);
            // 
            // zipCode_txtbox
            // 
            this.zipCode_txtbox.Location = new System.Drawing.Point(227, 496);
            this.zipCode_txtbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.zipCode_txtbox.Name = "zipCode_txtbox";
            this.zipCode_txtbox.Size = new System.Drawing.Size(172, 40);
            this.zipCode_txtbox.TabIndex = 19;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Admin_Interface.Properties.Resources.icon1;
            this.pictureBox1.Location = new System.Drawing.Point(108, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Bakc_btn
            // 
            this.Bakc_btn.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bakc_btn.Location = new System.Drawing.Point(420, 576);
            this.Bakc_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Bakc_btn.Name = "Bakc_btn";
            this.Bakc_btn.Size = new System.Drawing.Size(186, 93);
            this.Bakc_btn.TabIndex = 21;
            this.Bakc_btn.Text = "Back ";
            this.Bakc_btn.UseVisualStyleBackColor = true;
            this.Bakc_btn.Click += new System.EventHandler(this.Bakc_btn_Click);
            // 
            // ClinicPhone_Masked
            // 
            this.ClinicPhone_Masked.Location = new System.Drawing.Point(706, 196);
            this.ClinicPhone_Masked.Mask = "999-000-0000";
            this.ClinicPhone_Masked.MinimumSize = new System.Drawing.Size(10, 10);
            this.ClinicPhone_Masked.Name = "ClinicPhone_Masked";
            this.ClinicPhone_Masked.Size = new System.Drawing.Size(185, 40);
            this.ClinicPhone_Masked.TabIndex = 22;
            this.ClinicPhone_Masked.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.ClinicPhone_Masked_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 35);
            this.label3.TabIndex = 23;
            this.label3.Text = "(+20)";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = global::Admin_Interface.Properties.Resources.clin_jpeg;
            this.ClientSize = new System.Drawing.Size(925, 699);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClinicPhone_Masked);
            this.Controls.Add(this.Bakc_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.zipCode_txtbox);
            this.Controls.Add(this.ZipCode_label);
            this.Controls.Add(this.Governorate_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.City_txtbox);
            this.Controls.Add(this.city_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Street_txtbox);
            this.Controls.Add(this.ID_txtbox);
            this.Controls.Add(this.ClinicName_txtbox);
            this.Controls.Add(this.Street_Label);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.Phone_number_label);
            this.Controls.Add(this.Name_label);
            this.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form2";
            this.Text = "Create New Clinic";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label Phone_number_label;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Label Street_Label;
        private System.Windows.Forms.TextBox ClinicName_txtbox;
        private System.Windows.Forms.TextBox ID_txtbox;
        private System.Windows.Forms.TextBox Street_txtbox;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label city_label;
        private System.Windows.Forms.TextBox City_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Governorate_txtbox;
        private System.Windows.Forms.Label ZipCode_label;
        private System.Windows.Forms.TextBox zipCode_txtbox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Bakc_btn;
        private System.Windows.Forms.MaskedTextBox ClinicPhone_Masked;
        private System.Windows.Forms.Label label3;
    }
}