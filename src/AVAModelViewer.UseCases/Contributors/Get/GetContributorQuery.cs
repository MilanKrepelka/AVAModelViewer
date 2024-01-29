using Ardalis.Result;
using Ardalis.SharedKernel;

namespace AVAModelViewer.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
