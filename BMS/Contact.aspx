<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact"  MaintainScrollPositionOnPostback="true"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
<!--Page Title-->
<section class="page-title text-center" style="background-image:url(images/background/3.jpg);">
    <div class="container">
        <div class="title-text">
            <h1>Contact</h1>
            <ul class="title-menu clearfix">
                <li>
                    <a href="default.aspx">home</a>
                </li>
                <li>Contact</li>
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
                            <h3>Location</h3>
                            <p>PO Box 16122 Collins Street West
                                <br>Victoria 8007 Canada</p>
                        </div>
                    </div>
                    <!-- Phone -->
                    <div class="media">
                        <i class="fa fa-phone"></i>
                        <div class="media-body">
                            <h3>Phone</h3>
                            <p>
                                (+48) 564-334-21-22-34
                                <br>(+48) 564-334-21-22-38
                            </p>
                        </div>
                    </div>
                    <!-- Email -->
                    <div class="media">
                        <i class="fa fa-envelope-o"></i>
                        <div class="media-body">
                            <h3>Email</h3>
                            <p>
                                info@templatepath.com
                                <br>info@cleanxer.com
                            </p>
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
                            <label for="contact-name">Name
                                        <span>*</span>
                            </label>
                            <input type="text" name="name" class="form-control main"  required>
                        </div>
                        
                        <div class="col-md-6">
                            <label for="contact-name">E-Mail
                                        <span>*</span>
                            </label>
                            <input type="email" class="form-control main">
                        </div>
                        <!-- phone -->
                        <div class="col-md-6">
                            <label for="contact-name">Phone
                                        <span>*</span>
                            </label>
                            <input type="text" class="form-control main" required>
                        </div>
                        <!-- message -->
                        <div class="col-md-12">
                            <label for="contact-name">Message
                                        <span>*</span>
                            </label>
                            <textarea name="message" rows="5" class="form-control main" "></textarea>
                        </div>

                        <div class="col-md-12">
                            <asp:Label ID="lblmsg" runat="server" />
                        </div>
                        <!-- submit button -->
                        <div class="col-md-12 text-right">
                            <button class="btn btn-style-one" type="submit">Send Message</button>
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


</asp:Content>

