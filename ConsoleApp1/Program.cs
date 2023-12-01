using System.Reflection;
using System.Xml;
using Lab_07;

class Program
{
    private static void Main()
    {
        XmlDocument doc = new XmlDocument();
        XmlElement rootElement = doc.CreateElement("ClassDiagram");
        doc.AppendChild(rootElement);

        Assembly asm = Assembly.Load("Lab_07");

        Type[] types = asm.GetTypes();
        foreach (Type t in types)
        {
            if (!t.Namespace!.Contains("Lab_07")) continue;
            string str = null;
            if (t.IsClass)
            {
                str = "Class";
            }

            if (t.IsEnum)
            {
                str = "Enum";
            }

            XmlElement element = doc.CreateElement(str);
            rootElement.AppendChild(element);
            element.SetAttribute("name", t.Name);

            CommentAttribute? comment = (CommentAttribute)t.GetCustomAttribute(typeof(CommentAttribute));
            XmlElement cElement = doc.CreateElement("comment");
            if (comment != null)
            {
                cElement.InnerText = comment.Comment;
                element.AppendChild(cElement);
            }

            object[] propiproperties = t.GetProperties();
            foreach (object p in propiproperties)
            {
                XmlElement pElement = doc.CreateElement("properties");
                pElement.InnerText = p.ToString() ?? string.Empty;
                element.AppendChild(pElement);
            }

            MethodInfo[] methods = t.GetMethods();
            foreach (var m in methods)
            {
                XmlElement mElement = doc.CreateElement("methods");
                mElement.InnerText = m.ToString() ?? throw new InvalidOperationException();
                element.AppendChild(mElement);
            }
        }

        var f = File.Create("animals.xml");
        doc.Save(f);
    }
}
