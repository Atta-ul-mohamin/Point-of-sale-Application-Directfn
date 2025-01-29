using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using POINT_OF_SALE_APPLICATION;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Linq;
using CrystalDecisions.CrystalReports.Engine; //for crystal reports::
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using System.IO;

namespace testapp
{
    public partial class BillingScreen : Form
    {
        private int loginCashierID;
        private string connectionString;
        private string loginusername;

        public BillingScreen(int cashierID , string logedUserName)
        {
            InitializeComponent();

            loginCashierID = cashierID;
            loginusername = logedUserName;
            connectionString = ConfigurationManager.ConnectionStrings["PointOfSalesDBConnection"].ConnectionString;
        }

        private void BillingScreen_Load(object sender, EventArgs e)
        {
            InitializeBillingScreen();
            LoadPaymentMethods();
            gridControl1.DataSource = CreateEmptyDataTable();
            // Populate payment methods from database

        }


        private void InitializeBillingScreen()
        {
            try
            {
                txtBillingNumber.Text = GenerateBillingNumber().ToString();
                txtCurrentDate.Text = GetCurrentDate();
                txtCashierID.Text = loginCashierID.ToString();

                // Initialize read-only fields
                txtSubtotal.Text = "0.00";
                txtTotalAmount.Text = "0.00";
                txtDiscount.Text = "0.00";
                txtReceivedCash.Text = "0.00";
                txtChange.Text = "0.00";

                ConfigureGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing billing screen: " + ex.Message);
            }
        }
        private void ConfigureGrid()
        {
            gridView1.OptionsBehavior.Editable = true;
            gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            gridView1.Columns.Clear();

            // Add ItemID column (hidden, read-only)
            var colItemID = gridView1.Columns.AddVisible("ItemID", "Item ID");
            colItemID.OptionsColumn.AllowEdit = false;
            colItemID.Visible = false;

            var colUPCCode = gridView1.Columns.AddVisible("UPCCode", "UPC Code");
            colUPCCode.OptionsColumn.AllowEdit = true;

            var colItemName = gridView1.Columns.AddVisible("ItemName", "Item Name");
            colItemName.OptionsColumn.AllowEdit = false;

            var colSalePrice = gridView1.Columns.AddVisible("SalePrice", "Sale Price");
            colSalePrice.OptionsColumn.AllowEdit = false;

            var colQuantity = gridView1.Columns.AddVisible("Quantity", "Quantity");
            colQuantity.OptionsColumn.AllowEdit = true;
            var colDiscountPercent = gridView1.Columns.AddVisible("DiscountPercent", "Discount (%)");
            colDiscountPercent.OptionsColumn.AllowEdit = true;

            var colGST = gridView1.Columns.AddVisible("GST", "GST");
            colGST.OptionsColumn.AllowEdit = false;

            var colDiscount = gridView1.Columns.AddVisible("Discount", "Discount");
            colDiscount.OptionsColumn.AllowEdit = false;

            var colSubtotal = gridView1.Columns.AddVisible("Subtotal", "Subtotal");
            colSubtotal.OptionsColumn.AllowEdit = false;

            var colTotal = gridView1.Columns.AddVisible("Total", "Total");
            colTotal.OptionsColumn.AllowEdit = false;

            // Hook into CellValueChanged for dynamic updates
            gridView1.CellValueChanged += GridView1_CellValueChanged;
        }

        private DataTable CreateEmptyDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ItemID", typeof(int));       // Unique identifier for items
            table.Columns.Add("UPCCode", typeof(string));
            table.Columns.Add("ItemName", typeof(string));
            table.Columns.Add("SalePrice", typeof(decimal));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("DiscountPercent", typeof(decimal)); // New column for discount percentage

            table.Columns.Add("GST", typeof(decimal));
            table.Columns.Add("Discount", typeof(decimal));
            table.Columns.Add("Subtotal", typeof(decimal));
            table.Columns.Add("Total", typeof(decimal));

            return table;
        }


        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "UPCCode")
            {
                int rowHandle = e.RowHandle;
                string upcCode = gridView1.GetRowCellValue(rowHandle, "UPCCode")?.ToString();

                if (!string.IsNullOrWhiteSpace(upcCode))
                {
                    PopulateRowWithData(rowHandle, upcCode);
                }
            }
            else if (e.Column.FieldName == "Quantity")
            {
                int rowHandle = e.RowHandle;
                RecalculateRow(rowHandle);
            }
            else if (e.Column.FieldName == "DiscountPercent")
            {
                int rowHandle = e.RowHandle;
                RecalculateRow(rowHandle);
            }
        }

        private void PopulateRowWithData(int rowHandle, string upcCode)
        {
            try
            {
                // Fetch item data from the database based on the UPC code
                DataRow itemData = GetItemDataFromDatabase(upcCode);

                if (itemData != null)
                {
                    // Populate grid fields with the fetched data
                    gridView1.SetRowCellValue(rowHandle, "ItemID", itemData["TB01_ID"]); // Fetch ItemID
                    gridView1.SetRowCellValue(rowHandle, "ItemName", itemData["TB01_ItemName"]);
                    gridView1.SetRowCellValue(rowHandle, "SalePrice", itemData["TB01_SalePrice"]);
                    gridView1.SetRowCellValue(rowHandle, "Quantity", 1); // Default quantity

                    // Initialize new columns
                    gridView1.SetRowCellValue(rowHandle, "DiscountPercent", 0.00m); // Default discount percentage
                    gridView1.SetRowCellValue(rowHandle, "GST", 0.00m); // Initialize GST
                    gridView1.SetRowCellValue(rowHandle, "Discount", 0.00m); // Initialize Discount
                    gridView1.SetRowCellValue(rowHandle, "Subtotal", 0.00m); // Initialize Subtotal
                    gridView1.SetRowCellValue(rowHandle, "Total", 0.00m); // Initialize Total

                    // Recalculate the row to update the derived values
                    RecalculateRow(rowHandle);
                }
                else
                {
                    // Handle the case where no item data is found
                    MessageBox.Show($"Item with UPC Code '{upcCode}' not found in the database.");
                }
            }
            catch (Exception ex)
            {
                // Catch and display any exceptions
                MessageBox.Show("Error fetching item data: " + ex.Message);
            }
        }


        private void RecalculateRow(int rowHandle)
        {
            DataRow row = gridView1.GetDataRow(rowHandle);

            if (row != null)
            {
                decimal salePrice = row.IsNull("SalePrice") ? 0.0m : Convert.ToDecimal(row["SalePrice"]);
                int quantity = row.IsNull("Quantity") ? 0 : Convert.ToInt32(row["Quantity"]);
                decimal discountPercent = row.IsNull("DiscountPercent") ? 0.0m : Convert.ToDecimal(row["DiscountPercent"]);

                decimal discount = (salePrice * quantity) * (discountPercent / 100);
                decimal subtotal = (salePrice * quantity) - discount;
                decimal gst = subtotal * 0.05m; // Example GST: 5%
                decimal total = subtotal + gst;

                // Update row values
                row["Discount"] = discount;
                row["Subtotal"] = subtotal;
                row["GST"] = gst;
                row["Total"] = total;
            }
            UpdateTotalAmounts();
        }
 
        

        private void UpdateTotalAmounts()
        {
            decimal subtotal = 0.00m, total = 0.00m;

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);

                if (row != null)
                {
                    subtotal += row.IsNull("Subtotal") ? 0.0m : Convert.ToDecimal(row["Subtotal"]);
                    total += row.IsNull("Total") ? 0.0m : Convert.ToDecimal(row["Total"]);
                }
            }

            txtSubtotal.Text = subtotal.ToString("F2");
            txtTotalAmount.Text = total.ToString("F2");
        }


        private DataRow GetItemDataFromDatabase(string upcCode)
        {
            DataTable itemTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM TB01_Items WHERE TB01_UPC_Code = @UPCCode AND TB01_IsActive = 1";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UPCCode", upcCode);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(itemTable);
            }

            return itemTable.Rows.Count > 0 ? itemTable.Rows[0] : null;
        }



        private void LoadPaymentMethods()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PointOfSalesDBConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetDimDataForDropdown", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DimTable", "PaymentMethods");  // Specify to get PaymentMethods data

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        // Assuming TB03_Dim_Name holds the name (e.g., "Cash", "Credit Card") and TB03_ID holds the ID
                        cmbPaymentMethod.Items.Add(new ComboBoxItem
                        {
                            Text = reader["TB03_Dim_Name"].ToString(),
                            Value = Convert.ToInt32(reader["TB03_ID"])  // Ensure ID is an integer
                        });
                    }
                }
            }
        }
        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaymentMethod.SelectedItem is ComboBoxItem selectedItem)
            {
                int selectedMethodId = selectedItem.Value;
                string selectedMethodName = selectedItem.Text;
               // MessageBox.Show($"Selected Payment Method: {selectedMethodName} (ID: {selectedMethodId})");
            }
        }

        private void BillsearchBtn_Click(object sender, EventArgs e)
        {
            // Open the billingGrid form as a dialog
            billingGrid searchForm = new billingGrid();
            searchForm.OnBillingRecordSelected += LoadBillingDetails; // Attach event handler to load details
            searchForm.ShowDialog();
        }


        // Event handler to load full details of the selected billing record
        private void LoadBillingDetails(int billingNumber)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PointOfSalesDBConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Master Query: Fetch Billing Master Data
                string masterQuery = @"
            SELECT 
                TB04_BillNumber, 
                TB04_SaleDate, 
                TB04_CustomerName, 
                TB04_SubTotal, 
                TB04_DiscountAmount, 
                TB04_GSTAmount, 
                TB04_TotalAmount, 
                TB04_Received_Amount, 
                TB04_Remaining_Amount,
                TB04_PaymentMethod
            FROM TB04_sales_invoice_Master
            WHERE TB04_BillNumber = @BillingNumber";

                using (SqlCommand masterCmd = new SqlCommand(masterQuery, con))
                {
                    masterCmd.Parameters.AddWithValue("@BillingNumber", billingNumber);
                    con.Open();

                    using (SqlDataReader masterReader = masterCmd.ExecuteReader())
                    {
                        if (masterReader.Read())
                        {
                            // Populate main form fields with Master Table data
                            txtBillingNumber.Text = masterReader["TB04_BillNumber"].ToString();
                            txtCurrentDate.Text = Convert.ToDateTime(masterReader["TB04_SaleDate"]).ToString("yyyy-MM-dd");
                            txtCustomerName.Text = masterReader["TB04_CustomerName"].ToString();
                            txtSubtotal.Text = masterReader["TB04_SubTotal"].ToString();
                            txtDiscount.Text = masterReader["TB04_DiscountAmount"].ToString();
                            txtTotalAmount.Text = masterReader["TB04_TotalAmount"].ToString();
                            txtReceivedCash.Text = masterReader["TB04_Received_Amount"].ToString();
                            txtChange.Text = masterReader["TB04_Remaining_Amount"].ToString();

                            // Set Payment Method in ComboBox
                            string paymentMethod = masterReader["TB04_PaymentMethod"].ToString();
                            foreach (ComboBoxItem item in cmbPaymentMethod.Items)
                            {
                                if (item.Text == paymentMethod)
                                {
                                    cmbPaymentMethod.SelectedItem = item;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No data found for the selected Billing Number.");
                            return;
                        }
                    }
                }

                // Detail Query: Fetch Billing Detail Data
                string detailQuery = @"
            SELECT 
                detail.TB05_TB01_ItemID AS ItemID,
                items.TB01_ItemName AS ItemName,
                detail.TB05_Quantity AS Quantity,
                detail.TB05_Price AS SalePrice,
                detail.TB05_DiscountPercent AS DiscountPercent,
                detail.TB05_Discount AS Discount,
                detail.TB05_Subtotal AS Subtotal,
                detail.TB05_GST AS GST,
                detail.TB05_Total AS Total
            FROM 
                TB05_Customer_sale_invoice_details detail
            LEFT JOIN 
                TB01_Items items ON detail.TB05_TB01_ItemID = items.TB01_ID
            WHERE 
                detail.TB05_TB04_SaleID = (SELECT TB04_SaleID FROM TB04_sales_invoice_Master WHERE TB04_BillNumber = @BillingNumber)";

                using (SqlCommand detailCmd = new SqlCommand(detailQuery, con))
                {
                    detailCmd.Parameters.AddWithValue("@BillingNumber", billingNumber);

                    using (SqlDataAdapter detailAdapter = new SqlDataAdapter(detailCmd))
                    {
                        // Fill a DataTable with detail data
                        DataTable detailTable = new DataTable();
                        detailAdapter.Fill(detailTable);

                        // Bind the DataTable to the GridControl
                        gridControl1.DataSource = detailTable;
                    }
                }

                MessageBox.Show("Billing details loaded successfully.");
            }
        }




        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>

        private int GenerateBillingNumber()
        {
            int latestBillingNumber = 1000;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT MAX(TB04_BillNumber) FROM TB04_sales_invoice_Master", connection);
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    latestBillingNumber = Convert.ToInt32(result) + 1;
                }
            }
            return latestBillingNumber;
        }

        private string GetCurrentDate()
        {
            return DateTime.Now.ToString("yyyy-MM-dd");
        }
        private decimal CalculateGridDiscount()
        {
            decimal totalDiscount = 0.00m;

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);

                if (row != null && !row.IsNull("Discount"))
                {
                    totalDiscount += Convert.ToDecimal(row["Discount"]);
                }
            }

            return totalDiscount;
        }




        private int InsertMasterRecord()
        {
            int newSaleID = 0;

            try
            {
                // Ensure the detail table is initialized
                DataTable detailTable = (DataTable)gridControl1.DataSource;
                if (detailTable == null)
                {
                    MessageBox.Show("Detail table is not initialized.");
                    return 0;
                }

                // Validate GST column exists
                if (!detailTable.Columns.Contains("GST"))
                {
                    MessageBox.Show("GST column not found in the detail table.");
                    return 0;
                }

                // Sum up GST values safely
                
                // Validate input fields
                if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
                {
                    MessageBox.Show("Customer Name is required.");
                    return 0;
                }

                // Retrieve input values
                int billNumber = GenerateBillingNumber();
                DateTime saleDate = DateTime.Parse(txtCurrentDate.Text);
                string customerName = txtCustomerName.Text;

                // Calculate discount from the grid and the text field

                decimal gridDiscount = CalculateGridDiscount(); // Discount from grid
                decimal textFieldDiscount = string.IsNullOrWhiteSpace(txtDiscount.Text) ? 0 : decimal.Parse(txtDiscount.Text);
                decimal totalDiscount = gridDiscount + textFieldDiscount;

                // Calculate totals
                decimal subTotal = string.IsNullOrWhiteSpace(txtSubtotal.Text) ? 0 : decimal.Parse(txtSubtotal.Text);
                decimal gstAmount = detailTable.AsEnumerable().Sum(row => row.IsNull("GST") ? 0.0m : Convert.ToDecimal(row["GST"]));
                decimal totalAmount = (subTotal + gstAmount) - textFieldDiscount;
                string paymentMethod = cmbPaymentMethod.SelectedItem?.ToString() ?? "Cash";
                decimal receivedAmount = string.IsNullOrWhiteSpace(txtReceivedCash.Text) ? 0 : decimal.Parse(txtReceivedCash.Text);
                decimal remainingAmount = receivedAmount - totalAmount;

                // Prepare to execute stored procedure
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("InsertSalesInvoiceMaster", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Pass parameters to stored procedure
                        command.Parameters.AddWithValue("@BillNumber", billNumber);
                        command.Parameters.AddWithValue("@SaleDate", saleDate);
                        command.Parameters.AddWithValue("@CustomerName", customerName);
                        command.Parameters.AddWithValue("@SubTotal", subTotal);
                        command.Parameters.AddWithValue("@DiscountAmount", totalDiscount); // Pass combined discount
                        command.Parameters.AddWithValue("@GSTAmount", gstAmount);
                        command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                        command.Parameters.AddWithValue("@CreatedBy", loginCashierID);
                        command.Parameters.AddWithValue("@CashierID", loginCashierID);
                        command.Parameters.AddWithValue("@ReceivedAmount", receivedAmount);
                        command.Parameters.AddWithValue("@RemainingAmount", remainingAmount);

                        connection.Open();
                        newSaleID = Convert.ToInt32(command.ExecuteScalar()); // Retrieve SaleID
                       // MessageBox.Show("Master record saved successfully with Sale ID: " + newSaleID);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving master record: " + ex.Message);
            }

            return newSaleID;
        }

        /////////////////////////////////////////////////
        private bool ValidateItemID(int itemID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM TB01_Items WHERE TB01_ID = @ItemID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ItemID", itemID);

                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        return count > 0; // Return true if the ItemID exists
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error validating ItemID: " + ex.Message);
                return false;
            }
        }


        /////////////////////////////////////


        private void SaveDetailRecords(int saleID)
        {
            try
            {
                DataTable detailTable = (DataTable)gridControl1.DataSource;

                foreach (DataRow row in detailTable.Rows)
                {
                    if (row.RowState == DataRowState.Deleted) continue;

                    // Safely retrieve and handle possible DBNull values
                    int itemID = row.IsNull("ItemID") ? 0 : Convert.ToInt32(row["ItemID"]);
                    string upcCode = row.IsNull("UPCCode") ? string.Empty : row["UPCCode"].ToString();
                    int quantity = row.IsNull("Quantity") ? 0 : Convert.ToInt32(row["Quantity"]);
                    decimal price = row.IsNull("SalePrice") ? 0.0m : Convert.ToDecimal(row["SalePrice"]);
                    object discount = row.IsNull("Discount") ? DBNull.Value : row["Discount"]; // Allow NULL for Discount
                    decimal discountPercent = row.IsNull("DiscountPercent") ? 0.0m : Convert.ToDecimal(row["DiscountPercent"]);
                    decimal subtotal = row.IsNull("Subtotal") ? 0.0m : Convert.ToDecimal(row["Subtotal"]);
                    decimal gst = row.IsNull("GST") ? 0.0m : Convert.ToDecimal(row["GST"]);
                    decimal total = row.IsNull("Total") ? 0.0m : Convert.ToDecimal(row["Total"]); // Retrieve total

                    // Ensure essential columns have valid data before saving
                    if (itemID == 0)
                    {
                        MessageBox.Show("Error: ItemID is missing or invalid.");
                        return;
                    }

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand("InsertSalesInvoiceDetail", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            // Add parameters for procedure
                            command.Parameters.AddWithValue("@SaleID", saleID);
                            command.Parameters.AddWithValue("@ItemID", itemID);
                            command.Parameters.AddWithValue("@UPCCode", upcCode);
                            command.Parameters.AddWithValue("@Quantity", quantity);
                            command.Parameters.AddWithValue("@Price", price);
                            command.Parameters.AddWithValue("@DiscountPercent", discountPercent); // New
                            command.Parameters.AddWithValue("@Discount", discount); // New: Pass discount to the database
                            command.Parameters.AddWithValue("@Total", total);       // New: Pass total to the database
                            command.Parameters.AddWithValue("@Subtotal", subtotal); // New
                            command.Parameters.AddWithValue("@GST", gst); // New
                            command.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                            command.Parameters.AddWithValue("@CreatedBy", loginCashierID);

                            // Execute the insert query
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }
                }

                //MessageBox.Show("Detail records saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving detail records: " + ex.Message);
            }
        }



        private void btnSavePrint_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Save Master Record
                int saleID = InsertMasterRecord();

                if (saleID > 0)
                {
                    // Save Detail Records
                    SaveDetailRecords(saleID);

                    // Retrieve the bill number
                    int billNumber = GetBillNumberBySaleID(saleID);

                    if (billNumber > 0)
                    {
                        // Generate Report for the saved sale
                        GenerateInvoiceReport(billNumber);

                        MessageBox.Show("Bill saved and invoice generated successfully!");
                        // Reset form for the next bill
                        btnreset_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve the bill number.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to save the master record.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Method to get Bill Number by SaleID
        private int GetBillNumberBySaleID(int saleID)
        {
            int billNumber = 0;

            string query = "SELECT TB04_BillNumber FROM TB04_sales_invoice_Master WHERE TB04_SaleID = @SaleID";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SaleID", saleID);
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        billNumber = Convert.ToInt32(result);
                    }
                }
            }

            return billNumber;
        }

        // its methode not procedure but we called procedure in this below methode as name same both methode and procedure""GetInvoiceDetails"
        public DataTable GetInvoiceDetails(int billNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("GetInvoiceDetails", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BillNumber", billNumber);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable invoiceData = new DataTable();
                    adapter.Fill(invoiceData);
                    return invoiceData;
                }
            }
        }




        /////////////////////////////////////////
        private void GenerateInvoiceReport(int billNumber)
        {
            try
            {
                // Create an instance of the report
                ReportDocument reportDocument = new ReportDocument();

                // Load the report template
                string reportPath = @"C:\Users\YOGA\Documents\DirectFN intern ADO.NET\billing_invoice.rpt";
                if (!File.Exists(reportPath))
                {
                    MessageBox.Show($"Report file not found: {reportPath}");
                    return;
                }
                reportDocument.Load(reportPath);

                // Retrieve data using GetInvoiceDetails method
                DataTable invoiceData = GetInvoiceDetails(billNumber);

                if (invoiceData == null || invoiceData.Rows.Count == 0)
                {
                    MessageBox.Show("No data found for the report.");
                    return;
                }

                // Set the data source for the report
                reportDocument.SetDataSource(invoiceData);

                // Add any parameters if needed
                string loggedInUser = loginusername; // Replace with actual logged-in user value
                reportDocument.SetParameterValue("Cashier", loggedInUser);

                // Display the report in a new form with CrystalReportViewer
                var reportViewerForm = new CrystalReportViewerForm();
                reportViewerForm.crystalReportViewer1.ReportSource = reportDocument;
                reportViewerForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating invoice report: " + ex.Message);
            }
        }


        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
              try
                {
                    // Clear all input fields
                    txtBillingNumber.Text = GenerateBillingNumber().ToString(); // Get next billing number
                    txtCurrentDate.Text = GetCurrentDate();
                    txtCustomerName.Text = string.Empty;
                    txtSubtotal.Text = "0.00";
                    txtDiscount.Text = "0.00";
                    txtTotalAmount.Text = "0.00";
                    txtReceivedCash.Text = "0.00";
                    txtChange.Text = "0.00";
                    cmbPaymentMethod.SelectedIndex = -1; // Reset payment method selection

                    // Clear the grid
                    gridControl1.DataSource = CreateEmptyDataTable(); // Reset to an empty DataTable

                    MessageBox.Show("Form reset successfully. Ready for the next bill!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error resetting the form: " + ex.Message);
              }
            


        }
    }
}
