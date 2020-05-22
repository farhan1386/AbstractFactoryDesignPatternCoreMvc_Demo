namespace AbstractFactoryDesignPatternCoreMvc_Demo.Factory.AbstractFactory
{
    public class I7 : IProcessor
    {
        public string GetProcessor()
        {
            return Enumerations.Processor.I7.ToString();
        }
    }
    public class I5 : IProcessor
    {
        public string GetProcessor()
        {
            return Enumerations.Processor.I5.ToString();
        }
    }
}
