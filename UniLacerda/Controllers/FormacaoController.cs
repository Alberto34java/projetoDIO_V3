using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FormacaoController : ControllerBase
    {
        private readlonly FormacaoServices _services;
        public FormacaoController(FormacaoServices services)
        {
            _services= services;
        }

        
        
    }
}