using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace DataProcessing
{
    public interface IAnalizatorXMLStrategy
    {
        List<Serial> Search(Serial serial);
    }
    public class DOM : IAnalizatorXMLStrategy
    {
        private XmlDocument xDoc = new XmlDocument();
        public DOM(string path)
        {
            xDoc.Load(path);
        }

        public List<Serial> Search(Serial serial)
        {
            List<List<Serial>> info = new List<List<Serial>>();
            try 
            {
                if (serial.Genre != null)
                    info.Add(SearchbyParametr("Genre", serial.Genre, xDoc, false));
                if (serial.Country != null)
                    info.Add(SearchbyParametr("Country", serial.Country, xDoc, false));
                if (serial.Released != null)
                    info.Add(SearchbyParametr("Released", serial.Released, xDoc, true));
                if (serial.Rating != null)
                    info.Add(SearchbyParametr("Rating", serial.Rating, xDoc, true));
                if (serial.Seasons != null)
                    info.Add(SearchbyParametr("Seasons", serial.Seasons, xDoc, true));
            }
            catch { }
            return Cross(info);
        }
        private List<Serial> Cross (List<List <Serial>> list)
        {
            List<Serial> result = new List<Serial>();
            List<Serial> intersect = new List<Serial>();
            if (list.Count >= 2)
            {
                for(int j=0; j<list[0].Count; j++) //перебираем все сериалы в первом списке
                {
                    for(int k=0; k<list[1].Count; k++) //перебираем все сериалы во втором списке
                    {
                        if (list[1][k].Compare(list[0][j]))
                            intersect.Add(list[0][j]);
                    }
                }
                if (intersect.Count == 0) //если не нашли пересечения, нет смысла дальше проверять
                    return result;


                for (int i=2; i<list.Count; i++) //перебираем с 3 списка
                {
                    List<Serial> bufferIntersect = new List<Serial>();
                    for (int j=0; j<list[i].Count; j++) //перебираем элементы списка
                    {
                        for(int k=0; k<intersect.Count; k++) //перебираем элементы пересечения
                        {
                            if (intersect[k].Compare(list[i][j])) //если есть одинаковые эл
                                bufferIntersect.Add(intersect[k]); //добавляем их в буферный массив
                        }
                        
                    }
                    if (bufferIntersect.Count != 0)
                    {
                        intersect.Clear();
                        intersect.AddRange(bufferIntersect);
                        bufferIntersect.Clear();
                    }
                    else
                    {
                        intersect.Clear();
                        break; 
                    }
                }

                result.AddRange(intersect);
            }
            else result = list[0];
            return result;
        }
        private List<Serial> SearchbyParametr(string attr, string parametr, XmlDocument doc, bool isRange)
        {
            List<Serial> serials = new List<Serial>();

                XmlElement xRoot = doc.DocumentElement; //получаем корневой элемент <Serials>
                foreach (XmlElement xnode in xRoot) //обходим все узлы <Serial> </Serial>
                {
                    if (isRange)
                    {
                        bool isOk = Verify.IsInTheRange(parametr, xnode.Attributes.GetNamedItem(attr).Value);
                        if (isOk)
                            serials.Add(getInfo(xnode));
                    }
                    else
                    {
                        if (parametr == xnode.Attributes.GetNamedItem(attr).Value)
                            serials.Add(getInfo(xnode));
                    }    
                }
                return serials;
        }
        private Serial getInfo(XmlNode node)
        {
            Serial newSerial = new Serial();
            newSerial.Name = node.Attributes.GetNamedItem("Name").Value;
            newSerial.Genre = node.Attributes.GetNamedItem("Genre").Value;
            newSerial.Released = node.Attributes.GetNamedItem("Released").Value;
            newSerial.Rating = node.Attributes.GetNamedItem("Rating").Value;
            newSerial.Seasons = node.Attributes.GetNamedItem("Seasons").Value;
            newSerial.Country = node.Attributes.GetNamedItem("Country").Value;

            return newSerial;
        }
    }

    
    public class LINQ : IAnalizatorXMLStrategy
    {
        private List<Serial> result = new List<Serial>();
        private XDocument xDoc = new XDocument();
        public LINQ(string path)
        {
            xDoc = XDocument.Load(path);
        }
        public List<Serial> Search(Serial serial)
        {
            List<XElement> matches = (from obj in xDoc.Descendants("Serial")
                        where
                        (
                        (serial.Genre == null || serial.Genre == obj.Attribute("Genre").Value) && 
                        (serial.Country == null || serial.Country == obj.Attribute("Country").Value)) &&
                        (serial.Released == null || Verify.IsInTheRange(serial.Released, obj.Attribute("Released").Value)) &&
                        (serial.Rating == null || Verify.IsInTheRange(serial.Rating, obj.Attribute("Rating").Value)) &&
                        (serial.Seasons == null || Verify.IsInTheRange(serial.Seasons, obj.Attribute("Seasons").Value)
                        )
                        select obj).ToList();
            foreach(XElement match in matches)
            {
                Serial resSerial = new Serial();
                resSerial.Name = match.Attribute("Name").Value;
                resSerial.Genre = match.Attribute("Genre").Value;
                resSerial.Released = match.Attribute("Released").Value;
                resSerial.Rating = match.Attribute("Rating").Value;
                resSerial.Seasons = match.Attribute("Seasons").Value;
                resSerial.Country = match.Attribute("Country").Value;
                result.Add(resSerial);
            }
            return result;
        }
    }
    public class SAX : IAnalizatorXMLStrategy
    {
        private List<Serial> lastResult = null;
        private XmlReader reader;
        public SAX(string path)
        {
            reader = XmlReader.Create(path);
        }
        public List<Serial> Search(Serial serial)
        {
            List<Serial> result = new List<Serial>();
            List<Serial> findRes = Read(reader);
            if(findRes!=null)
            {
                foreach(Serial ser in findRes)
                {
                    if(
                        (serial.Genre == null || serial.Genre==ser.Genre) &&
                        (serial.Country == null || serial.Country==ser.Country) &&
                        (serial.Released == null || Verify.IsInTheRange(serial.Released, ser.Released)) &&
                        (serial.Rating == null || Verify.IsInTheRange(serial.Rating, ser.Rating)) &&
                        (serial.Seasons == null || Verify.IsInTheRange(serial.Seasons, ser.Seasons))
                       )
                    {
                        result.Add(ser);
                    }
                }
            }
            return result;
        }
        private List<Serial> Read(XmlReader read)
        {
            List<Serial> findRes = new List<Serial>();
            Serial find;
            while (reader.Read())
            {
                if (reader.Name == "Serial")
                {
                    find = new Serial();
                    while (reader.MoveToNextAttribute())
                    {
                        if (reader.Name == "Name")
                            find.Name = reader.Value;
                        if (reader.Name == "Genre")
                            find.Genre = reader.Value;
                        if (reader.Name == "Released")
                            find.Released = reader.Value;
                        if (reader.Name == "Rating")
                            find.Rating = reader.Value;
                        if (reader.Name == "Seasons")
                            find.Seasons = reader.Value;
                        if (reader.Name == "Country")
                            find.Country = reader.Value;
                    }
                    findRes.Add(find);
                }
            }
            return findRes;
        }
    }

    public class Verify
    {
        public static bool IsInTheRange(string range, string val)
        {
            NumberFormatInfo frinfo = new NumberFormatInfo { NumberDecimalSeparator = "."};
            double temp = Convert.ToDouble(val, frinfo);
            if (range == null)
                return false;

            if (range.Contains("Old"))
                return (temp <= 2005);
            if (range.Contains("Recent"))
                return (temp > 2005 && temp <= 2015);
            if (range.Contains("New"))
                return (temp > 2015);
            if (range.Contains("Bad"))
                return (temp <= 2);
            if (range.Contains("Satisfact"))
                return (temp > 2 && temp <= 4);
            if (range.Contains("Good"))
                return (temp > 4 && temp <= 5);
            if (range.Contains("Small"))
                return (temp <= 3);
            if (range.Contains("Medium"))
                return (temp > 3 && temp < 8);
            if (range.Contains("Large"))
                return (temp > 7);

            return false;
        }
    }

}
