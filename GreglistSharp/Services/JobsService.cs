namespace GreglistSharp.Services;

public class JobsService
{
  private readonly JobsRepository _jr;
  public JobsService(JobsRepository jr)
  {
    _jr = jr;
  }

  public List<Job> GetJobs()
  {
    return _jr.GetJobs();
  }
}