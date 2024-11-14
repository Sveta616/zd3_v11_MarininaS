using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Zadanie3_v11
{

    public partial class Form1 : Form
    {
        // Список пассажирских самолетов
        private List<PassangerAiroplane> passangersList = new List<PassangerAiroplane>();
        // Список самолетов
        private List<Airoplane> airoplaneList = new List<Airoplane>();



        public Form1()
        {
            InitializeComponent();

        }
        // Метод проверки заполненности поля
        private bool ProverkaOfSpace(string p)
        {
            if (string.IsNullOrWhiteSpace(p))
            {
                MessageBox.Show("Заполните все поля");
                return false;
            }
            return true;
        }
        //Метод проверки на буквы
        private bool ProverkaOfLetter(string str)
        {

            if (!char.IsUpper(str[0]))
            {
                MessageBox.Show("Поля с текстовым вводом должны начинаться с заглавной буквы");
                return false;
            }
            for (int i = 1; i < str.Length; i++)
            {
                if (!char.IsLower(str[i]))
                {
                    MessageBox.Show("Поля с текстовым вводом должны содержать только буквы, начиная с заглавной");
                    return false;
                }
            }
            return true;
        }
        //Метод проверки на цифры
        private bool ProverkaOfDigit(string num)
        {
            if (!num.All(char.IsDigit))
            {
                MessageBox.Show("Номер пилота содержит только цифры");
                return false;
            }
            return true;
        }


        // Кнопка для добавления объекта
        private void AddObject_Click(object sender, EventArgs e)
        {

            double probeg = Convert.ToDouble(ProbegNumeric.Value);
            int capacity = Convert.ToInt32(CapacitylNumeric.Value);
            double distance = Convert.ToDouble(DistanceNumeric.Value);
            string pynkt = PynktText.Text;
            string num = NumText.Text;

            if (!ProverkaOfSpace(pynkt) || !ProverkaOfSpace(num))
            {
                return;
            }
            if (!ProverkaOfLetter(pynkt))
            {
                return;
            }
            if (!ProverkaOfDigit(num))
            {
                return;
            }

            if (Airoplane.IsUniqueAir(num))
            {
                Airoplane.AddAiroplane(probeg, capacity, distance, pynkt, num);
                UpdateListBox();
                AddPass.Enabled = true;
                MessageBox.Show("Самолет успешно добавлен");
            }
            else
            {
                MessageBox.Show("Самолет с таким номером уже существует");
            }
        }
        // Метод обновления списка самолетов
        private void UpdateListBox()
        {
            AiroplaneList.Items.Clear();
            foreach (var airoplane in Airoplane.GetAllAiroplanes())
            {
                AiroplaneList.Items.Add(airoplane.ToString());
            }

        }
        // Отключение кнопки добавления пассажирского самолета при загрузке формы
        private void Form1_Load(object sender, EventArgs e)
        {
            AddPass.Enabled = false;
        }
        // Кнопка для добавления пассажирского самолета
        private void AddPass_Click(object sender, EventArgs e)
        {
            double probeg = Convert.ToDouble(ProbegNumeric.Value);
            int capacity = Convert.ToInt32(CapacitylNumeric.Value);
            double distance = Convert.ToDouble(DistanceNumeric.Value);
            string pynkt = PynktText.Text;
            string num = NumText.Text;
            double p = Convert.ToDouble(PNumeric.Value);
            string serviseClass = ClassText.Text;
            string mark = MarkText.Text;
            int seats = Convert.ToInt32(Seats.Value);

            if (!ProverkaOfSpace(pynkt) || !ProverkaOfSpace(num) || !ProverkaOfSpace(serviseClass) || !ProverkaOfSpace(mark))
            {
                return;
            }
            if (!ProverkaOfLetter(pynkt) || !ProverkaOfLetter(serviseClass) || !ProverkaOfLetter(mark))
            {
                return;
            }
            if (!ProverkaOfDigit(num))
            {
                return;
            }
            if (PassangerAiroplane.IsUniquePass(num))
            {
                PassangerAiroplane newpass = new PassangerAiroplane(probeg, capacity, distance, pynkt, num, p, serviseClass, mark, seats);
                PassangerAiroplane.AddPass(newpass);    
                MessageBox.Show("Самолет успешно добавлен");
                UpdateListBoxPass();
           
            }
            else
            {
                MessageBox.Show("Самолет с таким номером уже существует");
            }


        }
        // Метод обновления списка пассажирских самолетов
        private void UpdateListBoxPass()
        {
            PassangerList.Items.Clear();
            foreach (var pass in PassangerAiroplane.GetAllPass())
            {
                PassangerList.Items.Add(pass.Value.ToString());
            }
        }
        // Кнопка для поиска пассажирского самолета по номеру пилота
        private void FindPass_Click(object sender, EventArgs e)
        {
            string num = NumFind.Text;
            PassangerAiroplane found = PassangerAiroplane.FindByNum(num);

            if (found != null)
            {
                MessageBox.Show($"Найден самолет с таким номером пилота: {found}");
            }
            else
            {
                MessageBox.Show("Самолёт с таким номером пилота не найден");
            }

        }
        // Кнопка для удаления самолета по номеру пилота
        private void RemoveObjectByNum_Click(object sender, EventArgs e)
        {
            string num = NumRemove.Text;

            if (!ProverkaOfSpace(num) || !ProverkaOfDigit(num))
            {
                return;
            }
                Airoplane.RemoveAiro(num);
                UpdateListBox();
                MessageBox.Show("Самолёт удалён");

        }
        // Кнопка для удаления самолета по индексу
        private void DelInd_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(DelIndex.Value);

   
            if (index >= 0 && index < Airoplane.GetAllAiroplanes().Count)
            {
                Airoplane.RemoveAiro(index);
                MessageBox.Show("Самолёт успешно удалён");
            }
            else
            {
                MessageBox.Show("Индекс вне диапазона!");
            }

            UpdateListBox();


        }
        // Кнопка для удаления самолетов по вместимости
        private void RemoveByCapacity_Click(object sender, EventArgs e)
        {

            int capacity = Convert.ToInt32(numericUpDown1.Value);
         

            if (capacity > 0)
            {

                List<Airoplane> allairo= Airoplane.GetAllAiroplanes();


                bool rez = Airoplane.RemoveAiro(allairo, capacity);
                if (rez)
                {
                    MessageBox.Show("Самолеты с вместимостью <= " + capacity + " уудалены");
                }
                else
                {
                    MessageBox.Show("Нет самолетов с вместимостью <=" + capacity);
                }
            }
            else
            {
                MessageBox.Show("Введите корректное значение для вместимости");
            }
            UpdateListBox();
        }
    }
}

    



