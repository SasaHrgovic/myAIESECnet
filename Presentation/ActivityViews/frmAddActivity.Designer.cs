namespace Presentation.ActivityViews
{
    partial class frmAddActivity
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDeadlineDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDeadlineTime = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsers = new System.Windows.Forms.TextBox();
            this.chkStart = new System.Windows.Forms.CheckBox();
            this.lbxUsers = new System.Windows.Forms.ListBox();
            this.cboTeam = new System.Windows.Forms.ComboBox();
            this.cboProject = new System.Windows.Forms.ComboBox();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Aktivnost";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(384, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(16, 79);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(384, 55);
            this.txtDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(13, 62);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(28, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Opis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rok izvršavanja";
            // 
            // dtpDeadlineDate
            // 
            this.dtpDeadlineDate.CustomFormat = "dd.MM.yyyy";
            this.dtpDeadlineDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeadlineDate.Location = new System.Drawing.Point(16, 225);
            this.dtpDeadlineDate.Name = "dtpDeadlineDate";
            this.dtpDeadlineDate.Size = new System.Drawing.Size(260, 20);
            this.dtpDeadlineDate.TabIndex = 6;
            // 
            // dtpDeadlineTime
            // 
            this.dtpDeadlineTime.CustomFormat = "HH:mm";
            this.dtpDeadlineTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeadlineTime.Location = new System.Drawing.Point(282, 225);
            this.dtpDeadlineTime.Name = "dtpDeadlineTime";
            this.dtpDeadlineTime.ShowUpDown = true;
            this.dtpDeadlineTime.Size = new System.Drawing.Size(118, 20);
            this.dtpDeadlineTime.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(325, 455);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(235, 455);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRemove.Location = new System.Drawing.Point(12, 455);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Izbriši";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Izvršitelji";
            // 
            // txtUsers
            // 
            this.txtUsers.Location = new System.Drawing.Point(16, 278);
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.Size = new System.Drawing.Size(384, 20);
            this.txtUsers.TabIndex = 12;
            this.txtUsers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsers_KeyDown);
            // 
            // chkStart
            // 
            this.chkStart.AutoSize = true;
            this.chkStart.Location = new System.Drawing.Point(16, 415);
            this.chkStart.Name = "chkStart";
            this.chkStart.Size = new System.Drawing.Size(100, 17);
            this.chkStart.TabIndex = 13;
            this.chkStart.Text = "Odmah započni";
            this.chkStart.UseVisualStyleBackColor = true;
            // 
            // lbxUsers
            // 
            this.lbxUsers.FormattingEnabled = true;
            this.lbxUsers.Location = new System.Drawing.Point(16, 304);
            this.lbxUsers.Name = "lbxUsers";
            this.lbxUsers.Size = new System.Drawing.Size(384, 95);
            this.lbxUsers.TabIndex = 14;
            // 
            // cboTeam
            // 
            this.cboTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeam.FormattingEnabled = true;
            this.cboTeam.Location = new System.Drawing.Point(16, 173);
            this.cboTeam.Name = "cboTeam";
            this.cboTeam.Size = new System.Drawing.Size(195, 21);
            this.cboTeam.TabIndex = 15;
            // 
            // cboProject
            // 
            this.cboProject.FormattingEnabled = true;
            this.cboProject.Location = new System.Drawing.Point(217, 173);
            this.cboProject.Name = "cboProject";
            this.cboProject.Size = new System.Drawing.Size(186, 21);
            this.cboProject.TabIndex = 16;
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(13, 157);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(24, 13);
            this.lblTeam.TabIndex = 17;
            this.lblTeam.Text = "Tim";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(214, 157);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(40, 13);
            this.lblProject.TabIndex = 18;
            this.lblProject.Text = "Projekt";
            // 
            // frmAddActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(413, 505);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.cboProject);
            this.Controls.Add(this.cboTeam);
            this.Controls.Add(this.lbxUsers);
            this.Controls.Add(this.chkStart);
            this.Controls.Add(this.txtUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpDeadlineTime);
            this.Controls.Add(this.dtpDeadlineDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "frmAddActivity";
            this.Text = "Aktivnost";
            this.Load += new System.EventHandler(this.frmAddActivity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDeadlineDate;
        private System.Windows.Forms.DateTimePicker dtpDeadlineTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsers;
        private System.Windows.Forms.CheckBox chkStart;
        private System.Windows.Forms.ListBox lbxUsers;
        private System.Windows.Forms.ComboBox cboTeam;
        private System.Windows.Forms.ComboBox cboProject;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblProject;
    }
}