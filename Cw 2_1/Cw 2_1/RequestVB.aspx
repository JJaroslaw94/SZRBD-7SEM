<%@ Page Language="VB" Trace="false" %>
<script runat ="server">
    Sub Page_Load(Src As Object, E As EventArgs)

        Dim strCheckBox1 As String
        If Not Page.IsPostBack Then
            'budujemy Liste
            DropDownList1.Items.Add("")
            DropDownList1.Items.Add("Kobieta")
            DropDownList1.Items.Add("Meczyzna")
        Else
            If CheckBox1.Checked Then
                strCheckBox1 = "married"
            Else
                strCheckBox1 = "single"

            End If
            Label5.Text = "Hello, " & TextBox1.Text & ". You are a " & TextBox2.Text & " year old, " & strCheckBox1 & " " & DropDownList1.SelectedItem.Text & "."
        End If


    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs)

        Session("imie") = TextBox1.Text
        Session("age") = TextBox2.Text
        Session("marry") = CheckBox1.Checked
        Session("gen") = DropDownList1.SelectedItem.Text

        Response.Redirect("~/Logowanie.aspx")
    End Sub
</script>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="CSS/css1.css" rel="stylesheet" />
    <title>ASP Forms</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="CentrowanieDIV">
            <div class="Content">
                <asp:ValidationSummary ID="validSummary" runat="server"
                HeaderText="***Errors on your Form***"
                showSummary ="true"
                DisplayMode ="List" />
            </div>
            
            <div class="Content">
                <div class="ElementyWLini">
                    <div class="ElementyOddzielanie">
                        <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
                    </div>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqFN" runat="server"
                        ControlToValidate="TextBox1"
                        ErrorMessage ="you must provide your name"
                        display="None" />
                </div>
                <div class="ElementyWLini">
                    <div class="ElementyOddzielanie">
                        <asp:Label ID="Label2" runat="server" Text="Age"></asp:Label>
                    </div>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqAge" runat="server"
                        ControlToValidate="TextBox2"
                        type ="Integer"
                        minimumValue ="1"
                        maximumValue ="150"
                        ErrorMessage ="you must provide your age (1-150)"
                        display="None" />
                </div>
                <div class="ElementyWLini">
                    <div class="ElementyOddzielanie">
                        <asp:Label ID="Label3" runat="server" Text="Married?"></asp:Label>
                    </div>
                    <asp:CheckBox ID="CheckBox1" runat="server" EnableTheming="True" />
                </div>
                <div class="ElementyWLini">
                    <div class="ElementyOddzielanie">
                        <asp:Label ID="Label4" runat="server" Text="Sex"></asp:Label>
                    </div>
                    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                    <asp:RequiredFieldValidator ID="ReqS" runat="server"
                        ControlToValidate="DropDownList1"
                        ErrorMessage ="you must choose gender"
                        display="None" />
                </div>
                <div class="ElementyWLini">
                    <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" />
                    <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                    
                </div>
            </div>
        </div>
    </form>
</body>
</html>
