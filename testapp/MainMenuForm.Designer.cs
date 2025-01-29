using DevExpress.XtraEditors;

namespace POINT_OF_SALE_APPLICATION

{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.minimize_btn = new DevExpress.XtraEditors.SimpleButton();
            this.labelForName = new DevExpress.XtraEditors.LabelControl();
            this.maximize_btn = new DevExpress.XtraEditors.SimpleButton();
            this.close_screen_btn = new DevExpress.XtraEditors.SimpleButton();
            this.side_btn = new System.Windows.Forms.PictureBox();
            this.sidebar_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_MENU_Container = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Menu_Clic_btn = new DevExpress.XtraEditors.SimpleButton();
            this.btn_for_Items = new DevExpress.XtraEditors.SimpleButton();
            this.bill_screen_btnss = new DevExpress.XtraEditors.SimpleButton();
            this.submanu3 = new DevExpress.XtraEditors.SimpleButton();
            this.panel_setting = new System.Windows.Forms.Panel();
            this.btn_for_setting = new DevExpress.XtraEditors.SimpleButton();
            this.panel_about = new System.Windows.Forms.Panel();
            this.brn_for_logout = new DevExpress.XtraEditors.SimpleButton();
            this.panel_logout = new System.Windows.Forms.Panel();
            this.btn_for_info = new DevExpress.XtraEditors.SimpleButton();
            this.Menu_transition = new System.Windows.Forms.Timer(this.components);
            this.sidebar_Transition = new System.Windows.Forms.Timer(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.side_btn)).BeginInit();
            this.sidebar_Panel.SuspendLayout();
            this.panel_MENU_Container.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_setting.SuspendLayout();
            this.panel_about.SuspendLayout();
            this.panel_logout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.minimize_btn);
            this.panelControl1.Controls.Add(this.labelForName);
            this.panelControl1.Controls.Add(this.maximize_btn);
            this.panelControl1.Controls.Add(this.close_screen_btn);
            this.panelControl1.Controls.Add(this.side_btn);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1116, 40);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // minimize_btn
            // 
            this.minimize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.minimize_btn.Image = global::testapp.Properties.Resources.Macos_Minimize;
            this.minimize_btn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.minimize_btn.Location = new System.Drawing.Point(963, 5);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(35, 31);
            this.minimize_btn.TabIndex = 4;
            this.minimize_btn.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelForName
            // 
            this.labelForName.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelForName.Appearance.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelForName.Appearance.Options.UseBackColor = true;
            this.labelForName.Appearance.Options.UseFont = true;
            this.labelForName.Appearance.Options.UseForeColor = true;
            this.labelForName.Location = new System.Drawing.Point(75, 5);
            this.labelForName.Name = "labelForName";
            this.labelForName.Size = new System.Drawing.Size(206, 29);
            this.labelForName.TabIndex = 2;
            this.labelForName.Text = "Point OF Sale Application";
            this.labelForName.UseMnemonic = false;
            this.labelForName.Click += new System.EventHandler(this.labelForName_Click);
            // 
            // maximize_btn
            // 
            this.maximize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize_btn.Appearance.BackColor = System.Drawing.Color.White;
            this.maximize_btn.Appearance.Options.UseBackColor = true;
            this.maximize_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.maximize_btn.Image = global::testapp.Properties.Resources.Restore_Down1;
            this.maximize_btn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.maximize_btn.ImageUri.Uri = "BringToFront;Size16x16;GrayScaled";
            this.maximize_btn.Location = new System.Drawing.Point(1012, 6);
            this.maximize_btn.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.maximize_btn.Name = "maximize_btn";
            this.maximize_btn.Size = new System.Drawing.Size(44, 29);
            this.maximize_btn.TabIndex = 5;
            this.maximize_btn.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // close_screen_btn
            // 
            this.close_screen_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_screen_btn.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.close_screen_btn.Appearance.Options.UseBackColor = true;
            this.close_screen_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.close_screen_btn.Image = global::testapp.Properties.Resources.Close;
            this.close_screen_btn.Location = new System.Drawing.Point(1068, 5);
            this.close_screen_btn.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.close_screen_btn.Name = "close_screen_btn";
            this.close_screen_btn.Size = new System.Drawing.Size(33, 29);
            this.close_screen_btn.TabIndex = 2;
            this.close_screen_btn.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // side_btn
            // 
            this.side_btn.BackColor = System.Drawing.Color.Transparent;
            this.side_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.side_btn.Image = ((System.Drawing.Image)(resources.GetObject("side_btn.Image")));
            this.side_btn.Location = new System.Drawing.Point(0, 0);
            this.side_btn.Name = "side_btn";
            this.side_btn.Size = new System.Drawing.Size(56, 40);
            this.side_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.side_btn.TabIndex = 1;
            this.side_btn.TabStop = false;
            this.side_btn.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sidebar_Panel
            // 
            this.sidebar_Panel.BackColor = System.Drawing.Color.SlateGray;
            this.sidebar_Panel.Controls.Add(this.panel_MENU_Container);
            this.sidebar_Panel.Controls.Add(this.panel_setting);
            this.sidebar_Panel.Controls.Add(this.panel_about);
            this.sidebar_Panel.Controls.Add(this.panel_logout);
            this.sidebar_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar_Panel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.sidebar_Panel.Location = new System.Drawing.Point(0, 40);
            this.sidebar_Panel.Name = "sidebar_Panel";
            this.sidebar_Panel.Size = new System.Drawing.Size(199, 649);
            this.sidebar_Panel.TabIndex = 1;
            this.sidebar_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Panel_Paint);
            // 
            // panel_MENU_Container
            // 
            this.panel_MENU_Container.BackColor = System.Drawing.Color.SlateGray;
            this.panel_MENU_Container.Controls.Add(this.panel4);
            this.panel_MENU_Container.Controls.Add(this.btn_for_Items);
            this.panel_MENU_Container.Controls.Add(this.bill_screen_btnss);
            this.panel_MENU_Container.Controls.Add(this.submanu3);
            this.panel_MENU_Container.Location = new System.Drawing.Point(-3, 0);
            this.panel_MENU_Container.Margin = new System.Windows.Forms.Padding(0);
            this.panel_MENU_Container.Name = "panel_MENU_Container";
            this.panel_MENU_Container.Size = new System.Drawing.Size(202, 58);
            this.panel_MENU_Container.TabIndex = 6;
            this.panel_MENU_Container.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_MENU_Container_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Menu_Clic_btn);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(202, 50);
            this.panel4.TabIndex = 5;
            // 
            // Menu_Clic_btn
            // 
            this.Menu_Clic_btn.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.Menu_Clic_btn.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.Menu_Clic_btn.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.Menu_Clic_btn.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Clic_btn.Appearance.Options.UseBackColor = true;
            this.Menu_Clic_btn.Appearance.Options.UseBorderColor = true;
            this.Menu_Clic_btn.Appearance.Options.UseFont = true;
            this.Menu_Clic_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.Menu_Clic_btn.Image = global::testapp.Properties.Resources.Top_Menu;
            this.Menu_Clic_btn.Location = new System.Drawing.Point(-3, -3);
            this.Menu_Clic_btn.Name = "Menu_Clic_btn";
            this.Menu_Clic_btn.Size = new System.Drawing.Size(202, 53);
            this.Menu_Clic_btn.TabIndex = 2;
            this.Menu_Clic_btn.Text = "Menu";
            this.Menu_Clic_btn.Click += new System.EventHandler(this.Menu_Clic_btn_Click);
            // 
            // btn_for_Items
            // 
            this.btn_for_Items.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.btn_for_Items.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btn_for_Items.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btn_for_Items.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_for_Items.Appearance.Options.UseBackColor = true;
            this.btn_for_Items.Appearance.Options.UseBorderColor = true;
            this.btn_for_Items.Appearance.Options.UseFont = true;
            this.btn_for_Items.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn_for_Items.Location = new System.Drawing.Point(3, 59);
            this.btn_for_Items.Name = "btn_for_Items";
            this.btn_for_Items.Size = new System.Drawing.Size(202, 57);
            this.btn_for_Items.TabIndex = 3;
            this.btn_for_Items.Text = "ITEMS";
            this.btn_for_Items.Click += new System.EventHandler(this.btn_for_Items_Click);
            // 
            // bill_screen_btnss
            // 
            this.bill_screen_btnss.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.bill_screen_btnss.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.bill_screen_btnss.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.bill_screen_btnss.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_screen_btnss.Appearance.Options.UseBackColor = true;
            this.bill_screen_btnss.Appearance.Options.UseBorderColor = true;
            this.bill_screen_btnss.Appearance.Options.UseFont = true;
            this.bill_screen_btnss.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.bill_screen_btnss.Location = new System.Drawing.Point(3, 122);
            this.bill_screen_btnss.Name = "bill_screen_btnss";
            this.bill_screen_btnss.Size = new System.Drawing.Size(202, 56);
            this.bill_screen_btnss.TabIndex = 4;
            this.bill_screen_btnss.Text = "Billing Invoice";
            this.bill_screen_btnss.Click += new System.EventHandler(this.ssubmanu2_Click);
            // 
            // submanu3
            // 
            this.submanu3.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.submanu3.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.submanu3.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.submanu3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submanu3.Appearance.Options.UseBackColor = true;
            this.submanu3.Appearance.Options.UseBorderColor = true;
            this.submanu3.Appearance.Options.UseFont = true;
            this.submanu3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.submanu3.Location = new System.Drawing.Point(3, 184);
            this.submanu3.Name = "submanu3";
            this.submanu3.Size = new System.Drawing.Size(202, 56);
            this.submanu3.TabIndex = 9;
            this.submanu3.Text = "Test";
            this.submanu3.Click += new System.EventHandler(this.submanu3_Click);
            // 
            // panel_setting
            // 
            this.panel_setting.Controls.Add(this.btn_for_setting);
            this.panel_setting.Location = new System.Drawing.Point(-6, 61);
            this.panel_setting.Name = "panel_setting";
            this.panel_setting.Size = new System.Drawing.Size(202, 53);
            this.panel_setting.TabIndex = 5;
            // 
            // btn_for_setting
            // 
            this.btn_for_setting.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.btn_for_setting.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btn_for_setting.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btn_for_setting.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_for_setting.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn_for_setting.Appearance.Options.UseBackColor = true;
            this.btn_for_setting.Appearance.Options.UseBorderColor = true;
            this.btn_for_setting.Appearance.Options.UseFont = true;
            this.btn_for_setting.Appearance.Options.UseForeColor = true;
            this.btn_for_setting.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_for_setting.Image = global::testapp.Properties.Resources.Settings;
            this.btn_for_setting.Location = new System.Drawing.Point(0, -3);
            this.btn_for_setting.Name = "btn_for_setting";
            this.btn_for_setting.Size = new System.Drawing.Size(208, 56);
            this.btn_for_setting.TabIndex = 2;
            this.btn_for_setting.Text = "Setting";
            // 
            // panel_about
            // 
            this.panel_about.Controls.Add(this.brn_for_logout);
            this.panel_about.Location = new System.Drawing.Point(-6, 120);
            this.panel_about.Name = "panel_about";
            this.panel_about.Size = new System.Drawing.Size(202, 53);
            this.panel_about.TabIndex = 4;
            // 
            // brn_for_logout
            // 
            this.brn_for_logout.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.brn_for_logout.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.brn_for_logout.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.brn_for_logout.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brn_for_logout.Appearance.ForeColor = System.Drawing.Color.Black;
            this.brn_for_logout.Appearance.Options.UseBackColor = true;
            this.brn_for_logout.Appearance.Options.UseBorderColor = true;
            this.brn_for_logout.Appearance.Options.UseFont = true;
            this.brn_for_logout.Appearance.Options.UseForeColor = true;
            this.brn_for_logout.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.brn_for_logout.Image = global::testapp.Properties.Resources.Logout;
            this.brn_for_logout.Location = new System.Drawing.Point(0, -9);
            this.brn_for_logout.Name = "brn_for_logout";
            this.brn_for_logout.Size = new System.Drawing.Size(202, 72);
            this.brn_for_logout.TabIndex = 2;
            this.brn_for_logout.Text = "LOGOUT";
            this.brn_for_logout.Click += new System.EventHandler(this.brn_for_logout_Click_1);
            // 
            // panel_logout
            // 
            this.panel_logout.Controls.Add(this.btn_for_info);
            this.panel_logout.Location = new System.Drawing.Point(-6, 179);
            this.panel_logout.Name = "panel_logout";
            this.panel_logout.Size = new System.Drawing.Size(202, 53);
            this.panel_logout.TabIndex = 5;
            // 
            // btn_for_info
            // 
            this.btn_for_info.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.btn_for_info.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btn_for_info.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btn_for_info.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_for_info.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn_for_info.Appearance.Options.UseBackColor = true;
            this.btn_for_info.Appearance.Options.UseBorderColor = true;
            this.btn_for_info.Appearance.Options.UseFont = true;
            this.btn_for_info.Appearance.Options.UseForeColor = true;
            this.btn_for_info.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_for_info.Image = global::testapp.Properties.Resources.About;
            this.btn_for_info.Location = new System.Drawing.Point(0, -10);
            this.btn_for_info.Name = "btn_for_info";
            this.btn_for_info.Size = new System.Drawing.Size(202, 63);
            this.btn_for_info.TabIndex = 2;
            this.btn_for_info.Text = "ABOUT";
            this.btn_for_info.Click += new System.EventHandler(this.btn_for_info_Click);
            // 
            // Menu_transition
            // 
            this.Menu_transition.Interval = 10;
            this.Menu_transition.Tick += new System.EventHandler(this.Menu_transition_Tick);
            // 
            // sidebar_Transition
            // 
            this.sidebar_Transition.Interval = 10;
            this.sidebar_Transition.Tick += new System.EventHandler(this.sidebar_Transition_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 13;
            this.bunifuElipse1.TargetControl = this;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1116, 689);
            this.Controls.Add(this.sidebar_Panel);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenuForm";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.side_btn)).EndInit();
            this.sidebar_Panel.ResumeLayout(false);
            this.panel_MENU_Container.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel_setting.ResumeLayout(false);
            this.panel_about.ResumeLayout(false);
            this.panel_logout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.PictureBox side_btn;
        private DevExpress.XtraEditors.LabelControl labelForName;
        private System.Windows.Forms.FlowLayoutPanel sidebar_Panel;
        private System.Windows.Forms.Panel panel_about;
        private DevExpress.XtraEditors.SimpleButton btn_for_info;
        private System.Windows.Forms.Panel panel_logout;
        private DevExpress.XtraEditors.SimpleButton brn_for_logout;
        private System.Windows.Forms.FlowLayoutPanel panel_MENU_Container;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton Menu_Clic_btn;
        private DevExpress.XtraEditors.SimpleButton btn_for_Items;
        private DevExpress.XtraEditors.SimpleButton bill_screen_btnss;
        private System.Windows.Forms.Panel panel_setting;
        private DevExpress.XtraEditors.SimpleButton btn_for_setting;
        private System.Windows.Forms.Timer Menu_transition;
        private System.Windows.Forms.Timer sidebar_Transition;
        private DevExpress.XtraEditors.SimpleButton maximize_btn;
        private DevExpress.XtraEditors.SimpleButton close_screen_btn;
        private DevExpress.XtraEditors.SimpleButton minimize_btn;
        private SimpleButton submanu3;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}