using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class tanachController : ControllerBase
    {
        [HttpGet]
        public  string get()
        {
            return Da_Repository.Class1.AllTanach();
        }
        [HttpGet("{name}")]
        public List<string> get(string name)
        {
            int c = 0;
            return Bll_Services.Class1.search1(name, "",out c);
        }

    }
}
