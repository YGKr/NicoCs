using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;

namespace NicoCs
{
    namespace Image
    {
        class User
        {
            public string id;
            public string NickName;

            public void GetUserData(string ID)
            {
                string URL = "http://seiga.nicovideo.jp/api/user/info?id=" + ID;
                string NameBuffer = "";

                XmlTextReader reader = new XmlTextReader(URL);

                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:

                            NameBuffer = reader.Name;

                            break;

                        case XmlNodeType.Text:

                            if (NameBuffer == "id") this.id = reader.Value;

                            if (NameBuffer == "nickname") this.NickName = reader.Value;

                            break;

                        default: break;
                    }
                }
            }
        }
    }
}
