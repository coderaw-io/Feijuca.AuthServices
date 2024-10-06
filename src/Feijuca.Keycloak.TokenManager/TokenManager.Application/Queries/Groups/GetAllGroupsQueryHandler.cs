﻿using MediatR;

using TokenManager.Application.Mappers;
using TokenManager.Application.Responses;
using TokenManager.Common.Errors;
using TokenManager.Common.Models;
using TokenManager.Domain.Interfaces;

namespace TokenManager.Application.Queries.Groups
{
    public class GetAllGroupsQueryHandler(IGroupRepository groupRepository) : IRequestHandler<GetAllGroupsQuery, Result<IEnumerable<GroupResponse>>>
    {
        private readonly IGroupRepository _groupRepository = groupRepository;

        public async Task<Result<IEnumerable<GroupResponse>>> Handle(GetAllGroupsQuery request, CancellationToken cancellationToken)
        {
            var result = await _groupRepository.GetAllAsync(request.Tenant);

            if (result.IsSuccess)
            {
                return Result<IEnumerable<GroupResponse>>.Success(result.Response.ToResponse());
            }

            return Result<IEnumerable<GroupResponse>>.Failure(GroupErrors.CreationGroupError);
        }
    }
}
