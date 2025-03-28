using ConsoleServiceTool.RepairHub.Persistence.Entities.Parts;

namespace ConsoleServiceTool.RepairHub.Views
{
    partial class PartsView
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
                this.dbContext?.Dispose();
                this.dbContext = null;
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            searchBtn = new Button();
            referenceCb = new ComboBox();
            dgvParts = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            PartTypeName = new DataGridViewTextBoxColumn();
            PartTypeDescription = new DataGridViewTextBoxColumn();
            partDefinitionVMBindingSource = new BindingSource(components);
            dgvAttributes = new DataGridView();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            isRequiredDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            partAttributesBindingSource = new BindingSource(components);
            btnAddAttribute = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partDefinitionVMBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAttributes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partAttributesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 22);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Key enter search value";
            textBox1.Size = new Size(218, 31);
            textBox1.TabIndex = 0;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(565, 24);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(112, 34);
            searchBtn.TabIndex = 1;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // referenceCb
            // 
            referenceCb.FormattingEnabled = true;
            referenceCb.Items.AddRange(new object[] { "Motherboard serial", "Daughterboard serial", "Console serial" });
            referenceCb.Location = new Point(292, 20);
            referenceCb.Name = "referenceCb";
            referenceCb.Size = new Size(182, 33);
            referenceCb.TabIndex = 2;
            // 
            // dgvParts
            // 
            dgvParts.AllowUserToOrderColumns = true;
            dgvParts.AutoGenerateColumns = false;
            dgvParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParts.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, PartTypeName, PartTypeDescription });
            dgvParts.DataSource = partDefinitionVMBindingSource;
            dgvParts.Location = new Point(34, 76);
            dgvParts.Name = "dgvParts";
            dgvParts.RowHeadersWidth = 62;
            dgvParts.Size = new Size(1021, 194);
            dgvParts.TabIndex = 3;
            dgvParts.SelectionChanged += dgvParts_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // PartTypeName
            // 
            PartTypeName.DataPropertyName = "PartTypeName";
            PartTypeName.HeaderText = "PartTypeName";
            PartTypeName.MinimumWidth = 8;
            PartTypeName.Name = "PartTypeName";
            PartTypeName.Width = 150;
            // 
            // PartTypeDescription
            // 
            PartTypeDescription.DataPropertyName = "PartTypeDescription";
            PartTypeDescription.HeaderText = "PartTypeDescription";
            PartTypeDescription.MinimumWidth = 8;
            PartTypeDescription.Name = "PartTypeDescription";
            PartTypeDescription.Width = 150;
            // 
            // partDefinitionVMBindingSource
            // 
            partDefinitionVMBindingSource.DataSource = typeof(Services.PartDefinitionVM);
            // 
            // dgvAttributes
            // 
            dgvAttributes.AllowUserToOrderColumns = true;
            dgvAttributes.AutoGenerateColumns = false;
            dgvAttributes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttributes.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn1, descriptionDataGridViewTextBoxColumn1, isRequiredDataGridViewCheckBoxColumn });
            dgvAttributes.DataSource = partAttributesBindingSource;
            dgvAttributes.Location = new Point(34, 327);
            dgvAttributes.Name = "dgvAttributes";
            dgvAttributes.RowHeadersWidth = 62;
            dgvAttributes.Size = new Size(1021, 259);
            dgvAttributes.TabIndex = 4;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn1.MinimumWidth = 8;
            descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            descriptionDataGridViewTextBoxColumn1.Width = 150;
            // 
            // isRequiredDataGridViewCheckBoxColumn
            // 
            isRequiredDataGridViewCheckBoxColumn.DataPropertyName = "IsRequired";
            isRequiredDataGridViewCheckBoxColumn.HeaderText = "IsRequired";
            isRequiredDataGridViewCheckBoxColumn.MinimumWidth = 8;
            isRequiredDataGridViewCheckBoxColumn.Name = "isRequiredDataGridViewCheckBoxColumn";
            isRequiredDataGridViewCheckBoxColumn.Width = 150;
            // 
            // partAttributesBindingSource
            // 
            partAttributesBindingSource.DataMember = "PartAttributes";
            partAttributesBindingSource.DataSource = partDefinitionVMBindingSource;
            // 
            // btnAddAttribute
            // 
            btnAddAttribute.Location = new Point(1070, 338);
            btnAddAttribute.Name = "btnAddAttribute";
            btnAddAttribute.Size = new Size(168, 34);
            btnAddAttribute.TabIndex = 5;
            btnAddAttribute.Text = "Add attribute";
            btnAddAttribute.UseVisualStyleBackColor = true;
            btnAddAttribute.Click += btnAddAttribute_Click;
            // 
            // PartsView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddAttribute);
            Controls.Add(dgvAttributes);
            Controls.Add(dgvParts);
            Controls.Add(referenceCb);
            Controls.Add(searchBtn);
            Controls.Add(textBox1);
            DoubleBuffered = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "PartsView";
            Size = new Size(1258, 744);
            Load += PartsView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)partDefinitionVMBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAttributes).EndInit();
            ((System.ComponentModel.ISupportInitialize)partAttributesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button searchBtn;
        private ComboBox referenceCb;
        private DataGridView dgvParts;
        private DataGridView dgvAttributes;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn partDefinitionIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn partTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn partDefinitionIdDataGridViewTextBoxColumn;
        private BindingSource partDefinitionVMBindingSource;
        private DataGridViewTextBoxColumn linkIdDataGridViewTextBoxColumn;
        private BindingSource partAttributesBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn PartTypeName;
        private DataGridViewTextBoxColumn PartTypeDescription;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn isRequiredDataGridViewCheckBoxColumn;
        private Button btnAddAttribute;
    }
}
