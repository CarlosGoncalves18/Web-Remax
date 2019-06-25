using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace prjWebRemax.GUI
{
    public partial class message : System.Web.UI.Page
    {
        static OleDbConnection myCon;

        protected void Page_Load(object sender, EventArgs e)
        {          
            lblMessageSent.Text = "";

            if (!Page.IsPostBack)
            {
                myCon = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + Server.MapPath("~/App_Data/RemaxDatabase.mdb"));
                myCon.Open();
                string sql = "SELECT AgentNumber, AgentName from Agent";
                OleDbCommand myCmd = new OleDbCommand(sql, myCon);
                OleDbDataReader myRead = myCmd.ExecuteReader();
                cboRecipient.DataValueField = "AgentNumber";
                cboRecipient.DataTextField = "AgentName";
                cboRecipient.DataSource = myRead;
                cboRecipient.DataBind();

            }
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            var receiver = Convert.ToInt32(cboRecipient.SelectedItem.Value);
            string sql = "Insert into Messages (Title,Message,Sender,Receiver) Values ('" + txtSubject.Text + "','" + txtMessage.Text + "','" + txtFrom.Text + "'," + receiver + ")";
            OleDbCommand myCmd = new OleDbCommand(sql, myCon);
            myCmd.ExecuteNonQuery();
            txtMessage.Text = string.Empty;
            txtSubject.Text = string.Empty;
            txtFrom.Text = string.Empty;
            txtMessage.Focus();
            lblMessageSent.Text = "Your Message has been sent successfully.";
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtMessage.Text = string.Empty;
            txtSubject.Text = string.Empty;
            txtFrom.Text = string.Empty;
            txtFrom.Focus();
        }
    }
}