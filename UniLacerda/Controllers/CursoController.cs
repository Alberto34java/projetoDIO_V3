using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace Controllers
{
    [ApiController]
    [Route("[controllerCurso]")]
    public class CursoController  : ControllerBase
    {
        private readonly CursoServices _services;
         public CursoController(CursoServices services)
         {
             _services = services ;
         }

         [HttpGet]
         public ActionResult<List<Curso>> Index()=> _services.Index();
          [HttpGet("{id:length(24)}")]
         public ActionResult<Curso> GetCurso(string id)=> _services.GetCurso(id);
         [HttpPost]
         public ActionResult<Curso> Create(Curso curso)=> _services.SaveCurso(curso);
         [HttpPut]
         public ActionResult<Curso> Update(string id,Curso curso)=>_services.Put(id,curso);
         [HttpPost]
         public ActionResult<Curso> Delete(string id)=>_services.DeleteCurso(id);
    }
   
    
    
}