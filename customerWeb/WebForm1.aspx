<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="customerWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            width: 58%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 100%;">
            <tr>
                <td>Таблица &quot;Постояльцы&quot;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <table class="auto-style2">
                        <tr>
                            <td class="auto-style1">ФИО постояльца</td>
                            <td class="auto-style1">Паспортные данные</td>
                            <td class="auto-style1">Данные реквизитов</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan ="3" class="auto-style1">
                                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Добавить" Width="91px" />
&nbsp;<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Изменить" Width="91px" />
&nbsp;<asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Удалить" Width="91px" />
                            </td>
                            
                        </tr>
                        
                    </table>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan ="2" class="auto-style1">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="код_постояльца" DataSourceID="SqlDataSource1" EmptyDataText="Нет записей для отображения." OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                            <asp:BoundField DataField="код_постояльца" HeaderText="код_постояльца" ReadOnly="True" SortExpression="код_постояльца" />
                            <asp:BoundField DataField="фио_постояльца" HeaderText="фио_постояльца" SortExpression="фио_постояльца" />
                            <asp:BoundField DataField="паспортные_данные" HeaderText="паспортные_данные" SortExpression="паспортные_данные" />
                            <asp:BoundField DataField="данные_реквизитов" HeaderText="данные_реквизитов" SortExpression="данные_реквизитов" />
                        </Columns>
                        <SelectedRowStyle BackColor="#99CCFF" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Гостиница_DBConnectionString1 %>" DeleteCommand="DELETE FROM [постояльцы] WHERE [код_постояльца] = @код_постояльца" InsertCommand="INSERT INTO [постояльцы] ([фио_постояльца], [паспортные_данные], [данные_реквизитов]) VALUES (@фио_постояльца, @паспортные_данные, @данные_реквизитов)" ProviderName="<%$ ConnectionStrings:Гостиница_DBConnectionString1.ProviderName %>" SelectCommand="SELECT [код_постояльца], [фио_постояльца], [паспортные_данные], [данные_реквизитов] FROM [постояльцы]" UpdateCommand="UPDATE [постояльцы] SET [фио_постояльца] = @фио_постояльца, [паспортные_данные] = @паспортные_данные, [данные_реквизитов] = @данные_реквизитов WHERE [код_постояльца] = @код_постояльца">
                        <DeleteParameters>
                            <asp:Parameter Name="код_постояльца" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="фио_постояльца" Type="String" />
                            <asp:Parameter Name="паспортные_данные" Type="String" />
                            <asp:Parameter Name="данные_реквизитов" Type="String" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="фио_постояльца" Type="String" />
                            <asp:Parameter Name="паспортные_данные" Type="String" />
                            <asp:Parameter Name="данные_реквизитов" Type="String" />
                            <asp:Parameter Name="код_постояльца" Type="Int32" />
                        </UpdateParameters>
                    </asp:SqlDataSource>
                </td>
                <td class="auto-style1"></td>
                               
                
            </tr>
            <tr>
                <td colspan ="3">
                    <asp:Label ID="Label1" runat="server" Text="Статус"></asp:Label>
                </td>
                
                
            </tr>
        </table>
        
    </form>
</body>
</html>
