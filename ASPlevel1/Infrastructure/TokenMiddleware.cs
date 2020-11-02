using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPlevel1.Infrastructure
{
    public class TokenMiddleware
    {
        private const string correctToken= "123qew";
        public RequestDelegate Next { get; }
        public TokenMiddleware (RequestDelegate next)
        {
            Next = next;
        }
        public async Task InvokeAsync (HttpContext context)
        {
            var token = context.Request.Query["referenceToken"];

            if (string.IsNullOrEmpty(token))
            {
                await Next.Invoke(context);
                return;
            }
            if (token == correctToken)
            {
                // work
                await Next.Invoke(context);
            }
            else
            {
                await context.Response.WriteAsync("Token is incorrect");
            }
        }
    }
}
