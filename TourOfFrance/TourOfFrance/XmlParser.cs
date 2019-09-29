using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TourDeFranceCyclist;

namespace TourOfFrance
{


    class XmlParser
    {
        public XmlParser()
        {
            string name = "";
            string gender = "";
            string country = "";
            string result = "";
            string endPos = "";

            Cyclist c;
            XmlDocument doc = new XmlDocument();
            doc.Load("Cycling-Tour-De-France.xml");
            foreach (XmlNode Node in doc.DocumentElement)
            {
                if (Node.Name == "participant")
                {
                    name = Node.Attributes[0].InnerText;
                    gender = Node.Attributes[1].InnerText;
                    country = Node.Attributes[3].InnerText;
                    
                }
                else if (Node.Name != "results")
                {
                    result = null;
                    endPos = null;
                }
                else if (Node.Name == "result" && Node.Attributes[2].InnerText == "duration")
                {
                    result = Node.Attributes[3].InnerText;
                    
                }
                else if (Node.Name == "result" && Node.Attributes[2].InnerText == "rank")
                {
                    endPos = Node.Attributes[3].InnerText;
                }
                

                c = new Cyclist(name, gender, country, result, endPos);
                Console.WriteLine(name + " " + gender + " " + country + " " + result + " " + endPos);
                  
            }
        }

    }
}
