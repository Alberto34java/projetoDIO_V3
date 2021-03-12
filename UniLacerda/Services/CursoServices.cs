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
    }
}