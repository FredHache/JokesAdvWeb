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
            <a href="createNewJoke.aspx" class="font-center">Create a new joke</a>
            <div class="grid-container">
                <div class="grid-row">
                    <div class="grid-col-3-pad">
                        <p>Joke Categories</p>
                        <asp:DropDownList ID="ddlCategories" runat="server" AppendDataBoundItems="true" AutoPostBack="true" CssClass="DropDownList" OnSelectedIndexChanged="ddlCategories_SelectedIndexChanged">
               <asp:ListItem>--Select a Category--</asp:ListItem>
           </asp:DropDownList>
                    </div>
                    <div class="grid-col-9-pad">
                        <asp:Repeater ID="rptJokesByCat" runat="server">
                            <ItemTemplate>
                                <p class="font-xlarge jokeTitle"><%#Eval("title") %></p>
                                <span class="a-meta">Joke ID: <%#Eval("id") %></span>
                                <span class="a-meta">Created at: <%#Eval("created_at") %></span>
                                <span class="a-meta">User ID: <%#Eval("user_id") %></span>
                                <span class="a-meta">Category ID: <%#Eval("category_id") %></span>
                                <span class="a-meta">featured: <%#Eval("featured") %></span>
                                <p><%#Eval("teaser") %></p>
                                <span><a href="fullJoke.aspx?jid=<%#Eval("id") %>">See full joke</a> | <a href="update.aspx?jid=<%#Eval("id") %>">Update joke</a></span>
                                <br />
                                <br />
                                <br />
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <footer class="footer">
        <p>Jokes DB N-Tier app by Fred Hache, Nathan Noye, Nick Toogood. &copy; 2017</p>
        <span><a href="createNewJoke.aspx">Create a new joke</a></span>
    </footer>
</body>
</html>
