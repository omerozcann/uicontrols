using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using uicontrols.Shared;

namespace uicontrols.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class formController : ControllerBase
    {
        [HttpPost]
        [Route("Save")]
        public void Save(formModel fm)
        {
            StreamWriter sw = new StreamWriter("log.txt", true);
            sw.WriteLine(fm.email);
            sw.WriteLine(fm.password);
            sw.WriteLine(fm.rememberchk);
            sw.WriteLine(fm.select);
            sw.WriteLine("----------------------------------");
            sw.Close();
        }
    }   

}
