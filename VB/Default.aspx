<%@ Page Language="VB" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>
<%@ Register assembly="DevExpress.Web.ASPxRichEdit.v17.1, Version=17.1.17.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    namespace="DevExpress.Web.ASPxRichEdit" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v17.1, Version=17.1.17.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>How to create a custom save button in ASPxRichEdit with automatic enabling/disabling</title>
    <script src="JavaScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxRichEdit ID="RichEdit" ClientInstanceName="richEdit" WorkDirectory="~\App_Data\WorkDirectory" runat="server">
            <ClientSideEvents EndCallback="onEndCallback" DocumentChanged="onDocumentChanged"
                CustomCommandExecuted="onCustomCommandExecuted" />
        </dx:ASPxRichEdit>
    </form>
</body>
</html>
