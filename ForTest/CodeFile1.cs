using System;

class Test
{
    public static void Main(string[] args)
    {
        MyClass myClass = new MyClass();
        myClass.S1 = "TEST";
        myClass.h1();
        myClass.H1();
        myClass.e1();
        myClass.h1();
        myClass.H1();
        //Console.WriteLine("Hello World!!!");
        Console.ReadKey();
    }
}

class MyClass
{
    private int v1;
    private string s1;

    public int V1 { get => v1; set => v1 = value; }
    public string S1 { get => s1; set => s1 = value; }

    public void h1()
    {
        Console.WriteLine(s1);
    }

    public void H1()
    {
        Console.WriteLine(S1);
    }

    public void e1()
    {
        s1 += s1 + "Edit";
    }
}





