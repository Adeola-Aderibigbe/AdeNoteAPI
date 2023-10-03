﻿using AdeNote.Infrastructure.Utilities;

namespace AdeNote.Infrastructure.Services
{
    /// <summary>
    /// Manages the email notification using template
    /// </summary>
    public interface INotificationService
    {
        /// <summary>
        /// Send notification based on template type
        /// </summary>
        /// <typeparam name="T">Email type</typeparam>
        /// <param name="email">Hold email details</param>
        /// <param name="substitutions">User's details</param>
        /// <param name="template">Email template</param>
        /// <param name="contentType">Content type of message</param>
       Task SendNotification<T>(T email, EmailTemplate template, ContentType contentType, Dictionary<string, string> substitutions = null) where T : Email;
    }
}
