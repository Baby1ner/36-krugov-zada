using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_krugov_zada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Задание 1. Вывести на экран число е");
            Console.WriteLine("e =  2,7");



            Console.WriteLine("Задание 2. Вывести на экран числа 50 и 10 одно под другим");
            Console.WriteLine("50");
            Console.WriteLine("10");



            Console.WriteLine("Задание 3. Вывести на экран 4 cлучайных числа столбиком");
            Random x228 = new Random();
            int n01234 = x228.Next();
            Console.WriteLine(n01234); // немного неудобно все заданияписать в 
            int n1234 = x228.Next();   // в одном коде тк кончаются удобные буквы
            Console.WriteLine(n1234);  // ^_^
            int n234 = x228.Next();
            Console.WriteLine(n234);
            int n34 = x228.Next();
            Console.WriteLine(n34);



            Console.WriteLine("Задание 4. Вывести число больше на 10 чем введеное");
            Console.WriteLine("Введите число");
            string a4 = Console.ReadLine();
            int a41 = Convert.ToInt32(a4);
            Console.WriteLine($"ваше число = {a41+10}");



            Console.WriteLine("Задание 5. Дана сторона квадрата найти периметр");
            Console.WriteLine("Введите число");
            string a5 = Console.ReadLine();
            int a51 = Convert.ToInt32(a5);
            int a52 = a51 * 4;
            Console.WriteLine($"периметр = {a52}");
            


            Console.WriteLine("Задание 6.Дан Радиус Найти длину окр и площадь");
            int a6 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Длина окружности = {a6*2*3.14} Площадь круга = {a6 * a6 * 3.14}");



            Console.WriteLine("Задание 7. Найти y=cos(x)");
            Console.WriteLine("Введите x");
            float x7 = float.Parse(Console.ReadLine());
            double y7 = Math.Cos(x7);
            Console.WriteLine($"y = {y7}");
            


            Console.WriteLine("Задание 8. Найти периметр равнобедренной трапеции ");
            Console.WriteLine("Введите высоту рб. Трап.");
            int visota8 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите большее основание рб. Трап.");
            int bolshosn8 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите меньшее основание рб. Трап.");
            int menshosn8 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Плщадь = {visota8 * ((bolshosn8+menshosn8)/2)}");
            


            Console.WriteLine("Задание 9. Найти стоимость всей покупки если известна цена товара");
            Console.WriteLine("Введите сколько куплено кг конфет по 50 руб за кг");
            float x9 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите сколько куплено кг печения по 35 руб за кг");
            float y9 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите сколько куплено кг яблок по 15 руб за кг");
            float z9 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Стоимость покупки ={x9*50 + y9*35 + z9*15}" );
            


            Console.WriteLine("Задание 10. код который выводит Мир Труд Май");
            Console.WriteLine("Мир " + "Труд " + "Май");
            Console.WriteLine("Мир");     // Считается ли это за читерство?
            Console.WriteLine("    Труд");
            Console.WriteLine("          Май");
            


            Console.WriteLine("Задание 11. Поменять местами переменные с учетом глупости человека");
            string chislo10 = Console.ReadLine();
            


            Console.WriteLine("Задание 12. В зависимости от фигуры вычислить площ или перим");
            Console.WriteLine("Если фигура правильный треугольник введите 1, если четырехугольник то 2, если круг 3");
            int figur12 = int.Parse(Console.ReadLine());
            Console.WriteLine("Если нужно найти периметр введите 1, площадь 2");
            int Naiti12 = int.Parse(Console.ReadLine());
            if (figur12 == 1)
            {
                Console.WriteLine("Введите сторону треугольника");
                float storon121 = float.Parse(Console.ReadLine());
                if (Naiti12 == 1)
                {
                    Console.WriteLine($"Периметр Треугольника = {storon121*3}");
                }else
                {
                    Console.WriteLine($"Площадь Треугольника = {storon121*storon121* 1.73/4}");
                }
            }
            if (figur12 == 3) ;
            {
                Console.WriteLine("Введите радиус круга");
                float storon123 = float.Parse(Console.ReadLine());
                if (Naiti12 == 1)
                {
                    Console.WriteLine($"Периметр Круга = {storon123 * 2 *3.14}");
                }
                else
                {
                    Console.WriteLine($"Площадь Круга = {storon123 * storon123 * 3.14}");
                }
            }
            


            Console.WriteLine("Задание 13. Вывод на экран число которое вводили с клавы");
            float a13 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Вы ввели число {a13}"); //А задания не по сложности чтоль?
            


            Console.WriteLine("Задание 14. программу вывода на экран следующей информации:");
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");
            


            Console.WriteLine("Задание 15. Вывести на экран 4 cлучайных числа столбиком");
            Random x15 = new Random();
            int n151 = x15.Next();
            Console.WriteLine(n151); // опять это задание ¯\_(ツ)_/¯ 
            int n152 = x15.Next();   // Very strange
            Console.WriteLine(n152);  
            int n153 = x15.Next();
            Console.WriteLine(n153);
            int n154 = x15.Next();
            Console.WriteLine(n154);


            
            Console.WriteLine("Задание 16. Найти корни квадратного уравнения");
            Console.WriteLine("Введите коэфицент а");
            float a16 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэфицент b");
            float b16 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэфицент c");
            float c16 = float.Parse(Console.ReadLine());
            if (b16 * b16 - 4 * a16 * c16 > 0) 
            {
                Console.WriteLine($"X1 = {(-b16 + Math.Sqrt(b16*b16 - 4*a16*c16))/(a16*2)}");
                Console.WriteLine($"X2 = {(-b16 - Math.Sqrt(b16 * b16 - 4 * a16 * c16)) / (a16 * 2)}");
            }
            if (b16 * b16 - 4 * a16 * c16 == 0) 
            {
                Console.WriteLine($" Одно решение X = {(-b16 + Math.Sqrt(b16 * b16 - 4 * a16 * c16)) / (a16 * 2)}");

            }
            if (b16 * b16 - 4 * a16 * c16 < 0)
            {
                Console.WriteLine("Нет решений :-/");
            }


            
            Console.WriteLine("Задание 17. Найти ср геометрическое и арифметическое 2 чисел");
            Console.WriteLine("Введите 1 число");
            float a171 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 число");
            float a172 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Cреднее арифметическое = {(a171+a172)/2}");
            Console.WriteLine($"Cреднее геометрическое = {Math.Sqrt(a171 * a172) }");


            
            Console.WriteLine("Задание 18. Найти расстояние между 2 точками плоскости");
            Console.WriteLine("Введите y1");
            float y181 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите x1");
            float x181 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите y2");
            float y182 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите x2");
            float x182 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Растояние между точками = {Math.Sqrt((x182 - x181) * (x182 - x181) + (y182 - y181) * (y182 - y181))}");


            
            Console.WriteLine("Задание 19.Составить программу обмена значениями трех переменных величин");
            Console.WriteLine("Введите число а");
            float a18 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b");
            float b18 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите число c");
            float c18 = float.Parse(Console.ReadLine());
            float ahelper18 = a18; //помошник
            float bhelper18 = b18; //помошник
            float chelper18 = c18; //помошник
            b18 = chelper18;  // номер а
            a18 = bhelper18;
            c18 = ahelper18;
            Console.WriteLine($"a) a = {a18} b = {b18} c = {c18}");
            b18 = ahelper18;  // номер б
            a18 = chelper18;
            c18 = bhelper18;
            Console.WriteLine($"a) a = {a18} b = {b18} c = {c18}");

              

            Console.WriteLine("Задание 20.С начала суток прошло n секунд. Определить:");
            Console.WriteLine("Cколько прошло секунд");
            int n20 = int.Parse(Console.ReadLine());
            Console.WriteLine($"а) Прошло {n20 / 3600} часа(ов)");
            int n201 = (n20 - ((n20 / 3600)*3600))/60;
            Console.WriteLine($"б) С начала часа прошло {n201} минут(ы)");
            int n202 = (n20 - (((((n20 / 3600) * 3600) / 60)*60)+n201*60));
            Console.WriteLine($"в) С начала минуты прошло {n202} секунд(ы)");

            

            Console.WriteLine("Задание 21.Дан прямоугольник сколько от него можно отрезать квадратов");
            Console.WriteLine($"Можно вырезать {543/130} квадрата");


            
            Console.WriteLine("Задание 22.Дано трехзначное число поменять местами 1 и последнюю цифру");
            Console.WriteLine("Введите число");
            int n22 = int.Parse(Console.ReadLine());
            int a22 = n22 % 10;
            Console.WriteLine($"Новое число = {(n22 / 10) + (a22 * 100)}");


            
            Console.WriteLine("Задание 23.Дано число >1000 найти число сотен и число тысяч");
            Console.WriteLine("Введите число");
            int a23 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Число сотен = {(a23/100)%10}");
            Console.WriteLine($"Число тысяч = {(a23 / 1000) % 10}");


            
            Console.WriteLine("Задание 24.Дано 4 значное число переделать его");
            Console.WriteLine("Введите число");
            string ak24 = Console.ReadLine();
            string chislo124 = char.ToString(ak24[0]);
            string chislo224 = char.ToString(ak24[1]);
            string chislo324 = char.ToString(ak24[2]);
            string chislo424 = char.ToString(ak24[3]);
            Console.WriteLine($"а)слева направо Число = {Convert.ToInt64(chislo424 + chislo324 + chislo224 + chislo124)}");
            Console.WriteLine($"б)перестановка первой и вотрой,третей и четвертой Число = {Convert.ToInt64(chislo224 + chislo124 + chislo424 + chislo324)}");
            Console.WriteLine($"в)перестановка 2 и 3 Число = {Convert.ToInt64(chislo124 + chislo324 + chislo224 + chislo424)}");
            Console.WriteLine($"г)перестановка 1 и 2 с 3 и 4 Число = {Convert.ToInt64(chislo324 + chislo424 + chislo124 + chislo224)}");


            
            Console.WriteLine("Задание 25. Из трехзначного числа x вычли его последнюю цифру. Когда результат разделили\r\nна 10, а к частному слева приписали последнюю цифру числа x, то получилось\r\nчисло n. Найти число x.");
            Console.WriteLine("Введите число такое что 100 < n < 999");
            string ak25 = Console.ReadLine();
            string chislo125 = char.ToString(ak25[0]);
            string chislo225 = char.ToString(ak25[1]);
            string chislo325 = char.ToString(ak25[2]);
            Console.WriteLine($" Число х = {Convert.ToInt64(chislo325 + chislo225 + chislo125)}");


            
            Console.WriteLine("Задание 26.Дано время, сказать на сколько сдвинулась градусов часовая стрелка");
            Console.WriteLine("Введите сколько часов прошло 0 < h < 23");
            int chas26 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сколько минут прошло 0 < h < 60");
            int min26 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сколько секунд прошло 0 < h < 60");
            int sec26 = int.Parse(Console.ReadLine());
            if (chas26 < 12)
            {
                Console.WriteLine($"Стрелка прошла {(chas26 * 30) + (min26 * 0.5) + (sec26 * 0.00833)} градусов");

            }
            if (chas26 >= 12)
            {
                Console.WriteLine($"Стрелка прошла {((chas26-12) * 30) + (min26 * 0.5) + (sec26 * 0.00833)} градусов");

            }


            */
























        }
    }
}
