<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table>
			<thead> 
				<tr>
					<th>Nome</th>
					<th>ID</th>
					<th>Link</th>
				</tr>
			</thead>
			<tbody>
				<asp:Repeater runat="server" ID="listRepeater">
					<ItemTemplate>
						<tr>
							<td><%#Eval("Nome") %> </td>
						    <td><%#Eval("Id") %></td>
                            <td><a href="WebForm3.aspx?id=<%#Eval("Id") %>&id2=<%#Eval("Id2") %>">Next Page</a></td>
                        </tr>
					</ItemTemplate>
				</asp:Repeater>
			</tbody>
		</table>

        </div>
        <div>
            <asp:Button Text="Atualizar" ID="btnAtualizar" runat="server" OnClick="btnAtualizar_Click" />
        </div>
       <div>
           <asp:Label Text="" ID="lblMsg" runat="server" />
       </div>
    </form>
</body>
</html>
