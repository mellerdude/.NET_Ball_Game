//Omri Meller
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_2
{
    public partial class DBForm : Form
    {
        public static gameDBDataContext database = new gameDBDataContext();

        public DBForm()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void DBForm_Load(object sender, EventArgs e)
        {

            originalDB();
            dataGridView1.Refresh();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            originalDB();
            bindingSource1.DataSource = database.TblScores.OrderByDescending(s => s.Length).Take(1);
            dataGridView1.Refresh();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var query = from score in database.TblScores
                        group score by score.Name into g
                        select new
                        {
                            Name = g.Key,
                            LongestLength = g.Max(s => s.Length)
                        };

            dataGridView1.DataSource = query.ToList();
            dataGridView1.Refresh();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            originalDB();
            bindingSource1.DataSource = database.TblScores;
            dataGridView1.Refresh();
        }

        private void originalDB()
        {
            bindingSource1.DataSource = database.TblScores.ToList();
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
        }
    }
}
