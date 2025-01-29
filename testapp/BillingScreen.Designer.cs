using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

using System.Windows.Forms;
using System;

namespace testapp
{
    partial class BillingScreen
    {
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;

        private System.Windows.Forms.TextBox txtBillingNumber;
        private System.Windows.Forms.TextBox txtCurrentDate;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCashierID;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtReceivedCash;
        private System.Windows.Forms.TextBox txtChange;

        private void InitializeComponent()
        {
            this.txtBillingNumber = new System.Windows.Forms.TextBox();
            this.txtCurrentDate = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCashierID = new System.Windows.Forms.TextBox();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtReceivedCash = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.billingnumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnSavePrint = new DevExpress.XtraEditors.SimpleButton();
            this.Closebtn = new DevExpress.XtraEditors.SimpleButton();
            this.btnreset = new DevExpress.XtraEditors.SimpleButton();
            this.BillsearchBtn = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingnumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBillingNumber
            // 
            this.txtBillingNumber.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtBillingNumber.Location = new System.Drawing.Point(122, 59);
            this.txtBillingNumber.Name = "txtBillingNumber";
            this.txtBillingNumber.ReadOnly = true;
            this.txtBillingNumber.Size = new System.Drawing.Size(276, 25);
            this.txtBillingNumber.TabIndex = 0;
            // 
            // txtCurrentDate
            // 
            this.txtCurrentDate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCurrentDate.Location = new System.Drawing.Point(510, 59);
            this.txtCurrentDate.Name = "txtCurrentDate";
            this.txtCurrentDate.ReadOnly = true;
            this.txtCurrentDate.Size = new System.Drawing.Size(277, 25);
            this.txtCurrentDate.TabIndex = 1;
            this.txtCurrentDate.Text = "2024-11-11";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(122, 90);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(276, 25);
            this.txtCustomerName.TabIndex = 2;
            // 
            // txtCashierID
            // 
            this.txtCashierID.Location = new System.Drawing.Point(510, 90);
            this.txtCashierID.Name = "txtCashierID";
            this.txtCashierID.ReadOnly = true;
            this.txtCashierID.Size = new System.Drawing.Size(277, 25);
            this.txtCashierID.TabIndex = 4;
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(510, 134);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(277, 24);
            this.cmbPaymentMethod.TabIndex = 5;
            this.cmbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentMethod_SelectedIndexChanged);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(122, 197);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(276, 25);
            this.txtSubtotal.TabIndex = 6;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(122, 134);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(276, 25);
            this.txtDiscount.TabIndex = 7;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(510, 197);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(277, 25);
            this.txtTotalAmount.TabIndex = 8;
            // 
            // txtReceivedCash
            // 
            this.txtReceivedCash.Location = new System.Drawing.Point(122, 166);
            this.txtReceivedCash.Name = "txtReceivedCash";
            this.txtReceivedCash.Size = new System.Drawing.Size(276, 25);
            this.txtReceivedCash.TabIndex = 9;
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(510, 166);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(277, 25);
            this.txtChange.TabIndex = 10;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dataLayoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(807, 232);
            this.panelControl1.TabIndex = 15;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.labelControl1);
            this.dataLayoutControl1.Controls.Add(this.txtChange);
            this.dataLayoutControl1.Controls.Add(this.txtReceivedCash);
            this.dataLayoutControl1.Controls.Add(this.cmbPaymentMethod);
            this.dataLayoutControl1.Controls.Add(this.txtDiscount);
            this.dataLayoutControl1.Controls.Add(this.txtCashierID);
            this.dataLayoutControl1.Controls.Add(this.txtSubtotal);
            this.dataLayoutControl1.Controls.Add(this.txtCustomerName);
            this.dataLayoutControl1.Controls.Add(this.txtCurrentDate);
            this.dataLayoutControl1.Controls.Add(this.txtBillingNumber);
            this.dataLayoutControl1.Controls.Add(this.txtTotalAmount);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataLayoutControl1.Location = new System.Drawing.Point(2, 2);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(320, 156, 562, 500);
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(803, 238);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(214, 37);
            this.labelControl1.StyleController = this.dataLayoutControl1;
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Billing Screen";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.billingnumber,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem5,
            this.layoutControlItem8,
            this.emptySpaceItem3,
            this.layoutControlItem7});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.OptionsItemText.TextToControlDistance = 4;
            this.Root.Size = new System.Drawing.Size(803, 238);
            this.Root.TextVisible = false;
            // 
            // billingnumber
            // 
            this.billingnumber.Control = this.txtBillingNumber;
            this.billingnumber.Location = new System.Drawing.Point(0, 43);
            this.billingnumber.Name = "billingnumber";
            this.billingnumber.Size = new System.Drawing.Size(388, 31);
            this.billingnumber.Text = "Bill Number";
            this.billingnumber.TextSize = new System.Drawing.Size(102, 16);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtCurrentDate;
            this.layoutControlItem1.Location = new System.Drawing.Point(388, 43);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(389, 31);
            this.layoutControlItem1.Text = "Date";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(102, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtCustomerName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(388, 31);
            this.layoutControlItem2.Text = "Customer Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(102, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtCashierID;
            this.layoutControlItem3.Location = new System.Drawing.Point(388, 74);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(389, 31);
            this.layoutControlItem3.Text = "Cashier ID";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(102, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtDiscount;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 118);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(388, 32);
            this.layoutControlItem6.Text = "Discount";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(102, 16);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtReceivedCash;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 150);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(388, 31);
            this.layoutControlItem9.Text = "Recieved Cash";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(102, 16);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtChange;
            this.layoutControlItem10.Location = new System.Drawing.Point(388, 150);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(389, 31);
            this.layoutControlItem10.Text = "Remaining Cash";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(102, 16);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.labelControl1;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(777, 43);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtSubtotal;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 181);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(388, 31);
            this.layoutControlItem5.Text = "Sub Total";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(102, 16);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.cmbPaymentMethod;
            this.layoutControlItem8.Location = new System.Drawing.Point(388, 118);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(389, 32);
            this.layoutControlItem8.Text = "Payment Methode";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(102, 16);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 105);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(777, 13);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtTotalAmount;
            this.layoutControlItem7.Location = new System.Drawing.Point(388, 181);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(389, 31);
            this.layoutControlItem7.Text = "Total Amount";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(102, 16);
            // 
            // btnSavePrint
            // 
            this.btnSavePrint.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnSavePrint.Appearance.Options.UseBackColor = true;
            this.btnSavePrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSavePrint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSavePrint.ImageUri.Uri = "Print";
            this.btnSavePrint.Location = new System.Drawing.Point(3, 3);
            this.btnSavePrint.Name = "btnSavePrint";
            this.btnSavePrint.Size = new System.Drawing.Size(194, 41);
            this.btnSavePrint.TabIndex = 16;
            this.btnSavePrint.Text = "Save";
            this.btnSavePrint.Click += new System.EventHandler(this.btnSavePrint_Click_1);
            // 
            // Closebtn
            // 
            this.Closebtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.Closebtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Closebtn.ImageUri.Uri = "Close";
            this.Closebtn.Location = new System.Drawing.Point(603, 3);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(197, 41);
            this.Closebtn.TabIndex = 13;
            this.Closebtn.Text = "Close";
            // 
            // btnreset
            // 
            this.btnreset.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnreset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnreset.ImageUri.Uri = "Reset";
            this.btnreset.Location = new System.Drawing.Point(403, 3);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(194, 41);
            this.btnreset.TabIndex = 12;
            this.btnreset.Text = "Reset";
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // BillsearchBtn
            // 
            this.BillsearchBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.BillsearchBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BillsearchBtn.ImageUri.Uri = "Zoom";
            this.BillsearchBtn.Location = new System.Drawing.Point(203, 3);
            this.BillsearchBtn.Name = "BillsearchBtn";
            this.BillsearchBtn.Size = new System.Drawing.Size(194, 41);
            this.BillsearchBtn.TabIndex = 0;
            this.BillsearchBtn.Text = "SearchBill";
            this.BillsearchBtn.Click += new System.EventHandler(this.BillsearchBtn_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtSubtotal;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 62);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(677, 1);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(50, 20);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 39);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(777, 25);
            this.layoutControlItem15.TextSize = new System.Drawing.Size(50, 20);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(803, 390);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 232);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(807, 394);
            this.panelControl2.TabIndex = 16;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.tableLayoutPanel1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 574);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(807, 52);
            this.panelControl3.TabIndex = 17;
            this.panelControl3.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl3_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.BillsearchBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnreset, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSavePrint, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Closebtn, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(803, 47);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BillingScreen
            // 
            this.ClientSize = new System.Drawing.Size(807, 626);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillingScreen";
            this.Load += new System.EventHandler(this.BillingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingnumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem billingnumber;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraEditors.SimpleButton btnSavePrint;
        private DevExpress.XtraEditors.SimpleButton Closebtn;
        private DevExpress.XtraEditors.SimpleButton btnreset;
        private DevExpress.XtraEditors.SimpleButton BillsearchBtn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
