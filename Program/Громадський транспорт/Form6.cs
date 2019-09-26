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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "громадський_транспортDataSet.Види_транспорту". При необходимости она может быть перемещена или удалена.
            this.види_транспортуTableAdapter.Fill(this.громадський_транспортDataSet.Види_транспорту);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate(); this.видиТранспортуBindingSource.EndEdit();
            this.види_транспортуTableAdapter.Update(this.громадський_транспортDataSet.Види_транспорту);
        }
    }
}
