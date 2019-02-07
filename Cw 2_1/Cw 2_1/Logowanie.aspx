<%@ Page Language="VB" Trace="false" %>
<script runat ="server">

    Protected Sub Page_Load(sender As Object, e As EventArgs)
        Dim marry As String

        If Session("marry") = True Then
            marry = "married"
        Else
            marry = "single"
        End If

        Label1.Text = "Hello, " & Session("imie") & ". You are a " & Session("age") & " year old, " & marry & " " & Session("gen") & "."
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs)
        If TextBox1.Text = "admin" Then
            TextBox1.Text = "zalogowano!"
            Label2.Text = "zalogowano!"
        Else
            TextBox1.Text = "Błędne hasło"
            Label2.Text = "Hint: admin"
        End If
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs)
        If Label3.Visible = True Then
            Label3.Visible = False
        Else
            Label3.Visible = True
            Label3.Font.Name = "Verdana"
            Label3.Font.Size = FontUnit.Large
            Label3.ForeColor = System.Drawing.Color.Magenta
        End If
    End Sub

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short

    Protected Sub TextBox2_TextChanged(sender As Object, e As EventArgs)
        If (GetAsyncKeyState(13)) Or (GetAsyncKeyState(9)) Then
            Label6.Text = TextBox2.Text + "  " + TextBox3.Text
        End If
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs)
        If Image1.Visible = True Then
            Image1.Visible = False
        Else
            Image1.Visible = True
            Image1.ForeColor = System.Drawing.Color.Magenta
        End If
    End Sub

</script>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="CSS/css1.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="CentrowanieDIV">
            <div class="Content">
                <div  class="ElementyWLini">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </div>
                <div  class="ElementyWLini">
                    <div class ="ElementyOddzielanie">
                        <asp:Label ID="Label2" runat="server" Text="Podaj hasło do konta:"></asp:Label>
                    </div>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </div>
                <div class="Separator1"></div>

                <div  class="ElementyWLini">
                    <div class ="ElementyOddzielanie">
                        <asp:Button ID="Button1" runat="server" Text="Zaloguj" OnClick="Button1_Click" />
                    </div>
                </div>
                <div class="Separator1"></div>

                <div  class="ElementyWLini">
                    <div class ="ElementyOddzielanie">
                        <asp:Button ID="Button2" runat="server" Text="Visible = true" OnClick="Button2_Click" />
                    </div>
                    <asp:Label ID="Label3" runat="server" Text="Ukryty Text" Visible="false"></asp:Label>
                </div>
                <div class="Separator1"></div>

                <div  class="ElementyWLini">
                    <div class ="ElementyOddzielanie">
                        <asp:Label ID="Label4" runat="server" Text="Login:" ></asp:Label>
                    </div>
                    <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" AutoPostBack="True" CausesValidation="True"></asp:TextBox>
                </div>

                <div  class="ElementyWLini">
                    <div class ="ElementyOddzielanie">
                        <asp:Label ID="Label5" runat="server" Text="Haslp:"></asp:Label>
                    </div>
                    <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox2_TextChanged" AutoPostBack="True" CausesValidation="True"></asp:TextBox>
                </div>

                <div  class="ElementyWLini">
                    <div class ="ElementyOddzielanie">
                        <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
                    </div>
                    
                </div>
                <div class="Separator1"></div>

                <div  class="ElementyWLini">
                    <div class ="ElementyOddzielanie">
                        <asp:Button ID="Button3" runat="server" Text="Visible!" OnClick="Button3_Click" />
                    </div>
                    <asp:Image ID="Image1" runat="server" Height="50px" ImageUrl="~/IMG/10.png" Visible="false"/>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
