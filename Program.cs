using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    //page 44 
    // Первая простая програма
    /*class Program_1_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Простая програма на C#");
        }
    }*/

    //page 54
    // вказування на нейспейс
    /*class Program_1_2
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hi");
            Console.ReadKey();
        }
    }*/
    /*class Program_1_3
    {
        static void Main(string[] args)
        {
            int x;
            int y;

            x = 100;

            Console.WriteLine("x содержит "+x);
            y = x / 2;

            Console.Write("y содержит х/2: ");
            Console.Write(y);
            Console.ReadKey();
        }
    }*/

    //page 57
    // типи даних як float та double
    /*class Program_1_4
    {
        static void Main(string[] args)
        {
            int ivar;
            double dvar;

            ivar = 100;

            dvar = 100.0;

            Console.WriteLine("Исходное значение ivar: "+ivar);
            Console.WriteLine("Исходное значение dvar: "+dvar);

            Console.WriteLine();

            ivar /= 3;
            dvar /= 3.0;

            Console.WriteLine("Значение ivar после деления: "+ivar);
            Console.WriteLine("Значение dvar после деления: "+dvar);
            Console.ReadKey();
        }
    }*/


    //page 58
    //вичисляэм площу круга
    /*class Program_1_5
    {
        static void Main(string[] args)
        {
            double radius;
            double area;

            radius = 10.0;

            area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("Площадь равна "+area);
            Console.ReadKey();
        }
    }*/

    //page 59
    // продемонстрировать применение условного оператора if
    /*class Program_1_6
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = 2;
            b = 3;

            if (a < b) Console.WriteLine("a меньше b");

            if (a == b) Console.WriteLine("этого никто не увидит");

            Console.WriteLine();

            c = a - b;

            Console.WriteLine("c содержит -1");
            if (c >= 0) Console.WriteLine("значение с неотрицательно");
            if (c < 0) Console.WriteLine("значение с отрицательно");

            Console.WriteLine();

            c = b - a;
            Console.WriteLine("с содержит 1");
            if (c >= 0) Console.WriteLine("значение с неотрицательно");
            if (c < 0) Console.WriteLine("значение с отрицательно ");
            Console.ReadKey();
        }
    }*/

    //page 61
    //Продемонстрировать применение оператора цикла for
    /*class Program_1_7
    {
        static void Main(string[] args)
        {
            int count;
            for (count = 0; count < 5; count += 1)
            {
                Console.WriteLine("Это подсчет: "+count);
            }
            Console.WriteLine("Готово!");
        }
    }*/

    //page 62
    //Продемострировать применение кодовoго блока
    /*class Program_1_8
    {
        static void Main(string[] args)
        {
            int i, j, d;

            i = 5;
            j = 10;

            if (i != 0)
            {
                Console.WriteLine("i не равно нулю");
                d = j / i;
                Console.WriteLine("j/i равно "+d);
            }
            Console.ReadKey();
        }

    }*/
    //page 63
    //Вычислить сумму и произведение чисел от 1 до 10
    /*class Program_1_9
    {
        static void Main(string[] args)
        {
            int prod;
            int sum;
            int i;            
            

            sum = 0;
            prod = 1;

            for (i = 1; i <= 10; i++)
            {
                sum = sum + i;
                prod = prod * i;
            }

            Console.WriteLine("Сумма равна "+sum);
            Console.WriteLine("Произведение равно "+prod);
            Console.ReadKey();
        }
    }*/

    //page 66
    //Продемострировать применение идентификатора со знаком @
    /*class Program_1_10
    {
        static void Main(string[] args)
        {
            int @if;
            for (@if = 0; @if < 10; @if++)
                Console.WriteLine("@if равно "+@if);
            Console.ReadKey();
        }
    }*/

    //page 70
    //Вычислить расстояние от Земли до Солнца в дюймах
    /*class Program_1_11
    {
        static void Main(string[] args)
        {
            long miles;
            long inches;

            miles = 93000000;

            inches = miles * 5280 * 12;

            Console.WriteLine("Расстояние до Солнца: "+inches+" дюймов");
            Console.ReadKey();
        }
    }*/

    //page 70
    // Использовать тип byte
    /* class Program_1_12
     {

         static void Main(string[] args)
         {
             byte x;
             int sum;

             sum = 0;

             for (x = 1; x <= 100; x++)
                 sum += x;

             Console.WriteLine("Сумма чисел от 1 до 100 равна "+sum);
             Console.ReadKey();
         }
     }*/

    //page 71
    // Определить радиус окружности по площади круга
    /*class Program_1_13
    {
        static void Main(string[] args)
        {
            double r;
            double area;

            area = 10.0;

            r = Math.Sqrt(area / Math.PI);

            Console.WriteLine("РАдиус равен: "+r);
            Console.ReadKey();
        }
    }*/

    //page 71
    // Продемострировать примененеи тригонометрических функций
    /*class Program_1_14
    {
        static void Main(string[] args)
        {
            double theta;

            for (theta = 0.1; theta <= 1.0; theta += 0.1)
            {
                Console.WriteLine("Синус угла "+ theta +" равен "+Math.Sin(theta));
                Console.WriteLine("Косинус угла "+theta + " равен "+Math.Cos(theta));
                Console.WriteLine("Тангенс угла " + " равен "+theta +Math.Tan(theta));
            }
            Console.ReadKey();
        }
    }*/

    //page 73
    // Использовать тип decimal для расчета скидки
    /*class Program_1_15
    {
        static void Main(string[] args)
        {
            decimal price;
            decimal discount;
            decimal discount_price;

            price = 19.95m;
            discount = 0.15m;

            discount_price = price - (price * discount);

            Console.WriteLine("Цена со скидкой: $"+discount_price);
            Console.ReadKey();
        }
    }*/

    //page 74
    // Применить тип decimal для расчета будущей стоимости капиталовложений
    /*class Program_1_16
    {
        static void Main(string[] args)
        {
            decimal amount;
            decimal rate_of_return;
            int years, i;

            amount = 1000.0m;
            rate_of_return = 0.07m;
            years = 10;

            Console.WriteLine("Первоначальные вложения: $"+amount);
            Console.WriteLine("Норма прибыли: "+rate_of_return);
            Console.WriteLine("В течение "+years+"лет");

            for (i = 0; i < years; i++)
                amount += (amount * rate_of_return);

            Console.WriteLine("Будущая стоимость равна $"+amount);
            Console.ReadKey();
        }
    }*/

    //page 78
    // Пременить команды форматирования
    /*class Program_1_17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Число\tКвадрат\tКуб");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}",i,i*i,i*i*i);
            }
            Console.ReadKey();
        }
    }*/

    //page 91
    //ПРодемострировать приведение типов
    /*class Program_1_18
    {
        static void Main(string[] args)
        {
            double x, y;
            byte b;
            int i;
            char ch;
            uint u;
            short s;
            long l;

            x = 10.0;
            y = 3.0;

            //приведение типа double к типу int,
            //пробная часть числа теряеться
            i = (int)(x / y);
            Console.WriteLine("Целочисленный результат деления x/y: "+i+"\n");

            //Преведение типа int к типу byte без потерь данных
            i = 255;
            b = (byte)i;
            Console.WriteLine("b после присваивания 255: "+b+"-- без потерь данных");

            //Приведение типа int к типу byte с потерей данных
            i = 257;
            b = (byte)i;
            Console.WriteLine("b после присваивания 257: "+b+" -- с потерей данных\n");

            //Приведение типа uint к типу short без потерь данных
            u = 32000;
            s = (short)u;
            Console.WriteLine("s после присваивания 32000: "+s+" -- без потери данных");

            //Приведение типа uint к типу short с потерей данных
            u = 64000;
            s = (short)u;
            Console.WriteLine("s после присваивания 64000: "+s+" -- с потерей данных\n");

            //Приведение типа long к типу uint без потери данных
            l = 64000;
            u = (uint)l;
            Console.WriteLine("u после присваивания 64000: "+u+" -- без потерь данных");

            //Приведение типа long к типу uint с потерей данных
            l = -12;
            u = (uint)l;
            Console.WriteLine("u после присвоивания -12: "+u+" -- с потерей данных\n");

            //Приведение типа byte к типу char 
            b = 88;// X
            ch = (char)b;
            Console.WriteLine("ch после присваивания 88: "+ch);

            Console.ReadKey();
        }
    }*/

    //page 103
    // Построение операции импликация в C#
    /*class Program_1_19
    {
        static void Main(string[] args)
        {
            bool p = false, q = false;

            // int i, j;

            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 2; j++) {
                    if (i == 0) p = true;
                    if (i == 1) p = false;
                    if (j == 0) q = true;
                    if (j == 1) q = false;

                    Console.WriteLine("p равно "+p+", q равно "+q);
                    if(!p|q)
                        Console.WriteLine("Результат импликации "+p+" и "+q+" равен "+true);
                    else
                        Console.WriteLine("Результат импликации " + p + " и " + q + " равен " + false);

                    
              }
            }
            Console.ReadKey();
        }
    }*/


    //page 105
    //Продемострировать значение побочных еффектов
    /*class Program_1_20
    {
        static void Main(string[] args)
        {
            int i;
            bool someCondition = false;

            i = 0;

            if(someCondition&(++i<100))
                Console.WriteLine("Не выводится");
            Console.WriteLine("Оператор if выполняется: "+i);

            if(someCondition&& (++i<100))
                Console.WriteLine("НЕ выводиться");
            Console.WriteLine("Оператор if выполняется: "+i);
            Console.ReadKey();
        }
    }*/


    //page 110
    //Показивает биты, составляющие байт
    /*class Program_1_21
    {
        static void Main(string[] args)
        {
            int t;
            byte val;

            val = 123;
            for (t = 128; t > 0; t /= 2)
            {
                if ((val & t) != 0) Console.Write("1");
                if ((val & t) == 0) Console.Write("0");
                
            }
            Console.ReadKey();
        }
    }*/

    //page 113
    //Проемонстрировать применение поразрядного оператора исключабщее ИЛИ
    /*class Program_1_21
    {
        static void Main(string[] args)
        {
            char ch1 = 'H';
            char ch2 = 'i';
            char ch3 = '!';
            int key = 88;

            Console.WriteLine("Исходное сообщение: "+ch1+ch2+ch3);

            //зашифровать сообщение
            ch1 ^= (char)key;
            ch2 ^= (char)key;
            ch3 ^= (char)key;



            Console.WriteLine("Зашифрованное сообщение: "+ch1+ch2+ch3);

            //Разшифровать сообщение 
            ch1 ^= (char)key;
            ch2 ^= (char)key;
            ch3 ^= (char)key;

            Console.WriteLine("Расшифрованное сообщение: "+ch1+ch2+ch3);

            Console.ReadKey();
        }
    }*/

    //page 115
    //Продемонстрировать применение операторов сдвига
    /*class Program_2_22
    {
        static void Main(string[] args)
        {
            int val = 1;

            for (int i = 0; i < 8; i++)
            {
                for (int t = 128; t > 0; t /= 2)
                {
                    if ((val & t) != 0) Console.Write("1");
                    if ((val & t) == 0) Console.Write("0");
                }
                Console.WriteLine();
                val <<= 1;
            }
            Console.WriteLine();

            val = 128;
            for (int i = 0; i < 8; i++)
            {
                for (int t = 128; t > 0; t /= 2)
                {
                    if ((val & t) != 0) Console.Write("1");
                    if ((val & t) == 0) Console.Write("0");
                }
                Console.WriteLine();
                val >>= 1;
            }
            Console.ReadKey();
        }
    }*/

    //page 119
    // Разделить только на четные, ненулевые значения
    /*class Program_2_23
    {
        static void Main(string[] args)
        {

            for (int i = -5; i < 6; i++)
            {
                if (i != 0 ? (i % 2 == 0) : false)
                    Console.WriteLine("100 / " + i + " равно " + 100 / i);
            }
            Console.ReadKey();
        }
    }*/


    //page 124
    //Определить найменьший множитель заданного целого значения, состоящий из одной цифры
    /*class Program_2_24
    {
        static void Main(string[] args)
        {
            int num;

            for (num = 2; num < 12; num++)
            {
                if((num%2)==0)
                    Console.WriteLine("Найменьший множитель числа "+num+" равен 2");
                else if((num%3)==0)
                    Console.WriteLine("Найменьший множитель числа "+num+" равен 3");
                else if((num%5)==0)
                    Console.WriteLine("Найменьший множитель числа " + num + " равен 5");
                else if((num%7)==0)
                    Console.WriteLine("Найменьший множитель числа "+num+" равен 7");
                else
                    Console.WriteLine("Число не делиться на 2,3,5,7");
            }
            Console.ReadKey();
        }
    }*/

    //page 130
    //Выяснить, является ли число простым. 
    //Если оно непростое, вывести найбольший ешл множитель
    /*class Program_2_25
    {
        static void Main(string[] args)
        {
            int num;
            int i;
            int factor;
            bool isprime;

            for (num = 2; num < 20; num++)
            {
                isprime = true;
                factor = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if ((num % i) == 0)
                    {
                        isprime = false;
                        factor = i;

                    }
                }
                if(isprime)
                    Console.WriteLine(num+" - простое число");
                else
                    Console.WriteLine("Найбольший множитель числа "+num+" равен "+factor);
            }
            Console.ReadKey();
        }
    }*/

    //page 132
    // Использовать апятые в операторе цикла for для
    // выявления найменьшего и найбольшего множителя числа
    /*class Program_2_26
    {
        static void Main(string[] args)
        {
            int i, j;
            int smallest, largest;
            int num;

            num = 19;

            smallest = largest = 0;

            for (i = 2, j = num / 2; (i <= num / 2) & (j >= 2); i++, j--)
            {
                if ((smallest == 0) & ((num % i) == 0))
                    smallest = i;
                if ((largest == 0) & ((num % j) == 0))
                    largest = j;
            }

            Console.WriteLine("Найбольший множитель: "+largest);
            Console.WriteLine("Найменьший множитель: "+smallest);
            Console.ReadKey();
        }
    }*/


    //page 137
    // Вычислить порядок величины целого числа
    /*class Program_2_27
    {
        static void Main(string[] args)
        {
            int num;
            int mag;

            num = 234354;
            mag = 0;

            Console.WriteLine("Число: "+num);

            while (num > 0)
            {
                mag++;
                num /= 10;
            };

            Console.WriteLine("Порядок величины: "+mag);
            Console.ReadKey();
        }
    }*/

    //page 139
    // Отобразить цифры целого числа в обратном порядке
    /*class Program_2_28
    {
        static void Main(string[] args)
        {
            int num;
            int nextdigit;

            num = 198;

            Console.WriteLine("Число: "+num);

            Console.Write("Число в обратном порядке: ");

            do
            {
                nextdigit=num%10;
                Console.Write(nextdigit);
                num /= 10;
            } while (num>0);
            Console.ReadKey();
        }
    }*/


    //page 152
    // В этой программе создаются два обьекта типа Building
    /*class Building
    {
        public int Floors;
        public int Area;
        public int Occupants;
    }
    class Program_2_29
    {
        static void Main(string[] args)
        {
            Building house = new Building();
            Building office = new Building();

            int areaPP;

            // инициализация house
            house.Occupants = 4;
            house.Area = 2500;
            house.Floors = 2;

            // инициализация office
            office.Occupants = 25;
            office.Area = 4200;
            office.Floors = 3;

            areaPP = house.Area / house.Occupants;

            Console.WriteLine("Дом имеет: \n"+
                house.Floors+" этажа\n"+
                house.Occupants+" жильца\n"+
                house.Area+
                " кв. футов общей площади, из них\n"+
                areaPP+ " Приходиться на одного человека");

            areaPP = office.Area / office.Occupants;
            Console.WriteLine("\nУчреждение имеет:\n"+
                office.Floors+" этажа\n"+
                office.Occupants+" работнико\n"+
                office.Area+
                " кв. футов общей площади, из них\n"+
                areaPP+" приходится на одного человека");
            Console.ReadKey();
        }
    }*/

    //page 162
    // Простой пример применеия параметра
    /* class ChkNum
     {
         /*
         //ORIGINAL
         public bool IsPrime(int x)
         {
             if (x <= 1) return false;

             for (int i = 2; i <= x / i; i++)
                 if ((x % i) == 1) return false;

             return true;
         }*/
    /*public bool IsPrime(int x)
    {
        if (x <= 1) return false;

        for (int i = 2; i <= x / i; i++)
            if ((x % i) == 1) return true;

        return false;
    }
}*/
    /*class Program_2_29
    {
        static void Main(string[] args)
        {
            ChkNum on = new ChkNum();

            int i=80;
            if (on.IsPrime(i)) Console.WriteLine(i+" простое число");
            else Console.WriteLine(i+" непростое число");
            Console.ReadKey();
        }
    }*/



    /*class ChkNum
    {
        public bool IsPrime(int x)
        {
            if (x <= 1) return false;

            for (int i = 2; i <= x / i; i++)
            {
                if ((x % i) == 0) return false;
            }
            return true;
        }

        //Вичислення найбiльшого дiльника
        //public int LeastComFactor(int a, int b)
        //{
        //    int max;

        //    if (IsPrime(a) || IsPrime(b)) return 1;

        //    max = a < b ? a : b;

        //    for (int i = max; i > 0; i--)
        //        if (((a % i) == 0) && ((b % i) == 0)) return i;
        //    return 1;
        //}

        public int LeastComFactor(int a, int b)
        {
            int max;

            if (IsPrime(a) || IsPrime(b)) return 1;

            max = a < b ? a : b;

            for (int i =2; i <=max/2; i++)
                if (((a % i) == 0) && ((b % i) == 0)) return i;
            return 1;
        }
    }
    //page 163
    //Добавить метод вичисления наймельшего делителя
    class Program_2_30
    {
        static void Main(string[] args)
        {
            ChkNum ob = new ChkNum();
            int a, b;

            //for (int i = 2; i < 10; i++)

                int i = 25;
                if (ob.IsPrime(i)) Console.WriteLine(i + " простое число");
                else Console.WriteLine(i + " непростое число");

            a = 100;
            b = 25;

            Console.WriteLine("Наименьший общий множитель чисел " +
                                a + " и " + b + " равен " +
                                ob.LeastComFactor(a, b));

            Console.ReadKey();
        }
    }*/

    //page 183
    //Продемострировать двумернiй массив
    /*class Program_2_31
    {
        static void Main(string[] args)
        {
            int i, t;

            int[,] table= new int[3, 4];

            for (t = 0; t < 3; t++)
            {
                for (i = 0; i < 4; i++)
                {
                    table[t, i] = (t * 4) + i + 1;
                    Console.Write(table[t,i]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }*/

    //page 186
    // Продемонстрировать применеие ступенчастых массивов
    /*class Program_2_31
    {
        static void Main(string[] args)
        {
            int[][] jagget = new int[3][];
            jagget[0] = new int[4];
            jagget[1] = new int[5];
            jagget[2] = new int[3];

            for (int q = 0; q < jagget[0].Length; q++)
            {
                jagget[0][q] = q;
            }

            for (int w = 0; w < jagget[1].Length; w++)
            {
                jagget[1][w] = w;
            }

            for (int w = 0; w < jagget[2].Length; w++)
            {
                jagget[2][w] = w;
            }

            for (int w = 0; w < jagget[0].Length; w++)
            {
                Console.Write(jagget[0][w]);
            }
            Console.WriteLine();
            for (int w = 0; w < jagget[1].Length; w++)
            {
                Console.Write(jagget[1][w]);
            }
            Console.WriteLine();
            for (int w = 0; w < 3; w++)
            {
                Console.Write(jagget[2][w]);
            }
            Console.ReadKey();
        }
    }*/

    //page 190
    // Поменять местами содержимое элементо массива
    /*class Program_2_32
    {
        static void Main(string[] args)
        {
            int i, j;
            int[] nums1 = new int[10];
            int[] nums2 = new int[10];

            for (i = 0; i < nums1.Length; i++) nums1[i] = i;

            Console.Write("Исходное содержимое массива: ");
            for (i = 0; i < nums1.Length; i++)
            {
                Console.Write(nums1[i]+" ");
            }
            Console.WriteLine();

            if (nums2.Length >= nums1.Length)
                for (i = 0, j = nums1.Length - 1; i < nums1.Length; i++, j--)
                    nums2[j] = nums1[i];

            Console.Write("Содежимое массива в обратном порядке: ");
            for(i=0;i<nums2.Length;i++)
                Console.Write(nums2[i]+" ");
            Console.ReadKey();
        }
    }*/

    //page 191
    // Продемонстрироваь применение свойства Length 
    //при обращении со ступенчатыми массивами
    /*class Program_2_33
    {
        static void Main(string[] args)
        {
            int[][] network_nodes = new int[4][];
            network_nodes[0] = new int[3];
            network_nodes[1] = new int[7];
            network_nodes[2] = new int[2];
            network_nodes[3] = new int[5];

            int i, j;

            for (i = 0; i < network_nodes.Length; i++)
            {
                for (j = 0; j < network_nodes[i].Length; j++)
                    network_nodes[i][j] = i * j + 70; 
            }
            Console.WriteLine("Общее количество узлов сети: "+network_nodes.Length+"\n");

            for (i = 0; i < network_nodes.Length; i++)
            {
                for (j = 0; j < network_nodes[i].Length; j++)
                {
                    Console.Write("Использованик в узле сети: "+i+" ЦП "+j+": ");
                    Console.Write(network_nodes[i][j]+"% ");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }*/

    //page 194
    // Применение оператора foreach
    /*class Program_2_34
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] nums = new int[10];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }

            foreach (int x in nums)
            {
                Console.WriteLine("Значение элемента равно: "+x);
                sum += x;
            }
            Console.WriteLine("Сумма равна: "+sum);

            Console.ReadKey();
        }
    }*/

    //page 195
    // Использовать оператор break для 
    //преждевременного завершения цикла foreach
    /*class Program_2_35
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] nums = new int[10];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }

            foreach (int x in nums)
            {
                Console.WriteLine("Значение элемента равно: " + x);
                sum += x;
                if (x == 4) break;
            }
            Console.WriteLine("Сумма первых 5 элементов: " + sum);
            Console.ReadKey();
        }
    }*/

    //page 196
    //Использование оператора цикла foreach 
    //для обращение к двухмерному массиву
    /*class Program_2_36
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[,] nums= new int[3, 5];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    nums[i, j] = (i + 1) * (j + 1);
                }
            }

            foreach (int x in nums)
            {
                Console.WriteLine("Значение елемента равно: "+x);
                sum += x;
            }
            Console.WriteLine("Сумма равна: "+sum);
            Console.ReadKey();
        }
    }*/

    //page 246
    //Продемонстрировать вызов конструктора с помощью ключевого слова this
    /*class XYCoord
    {
        public int x, y;

        public XYCoord() : this(0, 0)
        {
            Console.WriteLine("в Конструкторе XYCoord");
        }

        public XYCoord(XYCoord ob) : this(ob.x, ob.y)
        {
            Console.WriteLine("В конструеторе XYCoord(obj)");
        }

        public XYCoord(int i, int j)
        {
            Console.WriteLine("В конструкторе XYCoord(int,int)");
            x = i;
            y = j;
        } 
    }
    class Program_2_37
    {
        static void Main(string[] args)
        {
            XYCoord t1 = new XYCoord();
            XYCoord t2 = new XYCoord(4, 7);
            XYCoord t3 = new XYCoord(t2);

            Console.WriteLine("t1.x, t1.y: "+t1.x+", "+t1.y);
            Console.WriteLine("t2.x, t2.y: " + t2.x + ", " + t2.y);
            Console.WriteLine("t3.x, t3.y: " + t3.x + ", " + t3.y);
            Console.ReadKey();
        }
    }*/


    //page 257
    //Простой пример рекурсии

    /*class Factorial
    {
        public int FactR(int n)
        {

            int result;
            if (n == 1) return 1;
            result = FactR(n - 1) * n;
            return result;
        }
        public int Fact(int n)
        {
            int t, result=1;

            for (t = 1; t <=n; t++)
            {
                result *= t;
                
            }
            return result;
        }
    }
    class Program_2_38
    {
        static void Main(string[] args)
        {
            Factorial ez = new Factorial();
            Console.WriteLine("Факториал рассчитаний рекурсивным методом: ");
            Console.WriteLine("ФАкториал числа 5: "+ez.FactR(5));

            Console.WriteLine("Факториал, рассчитанный итерационным методом");
            Console.WriteLine("Факториал числа 7: "+ez.Fact(7));
            Console.ReadKey();
        }
    }
    */


    //page 259
    //Вывести символьную строку в обратном порядке
    /*class Rever
    {
        public void DisplayRev(string str)
        {
            if (str.Length > 0)
            {
                DisplayRev(str.Substring(1, str.Length - 1));
            }
            else
                return;

                Console.Write(str[0]);
        }
    }
    class Program_2_39
    {
        static void Main(string[] args)
        {
            string s = "Это тест кароче";
            Rever rev = new Rever();

            Console.WriteLine("Исходная строка: " + s);

            Console.Write("Перевернутая строка: ");
            rev.DisplayRev(s);
            Console.WriteLine();
            Console.ReadKey();
        }
    }*/


    //page 271
    // Пример перезагрузки юинарных операторов
    /*class Vector3
    {
        int x, y, z;
        public Vector3()
        {
            x = y = z = 0;
        }
        public Vector3(int i,int j, int q)
        {
            x = i;
            y = j;
            z = q;
        }
        public static Vector3 operator + (Vector3 q, Vector3 w)
        {
            Vector3 result = new Vector3();

            result.x = q.x + w.x;
            result.y = q.y + w.y;
            result.z = q.z + w.z;
            return result;
        }

        public static Vector3 operator -(Vector3 q, Vector3 w)
        {
            Vector3 result1 = new Vector3();
            result1.x = q.x - w.x;
            result1.y = q.y - w.y;
            result1.z = q.z - w.z;

            return result1;
        }
        public static Vector3 operator ++ (Vector3 w)
        {
            Vector3 res = new Vector3();
            res.x = w.x+1;
            res.y = w.y+1;
            res.z = w.z+1;
            return res;
        }
        public void Show()
        {
            Console.WriteLine(x+" "+y+" "+ z);
        }
    }
    class Program_2_40
    {
        static void Main(string[] args)
        {
            Vector3 a = new Vector3(1,3,4);
            Vector3 b = new Vector3(10, 10, 10);

            Vector3 c;

            Console.Write("Координаты точки а: ");
            a.Show();
            Console.WriteLine();

            Console.Write("Координаты точки b: ");
            b.Show();
            Console.WriteLine();

            c = a + b;
            Console.Write("Результат сложения a+b: ");
            c.Show();
            Console.WriteLine();

            c = a + b + c;
            Console.Write("Результат сложения a+b+c: ");
            c.Show();
            Console.WriteLine();

            c = c - a;
            Console.Write("Результат вычитания c-a: ");
            c.Show();
            Console.WriteLine();

            c = c - b;
            Console.Write("Результат вычитания c-b: ");
            c.Show();
            Console.ReadKey();
        }
    }*/

    // page 282
    //перегрузка опрераторiв додавання, вiднiмання, унарнi оператори
    /*class Vector3
    {
        int x, y, z;
        public Vector3()
        {
            x = y = z = 0;
        }
        public Vector3(int i, int j, int k)
        {
            x = i;
            y = i;
            z = k;
        }
        public static bool operator <(Vector3 op1, Vector3 op2)
        {
            if (Math.Sqrt(op1.x * op1.x + op1.y * op1.y + op1.z * op1.z) <
                Math.Sqrt(op2.x * op2.x + op2.y * op2.y + op2.z * op2.z))
                return true;
            else
                return false;
        }
        public static bool operator >(Vector3 op1, Vector3 op2)
        {
            if (Math.Sqrt(op1.x * op1.x + op1.y * op1.y + op1.z * op1.z) >
               Math.Sqrt(op2.x * op2.x + op2.y * op2.y + op2.z * op2.z))
                return true;
            else
                return false;
        }
        public static Vector3 operator +(Vector3 op1, Vector3 op2)
        {
            Vector3 res = new Vector3();

            res.x = op1.x + op2.x;
            res.y = op1.y + op2.y;
            res.z = op1.z + op2.z;

            return res;
        }
        public static Vector3 operator +(Vector3 op1, int op)
        {
            Vector3 res = new Vector3();

            res.x = op1.x + op;
            res.y = op1.y + op;
            res.z = op1.z + op;

            return res;
        }
        public static Vector3 operator +(int op, Vector3 op1)
        {
            Vector3 res = new Vector3();

            res.x = op + op1.x;
            res.y = op + op1.y;
            res.z = op + op1.z;

            return res;
        }
        public static Vector3 operator ++(Vector3 op)
        {
            Vector3 res = new Vector3();

            res.x = op.x + 1;
            res.y = op.y + 1;
            res.z = op.z + 1;

            return res;
        }
        public static Vector3 operator -(Vector3 op)
        {
            Vector3 res = new Vector3();

            res.x = -op.x;
            res.y = -op.y;
            res.z = -op.z;

            return res;
        }
        public static Vector3 operator -(Vector3 op1, Vector3 op2)
        {
            Vector3 res = new Vector3();

            res.x = op1.x - op2.x;
            res.y = op1.y - op2.y;
            res.z = op1.z - op2.z;

            return res;
        }
        public static Vector3 operator -(Vector3 op1, int op)
        {
            Vector3 res = new Vector3();

            res.x = op1.x - op;
            res.y = op1.y - op;
            res.z = op1.z - op;

            return res;
        }
        public static Vector3 operator -(int op, Vector3 op1)
        {
            Vector3 res = new Vector3();

            res.x = op - op1.x;
            res.y = op - op1.y;
            res.z = op - op1.z;

            return res;
        }
        public static Vector3 operator --(Vector3 op)
        {
            Vector3 res = new Vector3();

            res.x = op.x - 1;
            res.y = op.y - 1;
            res.z = op.z - 1;

            return res;
        }
        public void Show()
        {
            Console.WriteLine(x+", "+y+", "+z);
        }

    }
    class Progtam_2_40
    {
        static void Main(string[] args)
        {
            Vector3 ez = new Vector3(50, 50, 50);
            Vector3 op = new Vector3(5, 5, 5);

            //Додавання 2 об'єктiв
            Console.Write("Додавання 2 об'єктiв: ");
            Vector3 res = ez + op;
            res.Show();

            //додавання числа
            Console.Write("Додавання об'єкта та числа: ");
            res = ez + 5;
            res.Show();

            //додавання числа
            Console.Write("Додавання числа та об'єкта: ");
            res = 5 + ez;
            res.Show();

            //вiднiмання об'єктiв
            Console.Write("Вiднiмання об'єктiв: ");
            res = ez - op;
            res.Show();

            //вiднiмання числа
            Console.Write("Вiднiмання об'єкта та числа: ");
            res = ez - 5;
            res.Show();

            //вiднiмання вiд числа
            Console.Write("Вiднiмання числа та об'єкта: ");
            res = 100 - ez;
            res.Show();

            //постфiксний iнкремент
            Console.Write("Постфiксний iнкремент: ");
            ez++;
            ez.Show();

            //префiксний iнкремент
            Console.Write("Префiксний iнкремент: ");
            ++ez;
            ez.Show();

            //унарний мiнус
            Console.Write("Унарний мiнус: ");
            res = -ez;
            res.Show();

            //префiксний декремент
            Console.Write("Префiксний декремент: ");
            --ez;
            ez.Show();

            //постфiксний декремент
            Console.Write("Постфiксний декремент: ");
            ez--;
            ez.Show();
            res=-res;

            //операцiя менше 
            Console.Write("Операцiя менше: \n");
            res.Show();
            Console.Write(" < ");
            ez.Show();
            if(res<ez)
            Console.WriteLine("\n res менше ez");

            //Операцiя бiльше
            Console.Write("Операцiя бiльше: \n");
            res.Show();
            Console.Write(" > ");
            ez.Show();
            if(res>ez)
            Console.WriteLine(" res більше ez");
            Console.ReadKey();
        }
    }*/

    //page 284
    //Перегрузить опреаторы true и false для класса Vector3
    /*class Vector3
    {
        int x, y, z;

        public Vector3() { x = y = z = 0; }
        public Vector3(int i, int j, int k)
        {
            x = i;
            y = j;
            z = k;
        }
        public static bool operator true(Vector3 op)
        {
            if ((op.x != 0) || (op.y != 0) || (op.z != 0))
                return true;
            else
            return false;
        }
        public static bool operator false(Vector3 op)
        {
            if ((op.x == 0) && (op.y == 0) && (op.z == 0))
            {
                return true;
            }
            else
            return false;
        }
        public static Vector3 operator --(Vector3 op)
        {
            Vector3 res = new Vector3();

            res.x = op.x - 1;
            res.y = op.y - 1;
            res.z = op.z - 1;

            return res;
        }
        public void Show()
        {
            Console.WriteLine(x + ", " + y + ", " + z);
        }
    }
    class Program_2_41
    {
        static void Main(string[] args)
        {
            Vector3 a = new Vector3(5, 6, 7);
            Vector3 b = new Vector3(10, 10, 10);
            Vector3 c = new Vector3(0, 0, 0);

            Console.Write("Координаты точки а: ");
            a.Show();
            Console.Write("Коорднаты точки b: ");
            b.Show();
            Console.Write("Координаты точки c: ");
            c.Show();
            Console.WriteLine();

            if (a) Console.WriteLine("Точка a истинна.");
            else Console.WriteLine("Точка a ложна.");

            if (b) Console.WriteLine("Точка b истинна.");
            else Console.WriteLine("Точка b ложна.");

            if (c) Console.WriteLine("Точка c истинна.");
            else Console.WriteLine("Точка c ложна.");

            Console.WriteLine();

            Console.WriteLine("Управление циклом с помощью обьекта класса Vector3");
            do
            {
                b.Show();
                b--;
            } while (b);
            Console.ReadKey();
        }
    }*/

    //page 286
    //Простой способ перезагрузить лог операторов
    /*class Vector3
    {
        int x, y, z;

        public Vector3() { x = y = z = 0; }
        public Vector3(int i, int j, int k)
        {
            x = i;
            y = j;
            z = k;
        }
        public static bool operator |(Vector3 op1, Vector3 op2)
        {
            if ((op1.x != 0) || (op1.y != 0) || (op1.z != 0) |
                (op2.x != 0) || (op2.y != 0) || (op2.z != 0)) 
            return true;
            else
            return false;
        }
        public static bool operator &(Vector3 op1, Vector3 op2)
        {
            if ((op1.x != 0) && (op1.y != 0) && (op1.z != 0) &
                (op2.x != 0) && (op2.y != 0) && (op2.z != 0))
                return true;
            else
                return false;
        }
        public static bool operator !(Vector3 op)
        {
            if ((op.x != 0) || (op.y != 0) || (op.z != 0))
            {
                return false;
            }
            else
                return true;
        }
        public void Show()
        {
            Console.WriteLine(x+", "+y+", "+z);
        }
    }
    class Program_2_42
    {
        static void Main(string[] args)
        {
            Vector3 a = new Vector3(5, 6, 7);
            Vector3 b = new Vector3(10, 10, 10);
            Vector3 c = new Vector3(0, 0, 0);

            Console.Write("Координаты точки a: ");
            a.Show();
            Console.Write("Координаты точки b: ");
            b.Show();
            Console.Write("Координаты точки c: ");
            c.Show();
            Console.WriteLine();

            if (!a) Console.WriteLine("Точка a ложна");
            if (!b) Console.WriteLine("Точка b ложна");
            if (!c) Console.WriteLine("Точка c ложна");

            if (a & b) Console.WriteLine("a & b истинно");
            else
                Console.WriteLine("a & b ложно");

            if (a & c) Console.WriteLine("a & c истинно");
            else
                Console.WriteLine("a & c ложно");

            if (a | b) Console.WriteLine("a | b истинно");
            else
                Console.WriteLine("a | b ложно");

            if (a | c) Console.WriteLine("a | c истинно");
            else
                Console.WriteLine("a | c ложно");
            Console.ReadKey();
        }
    }*/

    //page 289
    //Более совершенный способ перегрузки
    /*class Vector3
    {
        int x, y, z;

        public Vector3() { x = y = z = 0; }
        public Vector3(int i, int j, int k)
        {
            x = i;
            y = j;
            z = k;
        }

        public static Vector3 operator |(Vector3 op1, Vector3 op2)
        {
            if ((op1.x != 0) || (op1.y != 0) || (op1.z != 0) |
                (op2.x != 0) || (op2.y != 0) || (op2.z != 0))
                return new Vector3(1, 1, 1);
            else
                return new Vector3(0, 0, 0);
        }
        public static Vector3 operator &(Vector3 op1, Vector3 op2)
        {
            if ((op1.x != 0) && (op1.y != 0) && (op1.z != 0) &
                (op2.x != 0) && (op2.y != 0) && (op2.z != 0))
                return new Vector3(1, 1, 1);
            else
                return new Vector3(0, 0, 0);
        }
        public static bool operator !(Vector3 op)
        {
            if ((op.x != 0) || (op.y != 0) || (op.z != 0))
            {
                return false;
            }
            else
                return true;
        }
        public static bool operator true(Vector3 op)
        {
            if ((op.x != 0) || (op.y != 0) || (op.z != 0))
                return true;
            else
                return false;
        }
        public static bool operator false(Vector3 op)
        {
            if ((op.x == 0) && (op.y == 0) && (op.z == 0))
            {
                return true;
            }
            else
                return false;
        }
        public void Show()
        {
            Console.WriteLine(x+", "+y+", "+z);
        }
    }
    class Program_2_43
    {
        static void Main(string[] args)
        {
            Vector3 a = new Vector3(5, 6, 7);
            Vector3 b = new Vector3(10, 10, 10);
            Vector3 c = new Vector3(0, 0, 0);

            Console.Write("Координаты точки a: ");
            a.Show();
            Console.Write("Координаты точки b: ");
            b.Show();
            Console.Write("Координаты точки c: ");
            c.Show();
            Console.WriteLine();

            if (a) Console.WriteLine("Точка a истинна");
            if (b) Console.WriteLine("Точка b истинна");
            if (c) Console.WriteLine("Точка c истинна");

            if (!a) Console.WriteLine("Точка a ложна");
            if (!b) Console.WriteLine("Точка b ложна");
            if (!c) Console.WriteLine("Точка c ложна");
            Console.WriteLine();

            if (a & b) Console.WriteLine("a & b истинно");
            else
                Console.WriteLine("a & b ложно");

            if (a & c) Console.WriteLine("a & c истинно");
            else
                Console.WriteLine("a & c ложно");

            if (a | b) Console.WriteLine("a | b истинно");
            else
                Console.WriteLine("a | b ложно");

            if (a | c) Console.WriteLine("a | c истинно");
            else
                Console.WriteLine("a | c ложно");

            Console.WriteLine();

            Console.WriteLine("Применение логических операторов && и ||");
            if (a && b) Console.WriteLine("a && b истинно");
            else
                Console.WriteLine("a && b ложно");
              
            if (a && c) Console.WriteLine("a && c истинно");
            else
                Console.WriteLine("a && c ложно");

            if (a || b) Console.WriteLine("a || b истинно");
            else
                Console.WriteLine("a || b ложно");

            if (a || c) Console.WriteLine("a || c истинно");
            else
                Console.WriteLine("a || c ложно");
            Console.ReadKey();
        }
    }*/

    //page 293
    //Пример применения оператора неявного преобразования
    /*class Vector3
    {
        int x, y, z;

        public Vector3() { x = y = z = 0; }
        public Vector3(int i, int j, int k)
        {
            x = i;
            y = j;
            z = k;
        }

        public static Vector3 operator +(Vector3 op1, Vector3 op2)
        {
            Vector3 res = new Vector3();

            res.x = op1.x + op2.x;
            res.y = op1.y + op2.y;
            res.z = op1.z + op2.z;

            return res;
        }

        public static implicit operator int(Vector3 op)
        {
            return op.x + op.y + op.z; 
        }

        public void Show()
        {
            Console.WriteLine(x+", "+y+", "+z);
        }
    }
    class Program_2_44
    {
        static void Main(string[] args)
        {
            Vector3 a = new Vector3(1, 2, 3);
            Vector3 b = new Vector3(10, 10, 10);
            Vector3 c = new Vector3();
            int i;

            Console.Write("Координаты точки a: ");
            a.Show();
            Console.Write("Координаты точки b: ");
            b.Show();
            Console.WriteLine();

            c = a + b;
            Console.Write("Результат сложения a+b: ");
            c.Show();
            Console.WriteLine();

            i = a;
            Console.WriteLine("Результат присваивания i=a: "+i);
            Console.WriteLine();
            i = b;
            Console.WriteLine("Результат присваивания i=b: ");

            i = a * 2 - b;
            Console.WriteLine("Результат вычисления выражения a*2-b: "+i);
            Console.ReadKey();
        }
    }*/


    //page 295
    //Применить явное преобразование
    /*class Vector3
    {
        int x, y, z;

        public Vector3() { x = y = z = 0; }
        public Vector3(int i, int j, int k)
        {
            x = i;
            y = j;
            z = k;
        }

        public static Vector3 operator +(Vector3 op1, Vector3 op2)
        {
            Vector3 res = new Vector3();

            res.x = op1.x + op2.x;
            res.y = op1.y + op2.y;
            res.z = op1.z + op2.z;

            return res;
        }
        public static explicit operator int(Vector3 op)
        {
            return op.x + op.y + op.z;
        }
        public void Show()
        {
            Console.WriteLine(x + ", " + y + ", " + z);
        }
    }
    class Program_2_45
    {
        static void Main(string[] args)
        {
            Vector3 a = new Vector3(1, 2, 3);
            Vector3 b = new Vector3(10, 10, 10);
            Vector3 c = new Vector3();
            int i;

            Console.Write("Координаты точки a: ");
            a.Show();
            Console.Write("Координаты точки b: ");
            b.Show();
            Console.WriteLine();

            i = (int)a;
            Console.WriteLine("Результат явного присваивания i=a: "+i);
            Console.WriteLine();

            i = (int)a * 2 - (int)b;
            Console.WriteLine("Результат вычисления выражения a*2-b: "+i);
            Console.ReadKey();
        }
    }*/

    //page 299
    //создать полубайтовый тип 
    /*class Nybble
    {
        int val;

        public Nybble() { val = 0; }

        public Nybble(int i)
        {
            val = i;
            val &= 0xF;
        }

        public static Nybble operator +(Nybble op1, Nybble op2)
        {
            Nybble result = new Nybble();

            result.val = op1.val + op2.val;

            result.val = result.val & 0xF;
            return result;
        }
        public static Nybble operator +(Nybble op1, int op2)
        {
            Nybble result = new Nybble();

            result.val = op1.val + op2;

            result.val = result.val & 0xF;
            return result;
        }
        public static Nybble operator +(int op1, Nybble op2)
        {
            Nybble result = new Nybble();

            result.val = op1 + op2.val;

            result.val = result.val & 0xF;
            return result;
        }
        public static Nybble operator ++(Nybble op)
        {
            Nybble result = new Nybble();

            result.val = op.val + 1;

            result.val = result.val & 0xF;
            return result;
        }
        public static bool operator >(Nybble op1, Nybble op2)
        {
            if (op1.val > op2.val) return true;
            else return false;
        }
        public static bool operator <(Nybble op1, Nybble op2)
        {
            if (op1.val < op2.val) return true;
            else return false;
        }
        public static implicit operator Nybble(int op)
        {
            return new Nybble(op);
        }
        public static implicit operator int(Nybble op)
        {
            return op.val;
        }
    }
    class Program_2_46
    {
        static void Main(string[] args)
        {
            Nybble a = new Nybble(1);
            Nybble b = new Nybble(10);
            Nybble c = new Nybble();
            int t;

            Console.WriteLine("a: "+(int) a);
            Console.WriteLine("b: "+(int) b);
            if (a < b) Console.WriteLine("а меньше b\n");

            c = a + b;
            Console.WriteLine("c после операции c = a + b: "+(int)c);

            a += 5;
            Console.WriteLine("a после операции a +=5: "+(int) a);
            Console.WriteLine();

            t = a * 2 + 3;
            Console.WriteLine("Результат вычисления a*2+3: "+t);
            Console.WriteLine();

            a = 19;
            Console.WriteLine("Результат присваивания a=19: "+(int) a);
            Console.WriteLine();

            Console.WriteLine("Управление циклом for "+"с помощью обьекта типа Nybble");
            for (a = 0; a < 10; a++)
            {
                Console.WriteLine((int)a);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }*/

    //page 304
    // Использовать индексатор для создания отказоустойчиого массива
    /*class Index
    {
        int[] a;

        public int Length;

        public bool ErrFlag;

        public Index(int size)
        {
            a = new int[size];
            Length = size;
        }

        public int this[int index]
        {
            get
            {
                if (ok(index))
                {
                    ErrFlag = false;
                    return a[index];
                }
                else
                {
                    ErrFlag = true;
                    return 0;
                }
            }

            set
            {
                if (ok(index))
                {
                    a[index] = value;
                    ErrFlag = true;
                }
                else
                    ErrFlag = false;
            }

        }
            private bool ok(int index)
        {
            if (index >= 0 & index < Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
    class Program_4_47
    {
        static void Main(string[] args)
        {
            Index f = new Index(5);
            int x;

            Console.WriteLine("Скрытий сбой");
            for (int i = 0; i < (f.Length * 2); i++)
                f[i] = i * 10;

            for (int i = 0; i < (f.Length * 2); i++)
            {
                x = f[i];
                if (x != -1) Console.Write(x+" ");
            }
            Console.WriteLine();

            Console.WriteLine("\nСбой с уведомлением об ошибках");
            for (int i = 0; i < (f.Length * 2); i++)
            {
                f[i] = i * 10;
                if(f.ErrFlag)
                    Console.WriteLine("f["+i+"] вне границ");
            }

            for (int i = 0; i < (f.Length * 2); i++)
            {
                x = f[i];
                if(f.ErrFlag)
                    Console.WriteLine("f[" + i + "] вне границ");
                else
                    Console.Write(x + " ");

            }
            Console.ReadKey();
        }
    }*/


    //page 307
    // Перегрузка индексатора массива!
    /*class Index
    {
        int[] a;

        public int Length;
        public bool Err;

        public Index(int size)
        {
            a = new int[size];
            Length = size;
        }

        public int this[int index]
        {
            get
            {
                if (ok(index))
                {
                    Err = true;
                    return a[index];
                }
                else
                {
                    Err = false;
                    return 0;
                }
            }

            set
            {
                if (ok(index))
                {
                    Err = true;
                    a[index] = value;
                }
                else
                {
                    Err = false;
                }
            }
        }

        public int this[double ind]
        {
            get
            {
                int index;
                if (ind - (int)ind > 0.5)
                {
                    index = (int)ind + 1;
                }
                else
                {
                    index = (int)ind;
                }

                if (ok(index))
                {
                    Err = true;
                    return a[index];
                }
                else
                {
                    Err = false;
                    return 0;
                }
            }

            set
            {
                int index;
                if (ind - (int)ind > 0.5)
                {
                    index = (int)ind + 1;
                }
                else
                {
                    index = (int)ind;
                }
                if (ok(index))
                {
                    Err = true;
                    a[index] = value;
                }
                else
                {
                    Err = false;
                }
            }
        }
            private bool ok(int ind)
        {
            if (ind >= 0 & ind < Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
    class Program_4_48
    {
        static void Main(string[] args)
        {

            Index me = new Index(5);

            Console.WriteLine("\tЗ ошибками");
            for (int i = 0; i < 10; i++)
            {
                me[i] = i * 2;
                if (me.Err)
                {
                    Console.WriteLine("В границах");
                }
                else
                {
                    Console.WriteLine("index ["+i+"]За границей");
                }
            }

            int x;
            for (int i = 0; i < 10; i++)
            {
                x = me[i];
                if (me.Err)
                {
                    Console.Write(me[i]+" ");
                }
                else
                {
                    Console.WriteLine("index ["+i+"] вилез за границы");
                }
            }

            Console.WriteLine(me[1.3]+" "+ me[1.6]);
            Console.ReadKey();
        }
    }*/


    //page 324
    //Создание класса для -5 до 20
    /*class Range
    {
        int[] a;
        int lowerBound;
        int UpperBound;

        public int Length { get; private set; }
        public bool Err { get; private set; }

        public Range(int low, int high)
        {
            high++;
            if (high <= low)
            {
                Console.WriteLine("Неверные индексы");
                high = 1;
                low = 0;
            }
            a = new int[high - low];
            Length = high - low;

            lowerBound = low;
            UpperBound = --high;
        }

            public int this[int index]
            {
                get
                {
                    if (ok(index))
                    {
                        Err = false;
                        return a[index - lowerBound];
                    }
                    else
                    {
                        Err = true;
                        return 0;
                    }
                }

                set
                {
                if (ok(index))
                {
                    a[index - lowerBound] = value;
                    Err = false;
                }
                    else Err = true;
                }
            }

        private bool ok(int index)
        {
            if (index >= lowerBound & index <= UpperBound) return true;
            return false;
        }
    }
    class Program_4_49
    {
        static void Main(string[] args)
        {
            Range q1 = new Range(-5,5);
            Range q2 = new Range(1, 10);
            Range q3 = new Range(-20, -12);

            Console.WriteLine("Длина массива q1: "+q1.Length);
            for (int i = -5; i <= 5; i++)
            {
                q1[i] = i;
            }
            Console.Write("Содержимое массива q1: ");
            for (int i = -5; i <= 5; i++)
            {
                Console.Write(q1[i]+" ");
            }

            Console.WriteLine();

            Console.WriteLine("Длинна массива q2: "+q2.Length);
            for (int i = 1; i <= 10; i++)
            {
                q2[i] = i;
            }
            Console.Write("Содержимое массива q2: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(q2[i]+" ");
            }

            Console.WriteLine();

            Console.WriteLine("Длина массива q3: "+q3.Length);
            for (int i = -20; i <= -12; i++)
            {
                q3[i] = i;
            }

            Console.Write("Содержимое массива q3: ");
            for (int i = -20; i <= -12; i++)
            {
                Console.Write(q3[i]+" ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }*/


    // page 336
    // Продемонстрировать применение мдификатора доступа protected
    /*class Ez
    {
        protected int a, b;

        public void Set(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Show()
        {
            Console.WriteLine(a + " "+b);
        }
    }
    class Ez2:Ez
    {
        int k;

        public void Setk()
        {
            k = a * b;
        }
        public void Showk()
        {
            Console.WriteLine(k);
        }
    }
    class Program_4_50
    {
        static void Main()
        {
            Ez2 ob = new Ez2();
            ob.Set(2, 5);
            ob.Show();
            ob.Setk();
            ob.Showk();
            Console.ReadKey();
        }
    }*/

    // page 337
    // Добавить конструктор в класс Ez2
    /*class Ez
    {
        double width;
        double heigth;

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value < 0 ? -value : value;
            }
        }
        protected double Heigth
        {
            get
            {
                return heigth;
            }
            set
            {
                heigth = value < 0 ? -value : value;
            }
        }
        public void Show()
        {
            Console.WriteLine("Ширина и длина равны "+Width+" и "+Heigth);
        }
    }
    class Ez2 : Ez
    {
        string style;

        public Ez2(string s,double w,double h)
        {
            Width = w;
            Heigth = h;
            style = s;
        }

        public double Area()
        {
            return Width * Heigth * 2;
        }
        public void ShowStyle()
        {
            Console.WriteLine("Треугольник "+style);
        }
    }
    class Program_4_51
    {
        static void Main()
        {
            Ez2 ob1 = new Ez2("равнобедренный", 4.0, 4.0);
            Ez2 ob2 = new Ez2("прямоугольный", -8.0, 12.0);

            Console.WriteLine("Сведеньия об обьекте ob1: ");
            ob1.ShowStyle();
            ob1.Show();
            Console.WriteLine("Площадь равна "+ob1.Area());
            Console.WriteLine();

            Console.WriteLine("Сведения об обьекте ob2: ");
            ob2.ShowStyle();
            ob2.Show();
            Console.WriteLine("Площадь равна "+ob2.Area());
            Console.ReadKey();
        }
    }*/

    //page 339 //моё творение
    //Вызов базового конструктора с помощью клч слова base
    /*class Ez
    {
        double heigth;
        double width;

        public Ez(double w,double h)
        {
            width = w;
            heigth = h;
        }
        public void Show()
        {
            Console.WriteLine("Ширинна и высота равни "+ width + " и "+ heigth);
        }
    }

    class Ez1 : Ez
    {
        string style;

        public Ez1(string s, double w, double h) : base(w, h)
        {
            style = s;
        }

        public void ShowStyle()
        {
            Console.WriteLine("Треугольник: "+style);
        }
    }

    class PRogram_4_52
    {
        static void Main()
        {
            Ez1 ob1 = new Ez1("Равнобедренный", 10, 5);
            Ez1 ob2 = new Ez1("Прямоугольнный", 8.0, 12.0);

            Console.WriteLine("Обьект ob1: ");
            ob1.ShowStyle();
            ob1.Show();

            Console.WriteLine();
            Console.WriteLine("Обьект ob2: ");
            ob2.ShowStyle();
            ob2.Show();
            Console.ReadKey();
        }
    }*/


    //page 339
    //Добавить конструктор в класс
    /*class Ez
    {
        double width;
        double heigth;

        public Ez(double w, double h)
        {
            Width = w;
            Heigth = h;
        }

        double Width
        {
            set
            {
                width = value > 0 ? value : -value;
            }
            get
            {
                return width;
            }
        }
        double Heigth
        {
            set
            {
                heigth = value > 0 ? value : -value;
            }
            get
            {
                return heigth;
            }
        }

        public void Show()
        {
            Console.WriteLine("Ширина и высота равни: "+Width + " и "+Heigth);
        }
    }
    class Ez1:Ez
    {
        string style;

        public Ez1(string s, double w, double h) : base(w, h)
        {
            style = s;
        }

        public void ShowStyle()
        {
            Console.WriteLine("Треугольник: "+style);
        }
    }

    class Program_4_52
    {
        static void Main()
        {
            Ez1 ob1 = new Ez1("Равнобедренный", 4.0, 4.0);
            Ez1 ob2 = new Ez1("Прямоугольнный", 8.0, 12.0);

            Console.WriteLine("Об обьекте ob1: ");
            ob1.ShowStyle();
            ob1.Show();
            Console.WriteLine();

            Console.WriteLine("Об обьекте ob2: ");
            ob2.ShowStyle();
            ob2.Show();
            Console.ReadKey();
        }
    }*/

    //page 344
    //Пример сокрытия с наследственной связью
    /*class A
    {
        public int i=0;
    }
    class B : A
    {
        new int i;
        public B(int b)
        {
            i = b;
        }
        public void Show()
        {
            Console.WriteLine("Член i в производном классе: "+i);
        }
    }
    class Ez
    {
        static void Main()
        {
            B ob = new B(2);
            ob.Show();
            Console.ReadKey();
        }
    }*/

    //page 345
    //Пример применение ключевого слова base 
    //для преодоления сокрытия имен
    /*class A
    {
        public int i = 0;
    }
    class B : A
    {
         new public int i;

        public B(int q, int w) 
        {
            i = q;
            base.i = w;
        }
        public void Show()
        {
            Console.WriteLine("i: "+i);
            Console.WriteLine("base.i: "+base.i);
        }
    }
    class Ez
    {
        static void Main()
        {
            B ob = new B(2,5);

            ob.Show();
            Console.ReadKey();
        }
    }*/

    //page 347 //modified
    //Пример построения многоуровневой иерархии классов
    /*class Ez1
    {
        double width;
        double heigth;

        public Ez1()
        {
            width = heigth = 0;
        }
        public Ez1(double side)
        {
            Width = Heigth = side;
        }
        public Ez1(double w, double h)
        {
            Width = w;
            Heigth = h;
        }
        double Width
        {
            set
            {
                width = value > 0 ? value : -value;
            }

        }
        double Heigth
        {
            set
            {
                heigth = value > 0 ? value : -value;
            }

        }
        public void Show()
        {
            Console.WriteLine("Длина и высота: "+width+" и "+heigth);
        }
    }
    class Ez2:Ez1
    {
        string style;

        public Ez2()
        {
            style = "треугольник отсутствует";
        }
        public Ez2(double x) : base(x)
        {
            style = "равнобедренный";
        }
        public Ez2(string s, double w, double h) : base(w, h)
        {
            style = s;
        }
        new public void Show()
        {
            base.Show();
            Console.WriteLine("Треугольник: "+style);
        }
    }
    class Ez3 : Ez2
    {
        string color;

        public Ez3()
        {
            color = "треугольник отсутствует";
        }
        public Ez3(int w) : base(w)
        {
            color = "синий";
        }
        public Ez3(string c, string s, double w, double h) : base(s, w, h)
        {
            color = c;
        }
        new public void Show()
        {
            base.Show();
            Console.WriteLine("Цвет треугольника: "+color);
        }
    }
    class Ez
    {
        static void Main()
        {
            Ez3 ob1 = new Ez3();
            Ez3 ob2 = new Ez3(4);
            Ez3 ob3 = new Ez3("красний","Прямоугольнный",12.0,8.0);

            Console.WriteLine("Об обьекте ob1: ");
            ob1.Show();
            Console.WriteLine();

            Console.WriteLine("Об обьекте ob2: ");
            ob2.Show();
            Console.WriteLine();

            Console.WriteLine("Об обьекте ob3: ");
            ob3.Show();
            Console.ReadKey();
        }
    }*/

    //page 352
    //по ссылке на базовий класс можна обращаться
    //к обьекту приз класса
    /*class A
    {
        public int a;
        public A(int i)
        {
            a = i;
        }
    }
    class B : A
    {
        public int b;
        public B(int i, int j) : base(j)
        {
            b = i;
        }
    }
    class Program_4_56
    {
        static void Main()
        {
            A ob1 = new A(4);
            A ob2;
            B ob3 = new B(4, 5);

            ob2 = ob1;
            Console.WriteLine(ob2.a);

            ob2 = ob3;
            Console.WriteLine(ob2.a);
            Console.ReadKey();
        }
    }*/

    //page 353
    //Передаем ссылку на обьект производного класса 
    //переменной ссылки на обьект базового класса
    /*class Ez1
    {
        double width;
        double heigth;

        public Ez1()
        {
            Width = Heigth = 0.0;
        }

        public Ez1(double x)
        {
            Width = Heigth = x;
        }
        public Ez1(double w, double h)
        {
            Width = w;
            Heigth = h;
        }

        public Ez1(Ez1 ob)
        {
            Width = ob.Width;
            Heigth = ob.Heigth;
        }
        double Width
        {
            set
            {
                width = value > 0 ? value : -value;
            }
            get
            {
                return width;
            }
        }
        double Heigth
        {
            set
            {
                heigth = value > 0 ? value : -value;
            }
            get
            {
                return heigth;
            }
        }
        public void Show()
        {
            Console.WriteLine("Ширина и высота равны: "+Width + " и "+Heigth);
        }
    }
    class Ez2:Ez1
    {
        string style;

        public Ez2()
        {

        }
        public Ez2(double w) : base(w)
        {
            style = "Равнобедренный";
        }
        public Ez2(string s, double w, double h) : base(w, h)
        {
            style = s;
        }
        public Ez2(Ez2 ob):base(ob)
        {
            style = ob.style;
        }

        public void ShowStyle()
        {
            Console.WriteLine("Трегольник: "+style);
        }
    }

    class Program_4_57
    {
        static void Main()
        {
            Ez2 ob = new Ez2("Прямоугольный", 8.0, 12.0);

            Ez2 ob1 = new Ez2(ob);

            Console.WriteLine("Об обьекте ob: ");
            ob.ShowStyle();
            ob.Show();
            Console.WriteLine();

            Console.WriteLine("об обьекте ob1: ");
            ob1.ShowStyle();
            ob1.Show();
            Console.ReadKey();
        }
    }*/

    //
    //
    class Base
    {
        public virtual void Who()
        {
            Console.WriteLine("Base!");
        }
    }
    class Derived1 : Base
    {
        public override void Who()
        {
            Console.WriteLine("Derived1");
        }
    }
    class Derived2 : Base
    {
        public override void Who()
        {
            Console.WriteLine("Derived2");
        }
    }
    class Call
    {
        static void Main()
        {
            Derived1 q1 = new Derived1();
            Derived2 q2 = new Derived2();
            Base q = new Base();
            q.Who();

            q = q1;
            q.Who();

            q = q2;
            q.Who();
            Console.ReadKey();
        }
    }
}

