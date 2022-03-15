using BasketBusiness.Services;
using BasketBusiness.Services.Implementation;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketBusiness
{
    public class ServiceFactory
    {
        static internal StandardKernel Kernel { get; set; } = new StandardKernel(new BasketModule());
        public static I GetA<I>() => Kernel.Get<I>();
    }

    internal class BasketModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBasketServices>().To<BasketServices>();
        }
    }
}
