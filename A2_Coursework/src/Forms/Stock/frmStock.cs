using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using A2_Coursework.ApplicationManagement;
using A2_Coursework.Data;

namespace A2_Coursework.Forms
{
    public partial class frmStock : Form
    {
        //default selected id is -1 i.e. an impossible record
        private int m_SelectedStockId = -1;
        private int m_SearchTime = 0;
        private List<Supplier> m_StoredSuppliers;

        public void LoadStock()
        {
            searchLimterTimer.Start();
            //load all stock initally
            dataGridStock.DataSource = Raw_Stock.RetrieveAll();
        }

        public frmStock()
        {
            InitializeComponent();
            this.CenterToScreen();          

            //populate supplier dropdowns
            m_StoredSuppliers = Supplier.RetrieveAll();
            
            if(m_StoredSuppliers.Count > 0)
            {
                comboUSupplier.Items.AddRange(m_StoredSuppliers.ToArray());
                comboSupplier.Items.AddRange(m_StoredSuppliers.ToArray());
                comboSupplier.SelectedIndex = 0;
            }

            //UI
            comboStockCategory.SelectedItem = comboStockCategory.Items[0];
            comboSupplier.SelectedItem = comboSupplier.Items[0];

            //load stock initally
            LoadStock();

        }

        private void dataGridStock_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridStock.RowCount > 0)
            {
                try
                {
                    //keeps track of what row is selected for editing their record
                    m_SelectedStockId = Convert.ToInt32(dataGridStock.CurrentRow.Cells[0].Value);
                    Raw_Stock selectedStock = Raw_Stock.RetrieveById(m_SelectedStockId);

                    txtUStockName.Text = selectedStock.Name;
                    comboUStockCategory.SelectedItem = selectedStock.Category;
                    numUStockQty.Value = selectedStock.Quantity;
                    numUReorderLevel.Value = selectedStock.ReorderLevel;
                    txtUPrice.Text = selectedStock.Price.ToString();

                    for (int i = 0; i < comboUSupplier.Items.Count; i++)
                    {
                        if(((Supplier)comboUSupplier.Items[i]).ID == selectedStock.Supplier.ID)
                        {
                            comboUSupplier.SelectedIndex = i;
                            break;
                        }
                    }

                }
                catch
                {
                    //should never happen
                    Console.WriteLine("ERROR: Cannot convert current row[0] to int32");
                }
            }
        }

        private void txtStockSearch_TextChanged(object sender, EventArgs e)
        {
            //retrieve stock based on a SQL search
            //a timer is used here to ensure SQL queries are limited to 1/sec
            if (m_SearchTime % 2 == 0)
                dataGridStock.DataSource = Raw_Stock.Search(txtStockSearch.Text);
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (Raw_Stock.Add(new Raw_Stock(txtStockName.Text, comboStockCategory.Text, (int)numStockQty.Value,
                    (int)numReorderLevel.Value, Convert.ToDecimal(txtPrice.Text), ((Supplier)comboSupplier.SelectedItem))))
                {
                    MessageBox.Show("Stock Item Added!", "Success:", MessageBoxButtons.OK);
                    LoadStock();
                    return;
                }
                
            }
            catch 
            {
                MessageBox.Show("Failed to Add Stock, Check your input!", "ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            if (Raw_Stock.Update(new Raw_Stock(m_SelectedStockId, txtUStockName.Text, comboUStockCategory.Text, (int)numUStockQty.Value,
            (int)numUReorderLevel.Value, Convert.ToDecimal(txtUPrice.Text), ((Supplier)comboUSupplier.SelectedItem))))
            {
                MessageBox.Show("Stock Item Updated!", "Success:", MessageBoxButtons.OK);
                LoadStock();
                return;
            }
            
                
            MessageBox.Show("Failed to Update Stock, Check your input!", "ERROR:", MessageBoxButtons.OK);
        }
    }
}
