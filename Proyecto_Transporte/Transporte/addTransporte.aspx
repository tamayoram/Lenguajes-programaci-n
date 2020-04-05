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
     <div class="row float-right">
                  <a href="Index.html"><span class="badge badge-success">Volver al inicio</span></a>
     </div>

      <div class="row">
      
      <div class="col-6">
       <h2>Registro de conductores</h2>

           <br />
            <asp:Label ID="lblMensajeConductor" runat="server" ForeColor="Blue" EnableViewState="false"></asp:Label>
            <br />
   
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
     <asp:Button class="btn btn-primary" id="actualizarConductor" runat="server" Text="Actualizar" OnClick="actualizarConductor_Click"/>
     <asp:Button class="btn btn-primary" id="listarConductor" runat="server" Text="Listar" OnClick="listarConductor_Click"/>
     <asp:Button class="btn btn-primary" id="eliminarConductor" runat="server" Text="Eliminar" OnClick="eliminarConductor_Click"/> 

           <br />
            <br />
         
       <asp:GridView ID="GridViewConductor" runat="server" AutoGenerateColumns="false">

            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Identificación"/>
                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="tipo_licencia" HeaderText="Tipo de licencia" />
                </Columns>
       </asp:GridView>


      </div>
    
        
    <div class="col-6">
     
    <h2>Registro de vehículos</h2> 
        
        <br />
            <asp:Label ID="lblMensajeVehiculo" runat="server" ForeColor="Blue" EnableViewState="false"></asp:Label>
            <br />

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
        <asp:Button class="btn btn-primary" id="actualizarVehiculo" runat="server" Text="Actualizar"/>
        <asp:Button class="btn btn-primary" id="listarVehiculo" runat="server" Text="Listar"/>
        <asp:Button class="btn btn-primary" id="eliminarVehiculo" runat="server" Text="Eliminar"/> 

            <br />
            <br />
         
       <asp:GridView ID="GridViewVehiculo" runat="server" AutoGenerateColumns="false">

            <Columns>
                <asp:BoundField DataField="id_vehiculo" HeaderText="Id vehículo"/>
                <asp:BoundField DataField="marca" HeaderText="Marca" />
                <asp:BoundField DataField="modelo" HeaderText="Modelo" />
                <asp:BoundField DataField="matricula" HeaderText="Matricula" />
            </Columns>
       </asp:GridView>

   </div>
    </div>      
</div>
</form>
    
    

</body>
</html>
