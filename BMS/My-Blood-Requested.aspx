<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="My-Blood-Requested.aspx.cs" Inherits="My_Blood_Requested" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section class="page-title text-center" style="background-image:url(images/background/3.jpg);">
  
 <div class="container">
          <div class="title-text">
            <h1>My Blood Requests</h1>
            <ul class="title-menu clearfix">
                <li>
                    <a href="default.aspx">home &nbsp;/</a>
                </li>
                <li>My Blood Requests</li>
            </ul>
        </div>
    </div>
</section>

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
                            <h3>My Requests</h3>
                        </div>
                    </div>
                   
                </div>
                <!-- address end -->
            </div>
            <div class="col-md-8">
                <div class="contact-form">
                    <!-- contact form start -->
       
                    <form action="#" class="row">
                       <div id="bodyCenter">
<div id="Round">
<a name="#city"></a>
		<div style="padding:10px;">
	<h3>My Blood Requests </h3>
            <asp:Literal ID="litDnr" runat="server" />
    <br><br><br>        
        </div>
</div>	
</div>
                         </form>
                    <!-- contact form end -->
                </div>
            </div>
        </div>
    </div>
    <!-- container end -->
</section>
    
</asp:Content>

