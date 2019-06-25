using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

namespace prjWebRemax.GUI
{
    public partial class agents : System.Web.UI.Page
    {
        static OleDbConnection myCon;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                myCon = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + Server.MapPath("~/App_Data/RemaxDatabase.mdb"));
                myCon.Open();
                fillComboBox();
                string sql = "SELECT * FROM Agent";
                OleDbCommand myCmd = new OleDbCommand(sql, myCon);
                OleDbDataReader myRd = myCmd.ExecuteReader();
                Display(myRd);
            }
        }
        private void fillComboBox()
        {
            OleDbCommand cmdAgentNro = new OleDbCommand("SELECT AgentNumber From Agent", myCon);
            OleDbDataReader rdNro = cmdAgentNro.ExecuteReader();
            cboAgentNumber.DataTextField = "AgentNumber";
            cboAgentNumber.DataValueField = "AgentNumber";
            cboAgentNumber.DataSource = rdNro;
            cboAgentNumber.DataBind();

            OleDbCommand cmdLocation = new OleDbCommand("SELECT * FROM City", myCon);
            OleDbDataReader rdLocatom = cmdLocation.ExecuteReader();
            cboCity.DataTextField = "CityName";
            cboCity.DataValueField = "CityId";
            cboCity.DataSource = rdLocatom;
            cboCity.DataBind();

            OleDbCommand cmdGender = new OleDbCommand("SELECT * FROM Gender", myCon);
            OleDbDataReader rdGender = cmdGender.ExecuteReader();
            cboGender.DataTextField = "GenderName";
            cboGender.DataValueField = "GenderId";
            cboGender.DataSource = rdGender;
            cboGender.DataBind();

            OleDbCommand cmdLanguage = new OleDbCommand("SELECT * FROM AgentLanguage", myCon);
            OleDbDataReader rdLanguage = cmdLanguage.ExecuteReader();
            cboLanguage.DataTextField = "LanguageName";
            cboLanguage.DataValueField = "LanguageId";
            cboLanguage.DataSource = rdLanguage;
            cboLanguage.DataBind();


        }

        private void Display(OleDbDataReader myRd)
        {
            Image img = new Image();
            litAgents.Text = "<table><tr>";
            int c = 0;
            DateTime n = DateTime.Now;
            while (myRd.Read())
            {
                c++;
                litAgents.Text += @"<td><div class='card' style='width: 18rem; '><img src='../images/" + myRd["Photo"].ToString() + "' style='width:286px;height:286px;' class='card-img-top'><div class='card-body'><h6 class='card-title'><strong>" + myRd["AgentName"].ToString().ToUpper() + "</strong></h6><p class='card-text'>" + myRd["City"].ToString() + "</p><p>" + myRd["Language"].ToString() + "</p><a href = 'messages.aspx?refA=" + myRd["AgentNumber"] + "' class='btn btn-danger'>Contact Me</a></div></div></td>";
                if (c == 4)
                {
                    litAgents.Text += "</tr><tr>";
                    c = 0;
                }
            }
            litAgents.Text += "</table>";
        }

        protected void cboAgentNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Agent WHERE AgentNumber =" + cboAgentNumber.SelectedItem.Value;
            OleDbCommand myCmd = new OleDbCommand(sql, myCon);
            OleDbDataReader myRd = myCmd.ExecuteReader();
            Display(myRd);
        }

        protected void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Agent WHERE Gender ='" + cboGender.SelectedItem.Text + "'";
            OleDbCommand myCmd = new OleDbCommand(sql, myCon);
            OleDbDataReader myRd = myCmd.ExecuteReader();
            Display(myRd);
        }

        protected void cboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Agent WHERE City ='" + cboCity.SelectedItem.Text + "'";
            OleDbCommand myCmd = new OleDbCommand(sql, myCon);
            OleDbDataReader myRd = myCmd.ExecuteReader();
            Display(myRd);
        }

        protected void cboLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Agent WHERE [Language] ='" + cboLanguage.SelectedItem.Text + "'";
            OleDbCommand myCmd = new OleDbCommand(sql, myCon);
            OleDbDataReader myRd = myCmd.ExecuteReader();
            Display(myRd);
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Agent WHERE AgentNumber =" + cboAgentNumber.SelectedItem.Value + "AND Gender='" + cboGender.SelectedItem.ToString() + "'AND City='" + cboCity.SelectedItem.ToString() + "'AND [Language]='" + cboLanguage.SelectedItem.ToString() + "'";
            OleDbCommand myCmd = new OleDbCommand(sql, myCon);
            OleDbDataReader myRd = myCmd.ExecuteReader();
            Display(myRd);
        }
    }

  
}