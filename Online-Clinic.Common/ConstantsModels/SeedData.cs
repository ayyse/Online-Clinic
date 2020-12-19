using Microsoft.AspNetCore.Identity;
using Online_Clinic.Data.DbModels;

namespace Online_Clinic.Common.ConstantsModels
{
    public static class SeedData
    {
        public static void Seed(UserManager<Visitor> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        private static void SeedUsers(UserManager<Visitor> userManager)
        {
            if (userManager.FindByNameAsync(ResultConstant.AdminEmail).Result == null)
            {
                var user = new Visitor
                {
                    UserName = ResultConstant.AdminEmail,
                    Email = ResultConstant.AdminEmail
                };
                var result = userManager.CreateAsync(user, ResultConstant.AdminPassword).Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, ResultConstant.AdminRole);
                }
            }
        }

        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync(ResultConstant.AdminRole).Result)
            {
                var role = new IdentityRole
                {
                    Name = ResultConstant.AdminRole
                };
                var result = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync(ResultConstant.VisitorRole).Result)
            {
                var role = new IdentityRole
                {
                    Name = ResultConstant.VisitorRole
                };
                var result = roleManager.CreateAsync(role).Result;
            }
        }
    }
}
