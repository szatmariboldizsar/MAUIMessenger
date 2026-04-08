using MAUIMessenger.ViewModels;

namespace MAUIMessenger.Pages;

public partial class MessagePage : ContentPage
{
	public MessagePage(MessageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}