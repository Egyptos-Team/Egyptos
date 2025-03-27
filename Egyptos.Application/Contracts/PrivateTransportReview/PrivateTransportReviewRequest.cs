namespace Egyptos.Application.Contracts.PrivateTransportReview;
public record PrivateTransportReviewRequest
(
    string Comment, 
    double Rate,
    int PrivateTransportId
);