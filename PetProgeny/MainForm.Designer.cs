namespace PetProgeny
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.btnViewRecords = new System.Windows.Forms.Button();
            this.btnPedigreeTree = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.picAnimal = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.headerTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.AutoSize = true;
            this.btnAddAnimal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddAnimal.Location = new System.Drawing.Point(22, 301);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(141, 41);
            this.btnAddAnimal.TabIndex = 1;
            this.btnAddAnimal.Text = "Add Pet";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // btnViewRecords
            // 
            this.btnViewRecords.AutoSize = true;
            this.btnViewRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewRecords.Location = new System.Drawing.Point(22, 220);
            this.btnViewRecords.Name = "btnViewRecords";
            this.btnViewRecords.Size = new System.Drawing.Size(141, 41);
            this.btnViewRecords.TabIndex = 2;
            this.btnViewRecords.Text = "All Pets";
            this.btnViewRecords.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewRecords.UseVisualStyleBackColor = true;
            this.btnViewRecords.Click += new System.EventHandler(this.btnViewRecords_Click);
            // 
            // btnPedigreeTree
            // 
            this.btnPedigreeTree.AutoSize = true;
            this.btnPedigreeTree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPedigreeTree.Location = new System.Drawing.Point(22, 140);
            this.btnPedigreeTree.Name = "btnPedigreeTree";
            this.btnPedigreeTree.Size = new System.Drawing.Size(141, 41);
            this.btnPedigreeTree.TabIndex = 3;
            this.btnPedigreeTree.Text = "Pedigree Tree";
            this.btnPedigreeTree.UseVisualStyleBackColor = true;
            this.btnPedigreeTree.Click += new System.EventHandler(this.btnPedigreeTree_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.Location = new System.Drawing.Point(2, 78);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(959, 31);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "Welcome to PetTree, your application for managing the pedigree tree of your domes" +
    "tic pets !";
            // 
            // picAnimal
            // 
            this.picAnimal.ErrorImage = null;
            this.picAnimal.Image = ((System.Drawing.Image)(resources.GetObject("picAnimal.Image")));
            this.picAnimal.InitialImage = null;
            this.picAnimal.Location = new System.Drawing.Point(215, 124);
            this.picAnimal.Name = "picAnimal";
            this.picAnimal.Size = new System.Drawing.Size(811, 326);
            this.picAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnimal.TabIndex = 7;
            this.picAnimal.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSize = true;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogOut.Location = new System.Drawing.Point(22, 383);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(141, 41);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // headerTextBox
            // 
            this.headerTextBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerTextBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.headerTextBox.Location = new System.Drawing.Point(-8, 0);
            this.headerTextBox.Name = "headerTextBox";
            this.headerTextBox.Size = new System.Drawing.Size(1051, 75);
            this.headerTextBox.TabIndex = 9;
            this.headerTextBox.Text = "PetProgeny";
            this.headerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1048, 478);
            this.Controls.Add(this.headerTextBox);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.picAnimal);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnPedigreeTree);
            this.Controls.Add(this.btnViewRecords);
            this.Controls.Add(this.btnAddAnimal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.picAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Button btnViewRecords;
        private System.Windows.Forms.Button btnPedigreeTree;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogOut;
        public System.Windows.Forms.PictureBox picAnimal;
        private System.Windows.Forms.TextBox headerTextBox;
    }
}

