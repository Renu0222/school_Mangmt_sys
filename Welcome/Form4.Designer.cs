namespace Welcome
{
    partial class Form4
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
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.rOLLNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOURSENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Welcome.DataSet1();
            this.cOURSETableAdapter = new Welcome.DataSet1TableAdapters.COURSETableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rOLLNODataGridViewTextBoxColumn,
            this.dEPTDataGridViewTextBoxColumn,
            this.cOURSENAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cOURSEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(59, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(618, 331);
            this.dataGridView1.TabIndex = 0;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(800, 27);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 24);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
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
            // cOURSENAMEDataGridViewTextBoxColumn
            // 
            this.cOURSENAMEDataGridViewTextBoxColumn.DataPropertyName = "COURSE_NAME";
            this.cOURSENAMEDataGridViewTextBoxColumn.HeaderText = "COURSE_NAME";
            this.cOURSENAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cOURSENAMEDataGridViewTextBoxColumn.Name = "cOURSENAMEDataGridViewTextBoxColumn";
            this.cOURSENAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // cOURSEBindingSource
            // 
            this.cOURSEBindingSource.DataMember = "COURSE";
            this.cOURSEBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOURSETableAdapter
            // 
            this.cOURSETableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(637, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 49);
            this.button2.TabIndex = 18;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cOURSEBindingSource;
        private DataSet1TableAdapters.COURSETableAdapter cOURSETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOLLNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOURSENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Button button2;
    }
}