<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TicketBookingForm.aspx.cs" Inherits="U4_W3_D2.TicketBookingForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Prenotazione biglietti</title>
    <link href="Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Prenota il tuo biglietto</h1>
            <asp:Label ID="lblUsername" runat="server" Text=""></asp:Label><br />
            <asp:DropDownList ID="ddlSala" runat="server">
                <asp:ListItem Text="SALA NORD" Value="SALA NORD" />
                <asp:ListItem Text="SALA EST" Value="SALA EST" />
                <asp:ListItem Text="SALA SUD" Value="SALA SUD" />
            </asp:DropDownList><br />
            <asp:DropDownList ID="ddlTipoBiglietto" runat="server">
                <asp:ListItem Text="Intero" Value="Intero" />
                <asp:ListItem Text="Ridotto" Value="Ridotto" />
            </asp:DropDownList><br />
            <asp:Button ID="btnPrenota" runat="server" Text="Prenota" OnClick="btnPrenota_Click" /><br />
            <h2>Statistiche Vendite</h2>
            <asp:Label ID="lblSalaNord" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="lblSalaEst" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="lblSalaSud" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="lblRidotto" runat="server" Text=""></asp:Label><br />
        </div>
    </form>
</body>
</html>
