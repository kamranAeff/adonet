namespace WindowsFormsAppAdoNet
{
    partial class Form1
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
            this.dgvSizes = new System.Windows.Forms.DataGridView();
            this.dataSetShop = new WindowsFormsAppAdoNet.DataSetShop();
            this.sizesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sizesTableAdapter = new WindowsFormsAppAdoNet.DataSetShopTableAdapters.SizesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smallNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastModifiedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastModifiedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSizes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSizes
            // 
            this.dgvSizes.AutoGenerateColumns = false;
            this.dgvSizes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSizes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.smallNameDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.createdByDataGridViewTextBoxColumn,
            this.lastModifiedAtDataGridViewTextBoxColumn,
            this.lastModifiedByDataGridViewTextBoxColumn,
            this.deletedAtDataGridViewTextBoxColumn,
            this.deletedByDataGridViewTextBoxColumn});
            this.dgvSizes.DataSource = this.sizesBindingSource;
            this.dgvSizes.Location = new System.Drawing.Point(12, 156);
            this.dgvSizes.Name = "dgvSizes";
            this.dgvSizes.RowHeadersWidth = 51;
            this.dgvSizes.RowTemplate.Height = 24;
            this.dgvSizes.Size = new System.Drawing.Size(1005, 357);
            this.dgvSizes.TabIndex = 0;
            // 
            // dataSetShop
            // 
            this.dataSetShop.DataSetName = "DataSetShop";
            this.dataSetShop.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sizesBindingSource
            // 
            this.sizesBindingSource.DataMember = "Sizes";
            this.sizesBindingSource.DataSource = this.dataSetShop;
            // 
            // sizesTableAdapter
            // 
            this.sizesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // smallNameDataGridViewTextBoxColumn
            // 
            this.smallNameDataGridViewTextBoxColumn.DataPropertyName = "SmallName";
            this.smallNameDataGridViewTextBoxColumn.HeaderText = "SmallName";
            this.smallNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.smallNameDataGridViewTextBoxColumn.Name = "smallNameDataGridViewTextBoxColumn";
            this.smallNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.Width = 125;
            // 
            // createdByDataGridViewTextBoxColumn
            // 
            this.createdByDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy";
            this.createdByDataGridViewTextBoxColumn.HeaderText = "CreatedBy";
            this.createdByDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
            this.createdByDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastModifiedAtDataGridViewTextBoxColumn
            // 
            this.lastModifiedAtDataGridViewTextBoxColumn.DataPropertyName = "LastModifiedAt";
            this.lastModifiedAtDataGridViewTextBoxColumn.HeaderText = "LastModifiedAt";
            this.lastModifiedAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastModifiedAtDataGridViewTextBoxColumn.Name = "lastModifiedAtDataGridViewTextBoxColumn";
            this.lastModifiedAtDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastModifiedByDataGridViewTextBoxColumn
            // 
            this.lastModifiedByDataGridViewTextBoxColumn.DataPropertyName = "LastModifiedBy";
            this.lastModifiedByDataGridViewTextBoxColumn.HeaderText = "LastModifiedBy";
            this.lastModifiedByDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastModifiedByDataGridViewTextBoxColumn.Name = "lastModifiedByDataGridViewTextBoxColumn";
            this.lastModifiedByDataGridViewTextBoxColumn.Width = 125;
            // 
            // deletedAtDataGridViewTextBoxColumn
            // 
            this.deletedAtDataGridViewTextBoxColumn.DataPropertyName = "DeletedAt";
            this.deletedAtDataGridViewTextBoxColumn.HeaderText = "DeletedAt";
            this.deletedAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deletedAtDataGridViewTextBoxColumn.Name = "deletedAtDataGridViewTextBoxColumn";
            this.deletedAtDataGridViewTextBoxColumn.Width = 125;
            // 
            // deletedByDataGridViewTextBoxColumn
            // 
            this.deletedByDataGridViewTextBoxColumn.DataPropertyName = "DeletedBy";
            this.deletedByDataGridViewTextBoxColumn.HeaderText = "DeletedBy";
            this.deletedByDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deletedByDataGridViewTextBoxColumn.Name = "deletedByDataGridViewTextBoxColumn";
            this.deletedByDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 525);
            this.Controls.Add(this.dgvSizes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSizes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSizes;
        private DataSetShop dataSetShop;
        private System.Windows.Forms.BindingSource sizesBindingSource;
        private DataSetShopTableAdapters.SizesTableAdapter sizesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smallNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastModifiedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastModifiedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedByDataGridViewTextBoxColumn;
    }
}

