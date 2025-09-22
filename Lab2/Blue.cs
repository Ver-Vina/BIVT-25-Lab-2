using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here

            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here

            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
                public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0;
            double zn = 1;
            double elem = ch / zn;
            int i = 1;
            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            } while (elem > 0.0001);
            
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            while (S < L)
            {
                answer += h;
                S += S;
            }

            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double S1 = S;
            double k = 0;
            for (int i = 0; i < 7; i++)
            {
                a += S1;
                S1 = S1 + S1 * I * 0.01;
            }
            S1 = S;
            while (k < 100)
            {
                b += 1;
                k += S1;
                S1 = S1 + S1 * I * 0.01;
            }
            S1 = S;
            while (S1 <= 42)
            {
                c += 1;
                S1 = S1 + S1 * I * 0.01;
            }



            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            while (a <= b)
            {
                SY = SS + a * h;
                if (SY < 0.0001)
                    break;
                

                a += h;
            }
            // end

            return (SS, SY);
        }
    }
}
