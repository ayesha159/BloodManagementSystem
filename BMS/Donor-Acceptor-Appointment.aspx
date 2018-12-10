<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Donor-Acceptor-Appointment.aspx.cs" Inherits="Donor_Acceptor_Appointment" MaintainScrollPositionOnPostback="true"  %>

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
    <asp:HiddenField id="hftid" runat="server" />
            <div class="row" style="padding-top:20px;">
                <div class="col-xs-12 col-sm-6 col-md-6"> </div>
            </div>
      <div class="row" style="padding-top:20px;">
         
        
      </div>

      <!-- Contact Section -->
<section class="appoinment-section section">
    <div class="container">
        <div class="row">
            <div class="col-md-6 col-sm-12 col-xs-12">
                <div class="accordion-section">
    <div class="section-title">
        <h3>Acceptor Info</h3>
    </div>
   
        
                  <div class="col-md-12" style="background-color:#E2E2E2;"> 
                      
            <div class="col-md-12">
                <label>Name : </label>
                          <asp:Label ID="lblaname" runat="server"   />
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
            </div>
         
            
            
            <div class="col-md-6 col-sm-12 col-xs-12">
                <div class="contact-area">
    <div class="section-title">
        <h3>Set
            <span>Appointment</span>
        </h3>
    </div>
    <form name="contact_form" class="default-form contact-form" action="sendmail.php" method="post">
        <div class="row">
            <div class="col-md-6 col-sm-12 col-xs-12">
                
                <div class="form-group">
                   <asp:TextBox ID="txtPlace" runat="server" placeholder="Place" required/>
                </div>
               
            </div>
            <div class="col-md-6 col-sm-12 col-xs-12">
                
                <div class="form-group">
                   <asp:TextBox ID="txtdate" runat="server"  placeholder="Date mm/dd/yyyy" required/>
                    <i class="fa fa-calendar" aria-hidden="true"></i>
                </div>
              
            </div>
            <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="form-group">
                    <textarea runat="server" id="txtmsg" name="form_message" placeholder="Full Address " required=""></textarea>
                </div>
                <div class="form-group text-center">
                    <asp:Label ID="lblmsg" runat="server"        />
                    <br />
                   <asp:Button ID="btnSetAppointment" runat="server"  class="btn btn-style-one"  Text="Set Appointment"  BackColor="#00CCFF" Font-Size="Medium" OnClick="btnSetAppointment_Click" />
                </div>
            </div>
        </div>
    </form>
</div>                        
            </div>
        </div>                    
    </div>
</section>
<!-- End Contact Section -->


      <div class="row" style="padding-bottom:40px;">
          <div class="col-md-12">
            
            </div>
                <div class="col-xs-12 col-sm-6 col-md-6" style="padding-top:20px;"> 
                      
                </div>
            </div>
      
                        
                        
</div>
</asp:Content>
