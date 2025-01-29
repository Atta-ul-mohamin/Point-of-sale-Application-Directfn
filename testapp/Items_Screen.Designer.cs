using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using System;

namespace POINT_OF_SALE_APPLICATION
{
    partial class Items_Screen
    {
        private DevExpress.XtraEditors.ComboBoxEdit comboCategory;
        private DevExpress.XtraEditors.TextEdit txtItemName;
        private DevExpress.XtraEditors.TextEdit txtUPCCode;
        private DevExpress.XtraEditors.SpinEdit spinCostPrice;
        private DevExpress.XtraEditors.SpinEdit spinSalePrice;
        private DevExpress.XtraEditors.PictureEdit picItemImage;
        private DevExpress.XtraEditors.SpinEdit spinOpeningQuantity;
        private DevExpress.XtraEditors.DateEdit dateOpeningDate;
        private DevExpress.XtraEditors.CheckEdit checkIsActive;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items_Screen));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btn_crustal_Report = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.comboCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtItemID = new DevExpress.XtraEditors.TextEdit();
            this.checkIsActive = new DevExpress.XtraEditors.CheckEdit();
            this.dateOpeningDate = new DevExpress.XtraEditors.DateEdit();
            this.txtUPCCode = new DevExpress.XtraEditors.TextEdit();
            this.spinOpeningQuantity = new DevExpress.XtraEditors.SpinEdit();
            this.spinSalePrice = new DevExpress.XtraEditors.SpinEdit();
            this.spinCostPrice = new DevExpress.XtraEditors.SpinEdit();
            this.txtItemName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.picItemImage = new DevExpress.XtraEditors.PictureEdit();
            this.gridControlTems = new DevExpress.XtraGrid.GridControl();
            this.gridViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl_FOR_GRID_ITEMS = new DevExpress.XtraEditors.PanelControl();
            this.panelContro = new DevExpress.XtraEditors.PanelControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkIsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOpeningDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOpeningDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUPCCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinOpeningQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSalePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCostPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItemImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_FOR_GRID_ITEMS)).BeginInit();
            this.panelControl_FOR_GRID_ITEMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelContro)).BeginInit();
            this.panelContro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Controls.Add(this.btn_crustal_Report, 4, 0);
            this.tableLayoutPanel.Controls.Add(this.btnSave, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.btnReset, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.btnUpdate, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.btnDelete, 3, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1065, 76);
            this.tableLayoutPanel.TabIndex = 0;
            this.tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tablePanel1_Paint);
            // 
            // btn_crustal_Report
            // 
            this.btn_crustal_Report.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btn_crustal_Report.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crustal_Report.Appearance.Options.UseBackColor = true;
            this.btn_crustal_Report.Appearance.Options.UseFont = true;
            this.btn_crustal_Report.Image = ((System.Drawing.Image)(resources.GetObject("btn_crustal_Report.Image")));
            this.btn_crustal_Report.Location = new System.Drawing.Point(855, 3);
            this.btn_crustal_Report.Name = "btn_crustal_Report";
            this.btn_crustal_Report.Size = new System.Drawing.Size(207, 69);
            this.btn_crustal_Report.TabIndex = 16;
            this.btn_crustal_Report.Text = "Report";
            this.btn_crustal_Report.Click += new System.EventHandler(this.btn_crustal_Report_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(207, 69);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(117)))));
            this.btnReset.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Appearance.Options.UseBackColor = true;
            this.btnReset.Appearance.Options.UseFont = true;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(216, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(207, 69);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "New Item";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseBackColor = true;
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(429, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(207, 69);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(117)))));
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(642, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(207, 69);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // comboCategory
            // 
            this.comboCategory.Location = new System.Drawing.Point(137, 59);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboCategory.Properties.Appearance.Options.UseBackColor = true;
            this.comboCategory.Properties.AutoHeight = false;
            this.comboCategory.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.comboCategory.Properties.NullText = "Select Category";
            this.comboCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboCategory.Size = new System.Drawing.Size(246, 30);
            this.comboCategory.StyleController = this.layoutControl1;
            this.comboCategory.TabIndex = 0;
            this.comboCategory.SelectedIndexChanged += new System.EventHandler(this.comboCategory_SelectedIndexChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.txtItemID);
            this.layoutControl1.Controls.Add(this.checkIsActive);
            this.layoutControl1.Controls.Add(this.dateOpeningDate);
            this.layoutControl1.Controls.Add(this.txtUPCCode);
            this.layoutControl1.Controls.Add(this.spinOpeningQuantity);
            this.layoutControl1.Controls.Add(this.spinSalePrice);
            this.layoutControl1.Controls.Add(this.spinCostPrice);
            this.layoutControl1.Controls.Add(this.txtItemName);
            this.layoutControl1.Controls.Add(this.comboCategory);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9});
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 0, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(772, 213);
            this.layoutControl1.TabIndex = 24;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 37);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "ITEMS";
            // 
            // txtItemID
            // 
            this.txtItemID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemID.EditValue = "ID";
            this.txtItemID.Location = new System.Drawing.Point(142, 12);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Properties.NullText = "Enter Item Name";
            this.txtItemID.Size = new System.Drawing.Size(489, 22);
            this.txtItemID.StyleController = this.layoutControl1;
            this.txtItemID.TabIndex = 18;
            this.txtItemID.Visible = false;
            // 
            // checkIsActive
            // 
            this.checkIsActive.Location = new System.Drawing.Point(16, 167);
            this.checkIsActive.Name = "checkIsActive";
            this.checkIsActive.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkIsActive.Properties.Appearance.Options.UseBackColor = true;
            this.checkIsActive.Properties.AutoHeight = false;
            this.checkIsActive.Properties.Caption = "Is Active";
            this.checkIsActive.Size = new System.Drawing.Size(367, 30);
            this.checkIsActive.StyleController = this.layoutControl1;
            this.checkIsActive.TabIndex = 8;
            this.checkIsActive.CheckedChanged += new System.EventHandler(this.checkIsActive_CheckedChanged);
            // 
            // dateOpeningDate
            // 
            this.dateOpeningDate.EditValue = new System.DateTime(2024, 10, 22, 0, 0, 0, 0);
            this.dateOpeningDate.Location = new System.Drawing.Point(137, 95);
            this.dateOpeningDate.Name = "dateOpeningDate";
            this.dateOpeningDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateOpeningDate.Properties.Appearance.Options.UseBackColor = true;
            this.dateOpeningDate.Properties.AutoHeight = false;
            this.dateOpeningDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.dateOpeningDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateOpeningDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateOpeningDate.Size = new System.Drawing.Size(246, 30);
            this.dateOpeningDate.StyleController = this.layoutControl1;
            this.dateOpeningDate.TabIndex = 7;
            this.dateOpeningDate.EditValueChanged += new System.EventHandler(this.dateOpeningDate_EditValueChanged);
            // 
            // txtUPCCode
            // 
            this.txtUPCCode.Location = new System.Drawing.Point(510, 167);
            this.txtUPCCode.Name = "txtUPCCode";
            this.txtUPCCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUPCCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtUPCCode.Properties.AutoHeight = false;
            this.txtUPCCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtUPCCode.Properties.NullText = "Generate UPC Code";
            this.txtUPCCode.Properties.ReadOnly = true;
            this.txtUPCCode.Size = new System.Drawing.Size(246, 30);
            this.txtUPCCode.StyleController = this.layoutControl1;
            this.txtUPCCode.TabIndex = 2;
            // 
            // spinOpeningQuantity
            // 
            this.spinOpeningQuantity.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinOpeningQuantity.Location = new System.Drawing.Point(510, 95);
            this.spinOpeningQuantity.Name = "spinOpeningQuantity";
            this.spinOpeningQuantity.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.spinOpeningQuantity.Properties.Appearance.Options.UseBackColor = true;
            this.spinOpeningQuantity.Properties.Appearance.Options.UseTextOptions = true;
            this.spinOpeningQuantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.spinOpeningQuantity.Properties.AutoHeight = false;
            this.spinOpeningQuantity.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.spinOpeningQuantity.Properties.MaxValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.spinOpeningQuantity.Properties.NullText = "Enter Opening Quantity";
            this.spinOpeningQuantity.Size = new System.Drawing.Size(246, 30);
            this.spinOpeningQuantity.StyleController = this.layoutControl1;
            this.spinOpeningQuantity.TabIndex = 6;
            // 
            // spinSalePrice
            // 
            this.spinSalePrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinSalePrice.Location = new System.Drawing.Point(510, 131);
            this.spinSalePrice.Name = "spinSalePrice";
            this.spinSalePrice.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.spinSalePrice.Properties.Appearance.Options.UseBackColor = true;
            this.spinSalePrice.Properties.Appearance.Options.UseTextOptions = true;
            this.spinSalePrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.spinSalePrice.Properties.AutoHeight = false;
            this.spinSalePrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.spinSalePrice.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.spinSalePrice.Properties.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.spinSalePrice.Properties.NullText = "Enter Sale Price";
            this.spinSalePrice.Size = new System.Drawing.Size(246, 30);
            this.spinSalePrice.StyleController = this.layoutControl1;
            this.spinSalePrice.TabIndex = 4;
            // 
            // spinCostPrice
            // 
            this.spinCostPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinCostPrice.Location = new System.Drawing.Point(137, 131);
            this.spinCostPrice.Name = "spinCostPrice";
            this.spinCostPrice.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.spinCostPrice.Properties.Appearance.Options.UseBackColor = true;
            this.spinCostPrice.Properties.Appearance.Options.UseTextOptions = true;
            this.spinCostPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.spinCostPrice.Properties.AutoHeight = false;
            this.spinCostPrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.spinCostPrice.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.spinCostPrice.Properties.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.spinCostPrice.Properties.NullText = "Enter Cost Price";
            this.spinCostPrice.Size = new System.Drawing.Size(246, 30);
            this.spinCostPrice.StyleController = this.layoutControl1;
            this.spinCostPrice.TabIndex = 3;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(510, 59);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtItemName.Properties.Appearance.Options.UseBackColor = true;
            this.txtItemName.Properties.AutoHeight = false;
            this.txtItemName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtItemName.Properties.NullText = "Enter Item Name";
            this.txtItemName.Size = new System.Drawing.Size(246, 30);
            this.txtItemName.StyleController = this.layoutControl1;
            this.txtItemName.TabIndex = 1;
            this.txtItemName.EditValueChanged += new System.EventHandler(this.txtItemName_EditValueChanged);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtItemID;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(196, 26);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(623, 26);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.Text = "Items ID";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(118, 16);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem8,
            this.layoutControlItem15});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(772, 213);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.comboCategory;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 43);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(373, 36);
            this.layoutControlItem1.Text = "Select Category";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(118, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dateOpeningDate;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 79);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(373, 36);
            this.layoutControlItem4.Text = "Opening Date";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(118, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.spinCostPrice;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 115);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(373, 36);
            this.layoutControlItem5.Text = "Cost Price";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(118, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.spinSalePrice;
            this.layoutControlItem6.Location = new System.Drawing.Point(373, 115);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(373, 36);
            this.layoutControlItem6.Text = "Sell Price";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(118, 16);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.spinOpeningQuantity;
            this.layoutControlItem7.Location = new System.Drawing.Point(373, 79);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(373, 36);
            this.layoutControlItem7.Text = "Quantity";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(118, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtItemName;
            this.layoutControlItem2.Location = new System.Drawing.Point(373, 43);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(373, 36);
            this.layoutControlItem2.Text = "Enter Product Name ";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(118, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtUPCCode;
            this.layoutControlItem3.Location = new System.Drawing.Point(373, 151);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(373, 36);
            this.layoutControlItem3.Text = "UPC Code";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(118, 16);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.checkIsActive;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 151);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(373, 36);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.labelControl1;
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(746, 43);
            this.layoutControlItem15.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem15.TextVisible = false;
            // 
            // picItemImage
            // 
            this.picItemImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picItemImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.picItemImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.picItemImage.Location = new System.Drawing.Point(774, 2);
            this.picItemImage.Name = "picItemImage";
            this.picItemImage.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picItemImage.Properties.Appearance.Options.UseBackColor = true;
            this.picItemImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picItemImage.Properties.NullText = "Click To Upload Image";
            this.picItemImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Always;
            this.picItemImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picItemImage.Properties.ZoomAccelerationFactor = 1D;
            this.picItemImage.Size = new System.Drawing.Size(293, 207);
            this.picItemImage.TabIndex = 5;
            this.picItemImage.Click += new System.EventHandler(this.picItemImage_Click);
            // 
            // gridControlTems
            // 
            this.gridControlTems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTems.Location = new System.Drawing.Point(2, 2);
            this.gridControlTems.MainView = this.gridViewItems;
            this.gridControlTems.Name = "gridControlTems";
            this.gridControlTems.Size = new System.Drawing.Size(1065, 498);
            this.gridControlTems.TabIndex = 17;
            this.gridControlTems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewItems});
            this.gridControlTems.Click += new System.EventHandler(this.gridControlTems_Click);
            // 
            // gridViewItems
            // 
            this.gridViewItems.GridControl = this.gridControlTems;
            this.gridViewItems.Name = "gridViewItems";
            this.gridViewItems.OptionsBehavior.Editable = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.layoutControl1);
            this.panelControl1.Controls.Add(this.picItemImage);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1069, 211);
            this.panelControl1.TabIndex = 25;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // panelControl_FOR_GRID_ITEMS
            // 
            this.panelControl_FOR_GRID_ITEMS.Controls.Add(this.gridControlTems);
            this.panelControl_FOR_GRID_ITEMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl_FOR_GRID_ITEMS.Location = new System.Drawing.Point(0, 211);
            this.panelControl_FOR_GRID_ITEMS.Name = "panelControl_FOR_GRID_ITEMS";
            this.panelControl_FOR_GRID_ITEMS.Size = new System.Drawing.Size(1069, 502);
            this.panelControl_FOR_GRID_ITEMS.TabIndex = 27;
            // 
            // panelContro
            // 
            this.panelContro.Controls.Add(this.tableLayoutPanel);
            this.panelContro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContro.Location = new System.Drawing.Point(0, 713);
            this.panelContro.Name = "panelContro";
            this.panelContro.Size = new System.Drawing.Size(1069, 80);
            this.panelContro.TabIndex = 29;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Items_Screen
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 793);
            this.Controls.Add(this.panelControl_FOR_GRID_ITEMS);
            this.Controls.Add(this.panelContro);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Items_Screen";
            this.Text = "Items Screen";
            this.Load += new System.EventHandler(this.Items_Screen_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkIsActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOpeningDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOpeningDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUPCCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinOpeningQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSalePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCostPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItemImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_FOR_GRID_ITEMS)).EndInit();
            this.panelControl_FOR_GRID_ITEMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelContro)).EndInit();
            this.panelContro.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private GridControl gridControlTems;
        private GridView gridViewItems;
        private DevExpress.XtraEditors.TextEdit txtItemID;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl_FOR_GRID_ITEMS;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraEditors.PanelControl panelContro;
        private System.ComponentModel.IContainer components;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton btn_crustal_Report;
        private TableLayoutPanel tableLayoutPanel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
