namespace Welcome
{
    partial class Form5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet2 = new Welcome.DataSet2();
            this.sTUDENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTSTableAdapter = new Welcome.DataSet2TableAdapters.STUDENTSTableAdapter();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOLLNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEMYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONENODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAMEDataGridViewTextBoxColumn,
            this.rOLLNODataGridViewTextBoxColumn,
            this.dEPTDataGridViewTextBoxColumn,
            this.sEMYEARDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn,
            this.pHONENODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sTUDENTSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(113, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(979, 428);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTUDENTSBindingSource
            // 
            this.sTUDENTSBindingSource.DataMember = "STUDENTS";
            this.sTUDENTSBindingSource.DataSource = this.dataSet2;
            // 
            // sTUDENTSTableAdapter
            // 
            this.sTUDENTSTableAdapter.ClearBeforeFill = true;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // rOLLNODataGridViewTextBoxColumn
            // 
            this.rOLLNODataGridViewTextBoxColumn.DataPropertyName = "ROLLNO";
            this.rOLLNODataGridViewTextBoxColumn.HeaderText = "ROLLNO";
            this.rOLLNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rOLLNODataGridViewTextBoxColumn.Name = "rOLLNODataGridViewTextBoxColumn";
            this.rOLLNODataGridViewTextBoxColumn.Width = 125;
            // 
            // dEPTDataGridViewTextBoxColumn
            // 
            this.dEPTDataGridViewTextBoxColumn.DataPropertyName = "DEPT";
            this.dEPTDataGridViewTextBoxColumn.HeaderText = "DEPT";
            this.dEPTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dEPTDataGridViewTextBoxColumn.Name = "dEPTDataGridViewTextBoxColumn";
            this.dEPTDataGridViewTextBoxColumn.Width = 125;
            // 
            // sEMYEARDataGridViewTextBoxColumn
            // 
            this.sEMYEARDataGridViewTextBoxColumn.DataPropertyName = "SEM_YEAR";
            this.sEMYEARDataGridViewTextBoxColumn.HeaderText = "SEM_YEAR";
            this.sEMYEARDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sEMYEARDataGridViewTextBoxColumn.Name = "sEMYEARDataGridViewTextBoxColumn";
            this.sEMYEARDataGridViewTextBoxColumn.Width = 125;
            // 
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            this.aDDRESSDataGridViewTextBoxColumn.Width = 125;
            // 
            // pHONENODataGridViewTextBoxColumn
            // 
            this.pHONENODataGridViewTextBoxColumn.DataPropertyName = "PHONENO";
            this.pHONENODataGridViewTextBoxColumn.HeaderText = "PHONENO";
            this.pHONENODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pHONENODataGridViewTextBoxColumn.Name = "pHONENODataGridViewTextBoxColumn";
            this.pHONENODataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(909, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 621);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource sTUDENTSBindingSource;
        private DataSet2TableAdapters.STUDENTSTableAdapter sTUDENTSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOLLNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEMYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONENODataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}