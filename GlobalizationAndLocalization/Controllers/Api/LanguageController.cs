using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalizationAndLocalization.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly IStringLocalizer<LanguageController> _Localizer;

        public LanguageController(IStringLocalizer<LanguageController> Localizer)
        {
            _Localizer = Localizer;
        }

        public IActionResult Get()
        {
            var username = "islam";
            return Ok(_Localizer["Welcome",username].Value);
        }
    }
}
