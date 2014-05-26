using Microsoft.Practices.Unity;

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
            // Prepare
            var container = new UnityContainer();
            container.RegisterType<IPresentationLayer, PresentationLayer>();
            container.RegisterType<INumberProcessor, NumberProcessor>();
            container.RegisterType<ICoefficientProvider, ConstantCoefficientProvider>();

            // Do work
            container.Resolve<IPresentationLayer>().DoWork();
        }
    }
}
