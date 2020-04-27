using Convey.Exceptions;

namespace Pacco.Services.Identity.Core.Exceptions
{
    public class InvalidRoleException : DomainException
    {
        public override string Code => "invalid_role";
        
        public InvalidRoleException(string role) : base($"Invalid role: {role}.")
        {
        }
    }
    
    public class EmptyRefreshTokenException : DomainException
    {
        public override string Code => "empty_refresh_token";
        
        public EmptyRefreshTokenException() : base("Empty refresh token.")
        {
        }
    }
}