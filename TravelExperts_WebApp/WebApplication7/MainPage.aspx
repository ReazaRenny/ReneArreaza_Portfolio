<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="WebApplication7.MainPage" %>
<%--Author:Rene
Created: January 2017
Assignment: Workshop 2

    
 
--%>
<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width" />
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
    <script src="~/Scripts/jquery-2.1.4.min.js"></script>
    <script src="~/Scripts/bootstrap.min.js"></script>
</head>
<body>
    <%--<form id="form1" runat="server">
    </form>--%>
    <nav class="navbar navbar-default" style="position:fixed; width:100%">
        <div class="container-fluid">
            <div class="navbar-header">
                <a class="navbar-brand">Travel Experts</a>              
            </div>
            <ul class="nav navbar-nav">
                <%= NavBarState() %>
                <%--<li class="active"><a href="MainPage.aspx">Home</a></li>
                <li><a href="PackageHistory.aspx">Package History</a></li>
                <li><a href="UpdateInfo.aspx">Update Info</a></li>
                <li><a href="Register.aspx">Register</a></li>                
                <li><a href="Login.aspx">Login</a></li> --%>       
            </ul>
        </div>
    </nav>
    
  <%--  <div class="container">
      <div id="myCarousel" class="carousel slide" data-ride="carousel">
        <!-- Indicators -->
        <ol class="carousel-indicators">
          <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
          <li data-target="#myCarousel" data-slide-to="1"></li>
          <li data-target="#myCarousel" data-slide-to="2"></li>
        </ol>   

        <!-- Wrapper for slides -->
        <div class="carousel-inner">

          <div class="item active">
            <img src="Images/losA.jpg" alt="Los Angeles" style="width:100%;">
            <div class="carousel-caption">
              <h3>Los Angeles</h3>
              <p>LA is always so much fun!</p>
            </div>
          </div>

          <div class="item">
            <img src="Images/Chicago.jpg" alt="Chicago" style="width:100%;">
            <div class="carousel-caption">
              <h3>Chicago</h3>
              <p>Thank you, Chicago!</p>
            </div>
          </div>
    
          <div class="item">
            <img src="Images/NY.jpg" alt="New York" style="width:100%;">
            <div class="carousel-caption">
              <h3>New York</h3>
              <p>We love the Big Apple!</p>
            </div>
          </div>  
        </div>

        <!-- Left and right controls -->
        <a class="left carousel-control" href="#myCarousel" data-slide="prev">
          <span class="glyphicon glyphicon-chevron-left"></span>
          <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#myCarousel" data-slide="next">
          <span class="glyphicon glyphicon-chevron-right"></span>
          <span class="sr-only">Next</span>
        </a>
      </div>
    </div>--%>
    
    <div class="container" style="padding-top:7%">
        <div class="jumbotron">
          <h1 class="display-3">Welcome to Travel Experts!</h1>
          <p class="lead">Using this online portal, your customers can sign up to your database,
               update their information and view their purchase history. All of these features
               are done in a simple, easy to follow flow of information!

          </p>
          <hr class="my-4"/>
          <p>To showcase your website, we will register a new account, log in, update and view packages.</p>
          <p class="lead">
        
          </p>
        </div>
    </div>

    <div class="container" style="padding-bottom:10%">
        <div class="row">
            <div class="col-md-4">
                <div class="card">
                  <img class="card-img-top cardImg" src="Images/beach_dock_palmtree.jpeg" alt="beach_dock_palmtree" style="height:180px; width:318px;"/>
                  <div class="card-block">
                    <h4 class="card-title">Carribbean </h4>
                    <p class="card-text">Enjoy relaxing beaches, warm ocean breezes, and swim up bars.</p><br />
                    <a href="#" class="btn btn-primary">Explore</a>
                  </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="card">
                  <img class="card-img-top cardImg" src="Images/castle_germany.jpeg" alt="castle_in_germany" style="height:180px; width:318px;"/>
                  <div class="card-block">
                    <h4 class="card-title">Europe</h4>
                    <p class="card-text">Emmerse yourself in rich history through, and visit the biergartens of Munich, vineyards in Alsace, and the Neuschwanstein Castle in Austria.</p>
                    <a href="#" class="btn btn-primary">Explore</a>
                  </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="card">
                  <img class="card-img-top cardImg" src="Images/mountain_winter.jpeg" alt="mountain_in_the_winter" style="height:180px; width:318px;"/>
                  <div class="card-block">
                    <h4 class="card-title">The Great Canadian Rockies</h4>
                    <p class="card-text">Explore the magic of your own backyard: hike a mountain, explore caves, and relax in Lake Louise!</p><br />
                    <a href="#" class="btn btn-primary">Explore</a>
                  </div>
                </div>
            </div>
        </div>
        </div>

    <footer class="footer navbar-fixed-bottom container-fluid bg-4 modal-footer" style="background-color:white">
        <div class="container">
            <p>&copy; 2018 Travel Experts <a href="MainPage.aspx">Make a booking now!</a></p> 
        </div>
    </footer>

    </body>
</html>
