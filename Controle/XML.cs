using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using wsspool.Model;

namespace wsspool.Controle
{
    [XmlRoot("xml")]
    public class XML
    {
        public XML() { }
        public XML(List<Desenhos> contatos)
        {
            this.contatos = contatos;
        }
        public List<Desenhos> contatos { get; set; }
    }
}