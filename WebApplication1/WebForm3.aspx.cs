using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using WebApplication1.Models;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int id1 = int.Parse(Request.QueryString["id"]);
                int id2 = int.Parse(Request.QueryString["id2"]);
       


                if (id1 != null && id2 != null)
                {
                    using (SqlConnection conn = new SqlConnection("Server=tcp:junkainapi.database.windows.net,1433;Database=MeuAPI;User ID=dunada;Password=Junkain21!;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand("SELECT Nome, Peso FROM tbPessoas", conn))
                        {
                            
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read() == true)
                                {
                                    
                                    
                                }
                            }
                        }

                        


                    }

                }


            }
        }
        protected void btnHome_Click(object sender, EventArgs e)
        {
        }
    }

    
}
