using System.Reflection;
using System.Diagnostics;

using System;
using System.Collections.Generic;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using Models;

namespace Services
{
    public class CursoServices

    {
        private readonly IMongoCollection<Curso> _cursos;

        //senha do banco Pg7i0vWRAjhbm04Y User api nome banco UniLacerdaDB
        public CursoServices(IConfiguration configuration)
        {
            var cli=new MongoClient(configuration.GetConnectionString("Conexao"));
            var db=cli.GetDatabase("UniLacerdaDB");
            _cursos=db.GetCollection<Curso>("Curso");
            
        } 

        public List<Curso> Index()=> _cursos.Find(Curso=> true).ToList();
        public Curso GetCurso(string id)=>_cursos.Find(curso=> curso.Id == id).FirstOrDefault();
        public Curso SaveCurso(Curso curso)
        {
            _cursos.InsertOne(curso);
            return curso;
        }

        public Curso  Put(string id, Curso curso) {
            _cursos.ReplaceOne(id,curso);
            return curso;
        }

        public Curso DeleteCurso(string id) 
            {
                  var curso=  _cursos.Find(curso=> curso.Id == id).FirstOrDefault();
                  _cursos.DeleteOne(curso=>curso.Id ==id);
                  return curso;

            }
    }
}