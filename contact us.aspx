<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="contact us.aspx.cs" Inherits="Default6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    
    
    <div class="jumbotron jumbotron-sm">
    <div class="container">
        <div class="row">
            <div class="col-sm-12 col-lg-12">
                <h1 class="h1">
                    Contact us <small> 24*7 Available</small></h1>
            </div>
        </div>
    </div>
</div>
<div class="container">
    <div class="row">
        <div class="col-md-9">
            <div class="well well-sm">
                <form>
                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <label for="name">
                                Name</label>
                            <input type="text" class="form-control" id="name" placeholder="Enter name" />
                        </div>
                        <div class="form-group">
                            <label for="email">
                                Email Address</label>
                            <div class="input-group">
                                <span class="input-group-addon"><span class="glyphicon glyphicon-envelope"></span>
                                </span>
                                <input type="email" class="form-control" id="email" placeholder="Enter email"/></div>
                        </div>
                        <div class="form-group">
                            <label for="subject">
                                Subject</label>
                            <select id="subject" name="subject" class="form-control">
                                <option value="na" selected="">Choose One:</option>
                                <option value="service">News Related</option>
                                <option value="suggestions">Suggestions</option>
                                <option value="product"> Support</option>
                            </select>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <label for="name">
                                Message</label>
                            <textarea name="message" id="message" class="form-control" rows="9" cols="25" placeholder="Message"></textarea>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <button type="submit" class="btn btn-primary pull-right" id="btnContactUs">
                            Send Message</button>
                      
                    </div>
                </div>
                </form>
            </div>
        </div>
        <div class="col-md-3">
            <form>
                 <fieldset>
            <legend ><span class="glyphicon glyphicon-globe"></span> Our office</legend>
            <address>
                <strong>UNIVERSITY OF ALLAHABAD</strong><br/>
                INSTITUE OF PROFESSIONAL STUDIES<br/>
                KATRA ALLAHABAD<br/>
                <abbr title="Phone">
                    PHONE:</abbr>
                (123) 456-7890
            </address>
            <address>
                <strong>Full Name</strong><br/>
                <a href="mailto:#">@newshelpdesk.@gmail.com</a>
            </address>
                     </fieldset>
            </form>
        </div>
    </div>
</div>
    <style>
.jumbotron {
background: #358CCE;
color: #FFF;
border-radius: 0px;
}
.jumbotron-sm
     { padding-top: 24px;
padding-bottom: 24px; }
.jumbotron small {
color: #FFF;
}
.h1 small {
font-size: 24px;
}
        </style>
</asp:Content>

