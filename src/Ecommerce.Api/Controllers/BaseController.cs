using AutoMapper;
using Ecommerce.Api.Mapping;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.Controllers
{
    public class BaseController : Controller
    {
        public IMapper Mapper => Map.GetMapper();
    }
}
