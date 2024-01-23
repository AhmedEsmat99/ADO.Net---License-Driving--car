namespace licence.Forms
{
    partial class AddCars
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.INSERT = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.DELETED = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.chassisl = new System.Windows.Forms.Label();
            this.NumberCar = new System.Windows.Forms.TextBox();
            this.motor = new System.Windows.Forms.TextBox();
            this.chassis = new System.Windows.Forms.TextBox();
            this.showcarslicenses = new System.Windows.Forms.DataGridView();
            this.Start = new System.Windows.Forms.DateTimePicker();
            this.End = new System.Windows.Forms.DateTimePicker();
            this.ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showcarslicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(737, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "رقم السيارة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(737, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "تاريخ اصدار الرخصه";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(737, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "تاريخ انتهاء الرخصه";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.INSERT);
            this.panel1.Controls.Add(this.UPDATE);
            this.panel1.Controls.Add(this.DELETED);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 67);
            this.panel1.TabIndex = 7;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(737, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "رقم موتور";
            // 
            // chassisl
            // 
            this.chassisl.AutoSize = true;
            this.chassisl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chassisl.Location = new System.Drawing.Point(741, 359);
            this.chassisl.Name = "chassisl";
            this.chassisl.Size = new System.Drawing.Size(108, 25);
            this.chassisl.TabIndex = 6;
            this.chassisl.Text = "رقم الشاسيه";
            // 
            // NumberCar
            // 
            this.NumberCar.Location = new System.Drawing.Point(574, 164);
            this.NumberCar.Name = "NumberCar";
            this.NumberCar.Size = new System.Drawing.Size(138, 23);
            this.NumberCar.TabIndex = 8;
            // 
            // motor
            // 
            this.motor.Location = new System.Drawing.Point(574, 305);
            this.motor.Name = "motor";
            this.motor.Size = new System.Drawing.Size(143, 23);
            this.motor.TabIndex = 8;
            // 
            // chassis
            // 
            this.chassis.Location = new System.Drawing.Point(574, 364);
            this.chassis.Name = "chassis";
            this.chassis.Size = new System.Drawing.Size(142, 23);
            this.chassis.TabIndex = 8;
            // 
            // showcarslicenses
            // 
            this.showcarslicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showcarslicenses.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.showcarslicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showcarslicenses.Location = new System.Drawing.Point(12, 95);
            this.showcarslicenses.Name = "showcarslicenses";
            this.showcarslicenses.RowTemplate.Height = 25;
            this.showcarslicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.showcarslicenses.Size = new System.Drawing.Size(561, 370);
            this.showcarslicenses.TabIndex = 9;
            this.showcarslicenses.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.showcarslicenses_CellEnter);
            // 
            // Start
            // 
            this.Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Start.Location = new System.Drawing.Point(574, 215);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(138, 23);
            this.Start.TabIndex = 10;
            // 
            // End
            // 
            this.End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.End.Location = new System.Drawing.Point(574, 255);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(138, 23);
            this.End.TabIndex = 10;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(574, 121);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(138, 23);
            this.ID.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(737, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "كود السيارة";
            // 
            // AddCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(903, 491);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.showcarslicenses);
            this.Controls.Add(this.chassis);
            this.Controls.Add(this.motor);
            this.Controls.Add(this.NumberCar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chassisl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCars";
            this.Text = "CRUD_Car";
            this.Load += new System.EventHandler(this.AddCars_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showcarslicenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button INSERT;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button DELETED;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label chassisl;
        private System.Windows.Forms.TextBox NumberCar;
        private System.Windows.Forms.TextBox motor;
        private System.Windows.Forms.TextBox chassis;
        private System.Windows.Forms.DataGridView showcarslicenses;
        protected System.Windows.Forms.DateTimePicker Start;
        protected System.Windows.Forms.DateTimePicker End;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label4;
    }
}