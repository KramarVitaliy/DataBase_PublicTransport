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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "громадський_транспортDataSet.Зворотній_маршрут". При необходимости она может быть перемещена или удалена.
            this.зворотній_маршрутTableAdapter.Fill(this.громадський_транспортDataSet.Зворотній_маршрут);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate(); this.зворотнійМаршрутBindingSource.EndEdit();
            this.зворотній_маршрутTableAdapter.Update(this.громадський_транспортDataSet.Зворотній_маршрут);
        }
    }
}
