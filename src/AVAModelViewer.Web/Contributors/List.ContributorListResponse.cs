using AVAModelViewer.Web.ContributorEndpoints;

namespace AVAModelViewer.Web.Endpoints.ContributorEndpoints;

public class ContributorListResponse
{
  public List<ContributorRecord> Contributors { get; set; } = new();
}
