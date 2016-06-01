﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XJTResourcesCore.Models
{

    public enum NotificationType
    {
        Registration,
        Email,
        PasswordChange,
        QuestionAnswerChange

    };

    public class Notification
    {
        public int NotificationId { get; set; }
        public string Title { get; set; }
        public NotificationType NotificationType { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string UserId { get; set; }
        public bool IsDismissed { get; set; }
        
    }
}
