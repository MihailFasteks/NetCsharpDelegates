using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCsharpDelegates
{
    delegate int[] MyDelegate();
    public class MyArray
    {
        public int[] Array { get; set; }


        public MyArray(int s)
        {
            Array = new int[s];
        }
        public int[] getEven()
        {
            int[] temp = new int[Array.Length];
            int count = 0;
            foreach (int t in Array)
            {
                if (t % 2 == 0)
                {
                    temp[count] = t;
                    count++;
                }
            }
            return temp.Take(count).ToArray();
        }
        public int[] getOdd()
        {
            int[] temp = new int[Array.Length];
            int count = 0;
            foreach (int t in Array)
            {
                if (t % 2 != 0)
                {
                    temp[count] = t;
                    count++;
                }
            }
            return temp.Take(count).ToArray();
        }
        public int[] getSimple()
        {
            int[] temp = new int[Array.Length];
            int count = 0;
            int counter = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    if (Array[i] % j == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 2)
                {
                    temp[count] = Array[i];
                }
                counter = 0;
            }
            return temp.Take(count).ToArray();
        }
        public int[] getFib()
        {
            int[] temp = new int[Array.Length];
            int count = 0;


            for (int i = 2; i < Array.Length; i++)
            {
                if (Array[i] == (Array[i - 1] + Array[i - 2]))
                {
                    temp[count] = Array[i];
                    count++;
                }
            }
            return temp.Take(count).ToArray();
        }
    }
    public class Class1
    {
        public void getCurrentTime()
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime.ToString("T"));
        }
        public void getCurrentDate()
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime.ToString("D"));
        }
        public void getCurrentDayOfWeek()
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime.ToString("dddd"));
        }
        public int TriangSquare(int a, int h)
        {
            return (int)((a * h) / 2);
        }
        public int RectSquare(int a, int b)
        {
            return (int)(a * b);
        }
        public bool Task1(int a)
        {
            return a > 16;
        }
    }
    public delegate void CreditCardHandler(string message);
    public class CreditCard
    {
        public string CardNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SureName { get; set; }
        public string FinishDate { get; set; }
        public int PIN { get; set; }
        public decimal Limit { get; set; }
        public decimal Sum { get; set; }
        public CreditCard(string cn, string n, string ln, string sn, string fd, int pin, decimal l, decimal sum)
        {
            CardNumber = cn;
            Name = n;
            LastName = ln;
            SureName = sn;
            FinishDate = fd;
            PIN = pin;
            Limit = l;
            Sum = sum;
        }
        public void PutSum(decimal sum)
        {
            if (sum < 0)
            {
                del?.Invoke("Неверно введена сумма");

            }
            else
            {
                del?.Invoke("Введите текущий ПИН");
                int checkPIN = int.Parse(Console.ReadLine());

                if (checkPIN == PIN)
                {
                    Sum += sum;
                    del?.Invoke($"Счет пополнен на {sum} грн");
                }
                else
                {

                    del?.Invoke("ПИН введен неверно!");
                }
            }
          
          
        }
        public void PullSum(decimal sum)
        {
            if (sum < 0)
            {
                del?.Invoke("Неверно введена сумма");

            }
            else
            {
                if (Sum < 0)
                {
                    del?.Invoke("Вы используете кредитные деньги!");
                }
                if ((Sum - sum) < (-Limit))
                {
                    del?.Invoke("Вы не можете выйти за рамки кредитного лимита");
                }
                else
                {
                    Sum -= sum;
                    del?.Invoke($"Сумма {sum} грн снята со счета");
                }
                    
            }
            
        }
        public void ChangePin()
        {
            del?.Invoke("Введите текущий ПИН");
            int checkPIN = int.Parse(Console.ReadLine());

            if (checkPIN == PIN) {
                del?.Invoke("Введите новый ПИН");
                PIN = int.Parse(Console.ReadLine());
            }
            else
            {
                del?.Invoke("ПИН введен неверно!");
            }
        }
     
        CreditCardHandler del;

        public void RegisterHandler(CreditCardHandler _del)
        {
             del += _del;
        }
        public void UnregisterHandler(CreditCardHandler _del)
        {
           
             del -= _del; 
        }

    }
}
