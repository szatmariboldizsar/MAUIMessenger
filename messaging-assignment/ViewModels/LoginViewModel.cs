using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DAL.Models;
using DAL.Services;
using messaging_assignment.Pages;
using messaging_assignment.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace messaging_assignment.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        private readonly UserService _userService;
        private readonly AuthService _authService;

        public LoginViewModel(UserService userService, AuthService authService)
        {
            _userService = userService;
            _authService = authService;
        }

        [ObservableProperty]
        public partial string Username { get; set; } = string.Empty;

        [ObservableProperty]
        public partial string Password { get; set; } = string.Empty;

        [ObservableProperty]
        public partial string ErrorMessage { get; set; } = string.Empty;

        [ObservableProperty]
        public partial int Count { get; set; } = 0;

        [ObservableProperty]
        public partial string CounterText { get; set; } = string.Empty;

        [RelayCommand]
        async Task Login()
        {
            User? user = await _userService.GetUserByUsernameAsync(Username);

            if (user != null && PasswordHasher.Verify(Password, user.PasswordHash))
            {
                _authService.LoginUser(user);
                await Shell.Current.GoToAsync(nameof(UsersPage));
            }
            else
            {
                ErrorMessage = "Invalid username or password.";
            }
        }

        [RelayCommand]
        async Task Register()
        {
            await Shell.Current.GoToAsync(nameof(RegisterPage));
        }
    }
}
