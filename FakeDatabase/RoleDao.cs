﻿using GalliumPlus.WebApi.Core.Data;
using GalliumPlus.WebApi.Core.Users;

namespace GalliumPlus.WebApi.Data.FakeDatabase
{
    public class RoleDao : BaseDaoWithAutoIncrement<Role>, IRoleDao
    {
        public RoleDao()
        {
            this.Create(
                new Role(0, "Adhérent", 0)
            );
            this.Create(
                new Role(0, "CA",
                    Permissions.MANAGE_PRODUCTS
                    | Permissions.SEE_ALL_USERS
                    | Permissions.SELL
                    | Permissions.MANAGE_DEPOSITS
                )
            );
            this.Create(
                new Role(0, "Président",
                    Permissions.MANAGE_PRODUCTS
                    | Permissions.SEE_ALL_USERS
                    | Permissions.SELL
                    | Permissions.MANAGE_CATEGORIES
                    | Permissions.READ_LOGS
                    | Permissions.MANAGE_ROLES
                    | Permissions.MANAGE_USERS
                    | Permissions.RESET_MEMBERSHIPS
                )
            );
        }

        protected override int GetKey(Role item) => item.Id;
        protected override void SetKey(Role item, int key) => item.Id = key;
    }
}
