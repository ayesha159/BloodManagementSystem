<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Change-Password.aspx.cs" Inherits="Change_Password"  MaintainScrollPositionOnPostback="true"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <!--Page Title-->
<section class="page-title text-center" style="background-image:url(images/background/3.jpg);">
    <div class="container">
        <div class="title-text">
            <h1>Change Password</h1>
            <ul class="title-menu clearfix">
                <li>
                    <a href="default.aspx">home &nbsp;/</a>
                </li>
                <li>Change Password</li>
            </ul>
        </div>
    </div>
</section>
<!--End Page Title-->

<!--==================================
=            Change Password Form            =
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
                            <h3>Change Password Page</h3>
                        </div>
                    </div>
                   
                </div>
                <!-- address end -->
            </div>
            <div class="col-md-8">
                <div class="contact-form">
                    <!-- contact form start -->
               
                    <form action="#" class="row">
                        <!-- name -->
                        <div class="col-md-6">
                            <label for="contact-name">Old Password
                                        <span>*</span>
                            </label>
                           <asp:TextBox ID="txtopwd" runat="server"  class="form-control main" TextMode="Password" required />
                        </div>
                        
                        <div class="col-md-6">
                            <label for="contact-name">New Password
                                        <span>*</span>
                            </label>
                            <asp:TextBox ID="txtnpwd" runat="server"  class="form-control main"  required  TextMode="Password" />
                        </div>

                        <div class="col-md-6">
                            <label for="contact-name">Re-type Password
                                        <span>*</span>
                            </label>
                            <asp:TextBox ID="txtrpwd" runat="server"  class="form-control main"  required  TextMode="Password" />
                        </div>

                        <div class="col-md-6">
                            <asp:Label ID="lblmsg" runat="server" />
                            
                        </div>
                        
                        <!-- submit button -->
                        <div class="col-md-12 text-right">
                        <asp:Button ID="btnchngPwd" runat="server" class="btn btn-style-one"  Text="Change Password" OnClick="btnchngPwd_Click" />
                        </div>
                    </form>
                    <!-- contact form end -->
                </div>
            </div>
        </div>
    </div>
    <!-- container end -->
</section>
<!--====  End of Change Password Form  ====-->


</asp:Content>

