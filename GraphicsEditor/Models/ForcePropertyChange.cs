﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GraphicsEditor.Models
{
    public class ForcePropertyChange : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void UpdProperty([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
