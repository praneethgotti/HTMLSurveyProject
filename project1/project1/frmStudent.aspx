<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmStudent.aspx.cs" Inherits="project1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            margin-top: 43px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="z-index: 1; left: 1px; top: 371px; position: absolute; height: 27px; width: 963px">
            <asp:Label ID="lblStudentID" runat="server" Text="Label"></asp:Label>
        </div>
        <asp:Label ID="lblName" runat="server" Text="Label" style="z-index: 1; left: 10px; top: 77px; position: absolute"></asp:Label>
        <p>
        <asp:Label ID="lblTeacherScore" runat="server" Text="Label" style="z-index: 1; left: 6px; top: 155px; position: absolute; margin-top: 0px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblCourseScore" runat="server" Text="Label" style="z-index: 1; left: 7px; top: 192px; position: absolute"></asp:Label>
        </p>
        <asp:Label ID="lblProfessorGrade" runat="server" Text="Label" style="z-index: 1; left: 8px; top: 250px; position: absolute; bottom: 281px;"></asp:Label>
        <p style="z-index: 1; left: 4px; top: 281px; position: absolute; height: 19px; width: 354px">
            <asp:Label ID="lblCourseGrade" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
