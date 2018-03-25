using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Assignments
{
    public partial class Project4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        public List<string> get_the_recs(string rec)
        {
            List<string> result = null;
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["assignment"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT comment FROM tb_the_comments INNER JOIN tb_the_recs ON rec_the_ID = ID WHERE rec= '" + rec + "'", cn))
                    {
                        cn.Open();
                        SqlDataReader rd = cmd.ExecuteReader();
                        if (rd.HasRows)
                        {
                            result = new List<string>();
                            while (rd.Read())
                            {
                                result.Add(rd["comment"].ToString());
                            }
                            rd.Close();
                            cn.Close();                            
                        }
                        else
                        {
                            cn.Close();                            
                        }
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                return null;                
            }           
        }

        protected void btnGetData_Click(object sender, EventArgs e)
        {
            List<string> result = get_the_recs(txtData.Text.Replace("'", "''").Trim());
            gvwData.DataSource = result;
            gvwData.DataBind();
        }
    }
}