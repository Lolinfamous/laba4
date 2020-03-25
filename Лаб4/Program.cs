using System;

namespace Лаб4
{
    class Program
    {   
        class arra
        {
            private static Random rnd = new Random();
            public static void CreateTwoDimAr(int[,] massiv)
            {
                for (int i = 0; i < massiv.GetLength(0); i++)
                for (int j = 0; j < massiv.GetLength(1); j++)
                   massiv[i,j] = rnd.Next(1, 10);
            }
            public static void PrintArObj(string stroka, object[] objekt) // #4
            {
                Console.WriteLine("Массив {0} = ", stroka);
                Console.Write("{");
                   foreach (object a1 in objekt)
                Console.Write(" {0} ", objekt);
                Console.WriteLine("}");
            }
        }
        static void PrintAnyArr(string stroka, Array aray) //#1
        {
            Console.WriteLine("Массив {0} = ", stroka);
            switch (aray.Rank)
            {
                case 1:
                if (aray.GetValue(0) is Array)
                    {
                int nomer = 0;
                foreach (Array a1 in aray) // усеченный
                        {
                 PrintAnyArr(stroka + "("+ nomer.ToString() + ")", a1);
                     nomer++;
                        }
                    }
                    else
                    {
                        Console.Write("{"); // одномерный
                        for (int i=0; i < aray.Length; i++) 
                         if( i == aray.Length - 1) Console.Write("{0}", aray.GetValue(i).ToString());
                            else Console.Write("{0}; ",aray.GetValue(i).ToString());
                        Console.Write("}");
                        Console.WriteLine();
                    }
                    break;
                case 2:

                    for (int i = 0; i < aray.GetLength(0); i++, Console.WriteLine())
                    {
                        Console.Write("{");
                        for (int j = 0; j < aray.GetLength(1); j++)
                        if (j == aray.GetLength(1) - 1) Console.Write("{0}", aray.GetValue(i, j).ToString());
                            else Console.Write("{0}; ", aray.GetValue(i, j).ToString());
                        Console.Write("}");
                    }
                    break;
            }
        }

        static void PrintAnyArr2(string stroka, Array aray) //#2
        {
            Console.WriteLine("Массив {0} = ", stroka);
                        Console.Write("{");
                        foreach (Object aray1 in aray)
                        {
                        Console.Write(" {0} ", aray1.ToString());
                        }
                        Console.Write("}");
                        Console.WriteLine();
            }

        static void PrintArr(string stroka, Object aray) //#6
        {
            Array aray1 = aray as Array;
            if (aray == null)
            {
            Console.WriteLine("Ваш массив пуст");
            }
            Console.WriteLine("Массив {0} = ", stroka);
            Console.Write("{");
            foreach(Object elem in aray1)
            Console.Write(" {0} ", elem.ToString());
            Console.Write("}");
        }
        static void Slozenie(int[,] Aray, int[,] Aray1)
        {
            int ArayS1 = Minimum(Aray.GetLength(0), Aray1.GetLength(0));
            int ArayS2 = Minimum(Aray.GetLength(1), Aray1.GetLength(1));
            int[,] ArayS = new int[ArayS1, ArayS2];
            for (int i = 0; i < ArayS1; i++)
                for (int j = 0; j < ArayS2; j++)
                ArayS[i, j] = Aray[i, j] + Aray1[i, j];
            PrintAnyArr("Сложенный", ArayS);
        }
        static int Minimum(int first, int second)
        {
            if (first > second) return second;
            else return first;
        }
        static void Otnimanie(int[,] Aray, int[,] Aray1)
        {
            int ArayS1 = Minimum(Aray.GetLength(0), Aray1.GetLength(0));
            int ArayS2 = Minimum(Aray.GetLength(1), Aray1.GetLength(1));
            int[,] ArayS = new int[ArayS1, ArayS2];
            for (int i = 0; i < ArayS1; i++)
            for(int j = 0; j < ArayS2; j++)
                    ArayS[i,j] = Aray[i,j] - Aray1[i,j];
            PrintAnyArr("Отнятый", ArayS);
        }
        static void Ymnozenie(int[,] Aray, int[,] Aray1)
        {
            int[,] ArayS = new int[Aray.GetLength(0), Aray1.GetLength(0)];
            for (int i = 0; i < Aray.GetLength(0); i++)
            for (int j = 0; j < Aray.GetLength(1); j++)
            for (int k = 0; k < Aray1.GetLength(0); k++)
                 ArayS[i, j] += Aray[i, k] * Aray1[k, j];
            PrintAnyArr("Перемноженный", ArayS);
        }
        static void Delenie(int[,] Aray, int[,] Aray1)
        {
            double[,] ArayS = new double[Aray.GetLength(0), Aray1.GetLength(0)];
            for (int i = 0; i < Aray.GetLength(0); i++)
            for (int j = 0; j < Aray.GetLength(1); j++)
            for (int k = 0; k < Aray1.GetLength(0); k++)
                 ArayS[i, j] += Aray[i, k] / Aray[k, j];
            PrintAnyArr("Деленный", ArayS);
        }
        static void Main()
        {
            //Задание 1
             /*string[][] aray1 = {
                  new string[] {"A","B","C"},
                  new string[] {"1","2","3","4","5"},
                  new string[] {"А","Б","В","Г","Д","Е"}
              };
            int[] aray2 = { 124, 24, 32, 475 };
            double[,] aray3 = new double[2,3]  { { 1.2, 3.4, 5.6 }, { 7.8, 9.1, 2.3 } };
                 PrintAnyArr("aray1", aray1);
                    PrintAnyArr("aray2", aray2);
                        PrintAnyArr("aray3", aray3)*/

            //Задание 2
            /*string[] Mass = { "4", "1", "3", "4", "5", "6", "5" }, CopyMass = new string[6];
                Array.Copy(Mass,CopyMass, 6);
                    PrintAnyArr2("CopyMass", CopyMass);
            Console.WriteLine(Array.IndexOf(CopyMass, "3"));
            Console.WriteLine(Array.LastIndexOf(CopyMass, "5"));
                Array.Reverse(CopyMass);
            PrintAnyArr2("CopyMass", CopyMass);
                Array.Sort(CopyMass);
            PrintAnyArr2("CopyMass", CopyMass);
                    Console.WriteLine(Array.BinarySearch(CopyMass, "6"));*/

            //Задание 3
            /*int[,] Mass1 = { { 1,2,3 }, { 1,2,3 } };
             Console.WriteLine(Mass1.Length);//Возвращает общую длину массива
                Console.WriteLine(Mass1.GetLength(1));//Возвращает второе измерение массива
            PrintArr("Mass", Mass1); */

            //Задание 5
                /*object[] Aray = { 1, 2, 3 };
                object[] Mass = { 1.2, 1.4, 1.6 };
                    arra.PrintArObj("Aray", Aray);
                    arra.PrintArObj("Mass", Mass); */

            //Задание 6
            Console.WriteLine("Введите длину первого измерения массива");
                int raz1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите длину второго измерения массива");
                int raz2 = int.Parse(Console.ReadLine());
                int[,] Mass1 = new int[raz1, raz2];
                int[,] Mass2 = new int[5,5];
                    arra.CreateTwoDimAr(Mass2);
                        arra.CreateTwoDimAr(Mass1);
            Console.WriteLine("Введите индексы элементов для поиска значения");
                raz1 = int.Parse(Console.ReadLine());
                raz2 = int.Parse(Console.ReadLine());
            if (raz1 >= Mass1.GetLength(0) || raz2 >= Mass1.GetLength(1)) Console.WriteLine("Вы вышли за пределы массива");
                    else Console.WriteLine("Значение массива в точках ({0}, {1}) = {2}", raz1, raz2, Mass1[raz1, raz2]);
            PrintAnyArr("Mass1", Mass1);
            PrintAnyArr("Mass2", Mass2);
            Slozenie(Mass1, Mass2);
            Otnimanie(Mass1, Mass2);
            Ymnozenie(Mass1, Mass2);
            Delenie(Mass1, Mass2);
        }
    }
}