using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleGraphQL.Models;
using HotChocolate.Types;

namespace ExampleGraphQL.GraphQL.Commands
{
    public class CommandType : ObjectType<Command>
    {
        protected override void Configure(IObjectTypeDescriptor<Command> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Description("Represents any excecutable command.");
        }

        //...
    }
}
