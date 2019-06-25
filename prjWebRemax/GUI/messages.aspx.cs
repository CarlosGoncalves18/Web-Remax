using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace prjWebRemax.GUI
{
    public partial class messages : System.Web.UI.Page
    {
        static OleDbConnection myCon;
  
        protected void Page_Load(object sender, EventArgs e)
        {
            //txtRecipient.Text = Request.QueryString["refA"].ToString();
            var refAgent = Convert.ToInt32(Request.QueryString["refA"]);
            lblMessageSent.Text = "";

            if (!Page.IsPostBack)
            {
                myCon = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + Server.MapPath("~/App_Data/RemaxDatabase.mdb"));
                myCon.Open();
                string sql = "Select AgentName, AgentNumber FROM Agent WHERE AgentNumber =" + refAgent;
                OleDbCommand myCmd = new OleDbCommand(sql, myCon);
                OleDbDataReader myRead = myCmd.ExecuteReader();                   
                if (myRead.Read())
                {
                    txtRecipient.Text = myRead["AgentName"].ToString();
                }
                myRead.Close();     
            }       
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtMessage.Text = string.Empty;
            txtSubject.Text = string.Empty;
            txtFrom.Text = string.Empty;
            txtFrom.Focus();
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            var refAgent = Convert.ToInt32(Request.QueryString["refA"]);
            string sql = "Insert into Messages (Title,Message,Sender,Receiver) Values ('" + txtSubject.Text + "','" + txtMessage.Text + "','" + txtFrom.Text + "'," + refAgent + ")";
            OleDbCommand myCmd = new OleDbCommand(sql, myCon);
            myCmd.ExecuteNonQuery();
            txtMessage.Text = string.Empty;
            txtSubject.Text = string.Empty;
            txtFrom.Text = string.Empty;
            txtMessage.Focus();
            lblMessageSent.Text = "Your Message has been sent successfully.";
        }
    }
}