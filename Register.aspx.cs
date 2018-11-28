using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AJ_DataClass ajdbClass = new AJ_DataClass();
        DataSet ds = new DataSet();

        if (!IsPostBack)
        {
            ds = ajdbClass.GetRecords("tblCities", "select * from tblCities");
            cboCities.DataSource = ds.Tables[0];
            cboCities.DataValueField = "ct_id";
            cboCities.DataTextField = "ctName";
            cboCities.DataBind();

            ds = ajdbClass.GetRecords("tblBloodGroups", "select * from tblBloodGroups");
            cboBGroup.DataSource = ds.Tables[0];
            cboBGroup.DataValueField = "Bl_id";
            cboBGroup.DataTextField = "BlName";
            cboBGroup.DataBind();
        }
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        AJ_DataClass ajdbClass = new AJ_DataClass();
        string _name = txtName.Text;
        string _bgid = cboBGroup.SelectedValue;
        string _email = txtEmail.Text;
        string _ctid = cboCities.SelectedValue;
        string _gender = cboGender.SelectedValue;
        string _contact = txtcontact.Text;
        string _addr = txtaddr.Text;
        string _pwd = txtPwd.Text;

        string _isAcceptor = "false";
        string _isDonor = "false";
        if (chkAcceptor.Checked == true) _isAcceptor = "True";
        if (chkDonor.Checked == true) _isDonor = "True";



        string _DataFields = "rname,rbl_id,risAcceptor," +
            "risdonor,remail,rct_id,rgender,rcontact," + 
            "raddress,rpassword,rDate";
    string _Values = "'" + _name  +"','" + _bgid +"','" + _isAcceptor +"','"
            + _isDonor +"','" + _ctid  +"','" + _gender +"','" + _contact +"','" 
            + _addr +"','" + _pwd +"','" + DateTime.Now.ToShortDateString() +"'";
        string Result = ajdbClass.InsertIntoDatabase("tblRegister", _DataFields, _Values);
        lblmsg.Text = Result;

    }
}

//	[RBlockedDated] [datetime] NULL,
//	[RDate] [datetime] NULL,