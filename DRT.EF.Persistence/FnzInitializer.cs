using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using DRT.Domain.Entities;
using DRT.Domain.Enums;
using Microsoft.EntityFrameworkCore.Internal;

namespace DRT.Persistence
{
    public class FnzInitializer
    {
        private readonly Dictionary<int, User> Users = new Dictionary<int, User>();
        private readonly Dictionary<int, Account> Accounts = new Dictionary<int, Account>();
        private readonly Dictionary<int, Case> Cases = new Dictionary<int, Case>();

        public static void Initialize(DRTDbContext context)
        {
            var initializer = new FnzInitializer();
            initializer.SeedEverything(context);
        }


        public void SeedEverything(DRTDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Set<Account>().Any())
            {
                return; // db already seeded
            }

            SeedAccounts(context);
            SeedUsers(context);
            SeedCases(context);
        }


        public void SeedAccounts(DRTDbContext context)
        {
            
            Accounts.Add(1,
                new Account
                {
                    AccountName = "Foobar Ltd",
                    Users = new[]
                    {
                        new AccountUser { FirstName  = "Ed", LastName = "Murphy", Username = "emurphy", EmailAddress = "emurphy@foobar.co.uk" },
                        new AccountUser { FirstName  = "Jed", LastName = "Hue", Username = "jhue", EmailAddress = "jhue@foobar.co.uk" },
                        new AccountUser { FirstName  = "Roger", LastName = "Gracie", Username = "rgracie", EmailAddress = "rgracie@foobar.co.uk" }
                    }

                });

            Accounts.Add(2,
                new Account
                {
                    AccountName = "Gulag Services",
                    Users = new[]
                    {
                        new AccountUser { FirstName  = "Nick", LastName = "Meragali", Username = "nmeregali", EmailAddress = "nmeregali@thegulag.co.uk" },
                        new AccountUser { FirstName  = "Keenan", LastName = "Kai-James", Username = "keenankj", EmailAddress = "keenankj@thegulag.co.uk" },
                        new AccountUser { FirstName  = "Miha", LastName = "Perovic", Username = "mperovic", EmailAddress = "mperovic@thegulag.co.uk" }
                    }

                });

            Accounts.Add(3,
                new Account
                {
                    AccountName = "Uchi Mata",
                    Users = new[]
                    {
                        new AccountUser { FirstName  = "Dom", LastName = "Bell", Username = "dbell2", EmailAddress = "dbell2@um.co.uk" },
                        new AccountUser { FirstName  = "Dan", LastName = "Strauss", Username = "dstrauss", EmailAddress = "dstrauss@um.co.uk" },
                        new AccountUser { FirstName  = "Josh", LastName = "Hinger", Username = "jhinger", EmailAddress = "jhinger@um.co.uk" }
                    }

                });


            foreach (var account in Accounts.Values)
            {
                context.Set<Account>().Add(account);
            }

            context.SaveChanges();
        }

        public void SeedUsers(DRTDbContext context)
        {
            Users.Add(1, 
                new User
                {
                    FirstName = "Bruno",
                    LastName = "Malfacine",
                    EmailAddress = "bmalfacine@fnz.com",
                    Username = "bmalfacine"
                });

            Users.Add(2,
                new User
                {
                    FirstName = "Craig",
                    LastName = "Jones",
                    EmailAddress = "cjones@fnz.com",
                    Username = "cjones"
                });

            Users.Add(3,
                new User
                {
                    FirstName = "Gordon",
                    LastName = "Ryan",
                    EmailAddress = "gryan@fnz.com",
                    Username = "gryan"
                });

            Users.Add(4,
                new User
                {
                    FirstName = "Lucas",
                    LastName = "Lepri",
                    EmailAddress = "llepri@fnz.com",
                    Username = "llepri"
                });

            Users.Add(5,
                new User
                {
                    FirstName = "Ryan",
                    LastName = "Hall",
                    EmailAddress = "rhall5050@fnz.com",
                    Username = "rhall5050"
                });

            foreach (var user in Users.Values)
            {
                context.Set<User>().Add(user);
            }

            context.SaveChanges();

        }

        private void SeedCases(DRTDbContext context)
        {
            Cases.Add(1, new Case
            {
                UserFriendlyId = "FNZ02",
                Title = "Support Issue 01",
                OpenedDate = new DateTime(2020, 1, 1),
                Priority = PriorityLevel.Medium,
                Classification = Classification.Far,
                Account = Accounts[1],
                User = Users[1],
                Notes = new[]
                {
                    new CaseNote { Content = "This is my first note", NoteDate = new DateTime(2020, 1, 20), User = Users[1] },
                    new CaseNote { Content = "This is my second note", NoteDate = new DateTime(2020, 1, 22), User = Users[1] },
                    new CaseNote { Content = "This is my third note", NoteDate = new DateTime(2020, 1, 24), User = Users[1] }
                }
            });

            Cases.Add(2, new Case
            {
                UserFriendlyId = "FNZ411",
                Title = "Support Issue 02",
                OpenedDate = new DateTime(2020, 3, 30),
                Priority = PriorityLevel.Low,
                Classification = Classification.Foo,
                Account = Accounts[2],
                User = Users[2],
                Notes = new[]
                {
                    new CaseNote { Content = $"Case claimed by { Users[2].Username }", NoteDate = new DateTime(2020, 4, 1), User = Users[2] },
                    new CaseNote { Content = "I have called the customer", NoteDate = new DateTime(2020, 4, 2), User = Users[2] },
                    new CaseNote { Content = "This is an auto note or something", NoteDate = new DateTime(2020, 4, 10), User = Users[2] }
                }
            });

            Cases.Add(3, new Case
            {
                UserFriendlyId = "FNZ380",
                Title = "Support Issue 03",
                OpenedDate = new DateTime(2020, 4, 3),
                Priority = PriorityLevel.High,
                Classification = Classification.Bar,
                Account = Accounts[2],
                User = Users[3],
                Notes = new[]
                {
                    new CaseNote { Content = "This is a note on a case", NoteDate = new DateTime(2020, 4, 3), User = Users[2] },
                    new CaseNote { Content = "This is another note, amazing", NoteDate = new DateTime(2020, 4, 4), User = Users[3] },
                    new CaseNote { Content = "This is yet another note", NoteDate = new DateTime(2020, 4, 5), User = Users[3] }
                }
            });

            foreach(var ticket in Cases.Values)
            {
                context.Set<Case>().Add(ticket);
            }

            context.SaveChanges();
        }


    }
}
