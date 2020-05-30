<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="eDahabWebApp.UserProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="C1" runat="server">
      <div class="container-fluid">
                    <div class="row">
                        <div class="col-lg-12">
                            <h3 class="page-header">User Profile</h3>
                        </div>
                        <!-- /.col-lg-12 -->
                    </div>
                    <!-- /.row -->
                   
                                
                        <div class="col-lg-6">
                              <div>
                                <asp:Label ID="lblErrorMessage" runat="server" Text="" ForeColor="Red" ></asp:Label>
				                <asp:Label ID="lblSuccessMessage" runat="server" Text="" ForeColor="Green"></asp:Label>
                            </div>
                            <div class="form-group">
                                <label for="txtUsername">Username:</label>
                                <asp:TextBox ID="txtUsername" runat="server" class="form-control" ReadOnly="True"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="txtPassword">Password:</label>
                                <asp:TextBox ID="txtPassword" runat="server" class="form-control" TextMode="Password" ></asp:TextBox>
                            </div>
                             
                            <asp:Button ID="btnEditUser" runat="server" Text="Edit User" class="btn btn-sm btn-success" OnClick="btnEditUser_Click" />
                          </div>
                  
                </div>
                <!-- /.container-fluid -->
</asp:Content>
