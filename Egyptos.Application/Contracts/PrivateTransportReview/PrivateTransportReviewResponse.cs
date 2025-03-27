namespace Egyptos.Application.Contracts.PrivateTransportReview;
public record PrivateTransportReviewResponse
(
     int Id,
     string Comment,
     double Rate,
     DateOnly Date,
     string UserId,
     string UserName,
     int PrivateTransportId,
     string PrivateTransportName
);
