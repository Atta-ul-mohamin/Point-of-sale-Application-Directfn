using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using DevExpress.XtraGrid.Views.Base;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DevExpress.XtraGrid.Views.Base;


namespace testapp
{
    public partial class Test : Form
    {
        private int loginCashierId;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["PointOfSalesDBConnection"].ConnectionString;

        public Test(int loginCashierId)
        {
            LoadGridData();
            this.loginCashierId = loginCashierId;
            InitializeComponent();
            GenerateBillNumber();
            LoadCurrentDate();
            LoadCashierId();
            InitializePaymentMethodDropdown();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void GenerateBillNumber()
        {
            // Generate a new bill number (example logic here; modify as needed)
            int newBillNumber = new Random().Next(1000, 9999); // Replace with actual generation logic
            textEditBillNo.Text = newBillNumber.ToString();
        }

        private void LoadCurrentDate()
        {
            textEditDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void LoadCashierId()
        {
            textEditCashierId.Text = loginCashierId.ToString();
        }

        private void InitializePaymentMethodDropdown()
        {
            cboPaymentMethod.SelectedIndex = 0; // Default to "Cash"
        }

        private void textEditDate_EditValueChanged(object sender, EventArgs e)
        {

        }




        private void gridViewBilling_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "UPCCode" || e.Column.FieldName == "ItemName")
            {
                // Fetch item details based on UPC code and populate fields
                string upcCode = gridViewBilling.GetRowCellValue(e.RowHandle, "UPCCode")?.ToString();
                LoadItemDetails(upcCode, e.RowHandle);
            }
            else if (e.Column.FieldName == "Quantity")
            {
                // Update totals when quantity changes
                UpdateRowTotals(e.RowHandle);
            }
        }

        private void LoadItemDetails(string upcCode, int rowHandle)
        {
            // Query the database for item details
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("GetItems", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Type", 0);  // Assuming Type 0 fetches all items
                    command.Parameters.AddWithValue("@ItemID", DBNull.Value);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            decimal salePrice = reader.GetDecimal(reader.GetOrdinal("TB01_SalePrice"));
                            decimal gst = 5; // Assuming 5% GST for calculation purposes
                            decimal discount = 10; // Assuming 10% discount for demonstration

                            gridViewBilling.SetRowCellValue(rowHandle, "SalePrice", salePrice);
                            gridViewBilling.SetRowCellValue(rowHandle, "GST", gst);
                            gridViewBilling.SetRowCellValue(rowHandle, "Discount", discount);

                            // Calculate totals after setting initial values
                            UpdateRowTotals(rowHandle);
                        }
                    }
                }
            }
        }

        private void UpdateRowTotals(int rowHandle)
        {
            // Retrieve values from grid to calculate totals
            var quantity = Convert.ToDecimal(gridViewBilling.GetRowCellValue(rowHandle, "Quantity") ?? 1);
            var salePrice = Convert.ToDecimal(gridViewBilling.GetRowCellValue(rowHandle, "SalePrice") ?? 0);
            var gst = Convert.ToDecimal(gridViewBilling.GetRowCellValue(rowHandle, "GST") ?? 0);
            var discount = Convert.ToDecimal(gridViewBilling.GetRowCellValue(rowHandle, "Discount") ?? 0);

            // Calculate subtotal, GST, discount, and total
            var subtotal = quantity * salePrice;
            var totalGst = (gst / 100) * subtotal;
            var totalDiscount = (discount / 100) * subtotal;
            var total = subtotal + totalGst - totalDiscount;

            // Set calculated values in grid
            gridViewBilling.SetRowCellValue(rowHandle, "Subtotal", subtotal);
            gridViewBilling.SetRowCellValue(rowHandle, "Total", total);
        }
        private void LoadGridData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PointOfSalesDBConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("GetItems", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Type", 0); // Set to 0 to retrieve all items

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                gridControlBilling.DataSource = dataTable; // Use gridControlBilling instead of gridControl1
            }
        }



    }
}
