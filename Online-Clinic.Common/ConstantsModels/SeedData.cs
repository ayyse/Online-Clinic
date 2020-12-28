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
                    UserName = ResultConstant.AdminName,
                    Email = ResultConstant.AdminEmail,
                    Şifre = ResultConstant.AdminPassword
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

            //await roleManager.CreateAsync(new IdentityRole { Name = ResultConstant.AdminRole });
            //await roleManager.CreateAsync(new IdentityRole { Name = ResultConstant.DoktorRole });
            //await roleManager.CreateAsync(new IdentityRole { Name = ResultConstant.BağışçıRole });
            //await roleManager.CreateAsync(new IdentityRole { Name = ResultConstant.HastaRole });

            if (!roleManager.RoleExistsAsync(ResultConstant.AdminRole).Result)
            {
                var role = new IdentityRole
                {
                    Name = ResultConstant.AdminRole
                };
                var result = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync(ResultConstant.DoktorRole).Result)
            {
                var role = new IdentityRole
                {
                    Name = ResultConstant.DoktorRole
                };
                var result = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync(ResultConstant.HastaRole).Result)
            {
                var role = new IdentityRole
                {
                    Name = ResultConstant.HastaRole
                };
                var result = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync(ResultConstant.BağışçıRole).Result)
            {
                var role = new IdentityRole
                {
                    Name = ResultConstant.BağışçıRole
                };
                var result = roleManager.CreateAsync(role).Result;
            }
        }
    }
}
