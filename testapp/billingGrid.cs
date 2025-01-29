using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using DevExpress.XtraGrid; // Ensure you have DevExpress for grid control
using DevExpress.XtraGrid.Views.Grid;

namespace testapp
{
    public partial class billingGrid : Form
    {
        public event Action<int> OnBillingRecordSelected; // Event to communicate with the main form

        public billingGrid()
        {
            InitializeComponent();
            LoadBillingRecords(); // Load billing records when form is created
        }

        private void LoadBillingRecords()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PointOfSalesDBConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT TB04_BillNumber AS BillingNumber, TB04_SaleDate AS Date FROM TB04_sales_invoice_Master";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                gridControl1.DataSource = dataTable; // Bind the result to the grid
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = gridControl1.MainView as GridView;

            // Capture the selected row's BillingNumber
            if (view.GetFocusedRowCellValue("BillingNumber") is int billingNumber)
            {
                OnBillingRecordSelected?.Invoke(billingNumber); // Raise the event with the selected BillingNumber
                this.Close(); // Close the form after selection
            }
            else
            {
                MessageBox.Show("Please select a valid Billing Number."); // Show message if no valid billing number is selected
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }

}
