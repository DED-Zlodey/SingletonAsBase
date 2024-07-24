namespace SingletonAsBase;

/// <summary>
/// 3. Реализовать функцию, возвращающую все числа от 0 до 100, которых нет во входящей коллекции
/// </summary>
public class SingletonMy : SingletonCustom<SingletonMy>
{
    public List<int> GetNumbers(Dictionary<int, int> numbers)
    {
        var result = new List<int>();
        for (int i = 0; i < 100; i++)
        {
            if (!numbers.ContainsKey(i))
            {
                result.Add(i);
            }
        }
        return result;
    }
}