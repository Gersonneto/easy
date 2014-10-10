using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Data.OleDb;
using wsspool.Model;
using wsspool.Controle;

namespace wsspool
{
    /// <summary>
    /// Summary description for spool
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class spool : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Xml)]
        public XML obterDados()
        {

            List<Desenhos> litaOk = new List<Desenhos>();

            //Server.MapPath("~/Arquivos/teste.xlsx");

            string caminho = Server.MapPath("~/Arquivos/PLANTHAIS.xlsx");

            string strconect = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + caminho + ";Extended Properties='Excel 12.0 xml;HDR=YES';";

            OleDbConnection connect = new OleDbConnection(strconect);

            string comandoSQL = "SELECT * from [Plan1$]";

            OleDbCommand cmd = new OleDbCommand(comandoSQL, connect);

            try
            {
                connect.Open();

                OleDbDataReader retorno = cmd.ExecuteReader();

                while (retorno.Read())
                {

                    litaOk.Add(new Desenhos()
                    {
                        TAG               =  Addcampo(retorno,"TAG"),
                        ISOMETRICO        =  Addcampo(retorno,"ISOMÉTRICO"),
                        LINHA             =  Addcampo(retorno,"LINHA"),
                        DIAMETRO          =  Addcampo(retorno,"DN"),
                        FLUIDO            =  Addcampo(retorno,"Fluido"),
                        AREA              =  Addcampo(retorno,"AREA"),
                        NUMERO            =  Addcampo(retorno,"AREA"),
                        MATERIAL          =  Addcampo(retorno,"MATERIAL"),
                        ISOLAMENTO        =  Addcampo(retorno,"ISOLAMENTO"),
                        PESO              =  Addcampo(retorno,"Peso Maquete"),
                        ENVIO_CONTROLTUB  =  Addcampo(retorno,"ENVIO"),
                        RETORNO_CONTROLTUB=  Addcampo(retorno,"RETORNO"),
                        REVISAO_SIGEM     =  Addcampo(retorno,"REVISÃO SIGEM"),
                        REVISAO           =  Addcampo(retorno,"revisão"),
                        PESO_FAB          = Addcampo(retorno,"PESO_FAB"),
                        EMISSAO           = Addcampo(retorno,"EMISSÃO"),
                        GRD_CEDOC         =  Addcampo(retorno,"GRD CDOC"),
                        GRD_CTB           =  Addcampo(retorno,"GRD CTB"),
                        STATUS_CTB        =  Addcampo(retorno,"STATUS CTB"),
                        RESPONSAVEL       =  Addcampo(retorno,"Responsável")


                    });

                }

                if (litaOk.Count() > 0)
                {
                    XML dadosXML = new XML(litaOk);

                    return dadosXML;
                }
                else
                {
                    return null;
                }




            }
            catch(Exception Exc)
            {

               
            }
            finally
            {
                if (connect != null)
                    connect.Close();
            }

            return null;
        }
        public string Addcampo(OleDbDataReader row ,string campo)
        {
            try
            {
               
                    if (!DBNull.Value.Equals(row[campo]))
                        return row[campo].ToString();
                    else
                        return string.Empty;
               
              
                

            }
            catch (Exception ex)
            {
                return string.Empty;
            }

        }

      

    }

    }

