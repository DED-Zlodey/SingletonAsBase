namespace SingletonAsBase;

/// <summary>
/// 1. Реализовать подход Singleton
/// 2. Реализовать подход Singleton в качестве родительского класса
/// </summary>
/// <typeparam name="T"></typeparam>
public class SingletonCustom<T> where T : SingletonCustom<T>, new()
{
    public int Age { get; set; }

    private readonly static T Instance = new();
    
    public static T GetInstance()
    {
        return Instance;
    }
}