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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                List<Pessoa> pessoas = new List<Pessoa>();
                using (SqlConnection conn = new SqlConnection("Server=tcp:junkainapi.database.windows.net,1433;Database=MeuAPI;User ID=dunada;Password=Junkain21!;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Nome FROM tbPessoas ORDER BY Nome ASC", conn))
                    {

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        { 
                            while (reader.Read() == true)
                            { 
                                Pessoa p = new Pessoa();
                                p.Id = reader.GetInt32(0);
                                p.Nome = reader.GetString(1);

                                pessoas.Add(p);
                            }
                        }
                    }
                }
                listRepeater.DataSource = pessoas; 
                listRepeater.DataBind(); 
            }
            else
            {

            }
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            using (SqlConnection conn = new SqlConnection("Server=tcp:junkainapi.database.windows.net,1433;Database=MeuAPI;User ID=dunada;Password=Junkain21!;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT Id, Nome FROM tbPessoas ORDER BY Nome ASC", conn))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read() == true)
                        {
                            Pessoa p = new Pessoa();
                            p.Id = reader.GetInt32(0);
                            p.Nome = reader.GetString(1);

                            pessoas.Add(p);
                        }
                    }
                }
            }
            listRepeater.DataSource = pessoas;
            listRepeater.DataBind();
        }
    }
}