using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_StrategyPattern
{
    public partial class Form1 : Form
    {
        double total = 0.0d;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_Mode.Items.AddRange(new object[] { "正常收费", "打八折", "打七折", "打五折", "满300减100" });
            comboBox_Mode.SelectedIndex = 0;
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            CashContext cc = new CashContext(comboBox_Mode.SelectedItem.ToString());
            double totalPrices = cc.GetResult(Convert.ToDouble(textBox_Price.Text) * Convert.ToDouble(textBox_Num.Text));
            total += totalPrices;
            listBox.Items.Add("单价:" + textBox_Price.Text + "数量:" + textBox_Num.Text + "合计:" + totalPrices.ToString());
            label_Result.Text = total.ToString();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            textBox_Price.Text = "0.00";
            textBox_Num.Text = "0";
        }

    }
}
