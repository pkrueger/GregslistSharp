namespace GreglistSharp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JobsController : ControllerBase
{
  private readonly JobsService _js;
  public JobsController(JobsService js)
  {
    _js = js;
  }

  [HttpGet]
  public ActionResult<List<Job>> Get()
  {
    try
    {
      List<Job> jobs = _js.GetJobs();
      return Ok(jobs);
    }
    catch (System.Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}