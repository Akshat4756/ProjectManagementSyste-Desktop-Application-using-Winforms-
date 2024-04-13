using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementSystem
{
    public partial class Frm_Main : Form
    {
        bool _sidebarrExpanded = true;
        bool _isContainerExpanded = false;
        bool _isProfilePanelExpanded = false;

        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            SideBarTimer.Start();
            
        }

        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            if (_sidebarrExpanded)
            {
                Sidebar.Width -= 10;
                Pages.Width += 10;
                if (Sidebar.Width == Sidebar.MinimumSize.Width)
                {
                    _sidebarrExpanded = false;
                    SideBarTimer.Stop();
                }
                
            }
            else
            {
                Sidebar.Width += 10;
                Pages.Width-=10;
                if (Sidebar.Width == Sidebar.MaximumSize.Width)
                {
                    _sidebarrExpanded = true;
                    SideBarTimer.Stop();
                }
                
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileTimer.Start();
        }

        private void ProfileTimer_Tick(object sender, EventArgs e)
        {
            if (_isProfilePanelExpanded)
            {
                UserPanel.Height -= 10;
                if (UserPanel.Height == UserPanel.MinimumSize.Height)
                {   
                    _isProfilePanelExpanded = false;
                    ProfileTimer.Stop();
                }
            }
            else
            {
                UserPanel.Height += 10;
                if (UserPanel.Height == UserPanel.MaximumSize.Height)
                {
                    _isProfilePanelExpanded = true;
                    ProfileTimer.Stop();
                }
            }
        }

        private void lblProjectName_Click(object sender, EventArgs e)
        {
            Pages.SelectTab(tabDashboard);
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //this.Location = new Point(0, 0);
            // TODO: This line of code loads data into the 'projectManagementSystemDataSet.tbl_Project' table. You can move, or remove it, as needed.
            this.tbl_ProjectTableAdapter.Fill(this.projectManagementSystemDataSet.tbl_Project);

        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            var addProjects = new AddProject();
            addProjects.Show(this);
        }
    }
}
