using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiberadorSUAT.Models.Auxiliares
{
    public class GrupoEmail
    {
        [BsonElement("nome")]
        public string Nome { get; set; }

        [BsonElement("destinatarios")]
        public string[] enderecoEmail { get; set; }
    }
}
