<%@ Page Title="" Language="C#" MasterPageFile="~/aspNetBootstrap.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="aspNetBootstrapDemo.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <div class="col-lg-11" runat="server">
        <form runat="server">
            <asp:GridView ID="gv3" CssClass="table" runat="server" BackColor="#CCCCCC"  AllowPaging="True" AllowSorting="True" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <br />
            <asp:Button ID="btnPosebno" class="btn" runat="server" Text="Pregled po igraču" OnClick="btnPosebno_Click" />
            <asp:DropDownList ID="ddlPlayers" CssClass="dropdown" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPlayers_SelectedIndexChanged" ViewStateMode="Enabled"></asp:DropDownList>
            <br />
            <asp:GridView ID="GridView2" CssClass="table" runat="server" AllowPaging="true" AllowSorting="true"></asp:GridView>
            
        </form>
    </div>
    <div class="col-lg-1">
        
    </div>

</asp:Content>
