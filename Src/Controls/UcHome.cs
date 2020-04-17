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

namespace CRM_Project.Src.Controls
{
    public partial class UcHome : UserControl
    {
        public UcHome()
        {
            InitializeComponent();
        }

        private void UcHome_Load(object sender, EventArgs e)
        {
            lblTodayDate.Text = DateTime.Now.ToString("dd.MM.yyy");

            Database.connect();
            Database.query("SELECT (SELECT COUNT(id) FROM customers) AS customers, (SELECT COUNT(id) FROM events WHERE status = 1) AS events FROM dual");
            if (Database.status) {
                if (Database.reader.HasRows) {
                    while (Database.reader.Read()) {
                        lblNumberClients.Text = Database.reader.GetString(0);
                        lblActiveEvents.Text = Database.reader.GetString(1);
                    }
                }
            } else {
                UcDbError UcDE = new UcDbError();
                UserControls.show(UcDE, UserControls.elements[1]);
            }
            Database.close();

            string month = DateTime.Now.ToString("MMMM");
            lblEventChart.Text += " " + char.ToUpper(month[0]) + month.Substring(1);

            for (int i = 1; i <= DateTime.DaysInMonth(int.Parse(DateTime.Now.ToString("yyy")), int.Parse(DateTime.Now.ToString("MM"))); i++)
            {
                chart.Series["Events"].Points.AddXY(i, 0);
            }

            Database.connect();
            Database.query("SELECT DAY(date), COUNT(id) FROM `events` WHERE status = 1 AND MONTH(date) = " + DateTime.Now.ToString("MM") + " GROUP BY DaY(date)");
            if (Database.status) {
                if (Database.reader.HasRows) {
                    while (Database.reader.Read()) {
                        chart.Series["Events"].Points.AddXY(int.Parse(Database.reader.GetString(0)), Database.reader.GetString(1));
                    }
                }
            } else {
                UcDbError UcDE = new UcDbError();
                UserControls.show(UcDE, UserControls.elements[1]);
            }
            Database.close();
        }
    }
}
