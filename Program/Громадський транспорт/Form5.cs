using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Громадський_транспорт
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "громадський_транспортDataSet.Робота_транспорту". При необходимости она может быть перемещена или удалена.
            this.робота_транспортуTableAdapter.Fill(this.громадський_транспортDataSet.Робота_транспорту);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate(); this.роботаТранспортуBindingSource.EndEdit();
            this.робота_транспортуTableAdapter.Update(this.громадський_транспортDataSet.Робота_транспорту);
        }
    }
}
