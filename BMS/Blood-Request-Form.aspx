<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Blood-Request-Form.aspx.cs" Inherits="Blood_Request_Form" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <section class="page-title text-center" style="background-image:url(images/background/3.jpg);">
    <div class="container">
        <div class="title-text">
            <h1>Blood Request Form</h1>
            <ul class="title-menu clearfix">
                <li>
                    <a href="default.aspx">home &nbsp;/</a>
                </li>
                <li>Blood Request Form</li>
            </ul>
        </div>
    </div>
</section>

  <div class="container">
    
            <div class="row" style="padding-top:20px;">
                <div class="col-xs-12 col-sm-6 col-md-6"> </div>
            </div>
      <div class="row" style="padding-top:20px;">
        <div class="col-xs-12 col-sm-6 col-md-6" style="background-color:#E2E2E2;">
            
            <div class="col-md-12" >
                <b>DONOR's INFO</b>  <br />   
            </div>
            <div class="col-md-12">
            <asp:HiddenField ID="hfdnrid" runat="server" />
                <label>Donor Name :</label>
                          <asp:Label ID="lbldname" runat="server"        />
            </div>
            <div class="col-md-12">
                <label>Blood Group Required : </label>
                
                          <asp:DropDownList ID="cbodBGroup" runat="server" style="background-color:#E2E2E2;" Enabled="false"    />
            </div>
            <div class="col-md-12">
                <label>Email : </label>
                          <asp:Label ID="lbldemail" runat="server"        />
            </div>
            <div class="col-md-12">
                <label>City : </label>
                          <asp:DropDownList ID="cbodcities" runat="server" style="background-color:#E2E2E2;" Enabled="false"    />
            </div>
            <div class="col-md-12">
                <label>Gender : </label>
               <asp:DropDownList ID="cbodgender" runat="server" style="background-color:#E2E2E2;" Enabled="false"    >
                   <asp:ListItem Selected="True">Male</asp:ListItem>
                              <asp:ListItem>Fe-Male</asp:ListItem>
               </asp:DropDownList>
                
            </div>
            <div class="col-md-12">
                <label>Contact : </label>
                          <asp:Label ID="lbldcon" runat="server"        />
            </div>
            <div class="col-md-12">
                <label>Address : </label>
                          <asp:Label ID="lbldAddr" runat="server"        />
            </div>
        </div>
         
                  <div class="col-xs-12 col-sm-6 col-md-6" style="background-color:#E2E2E2;"> 
                      <b>ACCEPTOR's INFO</b>  <br />   
            <div class="col-md-12">
                <label>Name : </label>
                          <asp:Label ID="lblaname" runat="server"   />
            </div>
            <div class="col-md-12">
                <label>Blood Group : </label>
                          <asp:DropDownList ID="cboaBGroup" runat="server" style="background-color:#E2E2E2;" Enabled="false"    />
            </div>
            <div class="col-md-12">
                <label>Email : </label>
                          <asp:Label ID="lblaemail" runat="server"        />
            </div>
            <div class="col-md-12">
                <label>City : </label>
                          <asp:DropDownList ID="cboacities" runat="server" style="background-color:#E2E2E2;" Enabled="false"    />
            </div>
            <div class="col-md-12">
                <label>Gender : </label>
                          <asp:DropDownList ID="cboagender" runat="server" style="background-color:#E2E2E2;" Enabled="false"    >
                   <asp:ListItem Selected="True">Male</asp:ListItem>
                              <asp:ListItem>Fe-Male</asp:ListItem>
               </asp:DropDownList>
            </div>
            <div class="col-md-12">
                <label>Contact : </label>
                          <asp:Label ID="lblacon" runat="server"        />
            </div>
            <div class="col-md-12">
                <label>Address : </label>
                          <asp:Label ID="lblaAddr" runat="server"        />
            </div>
        
        </div>
        
      </div>

      <div class="row" style="padding-bottom:40px;">
          <div class="col-md-12">
            <asp:Label ID="lblmsg" runat="server"        />
            </div>
                <div class="col-xs-12 col-sm-6 col-md-6" style="padding-top:20px;"> 
                      <asp:Button ID="btnRegister" runat="server"  class="btn btn-style-one"  Text="Send Request" OnClick="btnRegister_Click" />
                </div>
            </div>
      
                        
                        
</div>
</asp:Content>
