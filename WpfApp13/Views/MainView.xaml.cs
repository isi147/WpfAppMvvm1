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
using WpfApp13.Command;

namespace WpfApp13.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public ICommand ShowCommand { get; set; }
        public MainView()
        {
            InitializeComponent();
            DataContext = this;
            ShowCommand = new RelayCommand(ExecuteShowCommand,CanExecuteShowCommand);
        }
        void ExecuteShowCommand(object? parametr)
        {
            MessageBox.Show(txtBox.Text);
        }
        bool CanExecuteShowCommand(object? parametr)
        {
            return txtBox.Text!="";
        }
    }
}
