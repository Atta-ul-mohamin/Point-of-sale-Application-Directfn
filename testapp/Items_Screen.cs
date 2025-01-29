using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using System.IO;
using System.Drawing;  // For Image class
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository; // Add this for RepositoryItemPictureEdit
using System.Linq;
using CrystalDecisions.CrystalReports.Engine; //for crystal reports::
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;

//using DevExpress.XtraEditors.Controls;

namespace POINT_OF_SALE_APPLICATION
{
    /// note== we implemet upc code in our add item procedures where it execute when all items are added then we update upc code 
    public partial class Items_Screen : DevExpress.XtraEditors.XtraForm
    {
        private int loggedInUserId; // Store the user ID
        private string logedUserName;
        private bool isUpdateMode = false;  // Track if the user is updating mean if we click on save btn during updation than we cannot save new items.so control this thing by using flags



        // Declare OpenFileDialog at class level
        // Declare it at the class level because we want that dialoug in two methods in btn_select image and in btn_save .
        // .That why i canoot put openfiledialog instance mean object in (using) because its mean that object only used for specific that class where we use keyword USING
        private string selectedImagePath = null;

        private OpenFileDialog openFileDialog = new OpenFileDialog
        {
            Filter = "Image Files|*.png;*.jpg;*.jpeg",
            Title = "Select an Item Image"
        };


        /////////////////////////////////////////////////////////////////////////////////Above are all class level declarion/////////////////////////////////////////////////////////////////////////////////////



        public Items_Screen(int userId , string UserName)
        {
            InitializeComponent();
            loggedInUserId = userId; // Assign the user ID
            logedUserName = UserName;
            gridViewItems.RowClick += gridViewItems_RowClick;



        }
        private void Items_Screen_Load(object sender, EventArgs e)
        {
            LoadItems();
            LoadCategories(); // Populate the category dropdown when the screen loads

        }
        /// <summary>
        /// //////////////////////////////////////////////////////////////////////loading catagories from database /////////////////////////////////////////////////////////////////
        /// </summary>
        private void LoadCategories()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PointOfSalesDBConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {  // here we calling pour stored procedure"GetDimDataForDropdown " that get data form TB03_DIM_DATA table
                using (SqlCommand cmd = new SqlCommand("GetDimDataForDropdown", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //here we telling procedure  go to COLUMN " DimTable"and get  the rows where DimTable= Categories
                    cmd.Parameters.AddWithValue("@DimTable", "Categories");

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        // Assuming the category name is in TB03_Dim_Name and the ID is in TB03_ID
                        // here we passing category id  to our add item screen where it store that id in table of column "TB01_Category_Id"
                        // here ComboBoxItem is class that we make to( get set) category id and name and displaying it in our comboboxcatageory field 
                        comboCategory.Properties.Items.Add(new ComboBoxItem{Text = reader["TB03_Dim_Name"].ToString(),// Category name (DISPLAYED)
                            Value = Convert.ToInt32(reader["TB03_ID"]) // Ensure the ID is an integer and internally stored
                        });
                    }
                }
            }
        }
        //////////////////////////////////////////////LODING ITEM DATA FROM DB //////////////////////////////////////////////////////////////////////////////
        private void LoadItems()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["PointOfSalesDBConnection"].ConnectionString;

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("GetItems", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Type", 0);  // Get all items

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        // Check if the gridControl is initialized
                        if (gridControlTems == null)
                        {
                            MessageBox.Show("gridControl is not initialized.");
                            return;
                        }

                        // Set DataSource for the gridControl
                        gridControlTems.DataSource = dt;


                     
                        // Check if MainView is set and is a GridView
                        GridView gridView = gridControlTems.MainView as GridView;
                        if (gridView == null)
                        {
                            MessageBox.Show("MainView is not a GridView.");
                            return;
                        }

                       

                        // Check if the DataTable contains the TB01_Image column
                        if (dt.Columns.Contains("TB01_Image"))
                        {
                            gridView.Columns["TB01_Image"].ColumnEdit = new RepositoryItemPictureEdit();
                        }
                        else
                        {
                            MessageBox.Show("TB01_Image column not found in the DataTable.");
                        }


                        // Customize the column headers when thay display on screen when we run our application without changing name in database////////////////
                        gridView.Columns["TB01_ID"].Caption = "Item ID";
                        gridView.Columns["TB01_ItemName"].Caption = "Item Name";
                        gridView.Columns["TB01_CostPrice"].Caption = "Cost Price";
                        gridView.Columns["TB01_SalePrice"].Caption = "Sale Price";
                        gridView.Columns["TB01_OpeningQuantity"].Caption = "Opening Quantity";
                        gridView.Columns["TB01_CreatedDate"].Caption = "Created Date";
                        gridView.Columns["TB01_CreatedBy"].Caption = "Created By";
                        gridView.Columns["TB01_Image"].Caption = "Product Image";

                        gridView.Columns["TB01_ModifiedBy"].Caption = "Modified By";

                        gridView.Columns["TB01_ModifiedDate"].Caption = "Modified Date";

                        gridView.Columns["TB01_IsActive"].Caption = "Active Status";
                        gridView.Columns["TB01_UPC_Code"].Caption = "UPC Code";
                        gridView.Columns["TB01_Category_Id"].Caption = "Category ID";

                        // Refresh the grid control to display changes
                        gridControlTems.Refresh();

                     

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
           

        }

       






        //////////////////////////////////////////IMAGE SELECTION CODE from device by clicking on image box not clicking on buttton //////////////////////////////////////////////
        private void picItemImage_Click(object sender, EventArgs e)
        {
            // Open file dialog when the picture box is clicked
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|All Files (*.*)|*.*";
            ///// The ShowDialog() method displays the OpenFileDialog and waits for the user to either select a file or cancel.
            //If the user selects a file and clicks "OK," the ShowDialog() method returns DialogResult.OK, and the code inside the if block is executed.

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    selectedImagePath = openFileDialog.FileName;

                    if (File.Exists(selectedImagePath))
                    {
                        // Display the selected image in the PictureBox
                        picItemImage.Image = new Bitmap(selectedImagePath);
                        MessageBox.Show("Image loaded successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The selected file could not be found.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Image Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        ///////////////////////////////////////////////////////ADD OR SAVE  ITEMS///////////////////////////////////////////
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isUpdateMode)
            {
                MessageBox.Show("You are updating an item. Please click the 'Update' button to proceed.",
                                "Update in Progress",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["PointOfSalesDBConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("AddItem", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 120;

                // Handle category selection
                var selectedCategory = comboCategory.SelectedItem as ComboBoxItem;
                if (selectedCategory == null)
                {
                    MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Add parameters
                cmd.Parameters.AddWithValue("@Category_Id", selectedCategory.Value);
                cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text);
                cmd.Parameters.AddWithValue("@CostPrice", spinCostPrice.Value);
                cmd.Parameters.AddWithValue("@SalePrice", spinSalePrice.Value);
                cmd.Parameters.AddWithValue("@OpeningQuantity", (int)spinOpeningQuantity.Value);
                cmd.Parameters.AddWithValue("@OpeningDate", (DateTime)dateOpeningDate.EditValue);
                // as created by column tel which login user add products so that we know who change it or add it or update it
                cmd.Parameters.AddWithValue("@CreatedBy", loggedInUserId);
                cmd.Parameters.AddWithValue("@IsActive", checkIsActive.Checked);

                // Handle image conversion
                if (picItemImage.Image != null)  // If an image is selected
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        string extension = Path.GetExtension(openFileDialog.FileName).ToLower();

                        // Save the image to the memory stream in the correct format
                        if (extension == ".png")
                        {
                            picItemImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        }
                        else if (extension == ".jpg" || extension == ".jpeg")
                        {
                            picItemImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        }

                        byte[] itemImage = ms.ToArray(); // Convert the image to byte array

                        //We use SqlDbType.VarBinary to ensure the parameter matches the database field type.
                        cmd.Parameters.Add("@Image", SqlDbType.VarBinary).Value = itemImage;
                    }
                }
                else  // No image selected
                {
                    cmd.Parameters.Add("@Image", SqlDbType.VarBinary).Value = DBNull.Value;
                }

                // Execute the query
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();  // Reset the form
            }

            LoadItems();  // Refresh the items grid
        }

        /////////////////////////////////////////////////////// Reset ITEMS///////////////////////////////////////////

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset the form fields
            txtItemName.Text = string.Empty;
            txtUPCCode.Text = string.Empty;
            spinCostPrice.Value = 0;
            spinSalePrice.Value = 0;
            picItemImage.Image = null;
            spinOpeningQuantity.Value = 0;
            dateOpeningDate.EditValue = null;
            checkIsActive.Checked = true;
        }

        private void ClearFields()
        {
            txtItemName.Text = string.Empty;
            dateOpeningDate.Text = string.Empty; // If using DateEdit, set to null or DateTime.MinValue if needed
            spinOpeningQuantity.Value = 0; // Assuming it's a SpinEdit
            txtUPCCode.Text = string.Empty;

            spinCostPrice.Value = 0; // Assuming it's a SpinEdit
            spinSalePrice.Value = 0; // Assuming it's a SpinEdit
            picItemImage.Image = null;
        }

        ///////////////////////////////////////////////////////DELETE ITEMS///////////////////////////////////////////

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemID.Text))
            {
                MessageBox.Show("Please select an item to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm before deleting the item
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to delete this item?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["PointOfSalesDBConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("DeleteItem", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 120;  // Increase timeout to 120 seconds


                // Add the ItemID parameter
                int itemId = Convert.ToInt32(txtItemID.Text);
                cmd.Parameters.AddWithValue("@ItemID", itemId);

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Item not found or already deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }

            }

            // Reload the items to reflect the change in the grid
            LoadItems();
        }

        /////////////////////////////////////////// grid click to select product/////////////////////////////////////////////////

        private void gridViewItems_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            // Get the focused row's data
            DataRow row = gridViewItems.GetDataRow(e.RowHandle);

            if (row != null)
            {
                // Extract values from the row and populate the form
                txtItemName.Text = row["TB01_ItemName"].ToString();
                spinCostPrice.Value = Convert.ToDecimal(row["TB01_CostPrice"]);
                spinSalePrice.Value = Convert.ToDecimal(row["TB01_SalePrice"]);
                spinOpeningQuantity.Value = Convert.ToInt32(row["TB01_OpeningQuantity"]);
                dateOpeningDate.EditValue = row["TB01_Opening_Date"] != DBNull.Value ? (DateTime)row["TB01_Opening_Date"] : (DateTime?)null;
                checkIsActive.Checked = Convert.ToBoolean(row["TB01_IsActive"]);

                // Category (find the matching category in comboCategory)
                int categoryId = Convert.ToInt32(row["TB01_Category_Id"]);
                comboCategory.SelectedItem = comboCategory.Properties.Items.Cast<ComboBoxItem>()
                    .FirstOrDefault(item => (int)item.Value == categoryId);

                // Load the image (if any)
                if (row["TB01_Image"] != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row["TB01_Image"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        picItemImage.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    picItemImage.Image = null;  // No image
                }
                // Set the isUpdateMode flag to true to indicate that the user is updating an item and not to  adding item so we control yhis thing by flag
                isUpdateMode = true;

                // Store the selected ItemID (primary key) for update in hidden field 
                txtItemID.Text = row["TB01_ID"].ToString();  // Assuming you have a hidden field or a way to store the ID
            }
        }






        /// <summary>
        /// // we  give id of pproduct from row clicked event when we clicked on it we get id in hidden text field that we false its visibility 
        /// </summary>
       
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemID.Text))
            {
                MessageBox.Show("No item selected for update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["PointOfSalesDBConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("UpdateItem", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 120;  // Increase timeout to 120 seconds

                // here we geting id for update from grid row clicked event as we discussed above
                int itemId = Convert.ToInt32(txtItemID.Text);

                cmd.Parameters.AddWithValue("@ItemID", itemId);

                var selectedCategory = comboCategory.SelectedItem as ComboBoxItem;
                if (selectedCategory == null)
                {
                    MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cmd.Parameters.AddWithValue("@Category_Id", selectedCategory.Value);
                cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text);
                cmd.Parameters.AddWithValue("@CostPrice", spinCostPrice.Value);
                cmd.Parameters.AddWithValue("@SalePrice", spinSalePrice.Value);
                cmd.Parameters.AddWithValue("@OpeningQuantity", (int)spinOpeningQuantity.Value);
                cmd.Parameters.AddWithValue("@Opening_Date", (DateTime)dateOpeningDate.EditValue);
                cmd.Parameters.AddWithValue("@ModifiedBy", loggedInUserId);
                cmd.Parameters.AddWithValue("@IsActive", checkIsActive.Checked);

                // Handle image update
                byte[] itemImage = null;
                if (!string.IsNullOrWhiteSpace(openFileDialog.FileName))
                {
                    using (MemoryStream ms = new MemoryStream()) { 

                    string extension = Path.GetExtension(openFileDialog.FileName).ToLower();
                    if (extension == ".png")
                    {
                        picItemImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    else if (extension == ".jpg" || extension == ".jpeg")
                    {
                        picItemImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    itemImage = ms.ToArray();
                }
                    
                }
                else
                {
                    // Retrieve existing image if no new image is selected
                    itemImage = GetExistingImageFromDatabase(itemId);
                }

                cmd.Parameters.AddWithValue("@Image", itemImage != null ? (object)itemImage : DBNull.Value);


                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isUpdateMode = false;
                ClearFields();
            }

            LoadItems(); // Refresh grid to reflect the update
        }

        // Method to retrieve the existing image from the database
        private byte[] GetExistingImageFromDatabase(int itemId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PointOfSalesDBConnection"].ConnectionString;
            byte[] imageData = null;

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT TB01_Image FROM TB01_Items WHERE TB01_ID = @Id", con))
            {
                cmd.Parameters.AddWithValue("@Id", itemId);
                con.Open();

                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    imageData = (byte[])result;
                }
            }

            return imageData;
        }



        private void btn_crustal_Report_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of the report
                ReportDocument reportDocument = new ReportDocument();

                // Load the report
                string reportPath = @"C:\Users\YOGA\Documents\DirectFN intern ADO.NET\ITEM_report.rpt";
                reportDocument.Load(reportPath);
                reportDocument.Refresh(); // Refresh the report
                //reportDocument.DataDefinition.RecordSelectionFormula = ""; // Clear any filters


                // Set database logon info (using Windows Authentication)
                ConnectionInfo connectionInfo = new ConnectionInfo
                {
                    ServerName = @"SARKAR\SQLEXPRESS",
                    DatabaseName = "Point_Of_Sales",
                    IntegratedSecurity = true
                };
                // Use SQL connection to fetch data
                using (SqlConnection con = new SqlConnection(
                    ConfigurationManager.ConnectionStrings["PointOfSalesDBConnection"].ConnectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("GetItemsForReport", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@Type", 0); // Retrieve all items

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No data found for the report.");
                            return;
                        }

                        // Set the data source for the report
                        reportDocument.SetDataSource(dt);
                    }
                }
               string loggedInUser = logedUserName; // Replace with actual logged-in user value
               reportDocument.SetParameterValue("PrintedBy", loggedInUser);

                // Display the report in the viewer form
                var reportViewerForm = new testapp.CrystalReportViewerForm();
                reportViewerForm.crystalReportViewer1.ReportSource = reportDocument;
                 reportViewerForm.Show();
               // testapp.CrystalReportViewerForm reportViewerForm = new testapp.CrystalReportViewerForm();
               // reportViewerForm.crystalReportViewer1.ReportSource = reportDocument;
               // reportViewerForm.Show();
            }
            catch (Exception ex)
            
{
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        







        /*

        /// <summary>
        /// //////////////////////////////////////////////////////Report generating by devexpreess report extension . Also make extension Items_Screen.cs in which frontend but now we generate report on crystal report////////////////////////////////////////////////////
        /// </summary>

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of the ItemReport class
                ItemReport report = new ItemReport();

                // Create a report data source
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PointOfSalesDBConnection"].ConnectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("GetItems", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Type", 0); // Pass the parameter

                        // Use a SqlDataAdapter to fill the report with data
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Set the data source for the"report" that we declaed in this methode above
                        report.DataSource = dt;

                    }
                }



                // Export the report to PDF
                string filePath = @"C:\Users\YOGA\Documents\ADO.NET\POINT OF SALE APPLICATION\reports generated by me\ItemReport.pdf"; // Specify the path where you want to save the PDF
                report.ExportToPdf(filePath);

                // Optionally, show a message or open the PDF
                MessageBox.Show("Report generated successfully! Saved at: " + filePath);

                // to show preview of report
                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.ShowPreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while generating the report: {ex.Message}");
            }
        }
        */




        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void tablePanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tablePanel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void checkIsActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void txtItemName_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dateOpeningDate_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControlTems_Click(object sender, EventArgs e)
        {

        }

        private void tablePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
