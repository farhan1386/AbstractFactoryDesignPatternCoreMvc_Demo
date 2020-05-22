using AbstractFactoryDesignPatternCoreMvc_Demo.Models;

namespace AbstractFactoryDesignPatternCoreMvc_Demo.Factory.AbstractFactory
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee e)
        {
            IComputerFactory returValue = null;

            if (e.EmployeeTypeId == 1)
            {
                if (e.Position == "Manager")
                {
                    returValue = new MACLaptopFactory();
                }
                else
                {
                    returValue = new MACFactory();
                }
            }
            else if (e.EmployeeTypeId == 2)
            {
                if (e.Position == "Manager")
                {
                    returValue = new DellLaptopFactory();
                }
                else
                {
                    returValue = new DellFactory();
                }
            }
            return returValue;
        }
    }
}
