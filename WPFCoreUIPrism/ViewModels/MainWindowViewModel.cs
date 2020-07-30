using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CoreData.Models;
using FluentValidation;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using StandardLibrary.Validator;
using WPFCore.Library;
using WPFCoreUIPrism.Events;


namespace WPFCoreUIPrism.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {

        private readonly IRegionManager _regionManager;

        public MainWindowViewModel(IRegionManager regionManager)
        {

            _regionManager = regionManager;

        }

        public string Title { get; set; } = TextItems.Title;




        private DelegateCommand<string> _navigateCommand = null;

        public DelegateCommand<string> NavigateCommand => _navigateCommand ?? ( new DelegateCommand<string>(ExecuteNavigateCommand));

        private void ExecuteNavigateCommand(string navigationPath)
        {
            if (string.IsNullOrEmpty(navigationPath))
            {
                throw new ArgumentNullException();
            }
            _regionManager.RequestNavigate(RegionNames.ContentRegion, navigationPath);
        }

  

    }
}
