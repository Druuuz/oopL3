using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{

    public partial class Form1 : Form
    {
        Button btn;
       public  List<Computer> computers = new List<Computer>();

        public Form1()
        {
            InitializeComponent();
           
            /*
            buttons(button1);
            buttons(button2);
            buttons(button3);
            buttons(button4);
            buttons(button5);
            */

            //DisplayTable();


        }
        /*
        public void buttons(Button btn)
        {
            btn.Click += new EventHandler(button_Click);
        }

        protected void button_Click(object sender, EventArgs e)
        {
            
        }
        */

        public void DisplayTable()
        {
            if (computers.Count != 0)
            {
               
                dataGridView1.ColumnCount = 6;
                dataGridView1.RowCount = computers.Count;

                dataGridView1.Columns[0].HeaderCell.Value = "Видеокарта";
                dataGridView1.Columns[1].HeaderCell.Value = "Процессор";
                dataGridView1.Columns[2].HeaderCell.Value = "Мат. Плата";
                dataGridView1.Columns[3].HeaderCell.Value = "ОЗУ";
                dataGridView1.Columns[4].HeaderCell.Value = "ПЗУ";
                dataGridView1.Columns[5].HeaderCell.Value = "Корпус";
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = computers[i].videocard;
                    dataGridView1.Rows[i].Cells[1].Value = computers[i].processor;
                    dataGridView1.Rows[i].Cells[2].Value = computers[i].motherboard;
                    dataGridView1.Rows[i].Cells[3].Value = computers[i].DDR;
                    dataGridView1.Rows[i].Cells[4].Value = computers[i].memory;
                    dataGridView1.Rows[i].Cells[5].Value = computers[i].box;

                }
            }
            else
            {
                dataGridView1.Rows.Clear();
            }
            
        }






        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                computers.Add(new Computer(comboBox6.SelectedItem.ToString(), comboBox5.SelectedItem.ToString(), comboBox4.SelectedItem.ToString(), comboBox3.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), comboBox1.SelectedItem.ToString(),"game"));
                DisplayTable();
            }
            catch(Exception)
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                computers.Add(new Computer(comboBox12.SelectedItem.ToString(), comboBox11.SelectedItem.ToString(), comboBox10.SelectedItem.ToString(), comboBox9.SelectedItem.ToString(), comboBox8.SelectedItem.ToString(), comboBox7.SelectedItem.ToString(),"office"));
                DisplayTable();
            }
            catch (Exception)
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                computers.Add(new Computer(comboBox18.SelectedItem.ToString(), comboBox17.SelectedItem.ToString(), comboBox16.SelectedItem.ToString(), comboBox15.SelectedItem.ToString(), comboBox14.SelectedItem.ToString(), comboBox13.SelectedItem.ToString(),"multimedia"));
                DisplayTable();
            }
            catch (Exception)
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                computers.Add(new Computer(comboBox24.SelectedItem.ToString(), comboBox23.SelectedItem.ToString(), comboBox22.SelectedItem.ToString(), comboBox21.SelectedItem.ToString(), comboBox20.SelectedItem.ToString(), comboBox19.SelectedItem.ToString(),"pro"));
                DisplayTable();
            }
            catch (Exception)
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                computers.Add(new Computer(comboBox30.SelectedItem.ToString(), comboBox29.SelectedItem.ToString(), comboBox28.SelectedItem.ToString(), comboBox27.SelectedItem.ToString(), comboBox26.SelectedItem.ToString(), comboBox25.SelectedItem.ToString(),"portable"));
                DisplayTable();
            }
            catch (Exception)
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog mySaveFileDialog = new SaveFileDialog();

            mySaveFileDialog.InitialDirectory = ".";
            mySaveFileDialog.Filter = "computer files (*.cmp)|*.cmp|All files(*.*)|*.*";
            mySaveFileDialog.FilterIndex = 1;
            mySaveFileDialog.RestoreDirectory = true;
            mySaveFileDialog.FileName = "computer";

            if (mySaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream mystream = mySaveFileDialog.OpenFile();

                BinaryFormatter serializer = new BinaryFormatter();

                try
                {
                    serializer.Serialize(mystream, computers);
                }
                catch (Exception)
                {
                    MessageBox.Show("Файл не сохранен");
                }
                finally
                {
                    mystream.Close();
                }
                
                
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog myOpenFileDialog = new OpenFileDialog();

            myOpenFileDialog.InitialDirectory = ".";
            myOpenFileDialog.Filter = "computer files (*.cmp)|*.cmp|All files(*.*)|*.*";
            myOpenFileDialog.FilterIndex = 1;
            myOpenFileDialog.RestoreDirectory = true;

            if (myOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                computers.Clear();
                Stream mystream = myOpenFileDialog.OpenFile();

                try
                {                 
                    BinaryFormatter deserializer = new BinaryFormatter();
                    computers = deserializer.Deserialize(mystream) as List<Computer>;
                }
                catch (Exception)
                {
                    MessageBox.Show("Не удалось загрузить файл");
                }
                finally
                {
                    mystream.Close();
                    DisplayTable();
                }
              
                
               

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            computers.Clear();
            DisplayTable();
        }
        private void SyncLists(ComboBox cb1, ComboBox cb2)
        {
            object[] a = new object[cb1.Items.Count];
            cb1.Items.CopyTo(a, 0);
            cb2.Items.AddRange(a);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (radioButton1.Checked)
                {
                try
                {
                    int numToDel = e.RowIndex;
                    computers.RemoveAt(numToDel);
                    DisplayTable();
                }
                catch (Exception)
                {
                    MessageBox.Show("Кликните по сборке, которую вы хотите удалить");
                }

                }
            if (radioButton2.Checked)
            {
                try
                {
                    int numToChange = e.RowIndex;
                    string type = computers[numToChange].type;
                    Form2 ChangeForm = new Form2(computers,numToChange,this);
                    
                    switch (type)
                    {
                        case "game":
                            SyncLists(comboBox1, ChangeForm.comboBox1);
                            SyncLists(comboBox2, ChangeForm.comboBox2);
                            SyncLists(comboBox3, ChangeForm.comboBox3);
                            SyncLists(comboBox4, ChangeForm.comboBox4);
                            SyncLists(comboBox5, ChangeForm.comboBox5);
                            SyncLists(comboBox6, ChangeForm.comboBox6);
                           
                            break;
                        case "office":
                            SyncLists(comboBox7, ChangeForm.comboBox1);
                            SyncLists(comboBox8, ChangeForm.comboBox2);
                            SyncLists(comboBox9, ChangeForm.comboBox3);
                            SyncLists(comboBox10, ChangeForm.comboBox4);
                            SyncLists(comboBox11, ChangeForm.comboBox5);
                            SyncLists(comboBox12, ChangeForm.comboBox6);
                          
                            break;
                        case "multimedia":
                            SyncLists(comboBox13, ChangeForm.comboBox1);
                            SyncLists(comboBox14, ChangeForm.comboBox2);
                            SyncLists(comboBox15, ChangeForm.comboBox3);
                            SyncLists(comboBox16, ChangeForm.comboBox4);
                            SyncLists(comboBox17, ChangeForm.comboBox5);
                            SyncLists(comboBox18, ChangeForm.comboBox6);
                            
                            break;
                        case "pro":
                            SyncLists(comboBox19, ChangeForm.comboBox1);
                            SyncLists(comboBox20, ChangeForm.comboBox2);
                            SyncLists(comboBox21, ChangeForm.comboBox3);
                            SyncLists(comboBox22, ChangeForm.comboBox4);
                            SyncLists(comboBox23, ChangeForm.comboBox5);
                            SyncLists(comboBox24, ChangeForm.comboBox6);
                            
                            break;
                        case "portable":
                            SyncLists(comboBox25, ChangeForm.comboBox1);
                            SyncLists(comboBox26, ChangeForm.comboBox2);
                            SyncLists(comboBox27, ChangeForm.comboBox3);
                            SyncLists(comboBox28, ChangeForm.comboBox4);
                            SyncLists(comboBox29 ,ChangeForm.comboBox5);
                            SyncLists(comboBox30, ChangeForm.comboBox6);
                            
                            break;

                    }
                    ChangeForm.comboBox1.SelectedItem = computers[numToChange].videocard;
                    ChangeForm.comboBox2.SelectedItem = computers[numToChange].processor;
                    ChangeForm.comboBox3.SelectedItem = computers[numToChange].motherboard;
                    ChangeForm.comboBox4.SelectedItem = computers[numToChange].memory;
                    ChangeForm.comboBox5.SelectedItem = computers[numToChange].DDR;
                    ChangeForm.comboBox6.SelectedItem = computers[numToChange].box;
                                      
                    ChangeForm.Show();
                   
                    
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Кликните по сборке, которую вы хотите изменить");
                }
            }
                 
            
        }
    }
}
