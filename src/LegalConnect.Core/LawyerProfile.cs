namespace LegalConnect.Core;

public enum UserRole { Client, Lawyer, Admin }
public enum VerificationStatus { Pending, Verified, Rejected }
public enum BookingStatus { Pending, Confirmed, Completed, Cancelled }

public sealed class LawyerProfile
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public required string DisplayName { get; init; }
    public required string PracticeSummary { get; init; }
    public VerificationStatus VerificationStatus { get; set; } = VerificationStatus.Pending;
    public decimal ConsultationFee { get; init; }
}
