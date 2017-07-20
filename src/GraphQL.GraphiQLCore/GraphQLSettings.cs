﻿using System;
using Microsoft.AspNetCore.Http;

namespace GraphQL.GraphiQLCore
{
    public class GraphQLSettings
    {
        public PathString Path { get; set; } = "/graphql";
        public Func<HttpContext, object> BuildUserContext { get; set; }
    }
}