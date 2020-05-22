namespace AbstractFactoryDesignPatternCoreMvc_Demo.Factory.AbstractFactory
{
    public class Laptop : ISystemType
    {
        public string GetSystemType()
        {
            return Enumerations.ComputerTypes.Laptop.ToString();
        }
    }
    public class Desktop : ISystemType
    {
        public string GetSystemType()
        {
            return Enumerations.ComputerTypes.Desktop.ToString();
        }
    }
}
