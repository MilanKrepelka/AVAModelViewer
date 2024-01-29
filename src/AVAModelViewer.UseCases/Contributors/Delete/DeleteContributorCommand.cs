using Ardalis.Result;
using Ardalis.SharedKernel;

namespace AVAModelViewer.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
