using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Rice_DanContact_List_Application.ViewModels
{
    public partial class ContactViewModel : BaseViewModel
    {
        public ObservableCollection<ContactModel> Contacts { get; set; } = new();

        [ObservableProperty]
        private string name = string.Empty;

        [ObservableProperty]
        private string email = string.Empty;

        [ObservableProperty]
        private string phoneNumber = string.Empty;

        [ObservableProperty]
        private string description = string.Empty;

        [ObservableProperty]
        private ContactModel? selectedContact = null;

        [RelayCommand]
        private async Task AddContact()
        {
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Email))
                return;

            Contacts.Add(new ContactModel
            {
                Name = Name,
                Email = Email,
                PhoneNumber = PhoneNumber,
                Description = Description
            });

            Name = Email = PhoneNumber = Description = string.Empty;

            await Shell.Current.GoToAsync("//ContactsPage");
        }

        [RelayCommand]
        private async Task GoToDetails()
        {
            if (SelectedContact is null) return;

            await Shell.Current.GoToAsync("//ContactDetailsPage");
        }

        [RelayCommand]
        private async Task GoToAddPage()
        {
            await Shell.Current.GoToAsync("//MainPage");
        }

        [RelayCommand]
        private async Task UpdateContact()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
