using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie3_v11
{
   
    public class PassangerAiroplane:Airoplane

    {
        // Статический словарь для хранения экземпляров 
        private static Dictionary<string, PassangerAiroplane> pas = new Dictionary<string, PassangerAiroplane>();
        //Поле
        double p;
        //Свойства
        public string ServiseClass { get; set; }
        public string Mark { get; set; }
        public int Seats { get; set; }
        //Свойство для доступа к переменной
        public double P
        {
            get { return p; }
            set { p = value; }
        }

        // Конструктор
        public PassangerAiroplane(double probeg, int сapacity, double distance, string pynkt, string num, double p, string serviseClass, string mark, int seats)
            : base( probeg,  сapacity,  distance, pynkt,  num)
        {
            this.p = p;
            ServiseClass = serviseClass;
            Mark = mark;
            Seats = seats;
        }
        // Метод для получения всех пассажирских самолётов
        public static Dictionary<string, PassangerAiroplane> GetAllPass()
        {
            return pas;
        }
        // Метод для добавления пассажирского самолёта в словарь
        public static void AddPass(PassangerAiroplane passan)
        {

            pas[passan.Num] = passan;


        }

        // Метод для проверки уникальности номера пилота пассажирского самолёта
        public static bool IsUniquePass(string num)
        {
            return !pas.ContainsKey(num);
        }

        // Метод для поиска пассажирского самолёта по номеру пилота
        public static PassangerAiroplane FindByNum(string num)
        {
            if (pas.TryGetValue(num, out PassangerAiroplane pass))
            {
                return pass;
            }
            return null;
        }
        // Переопределение метода ToString для вывода информации
        public override string ToString()
        {
            return base.ToString() + $"; Класс обслуживания: {ServiseClass}; Марка самолёта: {Mark}; Кол-во сидений= {Seats}; Срок эксплуатации= {P}";
        }
        // Переопределение метода качества для пассажирского самолёта
        public override double Q()
        {
            double Qp= base.Q();
            if (p < 10)
            {
                return Qp / 1.05 * p;
            }
            else if (p < 25)
            {
                return Qp / 1.15 * p;
            }
            else
            {
                return Qp/ 1.30 * p;
            }
        }
        // Метод, который возвращает значение Q из базового класса
        public double QpOutBase()
        {
            return base.Q();
        }

    }

  }
