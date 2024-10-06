﻿using MediatR;

using TokenManager.Common.Models;
using TokenManager.Domain.Interfaces;

namespace TokenManager.Application.Commands.GroupUser
{
    public class RemoveUserFromGroupCommandHandler(IGroupUsersRepository userGroupRepository) : IRequestHandler<RemoveUserFromGroupCommand, Result<bool>>
    {
        private readonly IGroupUsersRepository _userGroupRepository = userGroupRepository;

        public async Task<Result<bool>> Handle(RemoveUserFromGroupCommand request, CancellationToken cancellationToken)
        {
            var result = await _userGroupRepository.RemoveUserFromGroupAsync(request.Tenant, request.UserId, request.GroupId);

            if (result.IsSuccess)
            {
                return Result<bool>.Success(result.Response);
            }

            return Result<bool>.Failure(result.Error);
        }
    }
}
