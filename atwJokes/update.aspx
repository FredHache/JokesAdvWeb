<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="atwJokes.update" %>

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
			        <p id="message"><span class="font-strong" runat="server" id="SysMessage">Success!</span> The joke has been modified sucessfully!</p>
			        <p id="exit"><label for="alertexit1">X</label></p>
		        </div>

                <input type="checkbox" class="alert-exit-fail" id="alertexit2" checked runat="server">
		        <div class="alert-container-fail alert-red">
			        <p id="messageErr"><span class="font-strong" runat="server" id="SysMessageErr">Uh Oh!</span> Something went wrong!</p>
			        <p id="exitErr"><label for="alertexit2">X</label></p>
                    <p id="SysDetails" runat="server"></p>
		        </div>

            <h1>Update Joke</h1>
            <a href="index.aspx">Back to home</a>
            <hr />

            <asp:HiddenField ID="hdnID" runat="server" Value='<%#Eval("id") %>'/>
            <asp:HiddenField ID="hdnCreatedAt" runat="server" Value='<%#Eval("created_at") %>'/>
            <asp:HiddenField ID="hdnUID" runat="server" Value='<%#Eval("user_id") %>'/>
            <div class="grid-container">
                <div class="grid-row">
                    <div class="grid-col-6-pad">
                        <h3>Joke Title</h3>
                        <asp:TextBox ID="txtJokeTitle" runat="server" ></asp:TextBox>
                    </div>
                    <div class="grid-col-6-pad">
                        <h3>Category</h3>
                        <asp:DropDownList ID="ddlCat" runat="server" CssClass="DropDownList"></asp:DropDownList>
                    </div>
                </div>
                <div class="grid-row">
                    <div class="grid-col-12-pad">
                        <h3>Joke Teaser</h3>
                        <asp:TextBox ID="txtTeaser" runat="server" TextMode="MultiLine"></asp:TextBox>
                        <br />
                        <h3>Joke text</h3>
                        <asp:TextBox ID="txtJoke" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </div>
                </div>
                <div class="grid-row">
                    <div class="grid-col-12-pad">
                        <asp:CheckBox ID="chkFeatured" runat="server" /><span>Is joke featured?</span>
                    </div>
                </div>
            </div>
            <hr />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="button forms-btn-flat fx-btn-click" OnClick="btnUpdate_Click"/>
        </div>
    </form>
</body>
</html>
