using MAUIMessenger.ViewModels;

namespace MAUIMessenger.Pages;

public partial class UsersPage : ContentPage
{
	public UsersPage(UsersViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (BindingContext is UsersViewModel vm)
        {
            Task.Run(() => vm.ResortUserCategories());
        }
    }
}