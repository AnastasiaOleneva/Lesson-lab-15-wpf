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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Xps;
using System.Windows.Xps.Packaging;
using System.Windows.Markup;

namespace _15._2_WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            flowDSW.ClearValue(FlowDocumentScrollViewer.DocumentProperty);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = File.Open("WPFinfo.xaml", FileMode.Create)) 
            {

                XamlWriter.Save(flowDSW.Document, fs);


            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = File.Open("WPFinfo.xaml", FileMode.Open))
            {

                flowDSW.Document = XamlReader.Load(fs) as FlowDocument;


            }
        }
    }
}