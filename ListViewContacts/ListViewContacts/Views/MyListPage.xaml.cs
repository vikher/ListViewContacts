using ListViewContacts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewContacts.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyListPage : ContentPage
	{
		public MyListPage ()
		{
			InitializeComponent ();
            BindingContext = new MyListViewModel();

        }
    }
}