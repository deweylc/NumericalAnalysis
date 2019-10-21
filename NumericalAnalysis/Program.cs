using System;
using System.Collections;

namespace NumericalAnalysis
{
    class Program
    {

        static int count;
        static double wucha;
        Program()
        {
           
        }
        static void Main(string[] args)
        {
            wucha = 0.0001;
            double x = Double(0, 2);
            Console.WriteLine(x.ToString()+"  迭代次数："+count.ToString());
            double x1 = Newton(1);
            Console.WriteLine(x1.ToString()+"  迭代次数：" + count.ToString());
            Console.Read();
            
        }
        static double Double(double a,double b)//二分法
        {
            count = 0;
            double x=0;
            while(true)
            {
                double c = (a + b) / 2;
                if (Func(c) == 0)
                {
                    x = c;
                    return x;
                }
                if (b - a < wucha)
                {
                    x = c;
                    return x;
                }
                if (Func(a) * Func(c) < 0)
                {
                    b = c;
                }
                else
                {
                    a = c;
                }
                count++;
            }
        }
        static double Newton(double x0)//牛顿法
        {
            count = 0;
            double x = 0;
            double x1 = x0;
            double x2 = 0;
            x2 = Func(x0) / fun(x0);
            while(Math.Abs(x2-x1)>=wucha)
            {
                x1 = x2;
                x2=x1- Func(x1) / fun(x1);
                count++;
            }
            x = x2;
            return x;
        }
        static double Func(double x)
        {
            double y=0;
            y = Math.Pow(x, 4) - 1.4 * Math.Pow(x, 3) - 0.48 * Math.Pow(x, 2) + 1.408 * Math.Pow(x, 1) - 0.512 * Math.Pow(x, 0);
            return y;
        }
        static double fun(double x)
        {
            double y = 0;
            y = 4 * Math.Pow(x, 3) - 4.2 * Math.Pow(x, 2) - 0.96 * Math.Pow(x, 1) + 1.408 * Math.Pow(x, 0);
            return y;
        }
    }
}
