﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FitnesClub.View.MainMenu
{
    /// <summary>
    /// Логика взаимодействия для MainMenuAdministrator.xaml
    /// </summary>
    public partial class MainMenuAdministrator : Window
    {
        public MainMenuAdministrator()
        {
            InitializeComponent();
            ViewModel.Helper.MenuHelper.CloseWindow = new Action(() => this.Close());
            DataContext = new ViewModel.MainMenuViewModel.MainMenuAdministratorViewModel();
        }
    }
}
