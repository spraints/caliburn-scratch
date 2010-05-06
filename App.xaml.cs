using Caliburn.Core;
using Caliburn.PresentationFramework.ApplicationModel;
using Caliburn.StructureMap;
using StructureMap;
using Microsoft.Practices.ServiceLocation;

namespace Scratch
{
    public partial class App : CaliburnApplication
    {
        protected override IServiceLocator CreateContainer()
        {
            var structureMap = new Container(config =>
            {
                config.Scan(scan =>
                {
                    scan.WithDefaultConventions();
                    scan.TheCallingAssembly();
                });

                config.ForSingletonOf<MyDataModel>();
            });

            return new StructureMapAdapter(structureMap);
        }

        protected override void BeforeStart(CoreConfiguration core)
        {
            base.BeforeStart(core);
            core.AfterStart(() =>
            {
                var binder = (DefaultBinder)Container.GetInstance<IBinder>();
                binder.EnableBindingConventions();
                binder.EnableMessageConventions();
            });
        }

        protected override object CreateRootModel()
        {
            return Container.GetInstance<ShellViewModel>();
        }
    }
}
