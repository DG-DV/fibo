using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace FibonacciClassLibrary
{
    public class FibonacciUtils
    {

        private static JsonSerializerSettings settings = new JsonSerializerSettings()
        {
            Converters = { new FilteredExpandoObjectConverter() },
            NullValueHandling = NullValueHandling.Ignore,
            DefaultValueHandling = DefaultValueHandling.Ignore,
            Formatting = Newtonsoft.Json.Formatting.Indented
        };

        /// <summary>
        /// ExpandoObject - Suppress Null Value
        /// </summary>
        /// <returns></returns>
        public class FilteredExpandoObjectConverter : ExpandoObjectConverter
        {
            //https://stackoverflow.com/questions/42863644/ignore-expandoobject-properties-with-json-net-serializer-settings
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

        //
        public static KeyValuePair<bool, string> XmlToJson(string xml)
        {
            try
            {
                if (!string.IsNullOrEmpty(xml))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(xml);
                    return new KeyValuePair<bool, string>(true, JsonConvert.SerializeXmlNode(doc));
                }
                else
                {
                    return new KeyValuePair<bool, string>(false, "Bad Xml format");
                }

            }
            catch (XmlException x)
            {
                return new KeyValuePair<bool, string>(false, "Bad Xml format");
            }

            catch (JsonException e)
            {
                return new KeyValuePair<bool, string>(false, "Json Convert Error");
            }
            catch (Exception e)
            {
                //Console.Write(e.Message + " - " + e.StackTrace);
                return default;
            }
        }

        /// <summary>
        /// Validate Xml string  
        /// </summary>
        /// <param name="xmlStr"></param>
        /// <returns></returns>
        public static KeyValuePair<Boolean, XmlDocument> IsValidXML(string xmlStr)
        {
            try
            {
                if (!string.IsNullOrEmpty(xmlStr))
                {
                    System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
                    xmlDoc.LoadXml(xmlStr);
                    return new KeyValuePair<Boolean, XmlDocument>(true, xmlDoc);
                }
                else
                {
                    return new KeyValuePair<Boolean, XmlDocument>(false, null);
                }
            }
            catch (System.Xml.XmlException)
            {
                return new KeyValuePair<Boolean, XmlDocument>(false, null);
            }
        }

        public static KeyValuePair<bool, int> IsIntegerValue(string valeurSaisie)
        {
            int nombre = default;
            bool saisieDunNombre = int.TryParse(valeurSaisie, out nombre);
            return new KeyValuePair<bool, int>(saisieDunNombre, nombre);
        }

        public static string xmlInputToString(string xmltext)
        {
             return System.Xml.Linq.XDocument.Parse(xmltext).ToString();            
        }
    }
}
