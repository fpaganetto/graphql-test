using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleGraphQL.GraphQL.Commands
{
    public record AddCommandInput(string howTo, string commandLine, int platformId);
}
