<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SearchDonor.aspx.cs" Inherits="SearchDonor"  MaintainScrollPositionOnPostback="true"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section class="page-title text-center" style="background-image:url(images/background/3.jpg);">
  
 <div class="container">
        <div class="title-text">
            <h2>Search Donor</h2>
            <ul class="title-menu clearfix">
                <li>
                    <a href="default.aspx">home</a>
                </li>
                <li>Search Donor</li>
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
                            <h3>Search Donor</h3>
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

	<h3>Search Donor </h3>

        	<form action="#city" method="post" class="formFill">

            <fieldset>

            	<div class="col-md-6">
                          <label><span><asp:CheckBox id="chkCities" runat="server" /> </span>Cities</label>
                            <asp:DropDownList ID="cboCities" runat="server"  class="btn btn-secondary btn-lg dropdown-toggle" style="border:1px;" />
                            
                        </div>

                <div class="col-md-6">
                          <label><span><asp:CheckBox id="chkBlood" runat="server" /> </span>Blood Group</label>
                            <asp:DropDownList ID="cboBGroup" runat="server"   class="btn btn-secondary btn-lg dropdown-toggle"  />
                        </div>



	 <div class="col-md-12 text-right">
                        <asp:Button ID="btnsearch" runat="server" class="btn btn-style-one"  Text="search" OnClick="btnsearch_Click" />
                        </div>
	</fieldset>

            </form>

    <br>        
             
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

