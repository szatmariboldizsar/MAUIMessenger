using System;
using System.Collections.Generic;
using System.Text;

namespace messaging_assignment.DAL.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public int FromUserId { get; set; }
        public int ToUserId { get; set; }
        public required string Content { get; set; }
        public required DateTime DateSent { get; set; }
        public required bool IsSeen { get; set; }
    }
}
