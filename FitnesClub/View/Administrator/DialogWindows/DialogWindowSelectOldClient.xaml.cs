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

namespace FitnesClub.View.Administrator.DialogWindows
{
    /// <summary>
    /// Логика взаимодействия для DialogWindowSelectOldClient.xaml
    /// </summary>
    public partial class DialogWindowSelectOldClient : Window
    {
        public DialogWindowSelectOldClient()
        {
            InitializeComponent();
            DataContext = new ViewModel.AdministratorViewModel.DialogWindowsViewModel.DialogWindowSelectOldClientViewModel();
            ViewModel.Helper.HelperDialogWindows.DialogResult = new Action(() => this.DialogResult = true);
        }

        private void TextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            this.PopupListClient.IsOpen = true;
        }
    }
}
