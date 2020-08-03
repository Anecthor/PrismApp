using WPFCore.PrismModules.Settings.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using WPFCore.Library;

using WPFCore.PrismModules.Settings.ViewModels;

namespace WPFCore.PrismModules.Settings
{
    public class SettingsModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public SettingsModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.SettingsRegion, typeof(Views.Settings));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //hiermit kann das autowire viewmodel im xaml, welches auf die verwendung der namespaces views / viemodels angewiesen ist, überschrieben werden
            // dadurch kann man seine views und viewmodels in beliebige verzeichnisse packen
            ViewModelLocationProvider.Register<Views.Settings, SettingsViewModel>();
        }
    }
}