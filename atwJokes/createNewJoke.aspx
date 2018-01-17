<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createNewJoke.aspx.cs" Inherits="atwJokes.createNewJoke" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" type="text/css" href="css/agile.import.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="main-content">

            <input type="checkbox" class="alert-exit" id="alertexit1" checked runat="server">
                <div class="alert-container alert-green">
			        <p id="message"><span class="font-strong" runat="server" id="SysMessage">Success!</span> The joke has been created sucessfully!</p>
			        <p id="exit"><label for="alertexit1">X</label></p>
		        </div>

                <input type="checkbox" class="alert-exit-fail" id="alertexit2" checked runat="server">
		        <div class="alert-container-fail alert-red">
			        <p id="messageErr"><span class="font-strong" runat="server" id="SysMessageErr">Uh Oh!</span> Something went wrong!</p>
			        <p id="exitErr"><label for="alertexit2">X</label></p>
                    <p id="SysDetails" runat="server"></p>
		        </div>

            <h1>Create a new joke</h1>
            <a href="index.aspx">Back to home</a>
            <hr />
            <div class="grid-container">
                <div class="grid-row">
                    <div class="grid-col-4-pad">
                        <p class="font-xlarge">Joke Category</p>
                        <asp:DropDownList ID="ddlCat" runat="server" CssClass="DropDownList"></asp:DropDownList>
                    </div>
                    <div class="grid-col-4-pad">
                        <p class="font-xlarge">Joke Title</p>
                        <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                    </div>
                    <div class="grid-col-4-pad">
                        <p class="font-xlarge">User ID</p>
                        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="grid-row">
                    <div class="grid-col-6-pad">
                        <p class="font-xlarge">Joke Text</p>
                        <asp:TextBox ID="txtJokeText" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </div>
                    <div class="grid-col-6-pad">
                        <p class="font-xlarge">Joke Teaser</p>
                        <asp:TextBox ID="txtTeaser" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </div>
                </div>
                <div class="grid-row">
                    <div class="grid-col-12-pad">
                        <asp:CheckBox ID="chkFeatured" runat="server" /><span class="font-large">Is joke featured?</span>
                    </div>
                </div>
            </div>
            <br /><br />
            <asp:Button ID="btnAdd" runat="server" Text="Add new joke" CssClass="button forms-btn-flat fx-btn-click" OnClick="btnAdd_Click"/>
        </div>
    </form>
</body>
</html>
