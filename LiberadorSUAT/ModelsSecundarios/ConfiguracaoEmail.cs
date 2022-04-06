using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LiberadorSUAT.ModelsSecundarios
{
    public class ConfiguracaoEmail
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("destinatario")]
        public string Destinatario { get; set; }
    }
}
