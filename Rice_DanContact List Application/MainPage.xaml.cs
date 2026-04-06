using Rice_DanContact_List_Application.ViewModels;

namespace Rice_DanContact_List_Application.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage(ContactViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
