<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Página Principal</title>
    <style>
        body { font-family: Arial, sans-serif; }
        #menuHorizontal { 
            background-color: #000080; 
            overflow: hidden; 
            padding: 10px;
        }
        #menuHorizontal a {
            float: left;
            display: block; 
            color: white; 
            text-decoration: none;
            padding: 14px 16px; 
            text-align: center;
        }
        #menuHorizontal a:hover {
            background-color: #ddd;
            color: black;
        }
        .contenido {
            padding: 20px;
        }
    </style>
</head>
<body>
    <div id="menuHorizontal">
        <a href="RegistrarViajero.aspx">Registrar Viajero</a>
        <a href="RegistrarEntrada.aspx">Registrar Entrada</a>
        <a href="RegistrarSalida.aspx">Registrar Salida</a>
        <a href="CrearUsuario.aspx">Crear Usuario</a>
    </div>

    <div class="contenido">
        <h1>Bienvenido al Sistema de Gestión de Viajeros</h1>
        <img src="Images/viajeros.png" alt="Imagen de Bienvenida" />
    </div>
</body>
</html>
