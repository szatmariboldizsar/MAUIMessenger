using messaging_assignment.ViewModels;

namespace messaging_assignment.Pages;

public partial class MessagePage : ContentPage
{
	public MessagePage(MessageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}