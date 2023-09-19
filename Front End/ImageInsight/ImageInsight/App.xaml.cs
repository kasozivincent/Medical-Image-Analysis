using System.Windows;
using Prism.Ioc;
using Prism.Unity;

namespace ImageInsight
{
    public partial class App : PrismApplication
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
        
        protected override Window CreateShell()
                 => Container.Resolve<MainWindow>();
    }
}