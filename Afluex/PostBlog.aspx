<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostBlog.aspx.cs" Inherits="Afluex.PostBlog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Post Blog</title>

</head>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css" />

<!-- jQuery library -->
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>

<!-- Latest compiled JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
  
<body>

    <form id="form1" runat="server">
        <asp:ScriptManager ID="scrip" runat="server"></asp:ScriptManager>


        <div class="card">
            <div class="card-body">
                <h1 class="card-title">
                    <center>Post Blog</center>
                </h1>
                <br />
                <asp:UpdatePanel ID="udp" runat="server">
                    <ContentTemplate>
                        <div class="row">
                            <div class="col-md-12">
                                <div class="col-md-6">
                                    Select Category
                    <asp:DropDownList ID="ddlcategory" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlcategory_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                                    <asp:Button ID="btnclear" runat="server" Text="Clear All" CssClass="btn btn-info btn-sm" OnClick="btnclear_Click"/>
                                </div>
                                <div class="col-md-6">
                                    Selected Category
                    <asp:TextBox ID="ddlcategorname" runat="server" ForeColor="Blue" Enabled="false" CssClass="form-control"></asp:TextBox>
                                    <asp:Label ID="ddlcategoryid" runat="server" Visible="false"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <div class="row">
                    <div class="col-md-12">
                        <div class="col-md-12">
                            Title
                    <asp:TextBox ID="txttitle" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>

                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <div class="col-md-12">
                            Short Description
                     <div id="txtshortdecription" class="click2edit"></div>

                        </div>
                       <asp:TextBox ID="hdnshortdescription" runat="server" CssClass="hidden"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <div class="col-md-12">
                            Description
                     <div id="txtdescription" class="click2edit"></div>

                        </div>
                         <asp:TextBox ID="hdndescription" runat="server" CssClass="hidden" ></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <div class="col-md-6">
                            Upload Multiple File
                        <asp:FileUpload ID="flpimages" runat="server" AllowMultiple="true" />

                        </div>
                          <div class="col-md-6">
                        <asp:GridView ID="gredimages" runat="server" OnRowDeleting="gredimages_RowDeleting" AutoGenerateColumns="False" EmptyDataText="No Record Found"
                            CssClass="display nowrap table table-hover table-striped table-bordered dataTable no-footer" Width="100%">
                            <Columns>
                                <asp:TemplateField HeaderText="S.No." HeaderStyle-CssClass="orange">
                                    <ItemTemplate>
                                        <%# Container.DataItemIndex + 1 %>
                                        <asp:Label ID="Pk_BlogImagesId" runat="server" Visible="false" Text='<%# Bind("Pk_BlogImagesId") %>'></asp:Label>
                                    </ItemTemplate>

                                    <HeaderStyle CssClass="orange"></HeaderStyle>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Blog Image" HeaderStyle-CssClass="orange">
                                    <ItemTemplate>
                                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Images") %>' Height="80px" Width="100px" />
                                    </ItemTemplate>

                                    <HeaderStyle CssClass="orange"></HeaderStyle>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Action" HeaderStyle-CssClass="orange">
                                    <ItemTemplate>
                                        <asp:ImageButton ID="imgDelete" CommandName="Delete" OnClientClick="return confirm('Do you want to delete this Image ?') " runat="server" ImageUrl="~/images/delete.png" Height="18" Width="18" />
                                    </ItemTemplate>
                                    <HeaderStyle CssClass="orange"></HeaderStyle>
                                </asp:TemplateField>
                            </Columns>

                        </asp:GridView>
                    </div>
                        </div>
                </div>
                <div class="col-md-12">
                    <div class="col-md-6">
                            <br />
                            <asp:Button ID="btnpost" runat="server" Text="Post Blog" CssClass="btn btn-primary" OnClick="btnpost_Click" OnClientClick="return falidate();" />
                          <asp:Button ID="btnUpdate" runat="server" Text="Update Blog" OnClick="btnUpdate_Click" CssClass="btn btn-primary" OnClientClick="return falidate();" Visible="false" />
                            <asp:HiddenField ID="shortdecription" runat="server" />
                            <asp:HiddenField ID="description" runat="server" />
                        </div>
                </div>
            </div>
        </div>


    </form>
</body>
</html>
<script src="https://cdnjs.cloudflare.com/ajax/libs/summernote/0.8.12/summernote.js" defer></script>
<link href="https://cdnjs.cloudflare.com/ajax/libs/summernote/0.8.12/summernote.css" rel="stylesheet" />

<script>

    $(document).ready(function () {
       
        $("#divload").css({ 'display': 'none' });
        $('#txtdescription').summernote(
        {
            height: 150,
            toolbar: [
              // [groupName, [list of button]]
              ['style', ['bold', 'italic', 'underline', 'clear']],
              ['font', ['strikethrough', 'superscript', 'subscript']],
              ['fontsize', ['fontsize']],
              ['para', ['ul', 'ol', 'paragraph']],
              ['insert', ['link', 'video']],
              ['height', ['height']]
            ]
        });
        $('#txtshortdecription').summernote(
       {
           height: 150,
           toolbar: [
             // [groupName, [list of button]]
             ['style', ['bold', 'italic', 'underline', 'clear']],
             ['font', ['strikethrough', 'superscript', 'subscript']],
             ['fontsize', ['fontsize']],
             ['para', ['ul', 'ol', 'paragraph']],
             ['insert', ['link', 'video']],
             ['height', ['height']]
           ]
       });
        if (document.getElementById("<%=hdnshortdescription.ClientID%>").value != "" )
        {
          shortdecription=(document.getElementById("<%=hdnshortdescription.ClientID%>").value);
        $('#txtshortdecription').summernote('code', shortdecription);
        }
        else {

        }
        if (document.getElementById("<%=hdndescription.ClientID%>").value != "" )
        {
          decription=(document.getElementById("<%=hdndescription.ClientID%>").value);
            $('#txtdescription').summernote('code', decription);
        }
        else {

        }
    });
    function falidate()
    {
      

        if (document.getElementById("<%=ddlcategorname.ClientID%>").value == "") {
            document.getElementById("<%=ddlcategory.ClientID%>").style.borderColor = "Red";
            document.getElementById("<%=ddlcategory.ClientID%>").focus();
            return false;
        }
        if (document.getElementById("<%=txttitle.ClientID%>").value == "") {
            document.getElementById("<%=txttitle.ClientID%>").style.borderColor = "Red";
            document.getElementById("<%=txttitle.ClientID%>").focus();
            return false;
        }
       
         var description = $('#txtdescription').summernote('code');
        var shortdecription = $('#txtshortdecription').summernote('code');
        document.getElementById("<%=shortdecription.ClientID%>").value = shortdecription;
        document.getElementById("<%=description.ClientID%>").value = description;
       
    }
</script>

