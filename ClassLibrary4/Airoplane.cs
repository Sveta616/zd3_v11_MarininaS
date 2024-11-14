using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zadanie3_v11
{
  public class Airoplane
    {
        // Статический список со всеми экземплярами
        private static List<Airoplane> airoplanes = new List<Airoplane>();
        //Поля 
        double probeg;
         int capacity;
         double distance;
         string num;
         string pynkt;
        //Свойства для доступа к полям класса
        public double Probeg
        {
            get { return probeg; }
            set { probeg = value; }
        }
        public int Capacity
        { 
            get { return capacity; }
            set { capacity = value; }
        }
        public double Distance
        {
            get { return distance; }
            set { distance = value; }
        }
        public string Num
        {
            get { return num; }
            set { num = value; }
        }
        public string Pynkt
        {
            get { return pynkt; }
            set { pynkt = value; }
        }
        // Конструктор
        public Airoplane(double probeg, int capacity, double distance, string pynkt, string num)
        {
            this.probeg = probeg;
            this.capacity = capacity;
            this.distance = distance;
            this.num = num;
            this.pynkt = pynkt;

        }
        // Метод для получения всех самолетов
        public static List<Airoplane> GetAllAiroplanes()
        {
            return airoplanes;
        }



        // Метод для добавления нового самолета с параметрами
        public static void AddAiroplane(double probeg, int capacity, double distance, string pynkt, string num)
        {
            Airoplane newairo = new Airoplane(probeg, capacity, distance, pynkt, num);
            AddAiroplane(newairo); 
        }
        // Метод для добавления экземпляра самолета 
        public static void AddAiroplane(Airoplane airoplane)
        { 
                airoplanes.Add(airoplane);
         
        }




        // Метод для проверки уникальности номера пилота у самолета
        public static bool IsUniqueAir(string num)
         {

            return !airoplanes.Any(a => a.Num == num);

         }



        // Метод для удаления самолета по индексу
        public static void RemoveAiro(int index)
        {
           
                airoplanes.RemoveAt(index);
             
           
        }
        // Метод для удаления самолетов по вместимости
        public static bool RemoveAiro(List<Airoplane> airoList, int capacity)
        {
            int remove = airoList.RemoveAll(c => c.capacity <=capacity);
            return remove > 0;

        }
        // Метод для удаления самолета по номеру
        public static void RemoveAiro(string num)
        {
            var airoplane= airoplanes.FirstOrDefault(a => a.Num.Equals(num));
         
                airoplanes.Remove(airoplane);
             
            
           
        }
        // Метод для вычисления качества
        public virtual double Q()
        {
            return (probeg * capacity) / distance;
        }
        // Переопределение метода ToString для отображения информации
        public override string ToString()
        {
            return $"Пробег= {probeg}; Вместимость= {capacity}; Расходы на км= {distance}; Пункт назначения: {pynkt}; Номер пилота: {num}; Q= {Math.Round(Q(), 2)}";
        }




    }

}

