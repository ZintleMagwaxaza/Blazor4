using Microsoft.AspNetCore.Identity;

namespace Blazor4.Data.CustomProvider
{
    public class ApplicationRole : IdentityRole
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}







/* public class ApplicationRole : IdentityRole
     {
         public ApplicationRole() : base()
         {
         }

         public ApplicationRole(string roleName) : base(roleName)
         {
         }
     }*/