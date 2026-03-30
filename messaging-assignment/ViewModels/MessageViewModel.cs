using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DAL.Models;
using DAL.Services;
using messaging_assignment.Pages;
using messaging_assignment.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace messaging_assignment.ViewModels
{
    [QueryProperty("ToUserId", "ToUserId")]
    [QueryProperty("ToUserFullName", "ToUserFullName")]
    public partial class MessageViewModel : ObservableObject
    {
        private readonly AuthService _authService;
        private readonly MessageService _messageService;

        public MessageViewModel(UserService userService, AuthService authService, MessageService messageService)
        {
            _authService = authService;
            _messageService = messageService;
            if (_authService.LoggedInUser == null)
            {
                throw new InvalidOperationException("User must be logged in to view messages.");
            }
            LoggedInUserId = _authService.LoggedInUser.Id;
        }

        [ObservableProperty]
        public partial long LoggedInUserId { get; set; }

        [ObservableProperty]
        public partial long ToUserId { get; set; }

        [ObservableProperty]
        public partial string ToUserFullName { get; set; }

    }
}
