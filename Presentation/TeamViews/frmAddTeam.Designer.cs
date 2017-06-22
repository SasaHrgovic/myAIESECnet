namespace Presentation.TeamViews
{
    partial class frmAddTeam
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeleteTeam = new System.Windows.Forms.Button();
            this.gbxTeamType = new System.Windows.Forms.GroupBox();
            this.radFunctionalTeam = new System.Windows.Forms.RadioButton();
            this.radProjectTeam = new System.Windows.Forms.RadioButton();
            this.lbxCommitteeMembers = new System.Windows.Forms.ListBox();
            this.lbxTeamMembers = new System.Windows.Forms.ListBox();
            this.cbxProjects = new System.Windows.Forms.ComboBox();
            this.gbxTeamType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Naziv tima";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(25, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(22, 91);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(50, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Opis tima";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(22, 208);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(91, 13);
            this.lblStart.TabIndex = 3;
            this.lblStart.Text = "Početak mandata";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(25, 108);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(243, 80);
            this.txtDescription.TabIndex = 4;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(25, 224);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(243, 20);
            this.dtpStart.TabIndex = 5;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(25, 276);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(243, 20);
            this.dtpEnd.TabIndex = 6;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(22, 260);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(69, 13);
            this.lblEnd.TabIndex = 7;
            this.lblEnd.Text = "Kraj mandata";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(193, 314);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Spremi";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeleteTeam
            // 
            this.btnDeleteTeam.Location = new System.Drawing.Point(25, 313);
            this.btnDeleteTeam.Name = "btnDeleteTeam";
            this.btnDeleteTeam.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTeam.TabIndex = 9;
            this.btnDeleteTeam.Text = "Izbriši";
            this.btnDeleteTeam.UseVisualStyleBackColor = true;
            this.btnDeleteTeam.Click += new System.EventHandler(this.btnDeleteTeam_Click);
            // 
            // gbxTeamType
            // 
            this.gbxTeamType.Controls.Add(this.radFunctionalTeam);
            this.gbxTeamType.Controls.Add(this.radProjectTeam);
            this.gbxTeamType.Location = new System.Drawing.Point(298, 52);
            this.gbxTeamType.Name = "gbxTeamType";
            this.gbxTeamType.Size = new System.Drawing.Size(193, 68);
            this.gbxTeamType.TabIndex = 10;
            this.gbxTeamType.TabStop = false;
            this.gbxTeamType.Text = "Vrsta tima";
            // 
            // radFunctionalTeam
            // 
            this.radFunctionalTeam.AutoSize = true;
            this.radFunctionalTeam.Location = new System.Drawing.Point(106, 35);
            this.radFunctionalTeam.Name = "radFunctionalTeam";
            this.radFunctionalTeam.Size = new System.Drawing.Size(72, 17);
            this.radFunctionalTeam.TabIndex = 1;
            this.radFunctionalTeam.Text = "Funkcijski";
            this.radFunctionalTeam.UseVisualStyleBackColor = true;
            // 
            // radProjectTeam
            // 
            this.radProjectTeam.AutoSize = true;
            this.radProjectTeam.Checked = true;
            this.radProjectTeam.Location = new System.Drawing.Point(15, 35);
            this.radProjectTeam.Name = "radProjectTeam";
            this.radProjectTeam.Size = new System.Drawing.Size(66, 17);
            this.radProjectTeam.TabIndex = 0;
            this.radProjectTeam.TabStop = true;
            this.radProjectTeam.Text = "Projektni";
            this.radProjectTeam.UseVisualStyleBackColor = true;
            // 
            // lbxCommitteeMembers
            // 
            this.lbxCommitteeMembers.AllowDrop = true;
            this.lbxCommitteeMembers.FormattingEnabled = true;
            this.lbxCommitteeMembers.Location = new System.Drawing.Point(298, 136);
            this.lbxCommitteeMembers.Name = "lbxCommitteeMembers";
            this.lbxCommitteeMembers.Size = new System.Drawing.Size(193, 212);
            this.lbxCommitteeMembers.TabIndex = 11;
            this.lbxCommitteeMembers.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbxCommitteeMembers_DragDrop);
            this.lbxCommitteeMembers.DragOver += new System.Windows.Forms.DragEventHandler(this.lbxCommitteeMembers_DragOver);
            this.lbxCommitteeMembers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbxCommitteeMembers_MouseDown);
            // 
            // lbxTeamMembers
            // 
            this.lbxTeamMembers.AllowDrop = true;
            this.lbxTeamMembers.FormattingEnabled = true;
            this.lbxTeamMembers.Location = new System.Drawing.Point(510, 136);
            this.lbxTeamMembers.Name = "lbxTeamMembers";
            this.lbxTeamMembers.Size = new System.Drawing.Size(193, 212);
            this.lbxTeamMembers.TabIndex = 12;
            this.lbxTeamMembers.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbxTeamMembers_DragDrop);
            this.lbxTeamMembers.DragOver += new System.Windows.Forms.DragEventHandler(this.lbxTeamMembers_DragOver);
            this.lbxTeamMembers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbxTeamMembers_MouseDown);
            // 
            // cbxProjects
            // 
            this.cbxProjects.FormattingEnabled = true;
            this.cbxProjects.Location = new System.Drawing.Point(510, 83);
            this.cbxProjects.Name = "cbxProjects";
            this.cbxProjects.Size = new System.Drawing.Size(193, 21);
            this.cbxProjects.TabIndex = 13;
            // 
            // frmAddTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 530);
            this.Controls.Add(this.cbxProjects);
            this.Controls.Add(this.lbxTeamMembers);
            this.Controls.Add(this.lbxCommitteeMembers);
            this.Controls.Add(this.gbxTeamType);
            this.Controls.Add(this.btnDeleteTeam);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "frmAddTeam";
            this.Text = "Dodaj novi tim";
            this.Load += new System.EventHandler(this.frmAddTeam_Load);
            this.gbxTeamType.ResumeLayout(false);
            this.gbxTeamType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeleteTeam;
        private System.Windows.Forms.GroupBox gbxTeamType;
        private System.Windows.Forms.RadioButton radFunctionalTeam;
        private System.Windows.Forms.RadioButton radProjectTeam;
        private System.Windows.Forms.ListBox lbxCommitteeMembers;
        private System.Windows.Forms.ListBox lbxTeamMembers;
        private System.Windows.Forms.ComboBox cbxProjects;
    }
}