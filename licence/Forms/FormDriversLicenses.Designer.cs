namespace licence.Forms
{
    partial class FormDriversLicenses
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
            this.end = new System.Windows.Forms.Button();
            this.AllLicence = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Licenses_Month = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataLicensesDriver = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataLicensesDriver)).BeginInit();
            this.SuspendLayout();
            // 
            // end
            // 
            this.end.BackColor = System.Drawing.Color.CornflowerBlue;
            this.end.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.end.FlatAppearance.BorderSize = 0;
            this.end.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.end.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.end.Location = new System.Drawing.Point(558, 12);
            this.end.Name = "end";
            this.end.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.end.Size = new System.Drawing.Size(153, 41);
            this.end.TabIndex = 1;
            this.end.Text = "الرخص المنتهي";
            this.end.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.end.UseVisualStyleBackColor = false;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // AllLicence
            // 
            this.AllLicence.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AllLicence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AllLicence.FlatAppearance.BorderSize = 0;
            this.AllLicence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllLicence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AllLicence.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllLicence.Location = new System.Drawing.Point(141, 12);
            this.AllLicence.Name = "AllLicence";
            this.AllLicence.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AllLicence.Size = new System.Drawing.Size(153, 41);
            this.AllLicence.TabIndex = 3;
            this.AllLicence.Text = "جميع الرخص";
            this.AllLicence.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AllLicence.UseVisualStyleBackColor = false;
            this.AllLicence.Click += new System.EventHandler(this.AllLicence_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Licenses_Month);
            this.panel1.Controls.Add(this.end);
            this.panel1.Controls.Add(this.AllLicence);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 73);
            this.panel1.TabIndex = 4;
            // 
            // Licenses_Month
            // 
            this.Licenses_Month.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Licenses_Month.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Licenses_Month.FlatAppearance.BorderSize = 0;
            this.Licenses_Month.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Licenses_Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Licenses_Month.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Licenses_Month.Location = new System.Drawing.Point(328, 12);
            this.Licenses_Month.Name = "Licenses_Month";
            this.Licenses_Month.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Licenses_Month.Size = new System.Drawing.Size(195, 41);
            this.Licenses_Month.TabIndex = 1;
            this.Licenses_Month.Text = "رخص ستنتهي خلال شهر";
            this.Licenses_Month.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Licenses_Month.UseVisualStyleBackColor = false;
            this.Licenses_Month.Click += new System.EventHandler(this.Licenses_Month_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(206, 33);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(536, 23);
            this.search.TabIndex = 6;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(132, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "بحث";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.search);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 100);
            this.panel2.TabIndex = 7;
            // 
            // DataLicensesDriver
            // 
            this.DataLicensesDriver.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataLicensesDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataLicensesDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataLicensesDriver.Location = new System.Drawing.Point(0, 173);
            this.DataLicensesDriver.Name = "DataLicensesDriver";
            this.DataLicensesDriver.RowTemplate.Height = 25;
            this.DataLicensesDriver.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataLicensesDriver.Size = new System.Drawing.Size(903, 342);
            this.DataLicensesDriver.TabIndex = 8;
            // 
            // FormDriversLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 515);
            this.Controls.Add(this.DataLicensesDriver);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormDriversLicenses";
            this.Text = "رخص السائقين";
            this.Load += new System.EventHandler(this.FormDriversLicenses_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataLicensesDriver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button end;
        private System.Windows.Forms.Button AllLicence;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DataLicensesDriver;
        private System.Windows.Forms.Button Licenses_Month;
    }
}