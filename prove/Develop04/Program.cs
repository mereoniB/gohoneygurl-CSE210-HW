//using System;

//class Program;
//public class
{
   // static void Main(string[] args)
   //{
    //    Console.WriteLine("Hello Develop04 World!");
   // }
   // [10:13 AM] Lythgoe, BradImportant!Week 04 Spinner and Countdown
    //General I wanted to share this code with you so you don't have to try and figure out the spinner or countdown yourself. I used this code on my 'Activity' class..



//publicvoiddisplaySpinner(intnumSecondsToRun)
    //{​​​​​​​​​
//Stopwatchstopwatch = newStopwatch();
//stopwatch.Start();

//while (stopwatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        //{​​​​​​​​​
//spinnerCounter++;        
//switch (spinnerCounter % 4)
            //{​​​​​​​​​
//case0: Console.Write("/"); break;
//case1: Console.Write("-"); break;
//case2: Console.Write("\\"); break;
//case3: Console.Write("|"); break;
           // }​​​​​​​​​
//Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
//Thread.Sleep(200);
  //      }​​​​​​​​​

 // public class A
//{
 //   private int _value = 10;

  //  public class B : A
   // {
   //     public int GetValue()
   //     {
   ////         return _value;
   //     }
   // }
//

//public class C : A
//{
    //    public int GetValue()
    //    {
    //        return _value;
    //    }/
//}

//

//public class A
//{
   // public void Method1()
   // {
        // Method implementation.
    //}
//}

//p//ublic class B : A
{ }

//public class Example
//{
    //public static void Main()
    //{
       // B b = new ();
        //b.Method1();


   // }

//}
//public abstract class A
//{
   // public abstract void Method1();
//}

//public class B : A // Generates CS0534.
//{
   // public void Method3()
   // {
        // Do something.
  //  }
//}
//public struct ValueStructure : ValueType // Generates CS0527.
//{
//}

// Base class
public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

// Derived class
public class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Meowing...");
    }
}

// Usage
Cat cat = new Cat();
cat.Name = "Fluffy";
cat.Age = 3;
cat.Eat(); // Output: Eating...
cat.Meow(); // Output: Meowing...

