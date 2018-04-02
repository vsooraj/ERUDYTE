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
            context.SaveChanges();
        }

    }
}
