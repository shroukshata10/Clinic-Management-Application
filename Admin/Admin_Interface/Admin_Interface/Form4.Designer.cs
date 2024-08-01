
namespace Admin_Interface
{
    partial class Form4
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
            this.Add_btn = new System.Windows.Forms.Button();
            this.UserName_lbl = new System.Windows.Forms.Label();
            this.Pass_lbl = new System.Windows.Forms.Label();
            this.User_textbox = new System.Windows.Forms.TextBox();
            this.Pass_txtbox = new System.Windows.Forms.TextBox();
            this.Back_btn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_btn
            // 
            this.Add_btn.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.Location = new System.Drawing.Point(235, 414);
            this.Add_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(208, 60);
            this.Add_btn.TabIndex = 0;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // UserName_lbl
            // 
            this.UserName_lbl.AutoSize = true;
            this.UserName_lbl.BackColor = System.Drawing.Color.SkyBlue;
            this.UserName_lbl.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_lbl.Location = new System.Drawing.Point(256, 273);
            this.UserName_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserName_lbl.Name = "UserName_lbl";
            this.UserName_lbl.Size = new System.Drawing.Size(170, 39);
            this.UserName_lbl.TabIndex = 1;
            this.UserName_lbl.Text = "User Name";
            // 
            // Pass_lbl
            // 
            this.Pass_lbl.AutoSize = true;
            this.Pass_lbl.BackColor = System.Drawing.Color.SkyBlue;
            this.Pass_lbl.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_lbl.Location = new System.Drawing.Point(256, 341);
            this.Pass_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pass_lbl.Name = "Pass_lbl";
            this.Pass_lbl.Size = new System.Drawing.Size(139, 39);
            this.Pass_lbl.TabIndex = 2;
            this.Pass_lbl.Text = "Password";
            // 
            // User_textbox
            // 
            this.User_textbox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_textbox.Location = new System.Drawing.Point(458, 277);
            this.User_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.User_textbox.Name = "User_textbox";
            this.User_textbox.Size = new System.Drawing.Size(148, 45);
            this.User_textbox.TabIndex = 3;
            // 
            // Pass_txtbox
            // 
            this.Pass_txtbox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_txtbox.Location = new System.Drawing.Point(458, 341);
            this.Pass_txtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pass_txtbox.Name = "Pass_txtbox";
            this.Pass_txtbox.Size = new System.Drawing.Size(148, 45);
            this.Pass_txtbox.TabIndex = 4;
            this.Pass_txtbox.TextChanged += new System.EventHandler(this.Pass_txtbox_TextChanged);
            // 
            // Back_btn
            // 
            this.Back_btn.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.Location = new System.Drawing.Point(477, 414);
            this.Back_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(208, 60);
            this.Back_btn.TabIndex = 5;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Admin_Interface.Properties.Resources.admin4;
            this.ClientSize = new System.Drawing.Size(729, 580);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.Pass_txtbox);
            this.Controls.Add(this.User_textbox);
            this.Controls.Add(this.Pass_lbl);
            this.Controls.Add(this.UserName_lbl);
            this.Controls.Add(this.Add_btn);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form4";
            this.Text = "Add New Admin";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Label UserName_lbl;
        private System.Windows.Forms.Label Pass_lbl;
        private System.Windows.Forms.TextBox User_textbox;
        private System.Windows.Forms.TextBox Pass_txtbox;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}