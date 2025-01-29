using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;


namespace testapp
{
    partial class Test
    {
        private Label labelBillNo;
        private TextEdit textEditBillNo;
        private Label labelDate;
        private Label labelCustomerName;
        private TextEdit textEditCustomerName;
        private Label labelUPCCode;
        private TextEdit textEditUPCCode;
        private Label labelCashierId;
        private TextEdit textEditCashierId;
        private ComboBoxEdit cboPaymentMethod;
        private SimpleButton btnSavePrint;
        private SimpleButton btnReset;
        private SimpleButton btnClose;
        private GridControl gridControlBilling;
        private GridView gridViewBilling;

       
        private void InitializeComponent()
        {
            this.labelBillNo = new System.Windows.Forms.Label();
            this.textEditBillNo = new DevExpress.XtraEditors.TextEdit();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.textEditCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.labelUPCCode = new System.Windows.Forms.Label();
            this.textEditUPCCode = new DevExpress.XtraEditors.TextEdit();
            this.labelCashierId = new System.Windows.Forms.Label();
            this.textEditCashierId = new DevExpress.XtraEditors.TextEdit();
            this.cboPaymentMethod = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnSavePrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlBilling = new DevExpress.XtraGrid.GridControl();
            this.gridViewBilling = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textEditDate = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBillNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUPCCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCashierId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPaymentMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBillNo
            // 
            this.labelBillNo.Location = new System.Drawing.Point(20, 20);
            this.labelBillNo.Name = "labelBillNo";
            this.labelBillNo.Size = new System.Drawing.Size(74, 23);
            this.labelBillNo.TabIndex = 0;
            this.labelBillNo.Text = "Bill Number:";
            // 
            // textEditBillNo
            // 
            this.textEditBillNo.Location = new System.Drawing.Point(100, 20);
            this.textEditBillNo.Name = "textEditBillNo";
            this.textEditBillNo.Properties.ReadOnly = true;
            this.textEditBillNo.Size = new System.Drawing.Size(100, 22);
            this.textEditBillNo.TabIndex = 1;
            // 
            // labelDate
            // 
            this.labelDate.Location = new System.Drawing.Point(250, 20);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(65, 23);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date:";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.Location = new System.Drawing.Point(20, 60);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(100, 23);
            this.labelCustomerName.TabIndex = 4;
            this.labelCustomerName.Text = "Customer Name:";
            // 
            // textEditCustomerName
            // 
            this.textEditCustomerName.Location = new System.Drawing.Point(120, 60);
            this.textEditCustomerName.Name = "textEditCustomerName";
            this.textEditCustomerName.Size = new System.Drawing.Size(100, 22);
            this.textEditCustomerName.TabIndex = 5;
            // 
            // labelUPCCode
            // 
            this.labelUPCCode.Location = new System.Drawing.Point(250, 60);
            this.labelUPCCode.Name = "labelUPCCode";
            this.labelUPCCode.Size = new System.Drawing.Size(79, 23);
            this.labelUPCCode.TabIndex = 6;
            this.labelUPCCode.Text = "UPC Code:";
            // 
            // textEditUPCCode
            // 
            this.textEditUPCCode.Location = new System.Drawing.Point(355, 60);
            this.textEditUPCCode.Name = "textEditUPCCode";
            this.textEditUPCCode.Size = new System.Drawing.Size(100, 22);
            this.textEditUPCCode.TabIndex = 7;
            // 
            // labelCashierId
            // 
            this.labelCashierId.Location = new System.Drawing.Point(20, 100);
            this.labelCashierId.Name = "labelCashierId";
            this.labelCashierId.Size = new System.Drawing.Size(100, 23);
            this.labelCashierId.TabIndex = 8;
            this.labelCashierId.Text = "Cashier ID:";
            // 
            // textEditCashierId
            // 
            this.textEditCashierId.Location = new System.Drawing.Point(100, 100);
            this.textEditCashierId.Name = "textEditCashierId";
            this.textEditCashierId.Properties.ReadOnly = true;
            this.textEditCashierId.Size = new System.Drawing.Size(100, 22);
            this.textEditCashierId.TabIndex = 9;
            // 
            // cboPaymentMethod
            // 
            this.cboPaymentMethod.Location = new System.Drawing.Point(250, 100);
            this.cboPaymentMethod.Name = "cboPaymentMethod";
            this.cboPaymentMethod.Properties.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "Other"});
            this.cboPaymentMethod.Size = new System.Drawing.Size(100, 22);
            this.cboPaymentMethod.TabIndex = 10;
            // 
            // btnSavePrint
            // 
            this.btnSavePrint.Location = new System.Drawing.Point(20, 140);
            this.btnSavePrint.Name = "btnSavePrint";
            this.btnSavePrint.Size = new System.Drawing.Size(75, 23);
            this.btnSavePrint.TabIndex = 11;
            this.btnSavePrint.Text = "Save & Print";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(120, 140);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(220, 140);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            // 
            // gridControlBilling
            // 
            this.gridControlBilling.Location = new System.Drawing.Point(20, 180);
            this.gridControlBilling.MainView = this.gridViewBilling;
            this.gridControlBilling.Name = "gridControlBilling";
            this.gridControlBilling.Size = new System.Drawing.Size(600, 300);
            this.gridControlBilling.TabIndex = 14;
            this.gridControlBilling.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBilling});
            // 
            // gridViewBilling
            // 
            this.gridViewBilling.GridControl = this.gridControlBilling;
            this.gridViewBilling.Name = "gridViewBilling";
            this.gridViewBilling.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // textEditDate
            // 
            this.textEditDate.Location = new System.Drawing.Point(321, 17);
            this.textEditDate.Name = "textEditDate";
            this.textEditDate.Properties.ReadOnly = true;
            this.textEditDate.Size = new System.Drawing.Size(176, 22);
            this.textEditDate.TabIndex = 3;
            this.textEditDate.EditValueChanged += new System.EventHandler(this.textEditDate_EditValueChanged);
            // 
            // Test
            // 
            this.ClientSize = new System.Drawing.Size(1089, 500);
            this.Controls.Add(this.labelBillNo);
            this.Controls.Add(this.textEditBillNo);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textEditDate);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.textEditCustomerName);
            this.Controls.Add(this.labelUPCCode);
            this.Controls.Add(this.textEditUPCCode);
            this.Controls.Add(this.labelCashierId);
            this.Controls.Add(this.textEditCashierId);
            this.Controls.Add(this.cboPaymentMethod);
            this.Controls.Add(this.btnSavePrint);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridControlBilling);
            this.Name = "Test";
            this.Text = "Billing Screen";
            ((System.ComponentModel.ISupportInitialize)(this.textEditBillNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUPCCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCashierId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPaymentMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        private void InitializeGridControl()
        {
            // Define UPC Code column
            var upcCodeColumn = gridViewBilling.Columns.AddVisible("UPCCode", "UPC Code");
            upcCodeColumn.OptionsColumn.AllowEdit = true;

            // Define Item Name column with dropdown (editable)
            var itemNameColumn = gridViewBilling.Columns.AddVisible("ItemName", "Item Name");
            itemNameColumn.OptionsColumn.AllowEdit = true;
            itemNameColumn.ColumnEdit = new RepositoryItemComboBox(); // To be populated with items

            // Define Sale Price column (non-editable)
            var salePriceColumn = gridViewBilling.Columns.AddVisible("SalePrice", "Sale Price");
            salePriceColumn.OptionsColumn.AllowEdit = false;

            // Define Quantity column (editable)
            var quantityColumn = gridViewBilling.Columns.AddVisible("Quantity", "Quantity");
            quantityColumn.OptionsColumn.AllowEdit = true;

            // Define GST column (non-editable, auto-calculated)
            var gstColumn = gridViewBilling.Columns.AddVisible("GST", "GST");
            gstColumn.OptionsColumn.AllowEdit = false;

            // Define Discount column (non-editable, auto-calculated)
            var discountColumn = gridViewBilling.Columns.AddVisible("Discount", "Discount");
            discountColumn.OptionsColumn.AllowEdit = false;

            // Define Subtotal column (non-editable, auto-calculated)
            var subtotalColumn = gridViewBilling.Columns.AddVisible("Subtotal", "Subtotal");
            subtotalColumn.OptionsColumn.AllowEdit = false;

            // Define Total column (non-editable, auto-calculated)
            var totalColumn = gridViewBilling.Columns.AddVisible("Total", "Total");
            totalColumn.OptionsColumn.AllowEdit = false;

            // Adding grid control to form
            this.Controls.Add(gridControlBilling);
            gridControlBilling.MainView = gridViewBilling;
        }



        private TextEdit textEditDate;
    }

}
