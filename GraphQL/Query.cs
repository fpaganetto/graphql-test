using System.Linq;
using ExampleGraphQL.Data;
using ExampleGraphQL.Models;
using HotChocolate;
using HotChocolate.Data;

namespace ExampleGraphQL.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        public IQueryable<Platform> GetPlatform([ScopedService] AppDbContext context)
        {
            return context.Platforms;
        }
    }
}
