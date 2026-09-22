using LegalConnect.Core;

namespace LegalConnect.Tests;

public sealed class LawyerProfileTests
{
    [Fact]
    public void New_lawyer_profiles_require_verification_before_go_live()
    {
        var profile = new LawyerProfile
        {
            DisplayName = "Advocate Rajeev",
            PracticeSummary = "Property and civil law",
            ConsultationFee = 1500
        };

        Assert.Equal(VerificationStatus.Pending, profile.VerificationStatus);
    }
}
