namespace AibelDeelineInterface.WinForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbCommentedOn = new System.Windows.Forms.ComboBox();
            this.lblCommentedOn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCommentedBy = new System.Windows.Forms.Label();
            this.txtCommentBody = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tvDetails = new System.Windows.Forms.TreeView();
            this.aibelDeelineDbDataSet = new AibelDeelineInterface.WinForm.AibelDeelineDbDataSet();
            this.communicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.communicationsTableAdapter = new AibelDeelineInterface.WinForm.AibelDeelineDbDataSetTableAdapters.CommunicationsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purposeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discriminatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holdIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsibleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aibelDeelineDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.communicationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCommentBody);
            this.groupBox1.Controls.Add(this.lblCommentedBy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCommentedOn);
            this.groupBox1.Controls.Add(this.cmbCommentedOn);
            this.groupBox1.Location = new System.Drawing.Point(12, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comments";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.originLocationDataGridViewTextBoxColumn,
            this.createdOnDataGridViewTextBoxColumn,
            this.targetLocationDataGridViewTextBoxColumn,
            this.purposeDataGridViewTextBoxColumn,
            this.priorityLevelDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.moduleDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.discriminatorDataGridViewTextBoxColumn,
            this.commentsIdDataGridViewTextBoxColumn,
            this.createdByIdDataGridViewTextBoxColumn,
            this.holdIdDataGridViewTextBoxColumn,
            this.responsibleIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.communicationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1087, 260);
            this.dataGridView1.TabIndex = 1;
            // 
            // cmbCommentedOn
            // 
            this.cmbCommentedOn.FormatString = "g";
            this.cmbCommentedOn.FormattingEnabled = true;
            this.cmbCommentedOn.Location = new System.Drawing.Point(92, 19);
            this.cmbCommentedOn.Name = "cmbCommentedOn";
            this.cmbCommentedOn.Size = new System.Drawing.Size(226, 21);
            this.cmbCommentedOn.TabIndex = 0;
            // 
            // lblCommentedOn
            // 
            this.lblCommentedOn.AutoSize = true;
            this.lblCommentedOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentedOn.Location = new System.Drawing.Point(6, 22);
            this.lblCommentedOn.Name = "lblCommentedOn";
            this.lblCommentedOn.Size = new System.Drawing.Size(80, 13);
            this.lblCommentedOn.TabIndex = 1;
            this.lblCommentedOn.Text = "Commented On";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "By:";
            // 
            // lblCommentedBy
            // 
            this.lblCommentedBy.AutoSize = true;
            this.lblCommentedBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCommentedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentedBy.Location = new System.Drawing.Point(46, 54);
            this.lblCommentedBy.Name = "lblCommentedBy";
            this.lblCommentedBy.Size = new System.Drawing.Size(108, 13);
            this.lblCommentedBy.TabIndex = 3;
            this.lblCommentedBy.Text = "Faramarz Bodaghi";
            // 
            // txtCommentBody
            // 
            this.txtCommentBody.Location = new System.Drawing.Point(9, 80);
            this.txtCommentBody.Multiline = true;
            this.txtCommentBody.Name = "txtCommentBody";
            this.txtCommentBody.Size = new System.Drawing.Size(309, 147);
            this.txtCommentBody.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tvDetails);
            this.groupBox2.Location = new System.Drawing.Point(378, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 242);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // tvDetails
            // 
            this.tvDetails.Location = new System.Drawing.Point(6, 19);
            this.tvDetails.Name = "tvDetails";
            this.tvDetails.Size = new System.Drawing.Size(282, 208);
            this.tvDetails.TabIndex = 0;
            // 
            // aibelDeelineDbDataSet
            // 
            this.aibelDeelineDbDataSet.DataSetName = "AibelDeelineDbDataSet";
            this.aibelDeelineDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // communicationsBindingSource
            // 
            this.communicationsBindingSource.DataMember = "Communications";
            this.communicationsBindingSource.DataSource = this.aibelDeelineDbDataSet;
            // 
            // communicationsTableAdapter
            // 
            this.communicationsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // originLocationDataGridViewTextBoxColumn
            // 
            this.originLocationDataGridViewTextBoxColumn.DataPropertyName = "OriginLocation";
            this.originLocationDataGridViewTextBoxColumn.HeaderText = "OriginLocation";
            this.originLocationDataGridViewTextBoxColumn.Name = "originLocationDataGridViewTextBoxColumn";
            this.originLocationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdOnDataGridViewTextBoxColumn
            // 
            this.createdOnDataGridViewTextBoxColumn.DataPropertyName = "CreatedOn";
            this.createdOnDataGridViewTextBoxColumn.HeaderText = "CreatedOn";
            this.createdOnDataGridViewTextBoxColumn.Name = "createdOnDataGridViewTextBoxColumn";
            this.createdOnDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdOnDataGridViewTextBoxColumn.Width = 83;
            // 
            // targetLocationDataGridViewTextBoxColumn
            // 
            this.targetLocationDataGridViewTextBoxColumn.DataPropertyName = "TargetLocation";
            this.targetLocationDataGridViewTextBoxColumn.HeaderText = "TargetLocation";
            this.targetLocationDataGridViewTextBoxColumn.Name = "targetLocationDataGridViewTextBoxColumn";
            this.targetLocationDataGridViewTextBoxColumn.ReadOnly = true;
            this.targetLocationDataGridViewTextBoxColumn.Width = 104;
            // 
            // purposeDataGridViewTextBoxColumn
            // 
            this.purposeDataGridViewTextBoxColumn.DataPropertyName = "Purpose";
            this.purposeDataGridViewTextBoxColumn.HeaderText = "Purpose";
            this.purposeDataGridViewTextBoxColumn.Name = "purposeDataGridViewTextBoxColumn";
            this.purposeDataGridViewTextBoxColumn.ReadOnly = true;
            this.purposeDataGridViewTextBoxColumn.Width = 71;
            // 
            // priorityLevelDataGridViewTextBoxColumn
            // 
            this.priorityLevelDataGridViewTextBoxColumn.DataPropertyName = "PriorityLevel";
            this.priorityLevelDataGridViewTextBoxColumn.HeaderText = "PriorityLevel";
            this.priorityLevelDataGridViewTextBoxColumn.Name = "priorityLevelDataGridViewTextBoxColumn";
            this.priorityLevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.priorityLevelDataGridViewTextBoxColumn.Width = 89;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 62;
            // 
            // moduleDataGridViewTextBoxColumn
            // 
            this.moduleDataGridViewTextBoxColumn.DataPropertyName = "Module";
            this.moduleDataGridViewTextBoxColumn.HeaderText = "Module";
            this.moduleDataGridViewTextBoxColumn.Name = "moduleDataGridViewTextBoxColumn";
            this.moduleDataGridViewTextBoxColumn.ReadOnly = true;
            this.moduleDataGridViewTextBoxColumn.Width = 67;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.ReadOnly = true;
            this.areaDataGridViewTextBoxColumn.Width = 54;
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "Section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            this.sectionDataGridViewTextBoxColumn.ReadOnly = true;
            this.sectionDataGridViewTextBoxColumn.Width = 68;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Reason";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.reasonDataGridViewTextBoxColumn.Width = 69;
            // 
            // discriminatorDataGridViewTextBoxColumn
            // 
            this.discriminatorDataGridViewTextBoxColumn.DataPropertyName = "Discriminator";
            this.discriminatorDataGridViewTextBoxColumn.HeaderText = "Discriminator";
            this.discriminatorDataGridViewTextBoxColumn.Name = "discriminatorDataGridViewTextBoxColumn";
            this.discriminatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.discriminatorDataGridViewTextBoxColumn.Width = 92;
            // 
            // commentsIdDataGridViewTextBoxColumn
            // 
            this.commentsIdDataGridViewTextBoxColumn.DataPropertyName = "Comments_Id";
            this.commentsIdDataGridViewTextBoxColumn.HeaderText = "Comments_Id";
            this.commentsIdDataGridViewTextBoxColumn.Name = "commentsIdDataGridViewTextBoxColumn";
            this.commentsIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentsIdDataGridViewTextBoxColumn.Width = 96;
            // 
            // createdByIdDataGridViewTextBoxColumn
            // 
            this.createdByIdDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy_Id";
            this.createdByIdDataGridViewTextBoxColumn.HeaderText = "CreatedBy_Id";
            this.createdByIdDataGridViewTextBoxColumn.Name = "createdByIdDataGridViewTextBoxColumn";
            this.createdByIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdByIdDataGridViewTextBoxColumn.Width = 96;
            // 
            // holdIdDataGridViewTextBoxColumn
            // 
            this.holdIdDataGridViewTextBoxColumn.DataPropertyName = "Hold_Id";
            this.holdIdDataGridViewTextBoxColumn.HeaderText = "Hold_Id";
            this.holdIdDataGridViewTextBoxColumn.Name = "holdIdDataGridViewTextBoxColumn";
            this.holdIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.holdIdDataGridViewTextBoxColumn.Width = 69;
            // 
            // responsibleIdDataGridViewTextBoxColumn
            // 
            this.responsibleIdDataGridViewTextBoxColumn.DataPropertyName = "Responsible_Id";
            this.responsibleIdDataGridViewTextBoxColumn.HeaderText = "Responsible_Id";
            this.responsibleIdDataGridViewTextBoxColumn.Name = "responsibleIdDataGridViewTextBoxColumn";
            this.responsibleIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.responsibleIdDataGridViewTextBoxColumn.Width = 105;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(937, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "New Release";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(937, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Model update request";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(937, 437);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Revision request";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 611);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Aibel - Deeline Communication portal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aibelDeelineDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.communicationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCommentBody;
        private System.Windows.Forms.Label lblCommentedBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCommentedOn;
        private System.Windows.Forms.ComboBox cmbCommentedOn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView tvDetails;
        private AibelDeelineDbDataSet aibelDeelineDbDataSet;
        private System.Windows.Forms.BindingSource communicationsBindingSource;
        private AibelDeelineDbDataSetTableAdapters.CommunicationsTableAdapter communicationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purposeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discriminatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn holdIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsibleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

