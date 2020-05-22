namespace AbstractFactoryDesignPatternCoreMvc_Demo.Factory.AbstractFactory
{
    public class MAC : IBrand
    {
        public string GetBrand()
        {
            return Enumerations.Brand.APPLE.ToString();
        }
    }
}
