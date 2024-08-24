﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegistrarSalida.aspx.cs" Inherits="RegistrarSalida" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registrar Salida</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            color: #333;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }
        .form-container {
            background-color: #fff;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            padding: 20px;
            max-width: 400px;
            width: 100%;
            text-align: center;
        }
        h2 {
            color: #4CAF50;
            margin-bottom: 20px;
        }
        .form-group {
            margin-bottom: 15px;
            text-align: left;
        }
        .form-group label {
            display: block;
            margin-bottom: 5px;
            font-weight: bold;
        }
        .form-group input[type="text"] {
            width: calc(100% - 20px);
            padding: 8px;
            border-radius: 4px;
            border: 1px solid #ccc;
        }
        .form-group input[type="text"]:focus {
            border-color: #4CAF50;
            outline: none;
            box-shadow: 0 0 5px rgba(76, 175, 80, 0.5);
        }
        .form-group button {
            background-color: #4CAF50;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            font-size: 16px;
            width: 100%;
        }
        .form-group button:hover {
            background-color: #45a049;
        }
        .form-group .message {
            margin-top: 15px;
            font-size: 14px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <h2>Registrar Salida de Viajero</h2>
            <div class="form-group">
                <asp:Label ID="lblViajeroID" runat="server" Text="ID del Viajero:"></asp:Label>
                <asp:TextBox ID="txtViajeroID" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblFechaSalida" runat="server" Text="Fecha de Salida: (YYYY-MM-DD)"></asp:Label>
                <asp:TextBox ID="txtFechaSalida" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblLugarSalida" runat="server" Text="Lugar de Salida:"></asp:Label>
                <asp:TextBox ID="txtLugarSalida" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="btnRegistrarSalida" runat="server" Text="Registrar Salida" OnClick="btnRegistrarSalida_Click" />
            </div>
            <asp:Label ID="lblMensaje" runat="server" Text="" ForeColor="Green" CssClass="message"></asp:Label>
        </div>
    </form>
</body>
</html>
