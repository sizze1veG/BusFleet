using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BusFleet
{
    public partial class ListForm : Form
    {
        bool flag = false;
        List<Bus> busRoute = new List<Bus>(); //список автобусов на маршруте
        List<Bus> busParking = new List<Bus>(); //список автобусов на парковке
        public ListForm(List<Bus> bus, string label)
        {
            InitializeComponent();
            label1.Text = label;
            dataGridView2.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            foreach (var item in bus)
            {
                dataGridView2.Rows.Add(item.BusNumber, item.Name, item.RouteNumber);
            }
            buttonSend.Enabled = false;
        }

        public ListForm(List<Bus> busRoute, List<Bus> busParking, string label, bool flag)
        {
            this.busRoute = busRoute;
            this.busParking = busParking;
            InitializeComponent();
            label1.Text = label;         
            dataGridView2.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            if (flag)
            {
                foreach (var item in busRoute)
                {
                    dataGridView2.Rows.Add(item.BusNumber, item.Name, item.RouteNumber);
                }
            }
            else
            {
                foreach (var item in busParking)
                {
                    dataGridView2.Rows.Add(item.BusNumber, item.Name, item.RouteNumber);
                }
            }
            if (dataGridView2.Rows.Count == 0)
            {
                buttonSend.Enabled = false;
            }
            this.flag = flag;
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                DialogResult dialogResult = MessageBox.Show("Отправить автобус на маршрут?", "Маршрут", MessageBoxButtons.YesNo);
                SendTo(dialogResult, "busRoute.txt", "busParking.txt", busParking, busRoute);
            }
            if (flag)
            {
                DialogResult dialogResult = MessageBox.Show("Отправить автобус на парковку?", "Парковка", MessageBoxButtons.YesNo);
                SendTo(dialogResult, "busParking.txt", "busRoute.txt", busRoute, busParking);
            }
        }

        void SendTo(DialogResult dialogResult, string file1, string file2, List<Bus> bus1, List<Bus> bus2)
        {
            if (dialogResult == DialogResult.Yes)
            {
                int index = dataGridView2.CurrentRow.Index;
                Bus bus = new Bus();
                for (int i = 0; i < bus1.Count; i++)
                {
                    if (i == index)
                    {
                        bus = bus1.ElementAt(index);
                    }
                }
                foreach (var item in bus1)
                {
                    if (item.BusNumber == bus.BusNumber && item.Name == bus.Name && item.RouteNumber == bus.RouteNumber)
                    {
                        bus1.Remove(item);
                        bus2.Add(item);
                        RewriteTxt(file1, true, index);
                        dataGridView2.Rows.RemoveAt(index);
                        break;
                    }
                }
                RewriteTxt(file2, false, index);
            }
        }

        void RewriteTxt(string file, bool append, int index)
        {
            using (StreamWriter sw = new StreamWriter(file, append, Encoding.GetEncoding(1251)))
            {
                if (append)
                {
                    sw.WriteLine(dataGridView2.Rows[index].Cells[0].Value.ToString() + "|"
                    + dataGridView2.Rows[index].Cells[1].Value.ToString() + "|"
                    + dataGridView2.Rows[index].Cells[2].Value.ToString());
                }
                else
                {
                    for (int i = 0; i < Convert.ToInt32(dataGridView2.Rows.Count); i++)
                    {
                        sw.WriteLine(dataGridView2.Rows[i].Cells[0].Value.ToString() + "|"
                            + dataGridView2.Rows[i].Cells[1].Value.ToString() + "|"
                            + dataGridView2.Rows[i].Cells[2].Value.ToString());
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ListForm_Load(object sender, EventArgs e)
        {

        }
    }
}