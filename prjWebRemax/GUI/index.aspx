<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="prjWebRemax.GUI.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Real State Remax Website</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />
    <link href="https://fonts.googleapis.com/css?family=Montserrat" rel="stylesheet" />
    <link href="../styles/style.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-top-left-radius: calc(.25rem - 1px);
            border-top-right-radius: calc(.25rem - 1px);
            height: 190px;
        }
        .auto-style2 {
            width: 100%;
            border-top-left-radius: calc(.25rem - 1px);
            border-top-right-radius: calc(.25rem - 1px);
            height: 190px;
        }
        .auto-style3 {
            width: 100%;
            border-top-left-radius: calc(.25rem - 1px);
            border-top-right-radius: calc(.25rem - 1px);
            height: 257px;
        }    
    </style>
</head>
<body>
    <form runat="server">
    <header>
        <nav class="navbar navbar-expand-lg light">
            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav mr-auto">
                     <li class="nav-item active">
                        <a class="navbar-brand" href="index.aspx" style="padding-left: 80px"><img src="../images/REMAX_masterLogo@1x.png" width="150px" height="26px" class="d-inline-block align-top" alt=""/></a>
                    </li>
                    <li class="nav-item active">
                        <a class="nav-link" href="index.aspx"><strong>Home</strong> <span class="sr-only">(current)</span></a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="houses.aspx"><strong>Search Houses</strong></a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="agents.aspx"><strong>Search Agents</strong></a>
                    </li>
                    <li class="nav-item">
                            <a class="nav-link" href="message.aspx"><strong>Contact Agents</strong></a>
                    </li>
                </ul>
            </div>
        </nav>
    </header>

    <%--first banner--%>
    <section class="banner">
        <div class="bd-example">
          <div id="carouselExampleCaptions" class="carousel slide" data-ride="carousel">
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img src="../images/slide2.5.jpg"class="d-block w-100" alt="..." style="filter: brightness(50%)"/>
                    <div class="carousel-caption d-none d-md-block txt-position">
                        <h1>Find your dream home.</h1>
                        <p style="font-size: 18px">Contact an agent now and take your first step towards a new home</p>
                        <asp:Button ID="btnSearchHouse2" runat="server" Text="Find Houses" class="btn btn-color btn-size" />
                    </div>
              </div>              
          </div>
        </div>
       </div>
    </section>
    <footer>
          <p class="footer-description">© 2019 Carlos Goncalves.</p>
    </footer>
    </form>
</body>
</html>
