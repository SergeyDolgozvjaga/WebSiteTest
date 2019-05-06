using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromXml
{
    public class LoginPage : Driver
    {
        XmlParser parser = new XmlParser();

        public string GetLoginPageURL()
        {
            return parser.LoadFileUrlTableUrl().SelectSingleNode("Login_page").InnerText;
        }
    }
}
