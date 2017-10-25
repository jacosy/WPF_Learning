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
using Wpf_Learning.ViewModel;

namespace Wpf_Learning
{
    /// <summary>
    /// Interaction logic for DataBindingTwoWay.xaml
    /// </summary>
    public partial class DataBindingTwoWay : Window
    {
        public DataBindingTwoWay()
        {
            InitializeComponent();
            this.DataContext = Employee.GetEmployee();
        }
    }
}
