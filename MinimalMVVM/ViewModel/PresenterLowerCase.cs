﻿using MinimalMVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MinimalMVVM.ViewModel
{
    public class PresenterLowerCase : ObservableObject
    {
        private readonly TextConverter _textConverter = new TextConverter(s => s.ToLower());
        private string _someText;
        private readonly ObservableCollection<string> _history = new ObservableCollection<string>();

        public PresenterLowerCase(ObservableCollection<string> history, string someText)
        {
            _someText = someText;
            _history = history;
        }


        public string Name { get; } = "LowerCase Mode";

        public string SomeText
        {
            get { return _someText; }
            set
            {
                _someText = value;
                RaisePropertyChangedEvent("SomeText");
            }
        }

        public IEnumerable<string> History
        {
            get { return _history; }
        }

        public ICommand ConvertTextCommand
        {
            get { return new DelegateCommand(ConvertText); }
        }

        private void ConvertText()
        {
            AddToHistory(_textConverter.ConvertText(SomeText));
            SomeText = String.Empty;
        }

        private void AddToHistory(string item)
        {
            if (!_history.Contains(item))
                _history.Add(item);
        }
    }

}
