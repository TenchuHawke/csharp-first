using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace YourNamespace.Controllers
{
 public class HelloController : Controller
 {
  [HttpGet]
  public Task Index()
  {
   return Response.WriteAsync("Hello World!");
  }
 }
}