using DAL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DAL.DTOs
{
    public class UserWithMessage
    {
        [SetsRequiredMembers]
        public UserWithMessage(User user, Message? message)
        {
            User = user;
            Message = message;
        }

        public required User User { get; set; }

        public Message? Message { get; set; }
    }
}
