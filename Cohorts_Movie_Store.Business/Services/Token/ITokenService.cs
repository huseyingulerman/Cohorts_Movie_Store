using Cohorts_Movie_Store.Core.Utilities.Response;
using Cohorts_Movie_Store.Dtos.Token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.Business.Services.Token
{
    public interface ITokenService
    {
        Task<ApiResponse<TokenResponse>> Login(TokenRequest request);
    }
}
