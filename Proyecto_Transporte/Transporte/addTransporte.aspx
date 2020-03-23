<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addTransporte.aspx.cs" Inherits="Transporte.addTransporte" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
	<link href="Content/bootstrap.min.css" rel="stylesheet" />
	<script src="Scripts/jquery-3.0.0.min.js"></script>
	<script src="Scripts/bootstrap.min.js"></script>
	<script src="Scripts/popper.min.js"></script>
 </head>
<body>

    <form id="form1" runat="server">
    
 <div class="container my-5">   
      <div class="row">
      
      <div class="col-6">
       <h2>Registro de conductores</h2>
   
       <div class="form-group">
        <label for="">ID:</label>
        <input type="text" class="form-control" id="idConductor" name="" runat="server"/>
       </div>

       <div class="form-group">
        <label for="">Nombre:</label>
        <input type="text" class="form-control" id="nombre" name="" runat="server"/>
       </div>

       <div class="form-group">
        <label for="">Tipo de licencia:</label>
        <input type="text" class="form-control" id="licencia" name="" runat="server"/>
       </div>

       <div class="form-group">
        <label for="">Identificación de vehículo:</label>
        <input type="text" class="form-control" id="idVehiculoConductor" name="" runat="server"/>
       </div>

       <div class="form-group">
        <label for="">Tipo de conductor:</label>
        <input type="text" class="form-control" id="tipo" name="" runat="server"/>
       </div>
        
     <asp:Button class="btn btn-primary" id="enviarcond" runat="server" Text="Enviar" OnClick="enviarcond_Click" />
      
      </div>
    
        
    <div class="col-6">
     
    <h2>Registro de vehículos</h2>      
       <div class="form-group">
        <label for="">Identificación de vehículo:</label>
        <input type="text" class="form-control" id="idVehiculo" name="" runat="server"/>
       </div>

       <div class="form-group">
        <label for="">Marca:</label>
        <input type="text" class="form-control" id="marca" name="" runat="server"/>
       </div>

       <div class="form-group">
        <label for="">Modelo:</label>
        <input type="text" class="form-control" id="modelo" name="" runat="server"/>
       </div>

       <div class="form-group">
        <label for="">Matricula:</label>
        <input type="text" class="form-control" id="matricula" name="" runat="server"/>
       </div>
    
        <asp:Button class="btn btn-primary" id="enviarVehiculo" runat="server" Text="Enviar" OnClick="enviarVehiculo_Click" />
   
   </div>
    </div>      
</div>
</form>
        

</body>
</html>
