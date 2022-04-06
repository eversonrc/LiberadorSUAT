using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LiberadorSUAT.ModelsSecundarios
{
    public class ConfiguracaoFTP
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("usuario")]
        public string Usuario { get; set; }

        [BsonElement("senha")]
        public string Senha { get; set; }
    }
}
