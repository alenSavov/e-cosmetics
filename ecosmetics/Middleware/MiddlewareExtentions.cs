﻿using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecosmetics.Middleware
{
    public static class MiddlewareExtentions
    {
        public static IApplicationBuilder UseSeedDataMiddleware(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SeedDataMiddleware>();
        }
    }
}
