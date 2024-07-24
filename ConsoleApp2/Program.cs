namespace SingletonAsBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 88; i < 1120; i++)
            {
                dic.Add(i, i);
            }
            var singleton = SingletonMy.GetInstance();
            var result = singleton.GetNumbers(dic);
            singleton.Age = 28;
            Console.WriteLine("Hello, World!");
        }
    }
}
