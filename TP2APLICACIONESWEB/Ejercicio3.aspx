<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3.aspx.cs" Inherits="TP2APLICACIONESWEB.Ejercicio3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp; 
            &nbsp;&nbsp;<asp:LinkButton ID="lnkColor1" runat="server" OnClick="lnkColor1_Click">Rojo</asp:LinkButton>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="lnkColor2" runat="server" OnClick="lnkColor2_Click">Azul</asp:LinkButton>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="lnkColor3" runat="server" OnClick="lnkColor3_Click">Verde</asp:LinkButton>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtColor" runat="server" BorderStyle="None"></asp:TextBox>
        </div>
    </form>
</body>
</html>
