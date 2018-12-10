using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class My_Requests : System.Web.UI.Page
{
    string _userId = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CurrentUser_ID"] != null) { _userId = Session["CurrentUser_ID"].ToString(); }

            if (Session["CurrentUser_ID"] == null) Response.Redirect("Login.aspx");
        AJ_DataClass ajdbClass = new AJ_DataClass();
        DataSet ds = new DataSet();

        GetRecords();
        

    }

    private void GetRecords()
    {

        AJ_DataClass ajdbClass = new AJ_DataClass();
        DataSet ds = new DataSet();


        ds.Clear();
        string qry = "SELECT        tblRequestForBlood.tAcceptor_id, tblRequestForBlood.t_id, tblRegister.r_id, tblRegister.RName, tblBloodGroups.BlName, tblRequestForBlood.tRequestDate, " +
"                          tblRequestForBlood.tAcceptedbyDonor, tblRequestForBlood.tRejected, tblRequestForBlood.tRejectionReason,tMeetingPlace,tMeetingAddress,tMeetingDate " +
" FROM            tblRequestForBlood INNER JOIN " +
  "                        tblRegister ON tblRequestForBlood.tDonor_id = tblRegister.r_id INNER JOIN " +
    "                      tblBloodGroups ON tblRegister.rBl_id = tblBloodGroups.Bl_id " +
     " where tAcceptor_id = '"+ _userId +"' ";

        

        ds = ajdbClass.GetRecords("tblRequestForBlood", qry);

        string _litVal = "";




        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            DateTime _dt = Convert.ToDateTime(dr["tRequestDate"]);
            DateTime _dtm ;
            string _dts = "N/A";
            try { _dtm = Convert.ToDateTime(dr["tmeetingDate"]); _dts = _dtm.ToShortDateString(); } catch (Exception ex) { }
            
            

  _litVal = _litVal + "<tr>" +
                    "<td style = 'text-align: center;' >" + dr["r_id"].ToString().Trim() + "</td> " +

                    " <td style = 'text-align: center;' >" + dr["rName"].ToString().Trim() + "</td> " +

                     " <td style = 'text-align: center;' >" + dr["blName"].ToString().Trim() + "</td> " +

                     
                      " <td style = 'text-align: center;' >" + _dt.ToShortDateString() + "</td> " +

                      " <td style = 'text-align: center;' >" + dr["tRejected"].ToString().Trim() + "</td> " +
                      " <td style = 'text-align: center;' >" + dr["tRejectionReason"].ToString().Trim() + "</td> " +
                      
                      " <td style = 'text-align: center;' >" + dr["tAcceptedbyDonor"].ToString().Trim() + "</td> " +
                      " <td style = 'text-align: center;' >" + dr["tmeetingPlace"].ToString().Trim() + "</td> " +
                      " <td style = 'text-align: center;' >" + dr["tmeetingAddress"].ToString().Trim() + "</td> " +
                      
                      " <td style = 'text-align: center;' >" + _dts + "</td> " +




                        " </tr>";
        }
        string _heaed = "<table style='border:thin solid gray; width:100%;background-color:white' cellpadding = '1' cellspacing = '1' >" +

             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>Dnr-ID</td>" +
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>Name</td>" +
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>Blood</td>" +
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>Dated</td>" +
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>Rejected</td>" +
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>Reason</td>" +
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>Accepted</td>" +
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>Place</td>" +
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>Address</td>" +
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>Date</td>" +






             "</tr>";



        litDnr.Text = _heaed + _litVal + "</table> ";
    }


    protected void btnsearch_Click(object sender, EventArgs e)
    {
        GetRecords();
    }
}