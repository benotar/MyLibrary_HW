namespace HomeWork_22_01_2024;

public static class MyLibrary
{
    public static void MyReadLineInt(out int number)
        => int.TryParse(Console.ReadLine(), out number);

    public static void MyReadLineDouble(out double number)
        => double.TryParse(Console.ReadLine(), out number);

    public static void MyReadLineChar(out char ch)
        => char.TryParse(Console.ReadLine(), out ch);

    public static void MyWriteToFile(string? content, string pathFile, bool append = false)
    {
        using var writer = new StreamWriter(pathFile, append);

        writer.WriteLine(content);
    }

    public static string MyReadFile(string pathFile)
    {
        using var reader = new StreamReader(pathFile);

        return reader.ReadToEnd();
    }

    public static void MyMax<T>(List<T> list, out T result)
    {
        result = list.Count > 0 ? list.Max() : default;
    }

    public static void MyMin<T>(List<T> list, out T result)
    {
        result = list.Count > 0 ? list.Min() : default;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="number"></param>
    /// <returns>Returns a boolean value of true if the number is even, and false otherwise.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static bool MyIsEven<T>(T number)
    {
        if(typeof(T).IsPrimitive)
        {
            dynamic num = number!;

            return num % 2 == 0;
        }

        throw new ArgumentException("The type is invalid for this operation.");
    }


    public static void MyDateNow(out DateTime date)
    {
        date = DateTime.Now;
    }
}
