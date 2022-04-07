using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiberadorSUAT.Models.Auxiliares
{
    public class ConexaoMongo
    {
        string conexaoString = "mongodb+srv://liberadorSuat:61zy7S2uraHgTWTs@cluster0.9tbfn.mongodb.net/test";
        public MongoClient client;
        static IMongoDatabase db;
        static IMongoCollection<ConfiguracaoFTP> colecaoConfiguracaoFTP;
        static IMongoCollection<Sistema> colecaoSistema;

        public ConexaoMongo()
        {
            client = new MongoClient(conexaoString);
            db = client.GetDatabase("LiberadorSUAT");
            colecaoConfiguracaoFTP = db.GetCollection<ConfiguracaoFTP>("ConfiguracoesFTP");
            colecaoSistema = db.GetCollection<Sistema>("Sistemas");
        }


        public List<ConfiguracaoFTP> getConfigFTP()
        {
            List<ConfiguracaoFTP> listaFTP = colecaoConfiguracaoFTP.AsQueryable().ToList<ConfiguracaoFTP>();
            return listaFTP;
        }

        public List<Sistema> getSistemas()
        {
            List<Sistema> listaSistema = colecaoSistema.AsQueryable().ToList<Sistema>();
            return listaSistema;
        }

    }
}
