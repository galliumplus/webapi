﻿using GalliumPlus.WebApi.Core;
using GalliumPlus.WebApi.Core.Data;
using GalliumPlus.WebApi.Core.Users;

namespace GalliumPlus.WebApi.Data.FakeDatabase
{
    public class UserDao : BaseDao<string, User>, IUserDao
    {
        private IRoleDao roles;

        public IRoleDao Roles => roles;

        public UserDao(IRoleDao roles)
        {
            this.roles = roles;

            this.Create(
                new User(
                    "lomens", "Nicolas RESIN", this.roles.Read(0), "Prof", 20, false,
                    PasswordInformation.FromPassword("motdepasse")
                )
            );
            this.Create(
                new User(
                    "mf187870", "Matéo FAVARD", this.roles.Read(1), "2A", 1_000_000_000, false,
                    PasswordInformation.FromPassword("motdepasse")
                )
            );
            this.Create(
                new User(
                    "eb069420", "Evan BEUGNOT", this.roles.Read(2), "1A", 1_000_000_000, false,
                    PasswordInformation.FromPassword("motdepasse")
                )
            );
        }

        override public User Update(string key, User item)
        {
            try
            {
                if (GetKey(item) == key)
                {
                    this.Items[key] = item;
                    return item;
                }
                else
                {
                    if (this.Items.ContainsKey(GetKey(item))) throw new DuplicateItemException();
                    this.Items.Remove(key);
                    return this.Create(item);

                }
            }
            catch (KeyNotFoundException)
            {
                throw new ItemNotFoundException();
            }
        }

        public void UpdateDeposit(string id, double deposit)
        {
            User user = this.Read(id);
            user.Deposit = deposit;
            Update(id, user);
        }

        protected override string GetKey(User item) => item.Id;

        protected override void SetKey(User item, string key)
        {
            throw new InvalidOperationException("Can't set the user ID automatically");
        }
    }
}
