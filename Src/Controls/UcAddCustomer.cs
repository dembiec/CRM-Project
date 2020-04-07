using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_Project.Src.Classes;
using System.Net.Mail;

namespace CRM_Project.Src.Controls
{
    public partial class UcAddCustomer : UserControl
    {
        public UcAddCustomer()
        {
            InitializeComponent();
        }

        //name

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        bool name;

        private void tbName_Validated(object sender, EventArgs e)
        {
            if (tbName.Text == "") {
                name = false;
            } else {
                name = true;
            }
        }

        //email

        bool email;
        private void tbEmail_Validated(object sender, EventArgs e)
        {
            try {
                MailAddress mail = new MailAddress(tbEmail.Text);
                email = true;
            }
            catch {
                email = false;
            }
        }

        //telephone

        private void tbTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        bool telephone;

        private void tbTelephone_Validated(object sender, EventArgs e)
        {
            if (tbTelephone.Text == "") {
                telephone = false;
            } else {
                telephone = true;
            }
        }

        //adress

        bool adress;

        private void tbAdress_Validated(object sender, EventArgs e)
        {
            if (tbAdress.Text == "") {
                adress = false;
            } else {
                adress = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbEmail.Text = "";
            tbTelephone.Text = "";
            tbAdress.Text = "";
            tbDescription.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (name && email && telephone && adress) {
                if (tbDescription.Text == "") {
                    Database.manipulation("INSERT INTO `customers` (`id`, `name`, `email`, `telephone`, `address`, `description`) VALUES (NULL, '" + tbName.Text + "', '" + tbEmail.Text + "', '" + tbTelephone.Text + "', '" + tbAdress.Text + "', NULL)");
                } else {
                    Database.manipulation("INSERT INTO `customers` (`id`, `name`, `email`, `telephone`, `address`, `description`) VALUES (NULL, '" + tbName.Text + "', '" + tbEmail.Text + "', '" + tbTelephone.Text + "', '" + tbAdress.Text + "', '" + tbDescription.Text + "')");
                }
            } else {
                MessageBox.Show("Sprawdź Wszystkie Pola");
            }
        }
    }
}
