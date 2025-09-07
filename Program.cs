using System;
using System.Diagnostics.CodeAnalysis;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(int.MaxValue);
            //int number = 10; //создаем переменную  
            //Console.WriteLine(number); //вывод переменной 
            /*Console.WriteLine("hello world!");*/ //вывод 

            ////считывать будем снизу с клавы имя 
            //Console.WriteLine("введите имя: "); //просим ввести имя
            //string name = Console.ReadLine(); //считываем что человек напишет  
            //Console.WriteLine($" Ваше имя {name}"); //мы показываем 

            //создать 3 переменные - имя возраст город и вывести
            //string nam = "denis";
            //int age = 10;
            //string city = "volgo";
            //Console.WriteLine($" Ваше имя {nam}");
            //Console.WriteLine($" Ваше возраст  {age}");
            //Console.WriteLine($" Ваше город {city}");
            //Console.WriteLine("Имя - {0} возраст - {1} город - {2}", nam, age, city);

            //Console.Write("Введите возраст ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine(age);

            //int num = 240;
            //long num2 = num;
            //Console.WriteLine(num2);

            //int num = 240;
            //byte num2 = (byte) num;
            //Console.WriteLine(num2);

            //int num = 240;
            //byte num2 = (byte)num;
            //Console.WriteLine(num2);

            //bool alive = true;
            //bool isDead = false;

            //double iDouble = 2.4;
            //float iFloat = 3.3f; //f пишем 
            //decimal idecimal = 34.34m;

            //object fgf = 'f', "fdd", 34; // обжиг но не 

            //var name = "ew"; //он сам решает какой это тип данных но есть нюанс присвоить значения обязательно 

            //символы 
            //char symbol = 'a';

            //Console.WriteLine(int.MinValue); //максимальное значения 



            //hellooooooooooo
            //Console.WriteLine();

            //Console.Write("ds"); //нет перехода на другую строку
            //Console.Write("dвы");


            //12 задания 
            //Console.Write("Введите ваше имя ");
            //string name = Console.ReadLine();
            //Console.Write("Введите ваш возраст ");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine($"ваше имя {name}");
            //Console.WriteLine($"ваш возраст{age}");
            //Console.WriteLine($"привет {name}");
            //Console.WriteLine($"Через год тебе {age+1}");

            //самостоятельные задания 

            //1 задания 
            //Console.Write("Введите ваше любимую игру/кино/ангиме ");
            //string kino = Console.ReadLine();
            //Console.Write("Введите вашу любимую цифру  ");
            //int age = int.Parse(Console.ReadLine());
            //Console.Write("Введите число пи   ");
            //int pii = int.Parse(Console.ReadLine());
            //Console.Write("Ваша любимая буква ");
            //string bykva = Console.ReadLine();

            //Console.WriteLine(kino);
            //Console.WriteLine(age);
            //Console.WriteLine(pii);
            //Console.WriteLine(bykva);


            //2 задания 
            //string ma = "i\nneed\nmore\npower!";//не хочет (
            //Console.WriteLine(ma);//а нет хочет)) \n 

            //3 задания
            //Console.WriteLine("\"hello there\"");

            //4 задания 
            //Console.Write("монитор:  ");
            //int monitor = int.Parse(Console.ReadLine());
            //Console.Write("блок: ");
            //int blok = int.Parse(Console.ReadLine());
            //Console.Write("клава: ");
            //int clava = int.Parse(Console.ReadLine());
            //Console.Write("мышь: ");
            //int mouse = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Сумма трех пк :{(monitor + blok + clava + mouse) * 3}");


            //5 задания
            //Console.WriteLine("Введите число а ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите число b ");
            //int b = int.Parse(Console.ReadLine());

            //int s = a + b;
            //Console.WriteLine($"{3 * Math.Pow(s, 3) + 275 * Math.Pow(b, 2) - 127 * a - 41}");

            //6 задания 
            //Console.Write("Введите ваше имя ");
            //string name = Console.ReadLine();
            //Console.Write("Введите ваш возрст ");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine($"\"Привет, {name}\"");
            //Console.WriteLine($"\"Сейчас тебе {age} лет\"");
            //Console.WriteLine($"\"В следущем году тебе будет {age + 1}\"");

            //7 задания 
            //string name = "Дарья";
            //int age = 100;
            //string city = "Волгоград";

            //Console.WriteLine($"Привет, {name}! Тебе {age} лет и ты живешь в городе {city}");
            //Console.WriteLine("Привет , {0}!  Тебе {1} лет и ты живешь в городе {2}", name, age, city); 

            //*8 задания 
            //Console.WriteLine("Ввнди температуру в градусах Цельсия"); //формула °F = (°C × 9/5) + 32
            //int uls = int.Parse(Console.ReadLine());

            ////сначала сделаем в скобаках
            //decimal num = 9m / 5m; //вот это было трудновато))) хотела 9.5м
            
            //decimal f = uls * num +32m; //тк num decimal - будет дробное число(
            //Console.WriteLine($"Фаренгейт: {f}");
        }
    }
}