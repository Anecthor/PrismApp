using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using CoreData.Models;
using FluentValidation;
using Prism.Events;
using Prism.Regions;
using StandardLibrary.Validator;
using WPFCore.Library;
using WPFCoreUIPrism.Events;

namespace WPFCoreUIPrism.ViewModels
{
    public class MainButtonsViewModel : BindableBase
    {
        private string _helloText;
        private Hello _hello;
        private HelloValidator _helloValidator;
        private IEventAggregator _eventAggregator;
        private readonly IRegionManager _regionManager;
        private int _clickcounter = 0;

        public MainButtonsViewModel(Hello hello, HelloValidator helloValidator, IEventAggregator eventAggregator, IRegionManager regionManager)
        {
            _hello = hello;
            _helloValidator = helloValidator;
            _eventAggregator = eventAggregator;
            _regionManager = regionManager;
            _eventAggregator.GetEvent<CommandSayHelloClickedEvent>().Subscribe(OnEventTriggerd, ThreadOption.UIThread);
        }


        public string Title { get; set; } = TextItems.Title;


        public string HelloText
        {
            get => _helloText;
            set
            {
                SetProperty(ref _helloText, value);
                _hello.HelloText = _helloText;
                //CommandSayHello.RaiseCanExecuteChanged();
                CommandDeleteHello.RaiseCanExecuteChanged();
            }
        }


        private DelegateCommand _commandSayHello = null;

        public DelegateCommand CommandSayHello => _commandSayHello ??= new DelegateCommand(CommandSayHelloExecute, CanSayHello).ObservesProperty(() => HelloText);

        private void CommandSayHelloExecute()
        {

            _clickcounter++;
            HelloText = "Hello World";
            _eventAggregator.GetEvent<CommandSayHelloClickedEvent>().Publish(_clickcounter);

        }

        private bool CanSayHello()
        {

            var result = _helloValidator.Validate(_hello, ruleSet: "isEmpty");
            return result.IsValid;
        }
        private DelegateCommand _commandDeleteHello = null;

        public DelegateCommand CommandDeleteHello => _commandDeleteHello ??= new DelegateCommand(CommandDeleteHelloExecute, CanDeleteHello);//.ObservesProperty(() => HelloText);

        private void CommandDeleteHelloExecute()
        {
            HelloText = "";
        }

        private bool CanDeleteHello()
        {

            var result = _helloValidator.Validate(_hello, ruleSet: "notEmpty");
            return result.IsValid;
        }

        private void OnEventTriggerd(int counter)
        {
            HelloText = $"Hello World {counter}";
        }
    }
}
