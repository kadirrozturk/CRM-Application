using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Extension
{
    public class Helper
    {
        public static void ListControlDoldur(ListControl control, string text, string value, object kaynak)
        {
            control.DataSource = kaynak;
            control.DataTextField = text;
            control.DataValueField = value;
            control.DataBind();
        }
    }
}
