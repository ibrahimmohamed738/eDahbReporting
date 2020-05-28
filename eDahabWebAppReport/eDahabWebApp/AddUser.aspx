<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="eDahabWebApp.AddUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="C1" runat="server">
     <div class="container-fluid">
                    <div class="row">
                        <div class="col-lg-12">
                            <h3 class="page-header">Add New User</h3>
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
                                <asp:TextBox ID="txtUsername" runat="server" class="form-control" ></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="txtPassword">Password:</label>
                                <asp:TextBox ID="txtPassword" runat="server" class="form-control" TextMode="Password" ></asp:TextBox>
                            </div>
                             
                            <asp:Button ID="btnAddUser" runat="server" Text="New User" class="btn btn-sm btn-success" OnClick="btnAddUser_Click"  />
                          </div>
                  
                </div>
                <!-- /.container-fluid -->
</asp:Content>
