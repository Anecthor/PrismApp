using WPFCore.PrismModules.DataTransfer.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using WPFCore.Library;

namespace WPFCore.PrismModules.DataTransfer
{
    public class DataTransferModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public DataTransferModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(Views.ViewA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}