﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sample.aspx.cs" Inherits="LocalizationTest.Sample" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:Button ID="Button1" runat="server" meta:resourcekey="Button1Resource1" 
        Text="English Button" />
    <p>
        <asp:Label ID="Label1" runat="server" meta:resourcekey="Label1Resource1" 
            Text="English Label"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server" meta:resourcekey="TextBox1Resource1">English TextBox</asp:TextBox>
    </p>
    </form>
</body>
</html>
