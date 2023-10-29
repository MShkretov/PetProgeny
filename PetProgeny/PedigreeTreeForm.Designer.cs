namespace PetProgeny
{
    partial class PedigreeTreeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedigreeTreeForm));
            this.pedigreeTreeView = new System.Windows.Forms.TreeView();
            this.lblAnimalId = new System.Windows.Forms.Label();
            this.txtAnimalId = new System.Windows.Forms.TextBox();
            this.lblSearchCriteria = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSearchCriteria = new System.Windows.Forms.ComboBox();
            this.headerTextBox = new System.Windows.Forms.TextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pedigreeTreeView
            // 
            this.pedigreeTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pedigreeTreeView.Location = new System.Drawing.Point(0, 123);
            this.pedigreeTreeView.Name = "pedigreeTreeView";
            this.pedigreeTreeView.Size = new System.Drawing.Size(803, 340);
            this.pedigreeTreeView.TabIndex = 0;
            // 
            // lblAnimalId
            // 
            this.lblAnimalId.AutoSize = true;
            this.lblAnimalId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnimalId.Location = new System.Drawing.Point(25, 555);
            this.lblAnimalId.Name = "lblAnimalId";
            this.lblAnimalId.Size = new System.Drawing.Size(112, 29);
            this.lblAnimalId.TabIndex = 23;
            this.lblAnimalId.Text = "AnimalId:";
            // 
            // txtAnimalId
            // 
            this.txtAnimalId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAnimalId.Location = new System.Drawing.Point(167, 554);
            this.txtAnimalId.Name = "txtAnimalId";
            this.txtAnimalId.Size = new System.Drawing.Size(176, 30);
            this.txtAnimalId.TabIndex = 24;
            // 
            // lblSearchCriteria
            // 
            this.lblSearchCriteria.AutoSize = true;
            this.lblSearchCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchCriteria.Location = new System.Drawing.Point(389, 554);
            this.lblSearchCriteria.Name = "lblSearchCriteria";
            this.lblSearchCriteria.Size = new System.Drawing.Size(179, 29);
            this.lblSearchCriteria.TabIndex = 25;
            this.lblSearchCriteria.Text = "Search Criteria:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(290, 645);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(148, 46);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbSearchCriteria
            // 
            this.cmbSearchCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbSearchCriteria.FormattingEnabled = true;
            this.cmbSearchCriteria.Items.AddRange(new object[] {
            "Name",
            "Type",
            " Breed",
            "Color",
            "Gender"});
            this.cmbSearchCriteria.Location = new System.Drawing.Point(617, 550);
            this.cmbSearchCriteria.Name = "cmbSearchCriteria";
            this.cmbSearchCriteria.Size = new System.Drawing.Size(158, 33);
            this.cmbSearchCriteria.TabIndex = 27;
            // 
            // headerTextBox
            // 
            this.headerTextBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerTextBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.headerTextBox.Location = new System.Drawing.Point(-27, -3);
            this.headerTextBox.Name = "headerTextBox";
            this.headerTextBox.Size = new System.Drawing.Size(838, 75);
            this.headerTextBox.TabIndex = 28;
            this.headerTextBox.Text = "PetProgeny";
            this.headerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(729, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 33);
            this.btnClose.TabIndex = 36;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeading.Location = new System.Drawing.Point(181, 85);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(317, 25);
            this.lblHeading.TabIndex = 37;
            this.lblHeading.Text = "Welcome to the Pet Progeny Tree !";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInformation.Location = new System.Drawing.Point(12, 478);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(718, 25);
            this.lblInformation.TabIndex = 38;
            this.lblInformation.Text = "Enter the animal ID and select a search criterion to find childs with similar att" +
    "ributes";
            // 
            // PedigreeTreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(805, 802);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.headerTextBox);
            this.Controls.Add(this.cmbSearchCriteria);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearchCriteria);
            this.Controls.Add(this.txtAnimalId);
            this.Controls.Add(this.lblAnimalId);
            this.Controls.Add(this.pedigreeTreeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PedigreeTreeForm";
            this.Text = "PedegreeTreeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView pedigreeTreeView;
        private System.Windows.Forms.Label lblAnimalId;
        private System.Windows.Forms.TextBox txtAnimalId;
        private System.Windows.Forms.Label lblSearchCriteria;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.ComboBox cmbSearchCriteria;
        private System.Windows.Forms.TextBox headerTextBox;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblInformation;
    }
}