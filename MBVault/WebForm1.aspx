<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MBVault.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Id</td>
                    <td>
                        <asp:TextBox ID ="id" runat="server" OnTextChanged="id_TextChanged">
                        </asp:TextBox>
                    </td>

                    <td>FirstName</td>
                    <td>
                        <asp:TextBox ID ="firstname" runat="server" OnTextChanged="firstname_TextChanged">
                        </asp:TextBox>
                    </td>

                    <td>LastName</td>
                    <td>
                        <asp:TextBox ID ="lastname" runat="server" OnTextChanged="lastname_TextChanged">
                        </asp:TextBox>
                    </td>

                    <td>Region</td>
                    <td>
                        <asp:TextBox ID ="region" runat="server" OnTextChanged="region_TextChanged">
                        </asp:TextBox>
                    </td>

                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="email" runat="server" OnTextChanged="email_TextChanged"></asp:TextBox>
                    </td>

                    <td>Phone</td>
                    <td>
                        <asp:TextBox ID="phone" runat="server" OnTextChanged="phone_TextChanged"></asp:TextBox>
                    </td>

                    <td>Address</td>
                    <td>
                        <asp:TextBox ID="address" runat="server" OnTextChanged="address_TextChanged"></asp:TextBox>
                    </td>

                    <td>CNP</td>
                    <td>
                        <asp:TextBox ID="cnp" runat="server" OnTextChanged="cnp_TextChanged"></asp:TextBox>
                    </td>

                    <td>Postal Code</td>
                    <td>
                        <asp:TextBox ID="postalcode" runat="server" OnTextChanged="postalcode_TextChanged"></asp:TextBox>
                    </td>

                    <td>Idcard Series</td>
                    <td>
                        <asp:TextBox ID="idcard_series" runat="server" OnTextChanged="idcard_series_TextChanged"></asp:TextBox>
                    </td>

                    <td>Idcard Number</td>
                    <td>
                        <asp:TextBox ID="idcard_number" runat="server" OnTextChanged="idcard_number_TextChanged"></asp:TextBox>
                    </td>

                    <td>Birthday Date</td>
                    <td>
                        <asp:TextBox ID="birthday_date" runat="server" OnTextChanged="birthday_date_TextChanged"></asp:TextBox>
                    </td>

                    <td>Sex</td>
                    <td>
                        <asp:TextBox ID="sex" runat="server" OnTextChanged="sex_TextChanged"></asp:TextBox>
                    </td>

                    <td>City</td>
                    <td>
                        <asp:TextBox ID="city" runat="server" OnTextChanged="city_TextChanged" style="height: 25px"></asp:TextBox>
                    </td>

                    <td>County</td>
                    <td>
                        <asp:TextBox ID="county" runat="server" OnTextChanged="county_TextChanged"></asp:TextBox>
                    </td>

                    <td>Country</td>
                    <td>
                        <asp:TextBox ID="country" runat="server" OnTextChanged="country_TextChanged"></asp:TextBox>
                    </td>

                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="password" runat="server" OnTextChanged="password_TextChanged"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td colspan ="2" align ="center">
                        <asp:Button ID="Update" runat="server" Text="Update" OnClick="Update_Click" />
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
