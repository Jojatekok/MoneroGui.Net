﻿using System.Windows;

namespace Jojatekok.MoneroGUI.Windows
{
    public partial class AddressBookAddWindow
    {
        public AddressBookAddWindow()
        {
            Icon = StaticObjects.ApplicationIcon;
            Loaded += delegate {
                this.HideMinimizeAndMaximizeButtons();

                MaxHeight = ActualHeight;
                MinHeight = ActualHeight;
            };

            InitializeComponent();
        }

        public AddressBookAddWindow(Window owner) : this()
        {
            Owner = owner;
        }
    }
}