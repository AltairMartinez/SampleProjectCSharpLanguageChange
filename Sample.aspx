
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
        <asp:TextBox ID="TextBox1" runat="server" meta:resourcekey="TextBox1Resource1" Text="English TextBox"></asp:TextBox>
    </p>
        <asp:Button ID="Button2" runat="server" Text="En" meta:resourcekey="Button2Resource1" OnClick="Button2_Click" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="De" meta:resourcekey="Button3Resource1" OnClick="Button3_Click" />
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Fr" />
    </form>
</body>
</html>
