﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WPFCore.Business
{
    public class NavigationItem
    {
        public string Caption { get; set; }
        public string NavigationPath { get; set; }
        public ObservableCollection<NavigationItem> Items { get; set; }
    }
}