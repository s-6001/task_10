using System;

namespace task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool mistake = false;   //есть ошибка?
                Console.WriteLine("Вас приветствует программа перевода углов(градусы, минуты, секунды) в радианы.");
                Angle angle1 = new Angle(); //создаем экземпляр класса
                Console.WriteLine("Введите число градусов:");
                try
                {
                    angle1.gradus = Convert.ToDouble(Console.ReadLine());   //считываем число градусов
                }
                catch
                {
                    mistake = true;
                    Console.WriteLine("Число градусов введено некорректно.");
                    Console.WriteLine("Программа закрыта из-за ошибки.");
                    Console.WriteLine();
                }
                if (mistake == false)
                {
                    Console.WriteLine("Введите число минут:");
                    try
                    {
                        angle1.min = Convert.ToDouble(Console.ReadLine());  //считываем число минут
                        if (angle1.min < 0 || angle1.min >= 60) //если число минут отрицательно или больше 60
                        {
                            mistake = true;
                            Console.WriteLine("Число минут не может быть отрицательно и должно быть меньше 60.");
                            Console.WriteLine("Программа закрыта из-за ошибки.");
                            Console.WriteLine();
                        }
                    }
                    catch
                    {
                        mistake = true;
                        Console.WriteLine("Число минут введено некорректно.");
                        Console.WriteLine("Программа закрыта из-за ошибки.");
                        Console.WriteLine();
                    }
                }
                if (mistake == false)
                {
                    Console.WriteLine("Введите число секунд:");
                    try
                    {
                        angle1.sec = Convert.ToDouble(Console.ReadLine());  //считываем число секунд
                        if (angle1.sec < 0 || angle1.sec >= 60) //если число секунд отрицательно или больше 60
                        {
                            mistake = true;
                            Console.WriteLine("Число секунд не может быть отрицательно и должно быть меньше 60.");
                            Console.WriteLine("Программа закрыта из-за ошибки.");
                            Console.WriteLine();
                        }
                    }
                    catch
                    {
                        mistake = true;
                        Console.WriteLine("Число секунд введено некорректно.");
                        Console.WriteLine("Программа закрыта из-за ошибки.");
                        Console.WriteLine();
                    }
                }
                if (mistake == false)   //если ошибок нет, то выводим ответ
                {
                    angle1.ToRadians();
                    Console.WriteLine();
                }
            }
        }
    }

    class Angle //класс
    {
        public double gradus;
        public double min;
        public double sec;

        public Angle(double gradus = 0, double min = 0, double sec = 0) //конструктор
        {
            this.gradus = gradus;
            this.min = min;
            this.sec = sec;
        }

        public void ToRadians()
        {
            if (gradus >= 0)
            {
                Console.WriteLine("Десятичное значение угла: {0}", (gradus + min / 60 + sec / 3600) * Math.PI / 180); //если угол положительный
            }
            else
            {
                Console.WriteLine("Десятичное значение угла: {0}", (gradus - min / 60 - sec / 3600) * Math.PI / 180); //если угол отрицательный
            }
        }
    }
}