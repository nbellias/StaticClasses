namespace StaticClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Static classes");
            MyClass.DoSomething(DateTime.Now);
            Thread.Sleep(2000);
            MyClass.DoSomething(DateTime.Now);
            Thread.Sleep(2000);
            MyClass.DoSomething(DateTime.Now);
        }
    }
}