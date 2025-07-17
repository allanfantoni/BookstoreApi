using Microsoft.AspNetCore.Mvc;

namespace BookstoreApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookstoreApiBaseController : ControllerBase
{
    protected string GetCustomKey()
    {
        return Request.Headers["MyKey"].ToString();
    }
}