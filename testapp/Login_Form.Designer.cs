namespace POINT_OF_SALE_APPLICATION
{
    partial class Login_Form
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
        /// 
        private DevExpress.XtraEditors.TextEdit txtUserNameLoginField;
        private DevExpress.XtraEditors.TextEdit txtUserPasswordLoginField;
        private DevExpress.XtraEditors.SimpleButton LoginButton;
        private DevExpress.XtraEditors.LabelControl logintxtUserName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelToGoRegisterPage;
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtUserNameLoginField = new DevExpress.XtraEditors.TextEdit();
            this.txtUserPasswordLoginField = new DevExpress.XtraEditors.TextEdit();
            this.LoginButton = new DevExpress.XtraEditors.SimpleButton();
            this.logintxtUserName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelToGoRegisterPage = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtUserNameLoginField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPasswordLoginField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserNameLoginField
            // 
            this.txtUserNameLoginField.Location = new System.Drawing.Point(55, 156);
            this.txtUserNameLoginField.Name = "txtUserNameLoginField";
            this.txtUserNameLoginField.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.txtUserNameLoginField.Properties.Appearance.Options.UseBackColor = true;
            this.txtUserNameLoginField.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtUserNameLoginField.Size = new System.Drawing.Size(200, 20);
            this.txtUserNameLoginField.TabIndex = 0;
            // 
            // txtUserPasswordLoginField
            // 
            this.txtUserPasswordLoginField.Location = new System.Drawing.Point(56, 232);
            this.txtUserPasswordLoginField.Name = "txtUserPasswordLoginField";
            this.txtUserPasswordLoginField.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.txtUserPasswordLoginField.Properties.Appearance.Options.UseBackColor = true;
            this.txtUserPasswordLoginField.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtUserPasswordLoginField.Properties.PasswordChar = '*';
            this.txtUserPasswordLoginField.Size = new System.Drawing.Size(200, 20);
            this.txtUserPasswordLoginField.TabIndex = 1;
            this.txtUserPasswordLoginField.EditValueChanged += new System.EventHandler(this.txtUserPasswordLoginField_EditValueChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.LoginButton.Appearance.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Appearance.Options.UseBackColor = true;
            this.LoginButton.Appearance.Options.UseFont = true;
            this.LoginButton.Location = new System.Drawing.Point(95, 283);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(94, 29);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // logintxtUserName
            // 
            this.logintxtUserName.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintxtUserName.Appearance.Options.UseFont = true;
            this.logintxtUserName.Location = new System.Drawing.Point(55, 121);
            this.logintxtUserName.Name = "logintxtUserName";
            this.logintxtUserName.Size = new System.Drawing.Size(69, 17);
            this.logintxtUserName.TabIndex = 3;
            this.logintxtUserName.Text = "User Name";
            this.logintxtUserName.Click += new System.EventHandler(this.logintxtUserName_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(55, 197);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(92, 17);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "User Password";
            // 
            // labelToGoRegisterPage
            // 
            this.labelToGoRegisterPage.Appearance.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToGoRegisterPage.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelToGoRegisterPage.Appearance.Options.UseFont = true;
            this.labelToGoRegisterPage.Appearance.Options.UseForeColor = true;
            this.labelToGoRegisterPage.Location = new System.Drawing.Point(95, 359);
            this.labelToGoRegisterPage.Name = "labelToGoRegisterPage";
            this.labelToGoRegisterPage.Size = new System.Drawing.Size(91, 13);
            this.labelToGoRegisterPage.TabIndex = 5;
            this.labelToGoRegisterPage.Text = "Create Account";
            this.labelToGoRegisterPage.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(55, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(149, 30);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Get Started";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(74, 331);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(134, 13);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Dont have an account ?";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtUserNameLoginField);
            this.panelControl1.Controls.Add(this.txtUserPasswordLoginField);
            this.panelControl1.Controls.Add(this.labelToGoRegisterPage);
            this.panelControl1.Controls.Add(this.LoginButton);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.logintxtUserName);
            this.panelControl1.Location = new System.Drawing.Point(327, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(296, 455);
            this.panelControl1.TabIndex = 16;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pictureEdit1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(344, 455);
            this.panelControl2.TabIndex = 17;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = global::testapp.Properties.Resources.point_of_sale_application_high_resolution_logo_grayscale;
            this.pictureEdit1.Location = new System.Drawing.Point(-7, -2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(351, 471);
            this.pictureEdit1.TabIndex = 0;
            this.pictureEdit1.EditValueChanged += new System.EventHandler(this.pictureEdit1_EditValueChanged);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(623, 455);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUserNameLoginField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPasswordLoginField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}