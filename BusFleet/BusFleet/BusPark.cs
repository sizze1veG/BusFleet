using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BusFleet
{
    public partial class BusPark : Form
    {
        List<Bus> busFleet = new List<Bus>(); //список всех автобусов
        List<Bus> busRoute = new List<Bus>(); //список автобусов на маршруте
        List<Bus> busParking = new List<Bus>(); //список автобусов на парковке

        public BusPark()
        {
           InitializeComponent();
           dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckTxt("busFleet.txt");
            CheckTxt("busParking.txt");           
            CheckTxt("busRoute.txt");
            AddTxtToDGW("busFleet.txt", busFleet, true);           
            AddTxtToDGW("busParking.txt", busParking, false);           
            AddTxtToDGW("busRoute.txt", busRoute, false);
            if (dataGridView1.Rows.Count == 0)
            {
                buttonDeleteBus.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AddBus form = new AddBus(new MyDelegate(AddToDGW));
                form.ShowDialog();
                RewriteTxt(); //обновление файла busFleet.txt 
                List<string[]> rows = File.ReadAllLines("busFleet.txt", Encoding.GetEncoding(1251)).Select(x => x.Split('|')).ToList();
                AddNewBus(rows, rows.Count - 1);
                using (StreamWriter sw = new StreamWriter("busParking.txt", false, Encoding.GetEncoding(1251)))
                {
                    for (int i = 0; i < busParking.Count; i++)
                    {
                        sw.WriteLine(busParking.ElementAt(i).BusNumber + "|" + busParking.ElementAt(i).Name + "|" + busParking.ElementAt(i).RouteNumber);
                    }
                }
                if (dataGridView1.Rows.Count == 1)
                {
                    buttonDeleteBus.Enabled = true;
                }
            }
            catch{ MessageBox.Show("Автобус не добавлен"); }           
        }

        private void buttonDeleteBus_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить данные?", "Удаление данных", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) //удаление строки из таблицы
            {
                try
                {
                    bool flag = false;
                    int index = dataGridView1.CurrentRow.Index;
                    int indexDGW = 0;
                    Bus bus = GetDGWIndex(ref index);
                    foreach (var item in busParking)
                    {
                        if (item.BusNumber == bus.BusNumber && item.Name == bus.Name && item.RouteNumber == bus.RouteNumber)
                        {
                            foreach (var item1 in busFleet)
                            {
                                if (item.BusNumber == item1.BusNumber && item.Name == item1.Name && item.RouteNumber == item1.RouteNumber)
                                {
                                    busParking.Remove(item);
                                    dataGridView1.Rows.RemoveAt(indexDGW);
                                    flag = true;
                                    break;
                                }
                                indexDGW++;
                            }
                            break;
                        }
                    }
                    if (!flag)
                    {
                        MessageBox.Show("Чтобы удалить автобус, он должен находиться на парковке");
                        return;
                    }
                    busFleet.RemoveAt(index);//обновление списка автобусов
                    using (StreamWriter sw = new StreamWriter("busParking.txt", false, Encoding.GetEncoding(1251)))
                    {
                        for (int i = 0; i < busParking.Count; i++)
                        {
                            sw.WriteLine(busParking.ElementAt(i).BusNumber + "|" + busParking.ElementAt(i).Name + "|" + busParking.ElementAt(i).RouteNumber);
                        }
                    }
                    RewriteTxt(); //обновление файла busFleet.txt
                    if (dataGridView1.Rows.Count == 0)
                    {
                        buttonDeleteBus.Enabled = false;
                    }
                }
                catch {}
            }
        }

        private void buttonSetRoute_Click(object sender, EventArgs e)
        {
            ListForm form = new ListForm(busRoute, busParking, "Автобусы на\n парковке", false);
            form.ShowDialog();
        }

        private void buttonSetParking_Click(object sender, EventArgs e)
        {
            ListForm form = new ListForm(busRoute, busParking, "Автобусы на\n маршруте", true);
            form.ShowDialog();           
        }

        private void buttonParking_Click(object sender, EventArgs e)
        {
            ListForm form = new ListForm(busParking, "Автобусы на\n парковке");
            form.ShowDialog();
        }

        private void buttonRoute_Click(object sender, EventArgs e)
        {
            ListForm form = new ListForm(busRoute, "Автобусы на\n маршруте");
            form.ShowDialog();
        }

        void CheckTxt(string file)
        {
            if (!File.Exists(file)) // проверка существует ли файл 
            {
                // создание файла 
                using (FileStream fs = File.Create(file))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("");
                }
            }
        }

        void AddTxtToDGW(string file, List<Bus> buses, bool flag)
        {
            List<string[]> rows = File.ReadAllLines(file, Encoding.GetEncoding(1251)).Select(x => x.Split('|')).ToList(); // считать строки из файла

            //добавить строки в таблицу dataGridView и данные в список автобусов и список автобусов на парковке
            for (int i = 0; i < rows.Count; i++)
            {
                Bus bus = new Bus();
                bus.BusNumber = rows[i][0];
                bus.Name = rows[i][1];
                bus.RouteNumber = int.Parse(rows[i][2]);
                if (busRoute.Count > 0 && buses != busFleet)
                {
                    foreach (var item in busRoute)
                    {
                        if (!(item.BusNumber == bus.BusNumber) || !(item.Name == bus.Name) || !(item.RouteNumber == bus.RouteNumber))
                        {
                            buses.Add(bus);
                        }
                    }
                }
                else
                {
                    buses.Add(bus);
                }
                if (buses == busFleet && flag)
                {
                    dataGridView1.Rows.Add(rows[i]);
                }
            }
        }

        void AddNewBus(List<string[]> rows, int i, bool flag = true)
        {
            Bus bus = new Bus();
            bus.BusNumber = rows[i][0];
            bus.Name = rows[i][1];
            bus.RouteNumber = int.Parse(rows[i][2]);
            if (flag)
            {
                busFleet.Add(bus);
            }
            foreach (var item in busParking)
            {
                if (item.BusNumber == bus.BusNumber && item.Name == bus.Name && item.RouteNumber == bus.RouteNumber)
                {
                    return;
                }
            }
            busParking.Add(bus);
        }

        void RewriteTxt()
        {
            using (StreamWriter sw = new StreamWriter("busFleet.txt", false, Encoding.GetEncoding(1251)))
            {
                for (int i = 0; i < Convert.ToInt32(dataGridView1.Rows.Count); i++)
                {
                    sw.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString() + "|"
                        + dataGridView1.Rows[i].Cells[1].Value.ToString() + "|"
                        + dataGridView1.Rows[i].Cells[2].Value.ToString());
                }
            }
        }

        Bus GetDGWIndex(ref int index)
        {
            Bus bus = new Bus();
            for (int i = 0; i < busFleet.Count; i++)
            {
                if (i == index)
                {
                    bus = busFleet.ElementAt(index);
                }
            }
            return bus;
        }

        void AddToDGW(string param1, string param2, string param3)
        {
            dataGridView1.Rows.Add(param1, param2, param3);
        }


        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}