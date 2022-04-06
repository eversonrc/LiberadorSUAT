using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LiberadorSUAT.ModelsSecundarios
{
    public class ConfiguracoesBancoLiberador
    {
        public string ConnectionString { get; set; } 

        public string DatabaseName { get; set; }

        public string SistemaCollectionName { get; set; }

        public string ConfigEmailCollectionName { get; set; }

        public string ConfigFTPCollectionName { get; set; }


    }
}