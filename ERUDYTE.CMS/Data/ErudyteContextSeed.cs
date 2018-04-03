using Erudyte.CMS.Models;
using System.Linq;

namespace Erudyte.CMS.Data
{
    public class ErudyteContextSeed
    {
        public static void Seed(ErudyteContext context)
        {
            if (!context.CategoryTypes.Any())
            {
                context.AddRange
                (
                    new CategoryType() { Type = "Endocrinology" },
                    new CategoryType() { Type = "Neurology" },
                    new CategoryType() { Type = "Sleep Medicine" },
                    new CategoryType() { Type = "Test Category" }
                );
            }
            //var defaultUser = new IdentityUser { UserName = "admin@erudyte.com", Email = "admin@erudyte.com" };

            //userManager.CreateAsync(defaultUser, "Pass@word1");
            context.SaveChanges();
        }

    }
}
