<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Blood-Collection-Confirmation-Form.aspx.cs" Inherits="Blood_Collection_Confirmation_Form" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <!--Page Title-->
<section class="page-title text-center" style="background-image:url(images/background/3.jpg);">
    <div class="container">
        <div class="title-text">
            <h1>Blood Collection Confirmation</h1>
            <ul class="title-menu clearfix">
                <li>
                    <a href="default.aspx">home &nbsp;/</a>
                </li>
                <li>Blood Collection Confirmation</li>
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
                            <h3>Blood Collection Confirmation</h3>
                        </div>
                    </div>
                   
                </div>
                <!-- address end -->
            </div>
            <div class="col-md-8">
                <div class="contact-form">
                    <!-- contact form start -->
               <asp:HiddenField ID="hftid" runat="server" />
                    <asp:HiddenField ID="hfDnrPDate" runat="server" />
                    <form action="#" class="row">
                        <!-- name -->
                        <div class="col-md-12">
                            <label for="contact-name">
                                        <span>Statement</span>
                            </label>
                         <asp:TextBox ID="txtstatement"  runat="server"  class="form-control main" TextMode="MultiLine" Rows="3" />
                        </div>
                        
                       

                        <div class="col-md-6">
                            <asp:Label ID="lblmsg" runat="server" />
                            
                        </div>
                        
                        <!-- submit button -->
                        <div class="col-md-12 text-right">
                        <asp:Button ID="btngive" runat="server" class="btn btn-style-one"  Text="Give Blood to Acceptor" OnClick="btngive_Click"  />
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

