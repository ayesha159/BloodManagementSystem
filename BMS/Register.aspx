<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register"  MaintainScrollPositionOnPostback="true"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
<!--Page Title-->
<section class="page-title text-center" style="background-image:url(images/background/3.jpg);">
    <div class="container">
        <div class="title-text">
            <h1>Register</h1>
            <ul class="title-menu clearfix">
                <li>
                    <a href="default.aspx">home &nbsp;/</a>
                </li>
                <li>Register</li>
            </ul>
        </div>
    </div>
</section>
<!--End Page Title-->

<!--==================================
=            Contact Form            =
===================================-->
<section class="section contact">
    <!-- container start -->
    <div class="container">
        <div class="row">
            <div class="col-md-4">
                <!-- address start -->
                <div class="address-block">
                    <!-- Location -->
                    <div class="media">
                        <i class="fa fa-map-o"></i>
                        <div class="media-body">
                            <h3>Register</h3>
                        </div>
                    </div>
                    <!-- Phone -->
                    
                    
                </div>
                <!-- address end -->
            </div>
            <div class="col-md-8">
                <div class="contact-form">
                    <!-- contact form start -->
                    <form action="#" class="row">
                        
                        <div class="col-md-6">
                            <label>Name<span>*</span></label>
                           <asp:TextBox ID="txtName" runat="server"  class="form-control" required/>
                        </div>
                        
                        <div class="col-md-6">
                          <label>Blood Group<span>*</span></label>
                            <asp:DropDownList ID="cboBGroup" runat="server"   class="btn btn-secondary btn-lg dropdown-toggle"  />
                        </div>
                        
                        <div class="col-md-12">
                            <label>Email<span>*</span></label>
                           <asp:TextBox ID="txtEmail" runat="server"  class="form-control" required/>
                        </div>

                        <div class="col-md-6">
                          <label>Cities</label>
                            <asp:DropDownList ID="cboCities" runat="server"  class="btn btn-secondary btn-lg dropdown-toggle" style="border:1px;" />
                            
                        </div>
                        <!-- email -->
                        <div class="col-md-6">
                            <label>Gender</label>
                          <asp:DropDownList ID="cboGender" runat="server"  class="btn btn-secondary btn-lg dropdown-toggle">
                              <asp:ListItem Selected="True">Male</asp:ListItem>
                              <asp:ListItem>Fe-Male</asp:ListItem>
                              </asp:DropDownList>
                        </div>

                        <div class="col-md-12">
                           <label>Contact</label>
                            <asp:TextBox ID="txtcontact" runat="server"  class="form-control main"  required/>
                        </div>

                        <div class="col-md-12">
                           <label>Address</label>
                            <asp:TextBox ID="txtaddr" runat="server"  class="form-control main"  required/>
                        </div>

                        <div class="col-md-6">
                            <asp:CheckBox ID="chkAcceptor" runat="server" Text="Acceptor" />
                        </div>

                          <div class="col-md-6">
                            <asp:CheckBox ID="chkDonor" runat="server" Text="Donor" />
                        </div>


                        <div class="col-md-12">
                           <label>Password</label>
                            <asp:TextBox ID="txtPwd" runat="server"  class="form-control main"  required TextMode="Password"/>
                        </div>

                        <div class="col-md-12">
                           <label>Re-Type Password</label>
                            <asp:TextBox ID="txtPwd2" runat="server"  class="form-control main"  required  TextMode="Password"/>
                        </div>

                        <div class="col-md-12">
                          <asp:Label ID="lblmsg" runat="server"  />
                        </div>


                        <!-- submit button -->
                        <div class="col-md-12 text-right">
                          <asp:Button ID="btnRegister" runat="server"  class="btn btn-style-one"  Text="Register" OnClick="btnRegister_Click" />
                        </div>
                    </form>
                    <!-- contact form end -->
                </div>
            </div>
        </div>
    </div>
    <!-- container end -->
</section>
<!--====  End of Contact Form  ====-->

<!--================================
=            Google Map            =
=================================-->
<section class="map">
    <!-- Google Map -->
    <div id="map"></div>
</section>
<!--====  End of Google Map  ====-->
</asp:Content>

