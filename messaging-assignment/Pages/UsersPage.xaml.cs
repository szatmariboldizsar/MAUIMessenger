using messaging_assignment.ViewModels;

namespace messaging_assignment.Pages;

public partial class UsersPage : ContentPage
{
	public UsersPage(UsersViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}