using Newtonsoft.Json;
using System;
using System.Web.Services;
using System.Xml;
using System.Runtime.Serialization;
using System.Dynamic;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Linq;

namespace FibonacciService
{
    /// <summary>
    /// Description résumée de FiboWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class FiboWebService : System.Web.Services.WebService
    {
        internal static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Algorithme polynomial
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        [WebMethod]
        public int fibonacci2switch(int n)
        {
            log.Info("Fibonacci Async Service");
            System.Threading.Thread.Sleep(2000);
            switch (n)
            {
                case int m when (m < 1 || m > 100):
                    log.Info("Return value : -1");
                    return -1;
                    break;
                default:
                    int i = 0;
                    int j = 1;
                    int r = 1;
                    for (int k = 1; k < n; k++)
                    {
                        r = i + j;
                        i = j;
                        j = r;
                    }
                    log.Info("Return v : " + r);
                    return r;
                    break;
            }
        }

        [WebMethod]
        public string XmlToJson(string xml)
        {
            log.Info("Xml To Json Service");
            System.Threading.Thread.Sleep(2000);

            try
            {
                var getXML = IsValidXML(xml);
                if (getXML.Key == true)
                {
                    var ser = Newtonsoft.Json.JsonConvert.SerializeObject(getXML.Value, settings);
                    log.Info(ser);

                    var deser = Newtonsoft.Json.JsonConvert.DeserializeObject<ExpandoObject>(ser, settings);
                    log.Info(deser);
                    log.Info("Return Value : " + Newtonsoft.Json.JsonConvert.SerializeObject(deser, settings));
                    return Newtonsoft.Json.JsonConvert.SerializeObject(deser, settings);
                }
                else
                {
                    log.Info("Return Value : Bad Xml format");
                    return "Bad Xml format";
                }
            }
            catch (Newtonsoft.Json.JsonException e)
            {
                log.Error(e.Message + "\n" + e.StackTrace);
                return "Json Convert Error Newton" + e.Message + " - " + e.StackTrace;
            }
            catch (Exception e)
            {
                log.Error(e.Message + "\n" + e.StackTrace);
                return e.Message + " - " + e.StackTrace;
            }
        }


        private static JsonSerializerSettings settings = new JsonSerializerSettings()
        {
            Converters = { new FilteredExpandoObjectConverter() },
            NullValueHandling = NullValueHandling.Ignore,
            DefaultValueHandling = DefaultValueHandling.Ignore,
            Formatting = Newtonsoft.Json.Formatting.Indented
        };

        /// <summary>
        /// ExpandoObject - Suppression Valeurs Null 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public class FilteredExpandoObjectConverter : ExpandoObjectConverter
        {
            public override bool CanWrite { get { return true; } }

            public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
            {
                var expando = (IDictionary<string, object>)value;
                var dictionary = expando
                    .Where(p => p.Key != null && p.Value != null && !(p.Value is System.Delegate))
                    .ToDictionary(p => p.Key, p => p.Value);
                serializer.Serialize(writer, dictionary);
            }
        }

        private KeyValuePair<Boolean, XmlDocument> IsValidXML(string xmlStr)
        {
            try
            {
                if (!string.IsNullOrEmpty(xmlStr))
                {
                    System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
                    xmlDoc.LoadXml(xmlStr);
                    log.Info("IsValidXML true"+ "\n" + xmlDoc);
                    return new KeyValuePair<Boolean, XmlDocument>(true, xmlDoc);
                }
                else
                {
                    log.Info("IsValidXML false");
                    return new KeyValuePair<Boolean, XmlDocument>(false, null);
                }
            }
            catch (System.Xml.XmlException e)
            {
                log.Error(e.Message + "\n" + e.StackTrace);
                return new KeyValuePair<Boolean, XmlDocument>(false, null);
            }
        }
    }
}    






