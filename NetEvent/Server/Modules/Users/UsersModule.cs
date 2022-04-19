﻿using NetEvent.Server.Modules.Users.Endpoints;

namespace NetEvent.Server.Modules.Users
{
    public class RolesModule : IModule
    {
        public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/users", GetUsers.Handle);
            endpoints.MapGet("/users/{id}", GetUser.Handle);
            endpoints.MapPut("/users/{id}", PutRole.Handle);
            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            return builder;
        }
    }
}
