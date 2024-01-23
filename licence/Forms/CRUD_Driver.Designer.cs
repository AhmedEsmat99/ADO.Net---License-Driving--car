namespace licence.Forms
{
    partial class CRUD_Driver
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
            this.ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.End = new System.Windows.Forms.DateTimePicker();
            this.Start = new System.Windows.Forms.DateTimePicker();
            this.UPDATE = new System.Windows.Forms.Button();
            this.DELETED = new System.Windows.Forms.Button();
            this.ShowDriverLicenses = new System.Windows.Forms.DataGridView();
            this.rank = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.INSERT = new System.Windows.Forms.Button();
            this.chassisl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDriverLicenses)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(574, 134);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(138, 23);
            this.ID.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(737, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "كود السائق";
            // 
            // End
            // 
            this.End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.End.Location = new System.Drawing.Point(574, 373);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(138, 23);
            this.End.TabIndex = 23;
            // 
            // Start
            // 
            this.Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Start.Location = new System.Drawing.Point(574, 333);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(138, 23);
            this.Start.TabIndex = 24;
            // 
            // UPDATE
            // 
            this.UPDATE.BackColor = System.Drawing.Color.CornflowerBlue;
            this.UPDATE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UPDATE.FlatAppearance.BorderSize = 0;
            this.UPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UPDATE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UPDATE.Location = new System.Drawing.Point(368, 12);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(164, 41);
            this.UPDATE.TabIndex = 2;
            this.UPDATE.Text = "تعديل";
            this.UPDATE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UPDATE.UseVisualStyleBackColor = false;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // DELETED
            // 
            this.DELETED.BackColor = System.Drawing.Color.CornflowerBlue;
            this.DELETED.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DELETED.FlatAppearance.BorderSize = 0;
            this.DELETED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DELETED.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DELETED.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DELETED.Location = new System.Drawing.Point(178, 11);
            this.DELETED.Name = "DELETED";
            this.DELETED.Size = new System.Drawing.Size(153, 41);
            this.DELETED.TabIndex = 3;
            this.DELETED.Text = "حذف";
            this.DELETED.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DELETED.UseVisualStyleBackColor = false;
            this.DELETED.Click += new System.EventHandler(this.DELETED_Click);
            // 
            // ShowDriverLicenses
            // 
            this.ShowDriverLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShowDriverLicenses.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShowDriverLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowDriverLicenses.Location = new System.Drawing.Point(12, 108);
            this.ShowDriverLicenses.Name = "ShowDriverLicenses";
            this.ShowDriverLicenses.RowTemplate.Height = 25;
            this.ShowDriverLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShowDriverLicenses.Size = new System.Drawing.Size(561, 370);
            this.ShowDriverLicenses.TabIndex = 22;
            this.ShowDriverLicenses.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowDriverLicenses_CellEnter);
            // 
            // rank
            // 
            this.rank.Location = new System.Drawing.Point(574, 283);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(142, 23);
            this.rank.TabIndex = 19;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(574, 233);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(143, 23);
            this.phone.TabIndex = 20;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(574, 177);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(138, 23);
            this.name.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.INSERT);
            this.panel1.Controls.Add(this.UPDATE);
            this.panel1.Controls.Add(this.DELETED);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 67);
            this.panel1.TabIndex = 18;
            // 
            // INSERT
            // 
            this.INSERT.BackColor = System.Drawing.Color.CornflowerBlue;
            this.INSERT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.INSERT.FlatAppearance.BorderSize = 0;
            this.INSERT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.INSERT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.INSERT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.INSERT.Location = new System.Drawing.Point(564, 12);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(153, 41);
            this.INSERT.TabIndex = 1;
            this.INSERT.Text = "أضافه";
            this.INSERT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.INSERT.UseVisualStyleBackColor = false;
            this.INSERT.Click += new System.EventHandler(this.INSERT_Click);
            // 
            // chassisl
            // 
            this.chassisl.AutoSize = true;
            this.chassisl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chassisl.Location = new System.Drawing.Point(741, 278);
            this.chassisl.Name = "chassisl";
            this.chassisl.Size = new System.Drawing.Size(62, 25);
            this.chassisl.TabIndex = 13;
            this.chassisl.Text = "الدرجه";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(737, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "تاريخ انتهاء الرخصه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(737, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "تاريخ اصدار الرخصه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(737, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "الاسم";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(737, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "رقم الهاتف";
            // 
            // CRUD_Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(903, 491);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.ShowDriverLicenses);
            this.Controls.Add(this.rank);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.name);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chassisl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "CRUD_Driver";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CRUD_Driver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowDriverLicenses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.DateTimePicker End;
        protected System.Windows.Forms.DateTimePicker Start;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button DELETED;
        private System.Windows.Forms.DataGridView ShowDriverLicenses;
        private System.Windows.Forms.TextBox rank;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button INSERT;
        private System.Windows.Forms.Label chassisl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}