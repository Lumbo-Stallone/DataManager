using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace DataManager
{
    public partial class Form1 : Form
    {
        //static Data[] ob = new Data[4];
        static List<Data> ob = new List<Data>();
        public Form1()
        {
            InitializeComponent();
            ExportFromFileToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteData();
            ExportFromTheListToFile();
        }

      
        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
        //Saving in the Array
        public void SavingData()
        {
            ob.Add(new Data(FName.Text, int.Parse(Age.Text), char.Parse(Gender.Text), Adress.Text, PNumber.Text, DateTime.Parse(dateTimePicker1.Text)));//3
            ExportFromTheListToFile();
        }
        public static void ExportFromTheListToFile()
        {
            StreamWriter write = new StreamWriter("DataStore.txt");//
            for (int i = 0; i <ob.Count; i++)
            {
                if (ob[i]!=null)
                {
                    write.WriteLine(ob[i].name);
                    write.WriteLine(ob[i].age);
                    write.WriteLine(ob[i].gender);
                    write.WriteLine(ob[i].address);
                    write.WriteLine(ob[i].phoneNumber);
                    write.WriteLine(ob[i].dTime);
                }
              
            }
            write.Close();//
        }
        public static void ExportFromFileToList()
        {
            ob.Clear();
            StreamReader read = new StreamReader("DataStore.txt");
            string line;
           
            while ((line = read.ReadLine()) != null)
            {
                Data dt = new Data(
                    line, 
                    int.Parse(read.ReadLine()),
                    char.Parse(read.ReadLine()), 
                    read.ReadLine(), 
                    read.ReadLine(),
                    DateTime.Parse(read.ReadLine()));
              
                ob.Add(dt);
              
            }
            line = read.ReadLine();
            read.Close();
        }
















        //Display Data from the Array
        public void DispalyData()
        {
            listView1.Items.Clear();
            for (int i = 0; i < ob.Count; i++)
            {
                if (ob[i]!=null)
                {
                    listView1.Items.Add(ob[i].name);
                }
            }
        }

        //Delete Data from the Array
        public void DeleteData()
        {
            for (int i = 0; i < ob.Count; i++)
            {
                if (ob[i] != null)
                {
                    if (ob[i].name.Equals(textBox3.Text))
                    {
                        ob[i] = null;
                        break;
                    }
                }
            }
            DispalyData();
        }
        //Update Data from the Array
        public void UpdateData()
        {
            for (int i = 0; i < ob.Count; i++)
            {
                if (ob[i] != null)
                {
                    if (ob[i].name.Equals(textBox3.Text))
                    {
                        ob[i].name =FName.Text;
                        MessageBox.Show("Successfully Updated!");
                        break;
                    }
                }
            }
        }
        // Search Data From the Array
        public static void SearchData()
        {
            Console.WriteLine("Type the name to Search");
            string name = Console.ReadLine();

            for (int i = 0; i < ob.Count; i++)
            {
                if (ob[i] != null)
                {
                    if (ob[i].name.Equals(name))
                    {
                        Console.WriteLine(ob[i].name);
                    }
                }
            }
        }
     

        private void button6_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (var Data in ob)
            {
                if (Data!=null)
                {
                    if (Data.name.Equals(textBox3.Text))
                    {
                        listView1.Items.Add(Data.name);
                    }
                }
            }
        }
        string item;
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button1.Text == "Update")
            {
                UpdateData();
                button1.Text = "Save";
            }
            else
            {
                SavingData();
                DispalyData();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DispalyData();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < ob.Count; i++)
            {
                if (ob[i] != null)
                {
                    if (ob[i].name.Equals(textBox3.Text))
                    {
                        FName.Text = ob[i].name;
                        button1.Text = "Update";
                        break;
                    }
                }
            }
            ExportFromTheListToFile();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            item = listView1.Items[e.ItemIndex].Text;
            for (int i = 0; i < ob.Count; i++)
            {
                if (ob[i] != null)
                {
                    if (ob[i].name==item)
                    {
                        DName.Text = ob[i].name;
                        DAge.Text = ob[i].age.ToString();
                        DGender.Text = ob[i].gender.ToString();
                        DAdress.Text = ob[i].address;
                        DpNumber.Text = ob[i].phoneNumber;
                        DTime.Text = ob[i].dTime.ToLongDateString();

                        break;
                    }
                }
            }
        }

        //private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    MessageBox.Show("Items");
        //}
    }
    public class Data
    {
        public string name;
        public int age;
        public char gender;
        public string address;
        public string phoneNumber;
        public DateTime dTime;
      
        public Data(string Name,int age,char gender,string address,string Pnumber,DateTime dtime)
        {
            name = Name;
            this.age = age;
            this.gender = gender;
            this.address = address;
            phoneNumber = Pnumber;
            dTime = dtime;
        }
    }
}
