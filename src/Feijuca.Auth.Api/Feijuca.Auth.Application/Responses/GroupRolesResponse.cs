﻿namespace Feijuca.Auth.Application.Responses
{
    public record GroupRolesResponse(string Id, string Client, IEnumerable<RoleResponse> Mappings);
}
