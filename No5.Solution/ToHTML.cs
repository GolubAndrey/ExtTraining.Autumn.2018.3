using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public class ToHTML:IConverter
    {
        public string Convert(List<DocumentPart> parts)
        {
            string output = string.Empty;

            foreach (DocumentPart part in parts)
            {
                switch (part.GetType().Name.ToString())
                {
                    case "BoldText":
                        {
                            //
                            break;
                        }
                    case "Hyperlink":
                        {
                            //
                            break;
                        }
                    case "PlainText":
                        {
                            //
                            break;
                        }
                }
            }

            return output;
        }
    }
}
