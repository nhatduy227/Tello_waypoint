using System.Xml;

namespace Basic_GUI
{
    public class Data
    {
        private string txtdata1;
        private string txtdata2;
        private string txtdata3;
        private string txtdata4;
        string path = "C:/Users/nomie/Desktop/Tello_waypoint/XML-positioning/Run";

        public string PosX {
            get { return txtdata1;  }
            set { txtdata1 = value; }
        }

        public string PosY
        {
            get { return txtdata2; }
            set { txtdata2 = value; }
        }

        public string PosZ
        {
            get { return txtdata3; }
            set { txtdata3 = value; }
        }

        public string TimeStamp
        {
            get { return txtdata4; }
            set { txtdata4 = value; }
        }


        public void AddRecordToXML(string TimeStamp, string PosX, string PosY, string PosZ, int run) {
            XmlDocument doc = new XmlDocument();
            doc.Load(@path + run.ToString()+".xml");
            XmlNode root = doc.SelectSingleNode("WAYPOINTS");
            XmlElement point = doc.CreateElement("POINT");
            root.AppendChild(point);

            XmlAttribute id = doc.CreateAttribute("id");
            id.Value = doc.SelectNodes("WAYPOINTS/POINT").Count.ToString();
            point.Attributes.Append(id);

            XmlElement timeStamp = doc.CreateElement("TimeStamp");
            timeStamp.InnerText = TimeStamp;
            point.AppendChild(timeStamp);

            XmlElement posX = doc.CreateElement("PosX");
            posX.InnerText = PosX;
            point.AppendChild(posX);

            XmlElement posY = doc.CreateElement("PosY");
            posY.InnerText = PosY;
            point.AppendChild(posY);

            XmlElement posZ = doc.CreateElement("PosZ");
            posZ.InnerText = PosZ;
            point.AppendChild(posZ);
            doc.Save(@path + run.ToString() + ".xml");
        }
        public void CreateXMLFile(int run) {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("WAYPOINTS");
            doc.AppendChild(root);
            doc.Save(@path + run.ToString() + ".xml");
        }
    }
}
