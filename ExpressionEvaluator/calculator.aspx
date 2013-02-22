<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculator.aspx.cs" Inherits="ExpressionEvaluator.calculator" %>

<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Expression Evaluator</title>
    <link rel="stylesheet" href="css/main.css" />
    <link rel="stylesheet" href="css/bootstrap.css" />
</head>
<body>
    <div class="container">
        <form id="evaluationForm" runat="server">

            <div class="evaluationBox row">
                <asp:TextBox ID="evaluationBox" CssClass="span8" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
                <asp:Label ID="lblEqual" CssClass="" runat="server" Text=" = "></asp:Label>
                <asp:Label ID="lblResult" CssClass="result" runat="server" Text=""></asp:Label>
            </div>

            <div class="buttons row">
                <asp:Button ID="submitButton" CssClass="btn span2" runat="server" Text="Submit" OnClick="submitButton_Click" />
                <asp:Button ID="clearButton" CssClass="btn span2" runat="server" Text="Clear" OnClick="clearButton_Click" />
            </div>

            <div class="allVariables">

                <div class="variableRow row">
                    <div class="span4" id="varA">
                        <asp:Label ID="lblA" CssClass="variables offset1" runat="server" Text="a"></asp:Label>
                        <asp:TextBox ID="txtA" CssClass="values span1" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
                    </div><!-- end varA -->
                </div><!-- end varAB -->

                <div class="variableRow row">
                    <div class="span4" id="varB">
                        <asp:Label ID="lblB" CssClass="variables offset1" runat="server" Text="b"></asp:Label>
                        <asp:TextBox ID="txtB" CssClass="values span1" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
                    </div><!-- end varB -->
                </div><!-- end varAB -->

                <div class="variableRow row">
                    <div class="span4" id="varC">
                        <asp:Label ID="lblC" CssClass="variables offset1" runat="server" Text="c"></asp:Label>
                        <asp:TextBox ID="txtC" CssClass="values span1" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
                    </div><!-- end varC -->
                </div><!-- end varCD -->

                <div class="variableRow row">
                    <div class="span4" id="varD">
                        <asp:Label ID="lblD" CssClass="variables offset1" runat="server" Text="d"></asp:Label>
                        <asp:TextBox ID="txtD" CssClass="values span1" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
                    </div><!-- end varD -->
                </div><!-- end varCD -->

                <div class="variableRow row">
                    <div class="span4" id="varE">
                        <asp:Label ID="lblE" CssClass="variables offset1" runat="server" Text="e"></asp:Label>
                        <asp:TextBox ID="txtE" CssClass="values span1" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
                    </div><!-- end varE -->
                </div><!-- end varEF -->

                <div class="variableRow row">
                    <div class="span4" id="varF">
                        <asp:Label ID="lblF" CssClass="variables offset1" runat="server" Text="f"></asp:Label>
                        <asp:TextBox ID="txtF" CssClass="values span1" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
                    </div><!-- end varF -->
                </div><!-- end varEF -->

                <div class="variableRow row">
                    <div class="span4" id="varG">
                        <asp:Label ID="lblG" CssClass="variables offset1" runat="server" Text="g"></asp:Label>
                        <asp:TextBox ID="txtG" CssClass="values span1" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
                    </div><!-- end varG -->
                </div><!-- end varGH -->

                <div class="variableRow row">
                    <div class="span4" id="varH">
                        <asp:Label ID="lblH" CssClass="variables offset1" runat="server" Text="h"></asp:Label>
                        <asp:TextBox ID="txtH" CssClass="values span1" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
                    </div><!-- end varH -->
                </div><!-- end varGH -->

                <div class="variableRow row">
                    <div class="span4" id="varI">
                        <asp:Label ID="lblI" CssClass="variables offset1" runat="server" Text="i"></asp:Label>
                        <asp:TextBox ID="txtI" CssClass="values span1" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
                    </div><!-- end varI -->
                </div><!-- end varIJ -->

                <div class="variableRow row">
                    <div class="span4" id="varJ">
                        <asp:Label ID="lblJ" CssClass="variables offset1" runat="server" Text="j"></asp:Label>
                        <asp:TextBox ID="txtJ" CssClass="values span1" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
                    </div><!-- end varJ -->
                </div><!-- end varIJ -->

            </div><!-- end variables -->
        </form><!-- end form -->
    </div><!-- end container -->

    
    <script src="js/jquery-1.8.2.js"></script>
    <script src="js/main.js"></script>
    
</body>
</html>
