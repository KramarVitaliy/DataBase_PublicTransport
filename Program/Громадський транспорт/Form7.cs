﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Громадський_транспорт
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate(); this.зупинкиBindingSource.EndEdit();
            this.зупинкиTableAdapter.Update(this.громадський_транспортDataSet.Зупинки);
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "громадський_транспортDataSet.Зупинки". При необходимости она может быть перемещена или удалена.
            this.зупинкиTableAdapter.Fill(this.громадський_транспортDataSet.Зупинки);

        }
    }
}
