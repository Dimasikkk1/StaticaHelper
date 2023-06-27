﻿using StaticaHelper.Views;

namespace StaticaHelper.Forms
{
    internal partial class SettingsForm : BaseForm, ISettingsView
    {
        public string IP
        {
            get => textBoxIP.Text;
            set => textBoxIP.Text = value;
        }

        public string Port 
        { 
            get => textBoxPort.Text;
            set => textBoxPort.Text = value;
        }

        public string Username 
        { 
            get => textBoxUsername.Text;
            set => textBoxUsername.Text = value;
        }

        public string Password
        {
            get => textBoxPassword.Text;
            set => textBoxPassword.Text = value;
        }

        public string DataBase 
        { 
            get => textBoxDatabase.Text;
            set => textBoxDatabase.Text = value;
        }

        public SettingsForm() : base() => InitializeComponent();
    }
}
