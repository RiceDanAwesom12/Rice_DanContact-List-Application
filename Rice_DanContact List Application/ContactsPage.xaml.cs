using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rice_DanContact_List_Application.ViewModels;

namespace Rice_DanContact_List_Application.Views
{
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage(ContactViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}
