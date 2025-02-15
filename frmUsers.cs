using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleHotel
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        void FillListAllUser()
        {
            listAllUsers.Items.Clear();

           
            foreach (frmCreateAccount.stUserInfo info in frmCreateAccount.Quserinfo)
            {
                ListViewItem item = new ListViewItem(info.FirstName);
                if (info.Gender == "Male")
                    item.ImageIndex = 0;
                else
                    item.ImageIndex = 1;

              
                item.SubItems.Add(info.LastName);
                item.SubItems.Add(info.FirstName + " " + info.LastName);
                item.SubItems.Add(info.PhoneNumber);
                item.SubItems.Add(info.Email);
                item.SubItems.Add(info.Country);
                item.SubItems.Add(info.Gender);
                item.SubItems.Add(info.BirthDate);
                item.SubItems.Add(info.Username);
                item.SubItems.Add(info.Password);

                listAllUsers.Items.Add(item);
            }
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1484, 525);
            FillListAllUser();
        }

        private void listAllUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
