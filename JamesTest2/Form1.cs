using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;


namespace JamesTest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedManufacturer = ManufacturerComboBox.Text;
            SearchForRecords(selectedManufacturer);
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'red_Shed_InventoryDataSet1.VendorReferenceLookup' table. You can move, or remove it, as needed.
            this.vendorReferenceLookupTableAdapter.Fill(this.red_Shed_InventoryDataSet1.VendorReferenceLookup);
            // TODO: This line of code loads data into the 'red_Shed_InventoryDataSet.Sheet1' table. You can move, or remove it, as needed.
            this.sheet1TableAdapter.Fill(this.red_Shed_InventoryDataSet.Sheet1);

        }

        private void dataGridView1_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void sheet1BindingSource_CurrentChanged(object sender, System.EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selectedManufacturer = (ManufacturerComboBox.Text);
            SearchForRecords(selectedManufacturer);
        }

        private void SearchForRecords(string value)
        {
           

            DataSet dataset = new DataSet();

            string selectCommand = "select * from Sheet1 where Manufacturer = ('" + value + "') OR SKU = ('" + value + "')";

            using (OleDbConnection connection =
            new OleDbConnection(Properties.Settings.Default.Red_Shed_InventoryConnectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(selectCommand, connection);
                adapter.Fill(dataset, "Sheet1");
            }

            // Get the table from the data set and bind the data to the grid
            //   this.dataGridView1 = new System.Windows.Forms.DataGridView();

            dataGridView1.DataSource = dataset.Tables[0];

            //copy the dataset in datatable object 
            //    DataTable dataTable = dataSet11.Tables[0];

            //if the row count = 0 then the qurey return nothing
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Record Not Found");
        }

        }
    }

