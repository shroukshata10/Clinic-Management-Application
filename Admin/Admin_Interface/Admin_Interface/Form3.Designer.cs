
namespace Admin_Interface
{
    partial class Form3
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
            this.selectClinic_dataGrid = new System.Windows.Forms.DataGridView();
            this.SelectAllClinics_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selectClinic_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // selectClinic_dataGrid
            // 
            this.selectClinic_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectClinic_dataGrid.Location = new System.Drawing.Point(47, 124);
            this.selectClinic_dataGrid.Name = "selectClinic_dataGrid";
            this.selectClinic_dataGrid.RowHeadersWidth = 51;
            this.selectClinic_dataGrid.RowTemplate.Height = 24;
            this.selectClinic_dataGrid.Size = new System.Drawing.Size(616, 297);
            this.selectClinic_dataGrid.TabIndex = 13;
            this.selectClinic_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectClinic_dataGrid_CellContentClick);
            // 
            // SelectAllClinics_btn
            // 
            this.SelectAllClinics_btn.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectAllClinics_btn.Location = new System.Drawing.Point(223, 32);
            this.SelectAllClinics_btn.Name = "SelectAllClinics_btn";
            this.SelectAllClinics_btn.Size = new System.Drawing.Size(338, 57);
            this.SelectAllClinics_btn.TabIndex = 9;
            this.SelectAllClinics_btn.Text = "Select All Added Clinics";
            this.SelectAllClinics_btn.UseVisualStyleBackColor = true;
            this.SelectAllClinics_btn.Click += new System.EventHandler(this.SelectAllClinics_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "To View Doctors and Receptionist Accounts ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(104, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 76);
            this.button1.TabIndex = 15;
            this.button1.Text = "Click Here";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.Location = new System.Drawing.Point(430, 538);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(198, 76);
            this.Back_btn.TabIndex = 16;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Admin_Interface.Properties.Resources.clin_jpeg;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectClinic_dataGrid);
            this.Controls.Add(this.SelectAllClinics_btn);
            this.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "View Created Clinics";
            ((System.ComponentModel.ISupportInitialize)(this.selectClinic_dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView selectClinic_dataGrid;
        private System.Windows.Forms.Button SelectAllClinics_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Back_btn;
    }
}