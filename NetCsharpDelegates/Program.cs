// See https://aka.ms/new-console-template for more information
using NetCsharpDelegates;
using System.Security.Principal;
using System.Xml.Linq;
//task1
//MyArray arr1 = new MyArray(10);
//Random rnd = new Random();
//for (int i = 0; i < arr1.Array.Length; i++)
//{
//    arr1.Array[i]= rnd.Next(1, 100);
//}
//MyDelegate dg = new MyDelegate(arr1.getEven);

//foreach(int t in arr1.Array)
//{
//    Console.Write(t + " ");
//}
//Console.WriteLine();

//foreach (int t in dg())
//{
//    Console.Write(t + " ");
//}
//Console.WriteLine();

//dg=new MyDelegate(arr1.getOdd);

//foreach (int t in dg())
//{
//    Console.Write(t + " ");
//}
//Console.WriteLine();

//dg = new MyDelegate(arr1.getSimple);

//foreach (int t in dg())
//{
//    Console.Write(t + " ");
//}
//Console.WriteLine();

//dg = new MyDelegate(arr1.getFib);

//foreach (int t in dg())
//{
//    Console.Write(t + " ");
//}
//Console.WriteLine();

//task2
//Class1 cl1 = new Class1();
//Action act = cl1.getCurrentDate;
//act += cl1.getCurrentTime;
//act += cl1.getCurrentDayOfWeek;
//foreach (Action item in act.GetInvocationList())
//{
//    item();
//}

//Predicate<int> action1 = new Predicate<int>(cl1.Task1);
//Console.WriteLine(action1(cl1.TriangSquare(2,4)));
//Console.WriteLine(action1(cl1.RectSquare(2, 4)));

//task3

CreditCard card = new CreditCard(
      "1234567812345678",
      "Иван",
      "Иванов",
      "Иванович",
      "12/30",
      1234,
0,
0
);

card.del+=Show_Message;

card.PutSum(120);
card.PullSum(1300);
card.ChangePin();
static void Show_Message(string message)
{
    Console.WriteLine(message);
}


