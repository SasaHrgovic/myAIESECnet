namespace Presentation.CommitteeViews
{
    partial class ucCommittees
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnUpdateCommittee = new System.Windows.Forms.Button();
            this.btnAddCommittee = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvCommittees = new System.Windows.Forms.DataGridView();
            this.committeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommittees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.committeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateCommittee
            // 
            this.btnUpdateCommittee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateCommittee.Location = new System.Drawing.Point(805, 257);
            this.btnUpdateCommittee.Name = "btnUpdateCommittee";
            this.btnUpdateCommittee.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCommittee.TabIndex = 9;
            this.btnUpdateCommittee.Text = "Ažuriraj";
            this.btnUpdateCommittee.UseVisualStyleBackColor = true;
            // 
            // btnAddCommittee
            // 
            this.btnAddCommittee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCommittee.Location = new System.Drawing.Point(886, 257);
            this.btnAddCommittee.Name = "btnAddCommittee";
            this.btnAddCommittee.Size = new System.Drawing.Size(75, 23);
            this.btnAddCommittee.TabIndex = 8;
            this.btnAddCommittee.Text = "Dodaj";
            this.btnAddCommittee.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(11, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(128, 24);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Lokalni odbori";
            // 
            // dgvCommittees
            // 
            this.dgvCommittees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCommittees.AutoGenerateColumns = false;
            this.dgvCommittees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCommittees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvCommittees.BackgroundColor = System.Drawing.Color.White;
            this.dgvCommittees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommittees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.usersDataGridViewTextBoxColumn,
            this.teamsDataGridViewTextBoxColumn});
            this.dgvCommittees.DataSource = this.committeeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCommittees.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCommittees.Location = new System.Drawing.Point(15, 43);
            this.dgvCommittees.MultiSelect = false;
            this.dgvCommittees.Name = "dgvCommittees";
            this.dgvCommittees.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCommittees.Size = new System.Drawing.Size(946, 200);
            this.dgvCommittees.TabIndex = 6;
            // 
            // committeeBindingSource
            // 
            this.committeeBindingSource.DataSource = typeof(Data.Committee);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // usersDataGridViewTextBoxColumn
            // 
            this.usersDataGridViewTextBoxColumn.DataPropertyName = "Users";
            this.usersDataGridViewTextBoxColumn.HeaderText = "Users";
            this.usersDataGridViewTextBoxColumn.Name = "usersDataGridViewTextBoxColumn";
            this.usersDataGridViewTextBoxColumn.Visible = false;
            // 
            // teamsDataGridViewTextBoxColumn
            // 
            this.teamsDataGridViewTextBoxColumn.DataPropertyName = "Teams";
            this.teamsDataGridViewTextBoxColumn.HeaderText = "Teams";
            this.teamsDataGridViewTextBoxColumn.Name = "teamsDataGridViewTextBoxColumn";
            this.teamsDataGridViewTextBoxColumn.Visible = false;
            // 
            // ucCommittees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdateCommittee);
            this.Controls.Add(this.btnAddCommittee);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvCommittees);
            this.Name = "ucCommittees";
            this.Size = new System.Drawing.Size(986, 364);
            this.Load += new System.EventHandler(this.ucCommittees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommittees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.committeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateCommittee;
        private System.Windows.Forms.Button btnAddCommittee;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvCommittees;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource committeeBindingSource;
    }
}
