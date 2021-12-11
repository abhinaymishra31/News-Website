<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="about us.aspx.cs" Inherits="about_us" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <!-- Navigation -->
   <%-- <nav class="navbar navbar-inverse navbar-fixed-top" role="navigation">
        <div class="container">
            <!-- Brand and toggle get grouped for better mobile display -->
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="#">Start Bootstrap</a>
            </div>
            <!-- Collect the nav links, forms, and other content for toggling -->
            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                <ul class="nav navbar-nav">
                    <li>
                        <a href="#">About</a>
                    </li>
                    <li>
                        <a href="#">Services</a>
                    </li>
                    <li>
                        <a href="#">Contact</a>
                    </li>
                </ul>
            </div>
            <!-- /.navbar-collapse -->
        </div>
        <!-- /.container -->
    </nav>--%>

    <!-- Page Content -->
    <div class="container">

        <!-- Introduction Row -->
        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">About Us
                    <small>It's Nice to Meet You!</small>
                </h1>
                <p>THE INDIAN NEWS , started in 2017 as a weekly, became a daily in 2017 and from then on has been steadily growing to the circulation of 15,58,379 copies (ABC: July-December 2012) and a readership of about 22.58 lakhs.
The Hindu's independent editorial stand and its reliable and balanced presentation of the news have over the years, won for it the serious attention and regard of the people who matter in India and abroad.
The Hindu uses modern facilities for news gathering, page composition and printing. It is printed in seventeen centres including the Main Edition at Chennai (Madras) where the Corporate Office is based. The printing centres at Coimbatore, Bangalore, Hyderabad, Madurai, Noida, Visakhapatnam, Thiruvanathapuram, Kochi, Vijayawada, Mangalore, Tiruchirapalli, Kolkata, Hubli, Mohali, Allahabad and Kozhikode are connected with high speed data lines for news transmission across the country.</p>
            </div>
        </div>

        <!-- Team Members Row -->
        <div class="row">
            <div class="col-lg-12">
                <h2 class="page-header">Our Team</h2>
            </div>
            <div class="col-lg-12 col-sm-6 text-center">
                <img class="img-circle img-responsive img-center" src="images/abhinay.jpg" alt="abhinay kumar mishra" style="height:300px;width:300px;"/>
                <h2>Abhinay kumar Mishra
                    <small>TEAM LEADER</small>
                </h2>
                <p>His role on this project! 
                Maintaining the database and Asp.net</p>
            </div>
            <div class="col-lg-4 col-sm-6 text-center">
                <img class="img-circle img-responsive img-center" src="images/divy.jpg" alt="Divyansh Srivastava" width="304" height="236"/>
                <h3>Divyansh Srivastava
                    <small>TEAM MEMBER</small>
                </h3>
                <p>His role on this project! 
                Maintaining the database And Asp.net</p>
            </div>
            <div class="col-lg-4 col-sm-6 text-center">
                <img class="img-circle img-responsive img-center" src="images/kri.jpg"  alt="Krishna Kumar" width="304" height="236"/>
                <h3>Krishna Kumar
                    <small>TEAM MEMBER</small>
                </h3>
                <p>His role on this project! 
                Maintaining the design of the website</p>
            </div>
            <div class="col-lg-4 col-sm-6 text-center">
                <img class="img-circle img-responsive img-center" src="images/farhan.JPG" alt="Farhan Khan" width="304" height="236"/>
                <h3>Farhan
                    <small>TEAM MEMBER</small>
                </h3>
                <p>His role on this project! 
                Maintaining the database 
                </p>
            </div>
           
        </div>

        <hr/>

    </div>
   <style>
     .img-center{
    margin: 0 auto;
}
       </style>
</asp:Content>

