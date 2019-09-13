using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Типы
            //a. Определите переменные всех возможных примитивных типов. С# и проинициализируйте их. 

            int intVar = 1;
            uint uIntVar = 1;
            short shortVar = 1;
            ushort uShortVar = 1;
            long longVar = 1;
            long uLongVar = 1;
            char charVar = 'C';
            string stringVar = "Hello World!";
            bool boolVar = true;
            byte byteVar = 255;
            sbyte sByteVar = -128;
            float floatVar = 9.7F;
            double doubleVar = 9.7D;
            decimal decimalVar = 9.7M;
            object objectVar = false;

            //b. Выполните 5 операций явного и 5 неявного приведения.

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1b");
            Console.WriteLine(longVar + " long -> int: " + (int)longVar);
            Console.WriteLine(intVar + " int -> short: " + (short)intVar);
            Console.WriteLine(shortVar + " short -> byte: " + (byte)shortVar);
            Console.WriteLine(sByteVar + " sbyte -> byte: " + (byte)sByteVar); // -128 (Старший бит, отвечающий за знак обнуляется)
            Console.WriteLine(byteVar + " byte -> sbyte: " + (sbyte)byteVar); // 255 (Старший бит отвечает за знак -> 1111 1111 - в прямом коде 255, в дополнительном коде -1)

            longVar = intVar;
            intVar = shortVar;
            shortVar = byteVar;
            doubleVar = intVar;
            doubleVar = floatVar;

            //c. Выполните упаковку и распаковку значимых типов.

            objectVar = intVar;
            intVar = (int)objectVar;

            //d. Продемонстрируйте работу с неявно типизированной переменной.

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1d");
            var myVariable = 5;
            Console.WriteLine(myVariable.GetType());

            //e. Продемонстрируйте пример работы с Nullable переменной

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1e");
            int? nullableVar = null;
            bool? nullableVar2 = true;
            Console.WriteLine("Nullable var number 1: " + nullableVar);
            Console.WriteLine("Nullable var number 2: " + nullableVar2);

            //2) Строки
            //a. Объявите строковые литералы. Сравните их.

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("2a");
            string str = "Hello World!";
            string str2 = "HelloWorld";
            Console.WriteLine("{0} equals {1}: {2}", str, str2, str.Equals(str2));

            //b. Создайте три строки на основе String. Выполните: сцепление, копирование, выделение подстроки, разделение строки на слова, вставки подстроки в заданную позицию, удаление заданной подстроки.

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("2b");
            String string1 = "Hello World!";
            String string2 = "Welcome to hell";
            String string3 = "HllWrld";
            Console.WriteLine("\"{0}\" concat with \"{1}\" -> {2}", string1, string2, String.Concat(string1, string2));
            string3 = String.Copy(string1);
            Console.WriteLine("string1 copy in string number 3 -> " + string3);
            Console.WriteLine("Substring of string number 3:" + string3.Substring(0, 5));
            String[] strings = string2.Split(' ');
            Console.WriteLine("Word in string number 2: ");
            for (int i = 0; i < strings.Length; i++)
            {
                Console.Write(strings[i] + " ");
            }

            string3 = string3.Insert(0, "<-->");
            Console.WriteLine('\n' + string3);
            string3 = string3.Remove(0, 4);
            Console.WriteLine(string3);

            //c. Создайте пустую и null строку. Продемонстрируйте что можно выполнить с такими строками

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("2c");
            string nullString = null;
            string emptyString = "";
            Console.WriteLine("Null string concat with string \"{0}\" -> {1}", string1, String.Concat(nullString, string1));
            Console.WriteLine("Empty string concat with string \"{0}\" -> {1}",string1,String.Concat(string1, emptyString));
            Console.WriteLine(nullString.GetType());

            //d. Создайте строку на основе StringBuilder. Удалите определенные позиции и добавьте новые символы в начало и конец строки.

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("2d");
            StringBuilder SB = new StringBuilder("Hello World!",0,4,50);
            SB.Append("o World!");
            SB.Remove(0, 5);
            SB.Insert(0, "Hello +");
            Console.WriteLine("StringBuilder: " + SB);

            //3) Массивы
            //a. Создайте целый двумерный массив и выведите его на консоль в отформатированном виде(матрица).

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("3a");
            Random rand = new Random();
            int[,] intArray = new int[5, 5];
            Console.WriteLine("5x5 matrix:");
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    intArray[i, j] = rand.Next(0, 10);

                    Console.Write(intArray[i, j] + " ");
                }
                Console.Write('\n');
            }

            //b. Создайте одномерный массив строк. Выведите на консоль его содержимое, длину массива. Поменяйте произвольный элемент (пользователь определяет позицию и значение).

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("3b");
            string[] arrayOfStrings = { "Hello", "Welcome", "Goodbye", "Bye", "World" };
            Console.WriteLine("Length of Array of strings is {0}", arrayOfStrings.Length);
            for(int i = 0; i < arrayOfStrings.Length; i++)
            {
                Console.WriteLine("Item number 1 in Array of strings is {0}", arrayOfStrings[i]);
            }
            Console.WriteLine("Enter your string:");
            arrayOfStrings[rand.Next(0, arrayOfStrings.Length - 1)] = Console.ReadLine();
            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                Console.WriteLine("Item number 1 in Array of strings is {0}", arrayOfStrings[i]);
            }

            //c. Создайте ступечатый (не выровненный) массив вещественных чисел с 3 - мя строками, в каждой из которых 2, 3 и 4 столбцов соответственно.Значения массива введите с консоли.

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("3c");
            double[][] sArray = new double[3][];
            sArray[0] = new double[2];
            sArray[1] = new double[3];
            sArray[2] = new double[4];
            Console.WriteLine("Stepped array :");
            for(int i = 0; i < sArray.Length; i++)
            {
                for(int j = 0; j < sArray[i].Length; j++)
                {
                    sArray[i][j] = rand.Next(0, 10);

                    Console.Write(sArray[i][j] + " ");
                }
                Console.Write('\n');
            }

            //d. Создайте неявно типизированные переменные для хранения массива и строки.

            var vArray = new int[10];
            var vString = "";

            //4) Кортежи
            //a. Задайте кортеж из 5 элементов с типами int, string, char, string, ulong.

            var tuple = (intVar, stringVar, charVar, stringVar, uLongVar);

            //b. Сделайте именование его элементов.

            var namedTuple = (Int:intVar, String:stringVar, Char:charVar, String2:stringVar, ULong:uLongVar);

            //c. Выведите кортеж на консоль целиком и выборочно (1, 3, 4 элементы)

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("4c");
            Console.WriteLine("Item 1: " + tuple.Item1);
            Console.WriteLine("Item 2: " + tuple.Item2);
            Console.WriteLine("Item 3: " + tuple.Item3);
            Console.WriteLine("Item 4: " + tuple.Item4);
            Console.WriteLine("Item 5: " + tuple.Item5);
            Console.WriteLine("Item with name Int: " + namedTuple.Int);
            Console.WriteLine("Item with name String: " + namedTuple.String);
            Console.WriteLine("Item with name Char: " + namedTuple.Char);
            Console.WriteLine("Item with name String2: " + namedTuple.String2);
            Console.WriteLine("Item with name ULong: " + namedTuple.ULong);
            Console.WriteLine(tuple.ToString());

            //d. Выполните распаковку кортежа в переменные.

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("4d");
            (var a, var b, var c, var d, var f) = namedTuple;
            Console.WriteLine($"Unpacked tuple {a} {b} {c} {d} {f}");

            //e. Сравните два кортежа

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("4e");
            Console.WriteLine("Named tuple == tuple is " + (namedTuple == tuple)); // C# 7.3

            //5)

            Console.ForegroundColor = ConsoleColor.Yellow;
            (int, int, int, char) GetTuple(int[] Arr, string String)
            {
                return (Arr.Max(), Arr.Min(), Arr.Sum(), String[0]);
            } 
            var newTuple = GetTuple(new int[] { 1, 2, 3 }, "Hello World!");
            Console.WriteLine("Item 1: " + newTuple.Item1);
            Console.WriteLine("Item 2: " + newTuple.Item2);
            Console.WriteLine("Item 3: " + newTuple.Item3);
            Console.WriteLine("Item 4: " + newTuple.Item4);

            Console.ReadLine();
        }
    }
}
