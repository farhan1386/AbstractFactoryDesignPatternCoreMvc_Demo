namespace AbstractFactoryDesignPatternCoreMvc_Demo.Managers
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 5;
        }

        public decimal GetPay()
        {
            return 10;
        }

        public decimal GetHouseAllowance()
        {
            return 150;
        }
    }
}
