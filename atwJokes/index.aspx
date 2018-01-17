<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="atwJokes.index" %>

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
            <h1 class="font-center">N-Tier Jokes</h1>
            <h2 class="font-center">By team Fred, Nate, and Nick</h2>
            <div class="grid-container">
                <div class="grid-row">
                    <div class="grid-col-3-pad">
                        <p>Joke Categories</p>
                        <asp:DropDownList ID="ddlCategories" runat="server" CssClass="DropDownList">
                        </asp:DropDownList>
                    </div>
                    <div class="grid-col-9-pad">
                        <p class="font-xlarge jokeTitle">Joke Title</p>
                        <span class="a-meta">Joke ID: </span>
                        <span class="a-meta">Created at: </span>
                        <span class="a-meta">User ID: </span>
                        <span class="a-meta">Category ID: </span>
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam consectetur libero sed dolor eleifend, eu euismod nulla tempus. Nulla varius rhoncus nunc quis ullamcorper. Aliquam quis enim dictum libero volutpat rutrum vitae id nisi. Nullam a risus in sem aliquam maximus vel non nulla. Phasellus at tempor ipsum. Suspendisse sit ame....</p>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
