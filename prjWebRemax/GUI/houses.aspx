<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="houses.aspx.cs" Inherits="prjWebRemax.GUI.houses" %>

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
        body {
            background-color: #becbff;
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

        <%--Filter Section--%>
        <section>
            <table class="w-100 table-design">
                <tr>
                    <td class="text-center" style="border-right:solid">
                        <asp:Label ID="lblType" runat="server" Text="Type of Residence"></asp:Label>
                    </td>
                    <td class="text-center" style="border-right:solid">
                        <asp:Label ID="lblLocation" runat="server" Text="Location"></asp:Label>
                    </td>
                    <td class="text-center" style="border-right:solid">
                        <asp:Label ID="lblCity" runat="server" Text="Price"></asp:Label>
                    </td>
                    <td class="text-center">
                        <asp:Label ID="lblNumberRooms" runat="server" Text="Number of Rooms"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="text-center" style="border-right:solid">
                        <asp:DropDownList ID="cboTypeOfResidence" runat="server" Width="181px" AutoPostBack="True" OnSelectedIndexChanged="cboTypeOfResidence_SelectedIndexChanged"></asp:DropDownList>
                    </td>
                    <td class="text-center" style="border-right:solid">
                        <asp:DropDownList ID="cboLocation" runat="server" Width="181px" AutoPostBack="True" OnSelectedIndexChanged="cboLocation_SelectedIndexChanged"></asp:DropDownList>
                    </td>
                    <td class="text-center" style="border-right:solid">
                        <asp:DropDownList ID="cboPrice" runat="server" Width="181px" AutoPostBack="True" OnSelectedIndexChanged="cboPrice_SelectedIndexChanged" >
                            <asp:ListItem>0</asp:ListItem>
                            <asp:ListItem>10000</asp:ListItem>
                            <asp:ListItem>20000</asp:ListItem>
                            <asp:ListItem>30000</asp:ListItem>
                            <asp:ListItem>50000</asp:ListItem>
                            <asp:ListItem>100000</asp:ListItem>
                            <asp:ListItem>200000</asp:ListItem>
                            <asp:ListItem>300000</asp:ListItem>
                            <asp:ListItem>500000</asp:ListItem>
                            <asp:ListItem>600000</asp:ListItem>
                            <asp:ListItem>70000</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="text-center">
                        <asp:DropDownList ID="cboNumberOfRooms" runat="server" Width="181px" AutoPostBack="True" OnSelectedIndexChanged="cboNumberOfRooms_SelectedIndexChanged">
                            <asp:ListItem>0</asp:ListItem>
                            <asp:ListItem>1 1/2</asp:ListItem>
                            <asp:ListItem>2 1/2</asp:ListItem>
                            <asp:ListItem>3 1/2</asp:ListItem>
                            <asp:ListItem>4 1/2</asp:ListItem>
                            <asp:ListItem>5 1/2</asp:ListItem>
                            <asp:ListItem>6 1/2</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="text-center" rowspan="2">

                        <asp:Button ID="btnSearch" runat="server" Text="Search" Width="139px" OnClick="btnSearch_Click"/>

                    </td>
                </tr>
            </table>
        </section>

        <%--Search section --%>
        <table class="w-100">
            <tr>
                <td style="width: 10%;">&nbsp;</td>
                <td style="width: 85%;">
        <asp:Literal ID="litHouses" runat="server"></asp:Literal>
                </td>
                <td style="width: 5%;">&nbsp;</td>
            </tr>
        </table>
      <footer>
        <p class="footer-description">© 2019 Carlos Goncalves.</p>
    </footer>
    </form>
</body>
</html>