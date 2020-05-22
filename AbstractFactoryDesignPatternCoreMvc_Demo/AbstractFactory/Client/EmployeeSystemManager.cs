namespace AbstractFactoryDesignPatternCoreMvc_Demo.Factory.AbstractFactory
{
    public class EmployeeSystemManager
    {
        readonly IComputerFactory _IComputerFactory;
        public EmployeeSystemManager(IComputerFactory computerFactory)
        {
            _IComputerFactory = computerFactory;
        }

        public string GetSystemDetails()
        {
            IBrand brand = _IComputerFactory.Brand();
            IProcessor processor = _IComputerFactory.Processor();
            ISystemType systemType = _IComputerFactory.SystemType();
            string returnValue = string.Format("{0} {1} {2}", brand.GetBrand(),
                systemType.GetSystemType(), processor.GetProcessor());
            return returnValue;
        }
    }
}
