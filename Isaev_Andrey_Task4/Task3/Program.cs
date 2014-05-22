using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Diagnostics;
using System.Threading;

namespace Task3
{
    class Program
    {
        delegate string Del(string str, Array array);
        delegate string ElemetSeacher(string str3, Array array3);
        static void Main(string[] args)
        {
            //Задаем массив
            int[] array = { 1, 2, -3, 4, 5, 6, -7, 8, 9, 10 };
            string value = "negative";
            Stopwatch stopWatch = new Stopwatch();
            TimeEstimation te = new TimeEstimation();

            //Использование расширенного метода для нахождения отрицательных элементо
            Console.WriteLine("Использование расширенного метода для нахождения отрицательных элементов");
            for (int i = 0; i < 10; i++)
            {
                stopWatch.Reset();
                stopWatch.Start();
                Console.WriteLine(array.NegativeSearch());
                stopWatch.Stop();
                TimeSpan ts1 = stopWatch.Elapsed;
                Console.WriteLine("RunTime " + ts1.TotalMilliseconds);
                string ts11 = ts1.TotalMilliseconds.ToString();
                te.TimeEstimationMiddle(ts11);
            }
            te.Estimation();

            //Использзование делегата для вызова метода
            Console.WriteLine(" ");
            Console.WriteLine("Использзование делегата для вызова метода");
            for (int i = 0; i < 10; i++)
            {
                stopWatch.Reset();
                stopWatch.Start();
                SearchArray2 sa2 = new SearchArray2();
                Del del = new Del(sa2.ElementSeacher);
                string s2 = del(value, array);
                Console.WriteLine(s2);
                stopWatch.Stop();
                TimeSpan ts2 = stopWatch.Elapsed;
                Console.WriteLine("RunTime " + ts2.TotalMilliseconds);
                string ts22 = ts2.TotalMilliseconds.ToString();
                te.TimeEstimationMiddle(ts22);
            }
            te.Estimation();

            //Использование анонимного метода
            Console.WriteLine(" ");
            Console.WriteLine("Использование анонимного метода");
            for (int i = 0; i < 10; i++)
            {
                stopWatch.Reset();
                stopWatch.Start();
                string s3 = "";
                ElemetSeacher elmtsrch = delegate(string str3, Array array3)
                {
                    if (str3 == "negative")
                    {
                        foreach (int arr in array)
                        {
                            if (arr < 0)
                            {
                                s3 = s3 + " " + arr.ToString();
                            }
                        }
                    }
                    if (str3 == "positive")
                    {
                        foreach (int arr in array)
                        {
                            if (arr > 0)
                            {
                                s3 = s3 + " " + arr.ToString();
                            }
                        }
                    }
                    return s3;
                };
                string st3 = elmtsrch(value, array);
                Console.WriteLine(st3);
                stopWatch.Stop();
                TimeSpan ts3 = stopWatch.Elapsed;
                Console.WriteLine("RunTime " + ts3.TotalMilliseconds);
                string ts33 = ts3.TotalMilliseconds.ToString();
                te.TimeEstimationMiddle(ts33);
            }
            te.Estimation();


            //Использование лямбда выражение
            Console.WriteLine(" ");
            Console.WriteLine("Использование лямбда выражение");
            for (int i = 0; i < 10; i++)
            {
                stopWatch.Reset();
                stopWatch.Start();
                string s4 = "";
                Func<string, Array, string> elmtsrch4 = (str4, array4) =>
                {
                    if (str4 == "negative")
                    {
                        foreach (int arr in array)
                        {
                            if (arr < 0)
                            {
                                s4 = s4 + " " + arr.ToString();
                            }
                        }
                    }
                    if (str4 == "positive")
                    {
                        foreach (int arr in array)
                        {
                            if (arr > 0)
                            {
                                s4 = s4 + " " + arr.ToString();
                            }
                        }
                    }
                    return s4;
                };

                string st4 = elmtsrch4(value, array);
                Console.WriteLine(st4);
                stopWatch.Stop();
                TimeSpan ts4 = stopWatch.Elapsed;
                Console.WriteLine("RunTime " + ts4.TotalMilliseconds);
                string ts44 = ts4.TotalMilliseconds.ToString();
                te.TimeEstimationMiddle(ts44);
            }
            te.Estimation();


            //Использование LINQ
            Console.WriteLine(" ");
            Console.WriteLine("Использование LINQ");
            for (int i = 0; i < 10; i++)
            {
                stopWatch.Reset();
                stopWatch.Start();
                string st5 = "";
                var NegativeElement =
                    from arr in array
                    where arr < 0
                    select arr;
                foreach (var n in NegativeElement)
                {
                    st5 = st5 + " " + n;
                }
                Console.WriteLine(st5);
                stopWatch.Stop();
                TimeSpan ts5 = stopWatch.Elapsed;
                Console.WriteLine("RunTime " + ts5.TotalMilliseconds);
                string ts55 = ts5.TotalMilliseconds.ToString();
                te.TimeEstimationMiddle(ts55);
            }
            te.Estimation();

            Console.ReadKey();
        }

    }
}
