﻿using System.Collections.Generic;
using Core.Entities.Concrete;

namespace Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        TAccessToken CreateToken<TAccessToken>(User user, IEnumerable<OperationClaim> operationClaims)
          where TAccessToken : IAccessToken, new();
    }
}
