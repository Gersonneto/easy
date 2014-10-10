using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace wsspool.Model
{
    public class Desenhos
    {
        [XmlAttribute("TAG_")]
        public string  TAG { get; set; }
        [XmlElement("ISOMETRICO")]
        public string ISOMETRICO { get; set; }
        [XmlElement("LINHA")]
        public string LINHA { get; set; }
        [XmlElement("DIAMETRO")]
        public string DIAMETRO { get; set; }
        [XmlElement("FLUIDO")]
        public string FLUIDO { get; set; }
        [XmlElement("AREA")]
        public string AREA { get; set; }
        [XmlElement("NUMERO")]
        public string NUMERO { get; set; }
        [XmlElement("MATERIAL")]
        public string  MATERIAL { get; set; }
        [XmlElement("ISOLAMENTO")]
        public string ISOLAMENTO { get; set; }
        [XmlElement("PESO")]
        public string PESO { get; set; }
        [XmlElement("ENVIO_CONTROLTUB")]
        public string ENVIO_CONTROLTUB { get; set; }
        [XmlElement("RETORNO_CONTROLTUB")]
        public string RETORNO_CONTROLTUB { get; set; }
        [XmlElement("REVISAO_SIGEM")]
        public string REVISAO_SIGEM { get; set; }
        [XmlElement("REVISAO")]
        public string REVISAO{ get; set; }
        [XmlElement("PESO_FAB")]
        public string PESO_FAB { get; set; }
        [XmlElement("EMISSAO")]
        public string EMISSAO { get; set; }
        [XmlElement("GRD_CEDOC")]
        public string GRD_CEDOC { get; set; }
        [XmlElement("GRD_CTB")]
        public string GRD_CTB { get; set; }
        [XmlElement("STATUS_CTB")]
        public string STATUS_CTB { get; set; }
        [XmlElement("RESPONSAVEL")]
        public string RESPONSAVEL { get; set; }






    }
}