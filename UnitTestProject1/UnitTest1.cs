using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;

using Zadanie3_v11;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //МОДУЛЬГНЫЕ ТЕСТЫ БАЗОВОГО КЛАССА

        //Метод проверки корректности добавления объекта самолета по параметрам
        /*       [TestMethod]
               public void AddAiroplane1Test()
               {

                   double probeg = 1000;
                   int capacity = 150;
                   double distance = 2000;
                   string pynkt = "Москва";
                   string num = "456";

                   Airoplane.AddAiroplane(probeg, capacity, distance, pynkt, num);

                   Assert.AreEqual(1, Airoplane.GetAllAiroplanes().Count, "Количество самолетов должно быть 1 после добавления");
                   var add= Airoplane.GetAllAiroplanes()[0];
                   Assert.AreEqual(probeg, add.Probeg, "Пробег добавленного самолета должен совпадать");
                   Assert.AreEqual(capacity, add.Capacity, "Вместимость добавленного самолета должна совпадать");
                   Assert.AreEqual(distance, add.Distance, "Дистанция добавленного самолета должна совпадать");
                   Assert.AreEqual(pynkt, add.Pynkt, "Пункт назначения добавленного самолета должен совпадать");
                   Assert.AreEqual(num, add.Num, "Номер добавленного самолета должен совпадать");
               }*/

        //Метод проверки корректности добавления объектов самолета по уникальному номеру пилота
        [TestMethod]
        public void TestAddUnicNum()
        {

            string num = "456";
            Airoplane.AddAiroplane(new Airoplane(100, 2, 500, "Москва", num));
            Airoplane.AddAiroplane(new Airoplane(200, 2, 600, "Москва", num));

            bool isUnique = Airoplane.IsUniqueAir(num);


            Assert.IsFalse(isUnique, "Должен быть только один самолет с номером 456");
        }
        //Метод проверки корректности добавления объектов самолета
        [TestMethod]
        public void TestAddAiroplane()
        {

            var count = Airoplane.GetAllAiroplanes().Count;
            var newAiroplane = new Airoplane(1000, 170, 30, "Москва", "123");


            Airoplane.AddAiroplane(newAiroplane);
            var updated = Airoplane.GetAllAiroplanes().Count;


            Assert.AreEqual(count + 1, updated);
        }
        //Метод проверки корректности удаления объектов самолета по вместимости

        [TestMethod]
        public void RemoveAiroplaneToCapacityTest()
        {
            var airoList = new List<Airoplane>
           {
            new Airoplane(100, 2, 500, "Москва", "123"),
            new Airoplane(200, 5, 600, "Москва", "456"),
            new Airoplane(300, 10, 700, "Москва", "111")
           };

            int capacity = 5; // Удаление если вместимость <= 5


            bool rez = Airoplane.RemoveAiro(airoList, capacity);


            Assert.IsTrue(rez, "Метод должен вернуть true, если были удалены самолеты");
            Assert.AreEqual(1, airoList.Count, "Количество самолетов должно быть 1 после удаления");
            Assert.IsFalse(airoList.Exists(a => a.Capacity <= capacity), "Самолеты с вместимостью <= 5 должны быть удалены");
        }
        //Метод проверки корректности удаления объектов самолета
        [TestMethod]
        public void TestRemoveAiroplane()
        {

            var airoplane = new Airoplane(1000, 170, 30, "Москва", "123");
            Airoplane.AddAiroplane(airoplane);
            var count = Airoplane.GetAllAiroplanes().Count;


            Airoplane.RemoveAiro(airoplane.Num);
            var updated = Airoplane.GetAllAiroplanes().Count;


            Assert.AreEqual(count - 1, updated);
        }

        //Метод проверки уникальности самолетов
        [TestMethod]
        public void TestIsUniqueAir()
        {

            var airoplane1 = new Airoplane(1000, 180, 20, "Москва", "123");
            var airoplane2 = new Airoplane(1000, 100, 30, "Ростов", "111");
            Airoplane.AddAiroplane(airoplane1);
            Airoplane.AddAiroplane(airoplane2);


            var isUnique1 = Airoplane.IsUniqueAir("123");
            var isUnique2 = Airoplane.IsUniqueAir("111");

            Assert.IsFalse(isUnique1);
            Assert.IsFalse(isUnique2);
        }
        //Метод проверки корректности удаления самолетов по индексу
        [TestMethod]
        public void RemoveAiroplaneTest()
        {
            var airoplane1 = new Airoplane(1000, 170, 20, "Москва", "123");
            var airoplane2 = new Airoplane(2000, 180, 25, "Ростов", "456");
            var airoplane3 = new Airoplane(1500, 160, 30, "Екатеринбург", "789");


            Airoplane.AddAiroplane(airoplane1);
            Airoplane.AddAiroplane(airoplane2);
            Airoplane.AddAiroplane(airoplane3);


            Assert.AreEqual(3, Airoplane.GetAllAiroplanes().Count, "Количество самолетов должно быть 3 перед удалением");

            int index = 1;


            Airoplane.RemoveAiro(index);


            Assert.AreEqual(2, Airoplane.GetAllAiroplanes().Count, "Количество самолетов должно быть 2 после удаления");
            Assert.IsFalse(Airoplane.GetAllAiroplanes().Exists(a => a.Num == "456"), "Самолет с номером 456 должен быть удален");

        }

        //Метод проверки корректности расчётов качества самолета
        [TestMethod]
        public void TestQ()
        {
            Airoplane airplane = new Airoplane(1000, 180, 20, "Москва", "123");
            airplane.Q();
            Assert.AreEqual(9000, airplane.Q());
        }
        //Метод проверки корректности вывода информации об объектах самолета
        [TestMethod]
        public void StringMethodTest()
        {

            var airoplane = new Airoplane(1000, 170, 20, "Москва", "123");
            string output = $"Пробег= 1000; Вместимость= 170; Расходы на км= 20; Пункт назначения: Москва; Номер пилота: 123; Q= {Math.Round(airoplane.Q(), 2)}";


            string infostr = airoplane.ToString();


            Assert.AreEqual(output, infostr, "Метод ToString() должен возвращать корректное строковое представление.");
        }







        //МОДУЛЬНЫЕ ТЕСТЫ КЛАССА НАСЛЕДНИКА


        //Метод проверки корректности добавления пассажирских самолетов
        [TestMethod]
        public void AddPassTest()
        {

            var passenger = new PassangerAiroplane(12, 12, 3, "Москва", "123", 2, "Бизнес", "Boeling", 200);


            PassangerAiroplane.AddPass(passenger);


            Assert.AreEqual(1, PassangerAiroplane.GetAllPass().Count, "Количество пассажиров должно быть 1 после добавления");
            Assert.IsTrue(PassangerAiroplane.GetAllPass().ContainsKey(passenger.Num), "Пассажир с номером 123 должен быть добавлен");
        }
        //Метод проверки уникальности пассажирских самолетов
        [TestMethod]
        public void IsUniquePassTest()
        {

            var airoplane1 = new PassangerAiroplane(12, 12, 3, "Москва", "123", 2, "Бизнес", "Boeling", 200);
            var airoplane2 = new PassangerAiroplane(12, 12, 3, "Москва", "111", 2, "Бизнес", "Boeling", 200);
            PassangerAiroplane.AddPass(airoplane1);
            PassangerAiroplane.AddPass(airoplane2);


            var isUnique1 = PassangerAiroplane.IsUniquePass("123");
            var isUnique2 = PassangerAiroplane.IsUniquePass("111");


            Assert.IsFalse(isUnique1);
            Assert.IsFalse(isUnique2);

        }
        //Метод проверки корректности нахождения объекта пассажирского самолета по номеру пилота
        [TestMethod]
        public void FindByNumTest()
        {

            var passanger = new PassangerAiroplane(12, 12, 3, "Москва", "123", 2, "Бизнес", "Boeling", 200);
            PassangerAiroplane.AddPass(passanger);


            var rez = PassangerAiroplane.FindByNum("123");

            Assert.IsNotNull(rez, "Метод должен вернуть объект для существующего номера");
            Assert.AreEqual(passanger.Num, rez.Num, "Номера должны совпадать");
        }
        //Метод проверки поиска при несуществующем номере пилота 
        [TestMethod]
        public void FindByNumTest2()
        {

            var rez = PassangerAiroplane.FindByNum("12345678");


            Assert.IsNull(rez, "Метод должен вернуть null для несуществующего номера");
        }
        //Метод проверки корректности расчётов качества пассажирского самолета
        [TestMethod]
        public void TestQp()
        {
            PassangerAiroplane pass = new PassangerAiroplane(12, 12, 10, "Москва", "123", 5, "Бизнес", "Boeling", 200);

            double result = pass.Q();


            double baseQ = (pass.QpOutBase() / 1.05) * 5;

            Assert.AreEqual(baseQ, result, "Метод Q должен возвращать значение для p < 10.");


        }
        //Метод проверки корректности вывода информации об объектах пассажирского самолета
        [TestMethod]
        public void ToStringAiroPassTest()
        {
        
            var pass= new PassangerAiroplane(12, 12, 3, "Москва", "123", 2, "Бизнес", "Boeling", 200);

           
            string expectedString = $"Пробег= 12; Вместимость= 12; Расходы на км= 3; Пункт назначения: Москва; Номер пилота: 123; Q= 91,43; Класс обслуживания: Бизнес; Марка самолёта: Boeling; Кол-во сидений= 200; Срок эксплуатации= 2";

     
            Assert.AreEqual(expectedString, pass.ToString(), "Метод ToString() должен возвращать корректную строку с информацией о самолете.");

        }
    }
}

