namespace ConsoleApplication2
{
    public class DatabaseCoefficientProvider : ICoefficientProvider
    {
        public double GetCoefficient()
        {
            // Здесь лезем в базу и читаем значение параметра
            // return Database.ReadCoeff();

            return 0;
        }
    }
}