﻿using System;
using System.ComponentModel;

namespace WPFMySQLMVVM.Models
{
    public class User : INotifyPropertyChanged
    {
        #region VARIABLES
        public event PropertyChangedEventHandler? PropertyChanged;
        private String _user = "";
        private String _mail = "";
        private String _age = "";
        #endregion

        #region OBJETOS
        public String userName
        {
            get { return _user; }
            set
            {
                _user = value;
                OnPropertyChange("userName");
            }
        }
        public String mail
        {
            get { return _mail; }
            set
            {
                _mail = value;
                OnPropertyChange("mail");
            }
        }

        public String age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChange("age");
            }
        }
        #endregion

        //Método que se encarga de actualizar las propiedades en cada cambio
        private void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

