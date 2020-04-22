using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DRT.Domain.Entities;

namespace DRT.Application.CQRS.Users.Queries.GetUserDetail
{
    public class UserDetailModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }

        public static Expression<Func<User, UserDetailModel>> Projection
        {
            get
            {
                return user => new UserDetailModel
                {
                    Id = user.UserId,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Username = user.Username,
                    EmailAddress = user.EmailAddress
                };
            }
        }

        public static UserDetailModel Create(User user)
        {
            return Projection.Compile().Invoke(user);
        }
    }
}
