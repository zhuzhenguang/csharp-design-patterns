using Microsoft.AspNetCore.Mvc;

namespace information_microservice.Controllers
{
    [ApiController]
    public class InformationController
    {
        [HttpGet]
        [Route("/information")]
        public string GetProductTitle() => "The Product Title from Microservice";
    }
}