using System;

namespace OMSV1.Domain.Specifications.Profiles;
using DomainProfile = OMSV1.Domain.Entities.Profiles.Profile;
public class ProfileByUserIdSpecification : BaseSpecification<DomainProfile>
{
    public ProfileByUserIdSpecification(int userId)
        : base(p => p.UserId == userId)
    {
    }
}