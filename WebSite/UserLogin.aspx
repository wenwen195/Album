<%@ Page Language="C#" MasterPageFile="~/UserMasterPage.master" AutoEventWireup="true" CodeFile="UserLogin.aspx.cs" Inherits="Default2" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>Default</title>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="mid">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <table style="width:100%; height: 450px"
                    cellpadding="0" cellspacing="0">
                    <tr>
                        <td align="center">
                            <asp:DataList ID="dlPictrue" runat="server" RepeatColumns="3"
                                RepeatDirection="Horizontal" OnItemCommand="dlPictrue_ItemCommand"
                                OnItemDataBound="dlPictrue_ItemDataBound" DataKeyField="ID">
                                <ItemTemplate>

                                    <table style="margin-left:5px;margin-right:5px;" >
                                        <tr>
                                            <td style="text-align:center;" >
                                                <a href='Play_Photo.aspx?CategoryID=<%#Eval("ID") %>&CategoryName=<%#Eval("C_Name") %>'>
                                                    <img alt='<%#Eval("C_Name") %>' src='UpSmall/<%#Eval("url") %>' style="height: 200px; width: 258px;"/></a> 
                                                <br />
                                                 <a href='Play_Photo.aspx?CategoryID=<%#Eval("ID") %>&CategoryName=<%#Eval("C_Name") %>' style="font-size: 12px; color: #302D37; text-decoration: none;">Album Name:<%#                Eval("C_Name").ToString().Length > 5
                    ? Eval("C_Name").ToString().Substring(0, 5) + "..."
                    : Eval("C_Name") %>(totally <%#Eval("p_num") %> photos)</a>                                                              

                                            </td>
                                        </tr>                                        
                                    </table>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <table id="Page" cellpadding="0" cellspacing="0">
                                        <tr>
                                            <td>
                                                <asp:Label ID="labCurrentPage" runat="server"></asp:Label>
                                                /
                                                                      <asp:Label ID="labPageCount" runat="server"></asp:Label>
                                                <asp:LinkButton ID="lnkbtnFirst" runat="server" CommandName="first"
                                                    Font-Underline="False" ForeColor="Black" CausesValidation="False">Home</asp:LinkButton>
                                                <asp:LinkButton ID="lnkbtnFront" runat="server" CommandName="pre"
                                                    Font-Underline="False" ForeColor="Black" CausesValidation="False">Last</asp:LinkButton>
                                                <asp:LinkButton ID="lnkbtnNext" runat="server" CommandName="next"
                                                    Font-Underline="False" ForeColor="Black" CausesValidation="False">Next</asp:LinkButton>
                                                <asp:LinkButton ID="lnkbtnLast" runat="server" CommandName="last"
                                                    Font-Underline="False" ForeColor="Black" CausesValidation="False">Final</asp:LinkButton>
                                                &nbsp;&nbsp; Jump To<asp:TextBox ID="txtPage" runat="server" Height="21px" Width="35px" CssClass="watermark"></asp:TextBox>
                                                <asp:Button ID="Button1" runat="server" CommandName="search" Height="21px"
                                                    Text="GO" Width="46px" CausesValidation="False" />
                                                <br />
                                            </td>
                                        </tr>
                                    </table>
                                </FooterTemplate>
                            </asp:DataList>
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="imgBtnLogin" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
    </div>
</asp:Content>
