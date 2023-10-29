namespace PetProgeny
{
    partial class RecordsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordsForm));
            this.headerTextBox = new System.Windows.Forms.TextBox();
            this.dgvAnimalList = new System.Windows.Forms.DataGridView();
            this.Row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Details = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblAnimalList = new System.Windows.Forms.Label();
            this.addPetTaskButton = new System.Windows.Forms.Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimalList)).BeginInit();
            this.SuspendLayout();
            // 
            // headerTextBox
            // 
            this.headerTextBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerTextBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.headerTextBox.Location = new System.Drawing.Point(-103, -7);
            this.headerTextBox.Name = "headerTextBox";
            this.headerTextBox.Size = new System.Drawing.Size(1301, 75);
            this.headerTextBox.TabIndex = 10;
            this.headerTextBox.Text = "PetProgeny";
            this.headerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvAnimalList
            // 
            this.dgvAnimalList.AllowUserToAddRows = false;
            this.dgvAnimalList.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvAnimalList.ColumnHeadersHeight = 29;
            this.dgvAnimalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAnimalList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Row,
            this.Id,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Color,
            this.Column4,
            this.Gender,
            this.Edit,
            this.Details,
            this.Delete});
            this.dgvAnimalList.Location = new System.Drawing.Point(2, 120);
            this.dgvAnimalList.Name = "dgvAnimalList";
            this.dgvAnimalList.RowHeadersWidth = 51;
            this.dgvAnimalList.RowTemplate.Height = 24;
            this.dgvAnimalList.Size = new System.Drawing.Size(1196, 352);
            this.dgvAnimalList.TabIndex = 11;
            this.dgvAnimalList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnimalList_CellContentClick);
            // 
            // Row
            // 
            this.Row.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Row.HeaderText = "Row";
            this.Row.MinimumWidth = 6;
            this.Row.Name = "Row";
            this.Row.Width = 63;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 47;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 73;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Type";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 68;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Breed";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 73;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 6;
            this.Color.Name = "Color";
            this.Color.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "DateOfBirth";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.Width = 125;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 10;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Width = 59;
            // 
            // Details
            // 
            this.Details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Details.HeaderText = "Details";
            this.Details.Image = ((System.Drawing.Image)(resources.GetObject("Details.Image")));
            this.Details.MinimumWidth = 6;
            this.Details.Name = "Details";
            this.Details.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Details.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Details.Width = 78;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 76;
            // 
            // lblAnimalList
            // 
            this.lblAnimalList.AutoSize = true;
            this.lblAnimalList.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblAnimalList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnimalList.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblAnimalList.Location = new System.Drawing.Point(975, 77);
            this.lblAnimalList.Name = "lblAnimalList";
            this.lblAnimalList.Size = new System.Drawing.Size(127, 32);
            this.lblAnimalList.TabIndex = 12;
            this.lblAnimalList.Text = "Records:";
            // 
            // addPetTaskButton
            // 
            this.addPetTaskButton.AutoSize = true;
            this.addPetTaskButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addPetTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPetTaskButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.addPetTaskButton.Location = new System.Drawing.Point(28, 73);
            this.addPetTaskButton.Name = "addPetTaskButton";
            this.addPetTaskButton.Size = new System.Drawing.Size(149, 40);
            this.addPetTaskButton.TabIndex = 14;
            this.addPetTaskButton.Text = "+ Add Pet";
            this.addPetTaskButton.UseVisualStyleBackColor = false;
            this.addPetTaskButton.Click += new System.EventHandler(this.addAnimalTaskButton_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1081, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 33);
            this.btnClose.TabIndex = 21;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.Location = new System.Drawing.Point(333, 77);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(371, 31);
            this.lblWelcome.TabIndex = 22;
            this.lblWelcome.Text = "Explore Your Beloved Pets\' Legacy !";
            // 
            // RecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1198, 470);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.addPetTaskButton);
            this.Controls.Add(this.lblAnimalList);
            this.Controls.Add(this.dgvAnimalList);
            this.Controls.Add(this.headerTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecordsForm";
            this.Text = "RecordsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimalList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox headerTextBox;
        private System.Windows.Forms.Label lblAnimalList;
        private System.Windows.Forms.Button addPetTaskButton;
        public System.Windows.Forms.DataGridView dgvAnimalList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Row;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Details;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lblWelcome;
    }
}