using System.Collections.Generic;

namespace ApolloGraphQL.HotChocolate.Federation.CertificationSchema.CodeFirst.Types;

public class Data
{
    public List<Product> Products { get; } = new()
    {
        new("apollo-federation", "federation", "@apollo/federation", "OSS"),
        new("apollo-studio", "studio", string.Empty, "platform")
    };
}
