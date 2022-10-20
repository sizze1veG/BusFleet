using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BusFleet
{
    public partial class AddBus : Form
    {
        MyDelegate d;
        bool flag = false;
        List<Bus> busFleet = new List<Bus>();

        public AddBus(MyDelegate sender, List<Bus> bus)
        {
            InitializeComponent();
            d = sender;
            busFleet = bus;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //проверка данных, которые вводит пользователь
            if (CheckNumberBus(textBoxNumberBus.Text) && CheckRouteNumber(textBoxRouteNumber.Text) && CheckName(textBoxName.Text) && !flag && CheckRepeat(textBoxNumberBus.Text, textBoxName.Text, textBoxRouteNumber.Text))
            {
                d(textBoxNumberBus.Text, textBoxName.Text, textBoxRouteNumber.Text);
                Close();
            }
            else
            {
                if (!CheckNumberBus(textBoxNumberBus.Text))
                {
                    MessageBox.Show("Некоректный номер автобуса!");
                }
                else if (!CheckRouteNumber(textBoxRouteNumber.Text))
                {
                    MessageBox.Show("Некоректный номер маршрута!");
                }
                else if (!CheckName(textBoxName.Text))
                {
                    MessageBox.Show("Некоректное имя водителя!");
                }
                else if (!CheckRepeat(textBoxNumberBus.Text, textBoxName.Text, textBoxRouteNumber.Text))
                {
                    MessageBox.Show("Такой набор данных уже существует");
                }
            }
        }

        bool CheckNumberBus(string text)
        {
            if (text.Length != 6)
            {
                return false;
            }
            if (char.IsLetter(text.ElementAt(0)) && char.IsNumber(text.ElementAt(1)) && char.IsNumber(text.ElementAt(2)) 
                && char.IsNumber(text.ElementAt(3)) && char.IsLetter(text.ElementAt(4)) && char.IsLetter(text.ElementAt(5)))
            {
                return true;
            }
            return false;
        }

        bool CheckRouteNumber(string text)
        {
            foreach (char item in text)
            {
                if (!char.IsNumber(item))
                {
                    return false;
                }
            }
            if (int.TryParse(text, out int result))
            {
                if (result < 1 || result > 999)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        bool CheckName(string text)
        {
            if (text.Length < 6 || text.Length > 35)
            {
                return false;
            }
            foreach (char item in text)
            {
                if (!char.IsLetter(item) && !char.IsWhiteSpace(item) && !char.IsPunctuation(item))
                {
                    return false;
                }
            }
            return true;
        }

        private bool CheckRepeat(string numberBus, string name, string numberRoute)
        {
            int numberBusRoute = int.Parse(numberRoute);
            foreach (var item in busFleet)
            {
                if (item.BusNumber == numberBus && item.Name == name && item.RouteNumber == numberBusRoute)
                {
                    return false;
                }
            }
            return true;
        }

        private void AddBus_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void textBoxNumberBus_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRouteNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}