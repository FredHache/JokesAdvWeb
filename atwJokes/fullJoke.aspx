<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fullJoke.aspx.cs" Inherits="atwJokes.fullJoke" %>

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
            <h1>Full joke details</h1>
            <a href="index.aspx">Back to home</a>
            <hr />
            <p class="font-xlarge jokeTitle" runat="server" id="JokeTitle"><%#Eval("title") %></p>
            <span class="a-meta" runat="server" id="ID">Joke ID: <%#Eval("id") %></span>
            <span class="a-meta" runat="server" id="CreatedAt">Created at: <%#Eval("created_at") %></span>
            <span class="a-meta" runat="server" id="UID">User ID: <%#Eval("user_id") %></span>
            <span class="a-meta" runat="server" id="CatID">Category ID: <%#Eval("category_id") %></span>
            <span class="a-meta" runat="server" id="Feat">featured: <%#Eval("featured") %></span>
            <p runat="server" id="Teaser">Teaser: <%#Eval("teaser") %></p>
            <p runat="server" id="JokeText">Joke: <%#Eval("joke_text")%></p>
        </div>
    </form>
</body>
</html>
