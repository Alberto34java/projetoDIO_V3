
using System.Reflection.Metadata;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Diagnostics;

using System;
using System.Collections.Generic;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using Models;
namespace Services
{
    public class FormacaoServices
    {
        private readonly IMongoCollection<Formacao> _formacao;

        public FormacaoServices(IConfiguration config)
        {
            var cli= new MongoClient(config.GetConnectionString("Conexao"));
            var db= cli.GetDatabase("UniLacerdaDB");
            _formacao = db.GetCollection<Formacao>("Formacao");            
        }

        public List<Formacao> Index() => _formacao.Find(Formacao => true).ToList();
        public Formacao GetFormacao(string id) => _formacao.Find(formacao => formacao.Id == id).FirstOrDefault();
        public Formacao SaveFormacao(Formacao formacao){
            _formacao.InsertOne(formacao);
            return formacao;
        }

        public Formacao DeleteFormacao(string id)
        {
              var formacao= _formacao.Find(formacao=> formacao.Id == id).FirstOrDefault();
              _formacao.DeleteOne(formacao=> formacao.Id ==id);
              return formacao;
        }
    }
}