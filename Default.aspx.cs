using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp4
{
    public partial class Default : System.Web.UI.Page
    {
        crud gc = new crud();
        public void mostrardatos()
        {
            gc.LlenarGrid("select * from ciudades", "ciudades");
            GridView1.DataSource = gc.ds.Tables["ciudades"];
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            mostrardatos();
        }
    }
}