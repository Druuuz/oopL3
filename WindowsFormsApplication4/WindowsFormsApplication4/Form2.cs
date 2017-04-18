using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {
        
        List<Computer> computers;
        int number;
        Form1 MainForm;

        public Form2(List<Computer> computers, int number,Form1 MainForm )
        {
            InitializeComponent();
            this.computers = computers;
            this.number = number;
            this.MainForm = MainForm;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            computers[number].videocard = comboBox1.SelectedItem.ToString();
            computers[number].processor = comboBox2.SelectedItem.ToString();
            computers[number].motherboard = comboBox3.SelectedItem.ToString();
            computers[number].memory = comboBox4.SelectedItem.ToString();
            computers[number].DDR = comboBox4.SelectedItem.ToString();
            computers[number].box = comboBox6.SelectedItem.ToString();

            MainForm.DisplayTable();
            this.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
