<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="forgotPwd.aspx.cs" Inherits="forgotPwd"  MaintainScrollPositionOnPostback="true"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
          <!--Page Title-->
<section class="page-title text-center" style="background-image:url(images/background/3.jpg);">
    <div class="container">
        <div class="title-text">
            <h1>Forgot Password</h1>
            <ul class="title-menu clearfix">
                <li>
                    <a href="default.aspx">home</a>
                </li>
                <li>Forgot Password</li>
            </ul>
        </div>
    </div>
</section>
<!--End Page Title-->

<!--==================================
=        Forgot Password Form            =
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
                            <h3>Forgot Password Page</h3>
                        </div>
                    </div>
                   
                </div>
                <!-- address end -->
            </div>
            <div class="col-md-8">
                <div class="contact-form">
                    <!-- contact form start -->
       
                    <form action="#" class="row">
                        
                        
                        <div class="col-md-6">
                            <label for="contact-name">Email
                                        <span>*</span>
                            </label>
                           <asp:TextBox ID="txtemail" runat="server"  class="form-control main"  required/>
                        </div>
                        
                  

                        <div class="col-md-12">
                            <asp:Label ID="lblmsg" runat="server" />
                            
                        </div>
                        
                        <div class="col-md-12">
                            <asp:Button ID="btnSend" runat="server" class="btn btn-style-one"  Text="Send" OnClick="btnSend_Click" />
                        </div>


                         </form>
                    <!-- contact form end -->
                </div>
            </div>
        </div>
    </div>
    <!-- container end -->
</section>
<!--====  End of Forgot Password Form  ====-->


</asp:Content>

