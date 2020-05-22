using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPatternCoreMvc_Demo.Factory.AbstractFactory
{
    public interface IComputerFactory
    {
        IBrand Brand();
        IProcessor Processor();
        ISystemType SystemType();
    }
}
