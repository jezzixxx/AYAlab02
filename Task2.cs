//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace lab02
//{
//    internal class Task2
//    {
//        private static void Main()
//        {
//            Vechicle bus = new Vechicle(100, 70, 2010,"Автобус");
//            Car car = new Car(160, 90, 2022,"Машина");
//            Plane plane = new Plane(4000, 350, 2014, "Самолёт", 2000, 9);
//            Ship ship = new Ship(70, 40, 2007, "Корабль", "Владивосток", 10);
//            bus.Info();
//            car.Info();
//            plane.Info();
//            ship.Info();
//        }
//    }
//    public class Ship : Vechicle
//    {
//        private int _nums;
//        private string _port;
//        public Ship(int price, int speed, int year, string name, string port, int nums) : base(price, speed, year, name)
//        {
//            _port = port;
//            _nums = nums;
//        }
//        protected override void WriteInfo()
//        {
//            base.WriteInfo();
//            Console.WriteLine($"Порт приписки: {_port}\nЧисло пассажиров: {_nums}");

//        }
//    }
//    public class Plane : Vechicle
//    {
//        private int _high, _nums;
//        public Plane(int price, int speed, int year, string name, int high, int nums) : base(price, speed, year, name)
//        {
//            _high = high;
//            _nums = nums;
//        }
//        protected override void WriteInfo()
//        {
//            base.WriteInfo();
//            Console.WriteLine($"Высота: {_high}м\nЧисло пассажиров: {_nums}");

//        }
//    }
//    public class Car : Vechicle
//    {
//        public Car(int price, int speed, int year, string name) : base(price, speed, year, name) { }

//    }
//    public class Vechicle
//    {
//        private int _price, _speed, _year;
//        private string _name;
//        public Vechicle(int price, int speed, int year, string name)
//        {
//            _price = price;
//            _speed = speed;
//            _year = year;
//            _name = name;
//        }
//        public void Info() => WriteInfo();
//        protected virtual void WriteInfo()
//        {
//            Console.WriteLine($"\n{_name}\nЦена: {_price}000$\nСкорость: {_speed}км/ч\nГод выпуска: {_year}");
//        }
//    }
//}
