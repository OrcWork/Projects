using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Task3
{
    class TimeEstimation
    {
        //Передаем сюда значения времени и расчитываем среднее время выполнения операции
        static ArrayList times = new ArrayList();
        public void TimeEstimationMiddle(string t)
        {
            if (times.Count == 10)
            {
                times.Clear();
            }
            times.Add(t);

        }
        public void Estimation()
        {
            times.Sort();
            double sum = 0;
            foreach (string time in times)
            {
                Console.WriteLine(time);
                try
                {
                    sum = sum + Convert.ToDouble(time);
                }
                catch
                {
                }
                
            }
            double mid = sum / 10;// расчет среднего времени операции
            Console.WriteLine("Среднее время выполнения: " + mid);
        }
    }
}
