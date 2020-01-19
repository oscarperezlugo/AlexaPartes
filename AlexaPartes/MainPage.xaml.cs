using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using AlexaPartes.models;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AlexaPartes
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Scan scan = new Scan();
            scan.articulo = Articulo.Text;
            scan.almacen = Almacen.Text;
            scan.parte = Parte.Text;
        }
    }
}
