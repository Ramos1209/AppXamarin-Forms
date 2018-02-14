using AppXamarin_Forms.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppXamarin_Forms.Views
{
    public partial class TelaPrincipal : ContentPage
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            BindingContext = new TelaPrincipalViewModel();
        }
    }
}
