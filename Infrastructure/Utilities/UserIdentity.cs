﻿

namespace AdeNote.Infrastructure.Utilities
{
    /// <summary>
    /// Implemention
    /// </summary>
    public class UserIdentity : IUserIdentity
    {
        /// <summary>
        /// Passes the user id to the property
        /// </summary>
        /// <param name="httpContext">An object used to get the user details</param>
        public UserIdentity(IHttpContextAccessor httpContext)
        {
            Guid.TryParse(httpContext.HttpContext?.User?.Claims
                .FirstOrDefault(x => x.Type == "id")?.Value, out Guid id);

            UserId = id;
        }

        /// <summary>
        /// Stores the user id of the authenticated user
        /// </summary>
        public Guid UserId { get; set; }
    }
}