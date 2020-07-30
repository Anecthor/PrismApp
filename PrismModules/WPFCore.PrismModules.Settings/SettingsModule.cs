using WPFCore.PrismModules.Settings.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using WPFCore.Library;

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
            _regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(Views.Settings));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}