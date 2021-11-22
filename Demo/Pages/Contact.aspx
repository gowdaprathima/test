<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Demo.Contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h1><asp:Label ID="lblInformation" Text ="Please Enter Details below" runat ="server"/></h1><br />
        </div>
        <div>
            <asp:Label ID="lblFirstName" Text ="FirstName" runat ="server"/>           
            <asp:textbox ID="txtFirstName" runat ="server"></asp:textbox >
            <asp:RequiredFieldValidator runat ="server" ID="valFirstname" Text ="*" ErrorMessage ="Please Enter your First Name" 
                ControlToValidate="txtFirstName" ></asp:RequiredFieldValidator><br />            

            <asp:Label ID="lblLastName" Text ="LastName" runat ="server"/>
            <asp:textbox ID="txtLastName" runat ="server"></asp:textbox>
            <asp:RequiredFieldValidator runat ="server" ID="ValLastname" Text ="*" ErrorMessage ="Please Enter your Last Name" 
                ControlToValidate="txtLastName" ></asp:RequiredFieldValidator><br />

            <asp:Label ID="lblDOB" Text ="Date Of Birth" runat ="server" />
            <asp:textbox ID="txtDOB" runat ="server" ReadOnly="false" TextMode ="Date"></asp:textbox>
            <asp:RequiredFieldValidator runat ="server" ID="ValCalendar" Text ="*" ErrorMessage ="Please select your DOB from Calendar" 
                ControlToValidate="txtLastName" ></asp:RequiredFieldValidator><br />
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" ></asp:Calendar><br />
            <asp:Label runat ="server" Text ="" ID="lblResult" ForeColor ="Red"/><br />

            <asp:Button ID="btnSubmit" runat ="server" Text ="Submit" OnClick="btnSubmit_Click"/><br />

            <asp:ValidationSummary runat ="server" ID="ValSummary"  DisplayMode ="BulletList"  ShowSummary ="true"
                HeaderText="You must enter a value in the following fields:"
                              Font-Names="verdana" 
                              Font-Size="12"/>
            
        </div>
        
    </form>
</body>
</html>
