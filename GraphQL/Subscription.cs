using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleGraphQL.Models;
using HotChocolate;
using HotChocolate.Types;

namespace ExampleGraphQL.GraphQL
{
    public class Subscription
    {
        [Subscribe]
        [Topic]
        public Platform OnPlatformAdded([EventMessage] Platform platform)
        {
            return platform;
        }
    }
}
