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
using GestionCommercialeDll;
namespace WpfWinGest
{
    /// <summary>
    /// Logique d'interaction pour WConsultClient1.xaml
    /// </summary>
    public partial class WConsultClient1 : Window
    {
        public WConsultClient1(Client client)
        {
            InitializeComponent();


            lblIdClient.Content = client.IdClient;
        }
    }
}
