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
        private readonly FormacaoServices _services;
        public FormacaoController(FormacaoServices services)
        {
            _services= services;
        }

          [HttpGet] 
          public ActionResult<List<Formacao>> Index()=> _services.Index();
          
           
            
            [HttpGet("{id:length(24)}")]
            public ActionResult<Formacao> GetFormacao(string id)=>_services.GetFormacao(id);
            [HttpPost]
            public ActionResult<Formacao> Create(Formacao formacao)=> _services.SaveFormacao(formacao);
            [HttpPost]
            public ActionResult<Formacao> Delete(string id)=>_services.DeleteFormacao(id);
         

        
        
    }
}