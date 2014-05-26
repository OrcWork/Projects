namespace ConsoleApplication2
{
    /// <summary>
    /// Программа для умножения чисел на коэффициент, хранящийся в базе
    /// Бемысленно, но показывает работу всех трёх слоёв
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            new PresentationLayer().DoWork();
        }
    }
}
