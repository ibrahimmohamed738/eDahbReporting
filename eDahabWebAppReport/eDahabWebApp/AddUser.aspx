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
                              <div class="alert alert-danger" runat="server" id="ErrorMsg">
                                <asp:Label ID="lblErrorMessage" runat="server" Text=""></asp:Label>
                              </div>
                             <div class="alert alert-success" runat="server" id="SuccessMsg">
				                <asp:Label ID="lblSuccessMessage" runat="server" Text=""></asp:Label>
                            </div>
                            <div class="form-group">
                                <label for="txtUsername">Username:</label>
                                <asp:TextBox ID="txtUsername" runat="server" class="form-control" placeholder="Username"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="txtPassword">Password:</label>
                                <asp:TextBox ID="txtPassword" runat="server" class="form-control" TextMode="Password" placeholder="Password" ></asp:TextBox>
                            </div>
                             
                            <asp:Button ID="btnAddUser" runat="server" Text="New User" class="btn btn-sm btn-success" OnClick="btnAddUser_Click"  />
                          </div>
                  
                </div>
                <!-- /.container-fluid -->
</asp:Content>
