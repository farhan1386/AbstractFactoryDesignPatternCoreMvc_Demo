namespace AbstractFactoryDesignPatternCoreMvc_Demo.Factory.AbstractFactory
{
    public interface IComputerFactory
    {
        IBrand Brand();
        IProcessor Processor();
        ISystemType SystemType();
    }
}
