using System.Threading.Tasks;
using ExampleGraphQL.Data;
using ExampleGraphQL.GraphQL.Commands;
using ExampleGraphQL.Models;
using HotChocolate;
using HotChocolate.Data;

namespace ExampleGraphQL.GraphQL
{
    public class Mutation
    {
        [UseDbContext(typeof(AppDbContext))]
        public async Task<AddPlatformPayload> AddPlatformAsync(AddPlatformInput input, [ScopedService] AppDbContext context)
        {
            var platform = new Platform
            {
                Name = input.Name
            };

            context.Platforms.Add(platform);
            await context.SaveChangesAsync();

            return new AddPlatformPayload(platform);
        }

        [UseDbContext(typeof(AppDbContext))]
        public async Task<AddCommandPayload> AddCommandAsync(AddCommandInput input, [ScopedService] AppDbContext context)
        {
            var command = new Command
            {
                HowTo = input.howTo,
                CommandLine = input.commandLine,
                PlatformId = input.platformId
            };

            context.Add(command);
            await context.SaveChangesAsync();

            return new AddCommandPayload(command);
        }
    }
}
