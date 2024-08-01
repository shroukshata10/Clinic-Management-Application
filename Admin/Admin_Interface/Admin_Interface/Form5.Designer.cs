
namespace Admin_Interface
{
    partial class Form5
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
            this.Next_btn = new System.Windows.Forms.Button();
            this.SelectDoctor_DataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.FeesUpdate_txtBox = new System.Windows.Forms.TextBox();
            this.DUserNameUpdate_txtBox = new System.Windows.Forms.TextBox();
            this.DUserName_Label = new System.Windows.Forms.Label();
            this.Fees = new System.Windows.Forms.Label();
            this.DoctorDelete = new System.Windows.Forms.Button();
            this.DRUserName_Delete = new System.Windows.Forms.Label();
            this.DRDelete_txtBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Back_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Clinic_ID_Combobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SelectDoctor_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Next_btn
            // 
            this.Next_btn.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_btn.Location = new System.Drawing.Point(273, 95);
            this.Next_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(294, 68);
            this.Next_btn.TabIndex = 15;
            this.Next_btn.Text = "View Doctors\' Accounts";
            this.Next_btn.UseVisualStyleBackColor = true;
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            // 
            // SelectDoctor_DataGrid
            // 
            this.SelectDoctor_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectDoctor_DataGrid.Location = new System.Drawing.Point(159, 360);
            this.SelectDoctor_DataGrid.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SelectDoctor_DataGrid.Name = "SelectDoctor_DataGrid";
            this.SelectDoctor_DataGrid.RowHeadersWidth = 51;
            this.SelectDoctor_DataGrid.RowTemplate.Height = 24;
            this.SelectDoctor_DataGrid.Size = new System.Drawing.Size(650, 317);
            this.SelectDoctor_DataGrid.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "Enter Clinic ID";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(682, 168);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 68);
            this.button1.TabIndex = 20;
            this.button1.Text = "Update Doctor\'s Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FeesUpdate_txtBox
            // 
            this.FeesUpdate_txtBox.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeesUpdate_txtBox.Location = new System.Drawing.Point(480, 173);
            this.FeesUpdate_txtBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.FeesUpdate_txtBox.Multiline = true;
            this.FeesUpdate_txtBox.Name = "FeesUpdate_txtBox";
            this.FeesUpdate_txtBox.Size = new System.Drawing.Size(153, 63);
            this.FeesUpdate_txtBox.TabIndex = 21;
            // 
            // DUserNameUpdate_txtBox
            // 
            this.DUserNameUpdate_txtBox.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DUserNameUpdate_txtBox.Location = new System.Drawing.Point(188, 167);
            this.DUserNameUpdate_txtBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DUserNameUpdate_txtBox.Multiline = true;
            this.DUserNameUpdate_txtBox.Name = "DUserNameUpdate_txtBox";
            this.DUserNameUpdate_txtBox.Size = new System.Drawing.Size(146, 63);
            this.DUserNameUpdate_txtBox.TabIndex = 22;
            // 
            // DUserName_Label
            // 
            this.DUserName_Label.AutoSize = true;
            this.DUserName_Label.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DUserName_Label.Location = new System.Drawing.Point(11, 186);
            this.DUserName_Label.Name = "DUserName_Label";
            this.DUserName_Label.Size = new System.Drawing.Size(163, 38);
            this.DUserName_Label.TabIndex = 23;
            this.DUserName_Label.Text = "User Name";
            // 
            // Fees
            // 
            this.Fees.AutoSize = true;
            this.Fees.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fees.Location = new System.Drawing.Point(382, 187);
            this.Fees.Name = "Fees";
            this.Fees.Size = new System.Drawing.Size(76, 38);
            this.Fees.TabIndex = 24;
            this.Fees.Text = "Fees";
            // 
            // DoctorDelete
            // 
            this.DoctorDelete.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorDelete.Location = new System.Drawing.Point(682, 283);
            this.DoctorDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DoctorDelete.Name = "DoctorDelete";
            this.DoctorDelete.Size = new System.Drawing.Size(294, 68);
            this.DoctorDelete.TabIndex = 25;
            this.DoctorDelete.Text = "Delete Doctor";
            this.DoctorDelete.UseVisualStyleBackColor = true;
            this.DoctorDelete.Click += new System.EventHandler(this.DoctorDelete_Click);
            // 
            // DRUserName_Delete
            // 
            this.DRUserName_Delete.AutoSize = true;
            this.DRUserName_Delete.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DRUserName_Delete.Location = new System.Drawing.Point(11, 293);
            this.DRUserName_Delete.Name = "DRUserName_Delete";
            this.DRUserName_Delete.Size = new System.Drawing.Size(163, 38);
            this.DRUserName_Delete.TabIndex = 26;
            this.DRUserName_Delete.Text = "User Name";
            // 
            // DRDelete_txtBox
            // 
            this.DRDelete_txtBox.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DRDelete_txtBox.Location = new System.Drawing.Point(188, 283);
            this.DRDelete_txtBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DRDelete_txtBox.Multiline = true;
            this.DRDelete_txtBox.Name = "DRDelete_txtBox";
            this.DRDelete_txtBox.Size = new System.Drawing.Size(146, 61);
            this.DRDelete_txtBox.TabIndex = 27;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Back_btn
            // 
            this.Back_btn.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.Location = new System.Drawing.Point(744, 9);
            this.Back_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(210, 68);
            this.Back_btn.TabIndex = 28;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(538, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 68);
            this.button2.TabIndex = 29;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Clinic_ID_Combobox
            // 
            this.Clinic_ID_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Clinic_ID_Combobox.FormattingEnabled = true;
            this.Clinic_ID_Combobox.Location = new System.Drawing.Point(80, 25);
            this.Clinic_ID_Combobox.Name = "Clinic_ID_Combobox";
            this.Clinic_ID_Combobox.Size = new System.Drawing.Size(169, 44);
            this.Clinic_ID_Combobox.TabIndex = 30;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Admin_Interface.Properties.Resources.boarder2;
            this.ClientSize = new System.Drawing.Size(988, 691);
            this.Controls.Add(this.Clinic_ID_Combobox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.DRDelete_txtBox);
            this.Controls.Add(this.DRUserName_Delete);
            this.Controls.Add(this.DoctorDelete);
            this.Controls.Add(this.Fees);
            this.Controls.Add(this.DUserName_Label);
            this.Controls.Add(this.DUserNameUpdate_txtBox);
            this.Controls.Add(this.FeesUpdate_txtBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectDoctor_DataGrid);
            this.Controls.Add(this.Next_btn);
            this.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form5";
            this.Text = "Update Doctors\' Info";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectDoctor_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next_btn;
        private System.Windows.Forms.DataGridView SelectDoctor_DataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FeesUpdate_txtBox;
        private System.Windows.Forms.TextBox DUserNameUpdate_txtBox;
        private System.Windows.Forms.Label DUserName_Label;
        private System.Windows.Forms.Label Fees;
        private System.Windows.Forms.Button DoctorDelete;
        private System.Windows.Forms.Label DRUserName_Delete;
        private System.Windows.Forms.TextBox DRDelete_txtBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox Clinic_ID_Combobox;
    }
}