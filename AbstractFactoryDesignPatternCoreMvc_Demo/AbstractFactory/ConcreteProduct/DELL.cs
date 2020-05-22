namespace AbstractFactoryDesignPatternCoreMvc_Demo.Factory.AbstractFactory
{
    public class DELL : IBrand
    {
        public string GetBrand()
        {
            return Enumerations.Brand.DELL.ToString();
        }
    }
}
