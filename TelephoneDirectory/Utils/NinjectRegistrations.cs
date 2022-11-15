using Model.Interface;
using Model.Repositories;
using Ninject.Modules;
using Ninject.Web.Common;

namespace TelephoneDirectory.Utils
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            //Bind<IPhoneDictionary>().To<FileRepository>().InTransientScope();
            //Bind<IPhoneDictionary>().To<FileRepository>().InThreadScope();
            //Bind<IPhoneDictionary>().To<FileRepository>().InRequestScope();

            Bind<IPhoneDictionary>().To<DbRepository>().InTransientScope();
            //Bind<IPhoneDictionary>().To<DbRepository>().InThreadScope();
            //Bind<IPhoneDictionary>().To<DbRepository>().InRequestScope();
        }
    }
}