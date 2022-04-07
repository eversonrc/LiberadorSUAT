using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiberadorSUAT.Models.Auxiliares;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LiberadorSUAT.Models.Auxiliares
{
    public class Sistema
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nome")]
        public string Nome { get; set; }

        [BsonElement("versao")]
        public Int32 Versao { get; set; }

        [BsonElement("release")]
        public Int32 Release { get; set; }

        [BsonElement("sigla")]
        public string Sigla { get; set; }

        [BsonElement("grupoEmail")]
        public GrupoEmail grupoEmail { get; set; }

        public Sistema(string nome, int versao, int release, string sigla, GrupoEmail grupoEmail)
        {
            Nome = nome;
            Versao = versao;
            Release = release;
            Sigla = sigla;
            this.grupoEmail = grupoEmail;
        }
    }
}
