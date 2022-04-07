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
        public decimal Versao { get; set; }

        [BsonElement("release")]
        public string Release { get; set; }

        [BsonElement("sigla")]
        public string Sigla { get; set; }

        [BsonElement("destinatarios")]
        public GrupoEmail grupoEmail { get; set; }

        public Sistema(string nome, decimal versao, string release, string sigla, GrupoEmail grupoEmail)
        {
            Nome = nome;
            Versao = versao;
            Release = release;
            Sigla = sigla;
            this.grupoEmail = grupoEmail;
        }
    }
}
