using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class Change_Password : System.Web.UI.Page
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





            string _oldPwd = "";

            ds.Clear();
            ds = ajdbClass.GetRecords("tblRegister", "select * from tblRegister where r_id='" + _UserID + "'");

            if (ds.Tables[0].Rows.Count == 0)
            {
                lblmsg.Text = "Invalid User Name or Password";
            }
            else
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                   _oldPwd = dr["rPassword"].ToString().Trim();
                }
            }





        }
    }





    //protected void btnUpdate_Click(object sender, EventArgs e)

    //{

    //    string _isAcceptor = "false";
    //    string _isDonor = "false";
    //    if (chkAcceptor.Checked == true) _isAcceptor = "True";
    //    if (chkDonor.Checked == true) _isDonor = "True";

    //    AJ_DataClass ajdbClass = new AJ_DataClass();
    //    string updateQry = "update tblRegister set rName = '" + txtName.Text.Replace("'", "''").Trim() + "'," +
    //    "rcontact='" + txtcontact.Text.Trim().Replace("'", "''") + "'," +
    //    "raddress='" + txtaddr.Text.Trim().Replace("'", "''") + "'," +
    //    "rbl_id='" + cboBGroup.SelectedValue + "'," +
    //    "rct_id='" + cboCities.SelectedValue + "'," +
    //    "rgender='" + cboGender.SelectedValue + "'," +
    //    "risAcceptor='" + _isAcceptor + "'," +
    //    "risDonor='" + _isDonor + "' " +
    //    "  where r_id='" + _UserID + "'";
    //    lblmsg.Text = ajdbClass.UpdateDatabase(updateQry);



    //}

    protected void btnchngPwd_Click(object sender, EventArgs e)
    {

        if (txtopwd.Text.Trim().Length == 0)
        {
            lblmsg.Text = "Invalid Old Password or User Name ! ";
            txtopwd.Focus();
            return;
        }

        if (txtnpwd.Text.Trim() != txtrpwd.Text.Trim())
        {
            lblmsg.Text = "Password MissMatched !";
            txtrpwd.Focus();
            return;
        }



        AJ_DataClass ajdbClass = new AJ_DataClass();
        string updateQry = "update tblRegister set rPassword = '" + txtnpwd.Text.Replace("'", "''").Trim() + "' " +
        "  where r_id='" + _UserID + "'";
        lblmsg.Text = ajdbClass.UpdateDatabase(updateQry);
        if (lblmsg.Text == "Update Record(s) Succfully")
        {
            lblmsg.Text = "Password Changed Successfully";
            txtnpwd.Text = "";
            txtopwd.Text = "";
            txtrpwd.Text = "";

        }
    }
}