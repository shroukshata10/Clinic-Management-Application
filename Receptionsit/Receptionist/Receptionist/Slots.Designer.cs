namespace Receptionist
{
    partial class Slots
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Slots));
            this.clinicDataSet = new Receptionist.ClinicDataSet();
            this.freeSlotsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.free_SlotsTableAdapter = new Receptionist.ClinicDataSetTableAdapters.Free_SlotsTableAdapter();
            this.clinicDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.freeSlotsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.freeSlotsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.freeSlotsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Addbutton1 = new System.Windows.Forms.Button();
            this.StarttextBox3 = new System.Windows.Forms.TextBox();
            this.EndtextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Backbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeSlotsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeSlotsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeSlotsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeSlotsBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // clinicDataSet
            // 
            this.clinicDataSet.DataSetName = "ClinicDataSet";
            this.clinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // freeSlotsBindingSource
            // 
            this.freeSlotsBindingSource.DataMember = "Free_Slots";
            this.freeSlotsBindingSource.DataSource = this.clinicDataSet;
            // 
            // free_SlotsTableAdapter
            // 
            this.free_SlotsTableAdapter.ClearBeforeFill = true;
            // 
            // clinicDataSetBindingSource
            // 
            this.clinicDataSetBindingSource.DataSource = this.clinicDataSet;
            this.clinicDataSetBindingSource.Position = 0;
            // 
            // freeSlotsBindingSource1
            // 
            this.freeSlotsBindingSource1.DataMember = "Free_Slots";
            this.freeSlotsBindingSource1.DataSource = this.clinicDataSetBindingSource;
            // 
            // freeSlotsBindingSource2
            // 
            this.freeSlotsBindingSource2.DataMember = "Free_Slots";
            this.freeSlotsBindingSource2.DataSource = this.clinicDataSetBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(10, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(678, 258);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // freeSlotsBindingSource3
            // 
            this.freeSlotsBindingSource3.DataMember = "Free_Slots";
            this.freeSlotsBindingSource3.DataSource = this.clinicDataSetBindingSource;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(710, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 98);
            this.button1.TabIndex = 11;
            this.button1.Text = "Show / Refresh Slots";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Addbutton1
            // 
            this.Addbutton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Addbutton1.BackgroundImage")));
            this.Addbutton1.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton1.Location = new System.Drawing.Point(557, 387);
            this.Addbutton1.Name = "Addbutton1";
            this.Addbutton1.Size = new System.Drawing.Size(118, 72);
            this.Addbutton1.TabIndex = 18;
            this.Addbutton1.Text = "Add";
            this.Addbutton1.UseVisualStyleBackColor = true;
            this.Addbutton1.Click += new System.EventHandler(this.Addbutton1_Click);
            // 
            // StarttextBox3
            // 
            this.StarttextBox3.Location = new System.Drawing.Point(279, 437);
            this.StarttextBox3.Name = "StarttextBox3";
            this.StarttextBox3.Size = new System.Drawing.Size(142, 22);
            this.StarttextBox3.TabIndex = 17;
            // 
            // EndtextBox2
            // 
            this.EndtextBox2.Location = new System.Drawing.Point(279, 483);
            this.EndtextBox2.Name = "EndtextBox2";
            this.EndtextBox2.Size = new System.Drawing.Size(142, 22);
            this.EndtextBox2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "End Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Date";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(279, 347);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 22);
            this.textBox1.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Slot No.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Backbutton.BackgroundImage")));
            this.Backbutton.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.Location = new System.Drawing.Point(1049, 496);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(131, 45);
            this.Backbutton.TabIndex = 21;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(465, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "dd/mm/yyyy";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(465, 437);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "hh:mm:ss";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(465, 483);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "hh:mm:ss";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(446, 483);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "*";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1039, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 46);
            this.button2.TabIndex = 30;
            this.button2.Text = "Register\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(988, 239);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 22);
            this.textBox2.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(705, 239);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(193, 29);
            this.label13.TabIndex = 32;
            this.label13.Text = "Patient Name";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(197, 389);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 22);
            this.dateTimePicker1.TabIndex = 33;
            this.dateTimePicker1.Value = new System.DateTime(2021, 6, 13, 15, 14, 38, 0);
            // 
            // Slots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1204, 553);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.Addbutton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EndtextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StarttextBox3);
            this.Name = "Slots";
            this.Text = "Slots";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeSlotsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeSlotsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeSlotsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeSlotsBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ClinicDataSet clinicDataSet;
        private System.Windows.Forms.BindingSource freeSlotsBindingSource;
        private ClinicDataSetTableAdapters.Free_SlotsTableAdapter free_SlotsTableAdapter;
        private System.Windows.Forms.BindingSource clinicDataSetBindingSource;
        private System.Windows.Forms.BindingSource freeSlotsBindingSource1;
        private System.Windows.Forms.BindingSource freeSlotsBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource freeSlotsBindingSource3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Addbutton1;
        private System.Windows.Forms.TextBox StarttextBox3;
        private System.Windows.Forms.TextBox EndtextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}