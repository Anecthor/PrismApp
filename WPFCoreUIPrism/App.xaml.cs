using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using CoreData.Models;
using Prism;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Ninject;
using Prism.Regions;
using StandardLibrary.Validator;
using WPFCore.Library;
using WPFCore.PrismModules.Settings;

namespace WPFCoreUIPrism
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<Hello>();
            containerRegistry.RegisterSingleton<HelloValidator>();
            
        }

        protected override Window CreateShell()
        {
            var window = Container.Resolve<Views.MainWindow>();
            return window;
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<SettingsModule>();
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }
    }
    
}
