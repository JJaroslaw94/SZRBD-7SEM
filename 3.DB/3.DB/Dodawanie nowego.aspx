<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dodawanie nowego.aspx.cs" Inherits="_3.DB.Dodawanie_nowego" %>

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
                    
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </div>
                <div class="Wiersze">
                    <div class="DystansPoziomy">
                        <asp:Label ID="Label2" runat="server" Text="Imię pracownika: "></asp:Label>
                    </div>
                    
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </div>
                <div class="Wiersze">
                    <div class="DystansPoziomy">
                        <asp:Label ID="Label3" runat="server" Text="Nazwisko pracownika: "></asp:Label>
                    </div>
                    
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </div>
                <div class="Wiersze">
                    <div class="DystansPoziomy">
                        <asp:Label ID="Label4" runat="server" Text="Email: "></asp:Label>
                    </div>
                    
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </div>
                <div class="Wiersze">
                    <div class="DystansPoziomy">
                        <asp:Label ID="Label5" runat="server" Text="Data urodzenia (mm.dd.rrrr): "></asp:Label>
                    </div>
                    
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </div>
                <div class="Wiersze2" runat="server" id="DivUwagi">
                    <div class="DystansPoziomy">
                        <asp:TextBox ID="TextBox6" runat="server" Height="77px" TextMode="MultiLine" Width="485px" ReadOnly="True"></asp:TextBox>
                    </div>
                </div>
                <br />
                <br />
                <br />
                <br />
                <br />
                <div class="Wiersze">
                    <div class="DystansPoziomy">
                        <asp:Button ID="Button1" runat="server" Text="Wstecz" OnClick="Button1_Click" />
                        <asp:Button ID="Button2" runat="server" Text="Dodaj" OnClick="Button2_Click" />
                    </div>
                </div>
            </div>
        </div>
        <div class="custompopup" id="divThankYou" runat="server">
        <p>
            <asp:Label ID="lblmessage" runat="server"></asp:Label>
        </p>
        <asp:Button ID="ButtonPopUp" CssClass="classname leftpadding" runat="server" Text="Ok" OnClick="ButtonPopUp_Click1" />
    </div>
    </form>
</body>
</html>
