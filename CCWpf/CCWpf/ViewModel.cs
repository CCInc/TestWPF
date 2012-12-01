﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CCWpf
{
    public class ViewModel : UnifiedViewModelBase
    {
        public ViewModel()
        {
            Name = "DefaultName";
            Urls = new ObservableCollection<UrlDummy>(new[]
                                                          {
                                                              new UrlDummy
                                                                  {
                                                                      Browser = Browser.Chrome,
                                                                      Url = @"http://chat.stackoverflow.com/rooms/7/c"
                                                                  },
                                                              new UrlDummy
                                                                  {
                                                                      Browser = Browser.FF,
                                                                      Url = @"http://www.e-pedro.com/2009/07/a-view-model-base-class-to-use-with-mvvm-in-wpf/"
                                                                  },
                                                          });
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public ObservableCollection<UrlDummy> Urls { get; private set; }
    }

    public class UrlDummy : UnifiedViewModelBase
    {
        private string _url;
        public string Url
        {
            get { return _url; }
            set
            {
                _url = value;
                OnPropertyChanged("Url");
            }
        }

        private Browser _browser;
        public Browser Browser
        {
            get { return _browser; }
            set
            {
                _browser = value;
                OnPropertyChanged("Browser");
            }
        }
    }

    public enum Browser
    {
        Chrome,
        IE,
        FF
    }
}
