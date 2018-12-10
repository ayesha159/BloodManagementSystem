using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Blood_Collection_Confirmation_Form : System.Web.UI.Page
{
    string _UserID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CurrentUser_ID"] != null)
            _UserID = Session["CurrentUser_ID"].ToString();

        AJ_DataClass ajdbClass = new AJ_DataClass();
        DataSet ds = new DataSet();

        if (!IsPostBack)
        {
            ds.Clear();
            string qry = "SELECT        tblRequestForBlood.t_id, tblRegister.r_id, tblRegister.RName, tblRegister.RContact, tblRegister.RAddress, tblRequestForBlood.tDonor_id, tblRequestForBlood.tAcceptedbyDonor,  " + 
"                          tblRequestForBlood.tMeetingPlace, tblRequestForBlood.tMeetingAddress, tblRequestForBlood.tMeetingDate, tblRequestForBlood.tRecieved, tblRequestForBlood.tReceivedDate,  " +
"                          tblBloodGroups.BlName, tblRegister_1.RBloodPointDate AS DNR_RBloodPointDate " +
" FROM            tblRegister INNER JOIN " +
  "                        tblRequestForBlood ON tblRegister.r_id = tblRequestForBlood.tAcceptor_id INNER JOIN " +
    "                      tblBloodGroups ON tblRequestForBlood.tBloodGroup_id = tblBloodGroups.Bl_id INNER JOIN " +
      "                    tblRegister AS tblRegister_1 ON tblRequestForBlood.tDonor_id = tblRegister_1.r_id " + 
  " where tDonor_id ='" + _UserID + "' and  tAcceptedbyDonor='true' and tRecieved='false' ";
     ds = ajdbClass.GetRecords("tblRequestForBlood", qry);
            string _acptID = "";
            string _name = "";
            string _contact = "";
            string _blrequested = "";
            string _place = "";
            string _placeAddr = "";
            string _mdate = "";

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                hftid.Value = dr["t_id"].ToString().Trim();
                _acptID = dr["r_id"].ToString().Trim();
                 _name =  dr["rName"].ToString().Trim();
                 _contact =  dr["rcontact"].ToString().Trim();
                 _blrequested =  dr["blName"].ToString().Trim();
                 _place =  dr["tMeetingPlace"].ToString().Trim();
                 _placeAddr =  dr["tMeetingAddress"].ToString().Trim();
                 _mdate =  dr["tMeetingDAte"].ToString().Trim();
               hfDnrPDate.Value = dr["DNR_RBloodPointDate"].ToString().Trim();
            }
            DateTime _dt;
            string _dtx = "";
            try
            {
                _dt = Convert.ToDateTime(_mdate);
                _dtx = _dt.ToShortDateString();
            }
            catch (Exception ex) { }
            string _sentense = "N/A";
            if (ds.Tables[0].Rows.Count != 0)
            {
                _sentense = "Blood Acceptor " + _name + " (" + _acptID + ") *Contact#: " + _contact + " Requested for Blood Group(" + _blrequested + "). Meetings Place is :" + _place + " Full Address: " + _placeAddr + " Meeting Date:" + _dtx + " was set by donor.";
            }
            else btngive.Visible = false;
           txtstatement.Text = _sentense;



        }
    }



    

    protected void btnchngPwd_Click(object sender, EventArgs e)
    {

       


        AJ_DataClass ajdbClass = new AJ_DataClass();
        string updateQry = "update tblRegister set rPassword = '' " +
        "  where r_id='" + _UserID + "'";
        lblmsg.Text = ajdbClass.UpdateDatabase(updateQry);
        if (lblmsg.Text == "Update Record(s) Succfully")
        {
            lblmsg.Text = "Password Changed Successfully";
       
        }
    }

    protected void btngive_Click(object sender, EventArgs e)
    {
        DateTime d1 = DateTime.Now;
        


        AJ_DataClass ajdbClass = new AJ_DataClass();
        DataSet ds = new DataSet();

        string qryUpdate = "update tblRequestForBlood set tRecieved='true',tReceivedDate='" + DateTime.Now.ToShortDateString() + "' " +
            " where t_id='" + hftid.Value + "'";

        lblmsg.Text = ajdbClass.UpdateDatabase( qryUpdate);

        string qryUpdate2_rejectOtherRequests = "update tblRequestForBlood set tRecieved='false',tRejected='true',tRejectionReason='Donor is not Eligible Now' " +
            " where tDonor_id='" + _UserID + "' and t_id <> '" + hftid.Value + "' and tAcceptedbyDonor='false'";
       lblmsg.Text = ajdbClass.UpdateDatabase(qryUpdate2_rejectOtherRequests);

        string qryUpdateDnrEligibilityDate = "Update tblRegister set RBloodPointDate='" + d1.ToShortDateString() + "' " +
            " where r_id='" + _UserID + "'";
        lblmsg.Text = ajdbClass.UpdateDatabase(qryUpdateDnrEligibilityDate);

        btngive.Enabled = false;


    }
}