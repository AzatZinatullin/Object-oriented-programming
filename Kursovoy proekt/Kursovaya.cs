using System;

namespace Project 
{
    public class Test
    {
        public class Apartment                      // Объявляется базовый класс "квартира"
        {
            public int NumberOfRooms;               // Кол-во комнат
            protected double AreaOfApartment;       // Площадь квартиры
            protected int Floor;                    // Этаж
            protected string TypeOfHouse = "none";  // Тип дома
            protected double Price = 0.0d;          // Цена

            public Apartment(){}                    // Конструктор по умолчанию

            public Apartment(double AreaOfApartment, int Floor, int NumberOfRooms)  // Конструктор инициализирует поля класса
            {
                this.NumberOfRooms = NumberOfRooms;     
                this.AreaOfApartment = AreaOfApartment;
                this.Floor = Floor;
            }

            public void SetPriceAndType(string TypeOfHouse, double Price)   // Метод инициализирует 2 других поля (по желанию пользователя)
            {
                this.TypeOfHouse = TypeOfHouse;
                this.Price = Price;
            }

            public virtual void GetApartment()      // Метод выводит на экран все инициализированные поля класса
            {
                Console.WriteLine("\nApartment characteristics.");
                Console.WriteLine("Number of rooms: " + NumberOfRooms);
                Console.WriteLine("Area of apartment: " + AreaOfApartment);
                Console.WriteLine("Floor: " + Floor);

                if(TypeOfHouse!="none")             // Если пользователь инициализировал данное поле, то вывести его на экран
                    Console.WriteLine("Type of House: " + TypeOfHouse);
                if(Price!=0.0d)
                    Console.WriteLine("Price: " + Price + "$.");
            }
        }
        
        public class OneRoomApartment : Apartment           // Класс "однокомнатная квартира"" является наследником класса "квартира"
        {
            protected double AreaOfKitchen;                 // Площадь кухник
            protected double AreaOfRoom;                    // Площадь комнаты
            protected double AreaOfBathroomAndWC = 9.9d;    // Площадь ванной комнаты и туалета

            public OneRoomApartment(){}                     // Конструктор по умолчанию

            public OneRoomApartment(double AreaOfApartment, double AreaOfRoom, int Floor)   // Конструктор инициализирует поля класса
            {
                this.NumberOfRooms = 1;                     // Кол-во комнат инициализируем значением "1"
                this.AreaOfApartment = AreaOfApartment;     
                this.Floor = Floor;
                this.AreaOfRoom = AreaOfRoom;
                this.AreaOfKitchen = AreaOfApartment - AreaOfRoom - AreaOfBathroomAndWC;   // Значение площади кухни
            }

            public override void GetApartment()             // Переопределенный метод базового класса для вывода дополнительных полей
            {
                Console.WriteLine("\nOne-room apartment characteristics.");
                Console.WriteLine("Number of rooms: " + NumberOfRooms);
                Console.WriteLine("Area of apartment: " + AreaOfApartment);
                Console.WriteLine("Area of room: " + AreaOfRoom);
                Console.WriteLine("Area of kitchen: " + AreaOfKitchen);
                Console.WriteLine("Floor: " + Floor);
                if(TypeOfHouse!="none")
                    Console.WriteLine("Type of House: " + TypeOfHouse);
                if(Price!=0.0d)
                    Console.WriteLine("Price: " + Price + "$.");
            }
        }

        public class VipApartment : Apartment           // Класс "вип квартира" наследуется от базового "квартира"
        {
            bool Loggia = false;                        // По умолчанию лоджии нет
            bool VipApartmentDecoration = true;         // Вип отделка включена изначально

            public VipApartment(){}                     // Конструктор по умолчанию

            public VipApartment(double AreaOfApartment, int NumberOfRooms, int Floor, bool Loggia) 
            {   
                // Конструктор инициализирует поля класса
                this.NumberOfRooms = NumberOfRooms;
                this.AreaOfApartment = AreaOfApartment;
                this.Floor = Floor;
                this.Loggia = Loggia;                   
            }

            public override void GetApartment()         // Переопределенный метод вывода полей класса на экран
            {
                Console.WriteLine("\nVip apartment characteristics.");

                if(VipApartmentDecoration && Loggia)    // Если вип отделка и лоджия включены, то квартира "супер вип"
                    Console.WriteLine("Super Vip! (Loggia and vip-decoration)");
                Console.WriteLine("Number of rooms: " + NumberOfRooms);
                Console.WriteLine("Area of apartment: " + AreaOfApartment);
                Console.WriteLine("Floor: " + Floor);
                if(TypeOfHouse!="none")
                    Console.WriteLine("Type of House: " + TypeOfHouse);
                if(Price!=0.0d)
                    Console.WriteLine("Price: " + Price + "$.");
            }
        }

        public class ApartmentRegion : OneRoomApartment // Второй уровень иерархии (данный класс наследуется от однокомнатной квартиры)
        {
            protected string Region;        // Поле "регион"

            public ApartmentRegion(){}      // Конструктор по умолчанию

            public ApartmentRegion(double AreaOfApartment, double AreaOfRoom, int Floor, string Region)  
            {
                // Конструктор инициализирует поля класса
                this.NumberOfRooms = 1;
                this.AreaOfApartment = AreaOfApartment;
                this.Floor = Floor;
                this.AreaOfRoom = AreaOfRoom;
                this.AreaOfKitchen = AreaOfApartment - AreaOfRoom - AreaOfBathroomAndWC;
                this.Region = Region;
            }

            public override void GetApartment()         // Переопределенный метод вывода параметров на экран
            {
                Console.WriteLine("\nOne-room apartment characteristics (with Region).");
                Console.WriteLine("Region: " + Region);
                Console.WriteLine("Number of rooms: " + NumberOfRooms);
                Console.WriteLine("Area of apartment: " + AreaOfApartment);
                Console.WriteLine("Area of room: " + AreaOfRoom);
                Console.WriteLine("Area of kitchen: " + AreaOfKitchen);
                Console.WriteLine("Floor: " + Floor);
                if(TypeOfHouse!="none")
                    Console.WriteLine("Type of House: " + TypeOfHouse);
                if(Price!=0.0d)
                    Console.WriteLine("Price: " + Price + "$.");
            }
        }

        public static void Main()
        {
            Apartment A1 = new Apartment(65.4d, 12, 2);     // Создается объект класса квартира, инициализируются поля
            A1.GetApartment();                              // Вывод значения полей на экран
            A1.SetPriceAndType("Panel", 80000.5d);          // Инициализация двух дополнительных полей
            A1.GetApartment();                              // Вывод значения полей на экран

            // Создается объект класса однокомнатная квартира, инициализируются поля
            OneRoomApartment A2 = new OneRoomApartment(38.5d, 17.8d, 5);  
            A2.GetApartment();                              // Вывод значения полей на экран

            VipApartment A3 = new VipApartment(115.8d, 4, 10, true);   // Создается объект класса вип квартира, инициализируются поля
            A3.SetPriceAndType("Brick", 310000.8d);         // Инициализация двух дополнительных полей
            A3.GetApartment();                              // Вывод значения полей на экран

            // Создается объект класса, являющегося наследником класса однокомнатная квартира, инициализируются поля
            ApartmentRegion A4 = new ApartmentRegion(40.4d, 19.3, 1, "Leningrad Oblast");
            A4.GetApartment();                              // Вывод значения полей на экран
            
        }   
    }
}