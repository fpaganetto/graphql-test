using System.Linq;
using ExampleGraphQL.Data;
using ExampleGraphQL.Models;
using HotChocolate;
using Microsoft.AspNetCore.Mvc;

namespace ExampleGraphQL.GraphQL
{
    public class Query
    {
        public IQueryable<Platform> GetPlatform([Service] AppDbContext context)
        {
            return context.Platforms;
        }
    }
}
