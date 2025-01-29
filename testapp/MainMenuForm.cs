using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testapp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;


namespace POINT_OF_SALE_APPLICATION
{

    public partial class MainMenuForm : Form
    {
        /// <summary>
        // here we declare instance  of evey screen we want to show on main form so here below:
        //purpose for this first we wana check is form is alredy open or not .  
        /// </summary>
        Items_Screen sub1;
        BillingScreen sub2;
        Test sub3;



        private int loggedInUserId;
        private string logedUserName;

        public MainMenuForm(int userId,String userName)
        {
            InitializeComponent();
            loggedInUserId = userId;
            logedUserName = userName;
            // Store the user ID for later use
            this.WindowState = FormWindowState.Maximized; // Set the form to maximized

        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Maximized; // Set the form to maximized



        }

        private void mdiProp()
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }



        //menu transiton code
        bool menuExpand = false;
        private void Menu_transition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                panel_MENU_Container.Height += 10;
                if (panel_MENU_Container.Height >= 241)
                {
                    Menu_transition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                panel_MENU_Container.Height -= 10;
                if (panel_MENU_Container.Height <= 56)
                {
                    Menu_transition.Stop();
                    menuExpand = false;


                }

            }

        }

        private void Menu_Clic_btn_Click(object sender, EventArgs e)
        {
            Menu_transition.Start();
        }

        private void brn_for_logout_Click(object sender, EventArgs e)
        {

        }

       

        // side bar on off methode logic written below 
        // first w e define bool variable  " bool sidebar_panel_open"
        bool sidebar_panel_open = true;
        private void sidebar_Transition_Tick(object sender, EventArgs e)
        {
            if (sidebar_panel_open)
            {
                //'sidebar_Panel' is the name of pannel
                sidebar_Panel.Width -= 15;
                if (sidebar_Panel.Width <= 52)
                {
                    //it is variable bool
                    sidebar_panel_open = false;
                    sidebar_Transition.Stop();

                }
            }
            else
            {
                sidebar_Panel.Width += 15;
                if (sidebar_Panel.Width >= 211)
                {
                    sidebar_panel_open = true;
                    sidebar_Transition.Stop();






                }

            }

        }



        private void btn_for_Items_Click(object sender, EventArgs e)
        {
            //The purpose of this check  sub1 that is instace ofis to determine if the Items_Screen form is already open.
            //If it is null, that means the form is not currently open.
            if (sub1 == null || sub1.IsDisposed)
            {
                // If sub1 is null, the code creates a new instance of the Items_Screen form.
                sub1 = new Items_Screen(loggedInUserId, logedUserName); //sub1 now refers to a new instance of the Items_Screen form.


                //This line adds an event handler (Subitem_closed) to the FormClosed event of the Items_Screen  .
                //   when this itemscreen   closed, the Subitem_closed method will be called and set sub1=0  that methode is also written beloe name is :  ( public void Subitem_closed(object sender, FormClosedEventArgs e))
               // here we also confused why we add event before .show(). it is because if we closed our form before event calling the value is not set to null and next time our sub1 will be not null andd our form will not open so that why we call it first before showing form
                sub1.FormClosed += Subitem_closed;

                //This sets the current form(mean Mainform)   parent the item_Screen form, making it a child form inside an MDI (Multiple Document Interface) application.
                sub1.MdiParent = this;

                //This means that the Items_Screen form will fill the entire space of its parent (the current form).
                sub1.Dock = DockStyle.Fill;
                sub1.Show();


            }
            else
            {
                //If sub1 is not null (meaning the Items_Screen is already open), the following code is executed:
                sub1.Activate();
            }

        }


        ///////////////////////////////////////////// bill screen button/////////////////////////////////////////////////////////
        private void ssubmanu2_Click(object sender, EventArgs e)
        {
            //billing screen

            //The purpose of this check  sub2 that is instace ofis to determine if the Items_Screen form is already open.
            //If it is null, that means the form is not currently open.
            if (sub2 == null || sub2.IsDisposed)
            {
                // If sub1 is null, the code creates a new instance of the Items_Screen form.
                sub2 = new BillingScreen(loggedInUserId, logedUserName); //sub1 now refers to a new instance of the Items_Screen form.


                //This line adds an event handler (Subitem_closed) to the FormClosed event of the Items_Screen  .
                //   when this itemscreen   closed, the Subitem_closed method will be called and set sub1=0  that methode is also written beloe name is :  ( public void Subitem_closed(object sender, FormClosedEventArgs e))
                // here we also confused why we add event before .show(). it is because if we closed our form before event calling the value is not set to null and next time our sub1 will be not null andd our form will not open so that why we call it first before showing form
                sub2.FormClosed += Subitem_closed;

                //This sets the current form(mean Mainform)   parent the item_Screen form, making it a child form inside an MDI (Multiple Document Interface) application.
                sub2.MdiParent = this;

                //This means that the Items_Screen form will fill the entire space of its parent (the current form).
                sub2.Dock = DockStyle.Fill;
                sub2.Show();


            }
            else
            {
                //If sub1 is not null (meaning the Items_Screen is already open), the following code is executed:
                sub2.Activate();
            }


        }


        private void submanu3_Click(object sender, EventArgs e)
        {
            // sub3

            //billing screen

            //The purpose of this check  sub2 that is instace ofis to determine if the Items_Screen form is already open.
            //If it is null, that means the form is not currently open.
            if (sub3 == null || sub3.IsDisposed)
            {
                // If sub1 is null, the code creates a new instance of the Items_Screen form.
                sub3 = new Test(loggedInUserId); //sub1 now refers to a new instance of the Items_Screen form.


                //This line adds an event handler (Subitem_closed) to the FormClosed event of the Items_Screen  .
                //   when this itemscreen   closed, the Subitem_closed method will be called and set sub1=0  that methode is also written beloe name is :  ( public void Subitem_closed(object sender, FormClosedEventArgs e))
                // here we also confused why we add event before .show(). it is because if we closed our form before event calling the value is not set to null and next time our sub1 will be not null andd our form will not open so that why we call it first before showing form
                sub3.FormClosed += Subitem_closed;

                //This sets the current form(mean Mainform)   parent the item_Screen form, making it a child form inside an MDI (Multiple Document Interface) application.
                sub3.MdiParent = this;

                //This means that the Items_Screen form will fill the entire space of its parent (the current form).
                sub3.Dock = DockStyle.Fill;
                sub3.Show();


            }
            else
            {
                //If sub1 is not null (meaning the Items_Screen is already open), the following code is executed:
                sub3.Activate();
            }

        }


        public void Subitem_closed(object sender, FormClosedEventArgs e)
        {
            //This method sets sub1 back to null when the Items_Screen form is closed, so that the next time you click the button, a new instance of the form will be created.
            //It ensures that the form can be reopened after being closed.
            sub1 = null;
            sub2 = null;
            sub3 = null;

        }

        private void pictureBoxfor_minimize_Click(object sender, EventArgs e)
        {

        }
        private void brn_for_logout_Click_1(object sender, EventArgs e)
        {
            Login_Form loginform = new Login_Form();
            loginform.ShowDialog();
            this.Hide();
        }



        private void labelForName_Click(object sender, EventArgs e)
        {

        }

        private void btn_for_Home_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebar_Transition.Start();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_for_info_Click(object sender, EventArgs e)
        {

        }

        private void sidebar_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_MENU_Container_Paint(object sender, PaintEventArgs e)
        {

        }

       
       
        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
