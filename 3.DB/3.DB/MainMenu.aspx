<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="_3.DB.MainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="CSS/css1.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="CentujacyDiv">
            <div class="KontenerNaWyswietlaneDane">
                <div class="Wiersze">
                    <div class="DystansPoziomy">
                        <asp:Label ID="Label1" runat="server" Text="ID: "></asp:Label>
                    </div>
                    
                    <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
                </div>
                <div class="Wiersze">
                    <div class="DystansPoziomy">
                        <asp:Label ID="Label2" runat="server" Text="Imię pracownika: "></asp:Label>
                    </div>
                    
                    <asp:TextBox ID="TextBox2" runat="server" Enabled="False"></asp:TextBox>
                </div>
                <div class="Wiersze">
                    <div class="DystansPoziomy">
                        <asp:Label ID="Label3" runat="server" Text="Nazwisko pracownika: "></asp:Label>
                    </div>
                    
                    <asp:TextBox ID="TextBox3" runat="server" Enabled="False"></asp:TextBox>
                </div>
                <div class="Wiersze">
                    <div class="DystansPoziomy">
                        <asp:Label ID="Label4" runat="server" Text="Email: "></asp:Label>
                    </div>
                    
                    <asp:TextBox ID="TextBox4" runat="server" Enabled="False"></asp:TextBox>
                </div>
                <div class="Wiersze">
                    <div class="DystansPoziomy">
                        <asp:Label ID="Label5" runat="server" Text="Data urodzenia: "></asp:Label>
                    </div>
                    
                    <asp:TextBox ID="TextBox5" runat="server" Enabled="False"></asp:TextBox>
                </div>
                <div class="Wiersze">
                    <div class="DystansPoziomy">
                        <asp:Button ID="Button1" runat="server" Text="Poprzedni" OnClick="Button1_Click" />
                        <asp:Button ID="Button2" runat="server" Text="Następny" OnClick="Button2_Click" />
                    </div>
                    <asp:Button ID="Button3" runat="server" Text="Nowy" OnClick="Button3_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
