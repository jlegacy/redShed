namespace RedShed
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.red_Shed_InventoryDataSet = new RedShed.Red_Shed_InventoryDataSet();
            this.sheet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sheet1TableAdapter = new RedShed.Red_Shed_InventoryDataSetTableAdapters.Sheet1TableAdapter();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ManufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.vendorReferenceLookupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.red_Shed_InventoryDataSet1 = new RedShed.Red_Shed_InventoryDataSet1();
            this.vendorReferenceLookupTableAdapter = new RedShed.Red_Shed_InventoryDataSet1TableAdapters.VendorReferenceLookupTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_Shed_InventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorReferenceLookupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_Shed_InventoryDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(47, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(47, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1100, 500);
            this.dataGridView1.TabIndex = 1;
            // 
            // red_Shed_InventoryDataSet
            // 
            this.red_Shed_InventoryDataSet.DataSetName = "Red_Shed_InventoryDataSet";
            this.red_Shed_InventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sheet1BindingSource
            // 
            this.sheet1BindingSource.DataMember = "Sheet1";
            this.sheet1BindingSource.DataSource = this.red_Shed_InventoryDataSet;
            // 
            // sheet1TableAdapter
            // 
            this.sheet1TableAdapter.ClearBeforeFill = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Red;
            this.richTextBox1.Location = new System.Drawing.Point(47, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(408, 96);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "RED SHED";
            this.richTextBox1.ZoomFactor = 6F;
            // 
            // ManufacturerComboBox
            // 
            this.ManufacturerComboBox.DataSource = this.vendorReferenceLookupBindingSource;
            this.ManufacturerComboBox.DisplayMember = "Manufacturer";
            this.ManufacturerComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ManufacturerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.ManufacturerComboBox.FormattingEnabled = true;
            this.ManufacturerComboBox.Location = new System.Drawing.Point(165, 104);
            this.ManufacturerComboBox.Name = "ManufacturerComboBox";
            this.ManufacturerComboBox.Size = new System.Drawing.Size(460, 33);
            this.ManufacturerComboBox.TabIndex = 4;
            this.ManufacturerComboBox.ValueMember = "Manufacturer";
            this.ManufacturerComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // vendorReferenceLookupBindingSource
            // 
            this.vendorReferenceLookupBindingSource.DataMember = "VendorReferenceLookup";
            this.vendorReferenceLookupBindingSource.DataSource = this.red_Shed_InventoryDataSet1;
            this.vendorReferenceLookupBindingSource.CurrentChanged += new System.EventHandler(this.vendorReferenceLookupBindingSource_CurrentChanged);
            // 
            // red_Shed_InventoryDataSet1
            // 
            this.red_Shed_InventoryDataSet1.DataSetName = "Red_Shed_InventoryDataSet1";
            this.red_Shed_InventoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorReferenceLookupTableAdapter
            // 
            this.vendorReferenceLookupTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.ManufacturerComboBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_Shed_InventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorReferenceLookupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_Shed_InventoryDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Red_Shed_InventoryDataSet red_Shed_InventoryDataSet;
        private System.Windows.Forms.BindingSource sheet1BindingSource;
        private Red_Shed_InventoryDataSetTableAdapters.Sheet1TableAdapter sheet1TableAdapter;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox ManufacturerComboBox;
        private Red_Shed_InventoryDataSet1 red_Shed_InventoryDataSet1;
        private System.Windows.Forms.BindingSource vendorReferenceLookupBindingSource;
        private Red_Shed_InventoryDataSet1TableAdapters.VendorReferenceLookupTableAdapter vendorReferenceLookupTableAdapter;
    }
}

