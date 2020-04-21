<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gestionContratoRuta.aspx.cs" Inherits="Transporte.gestionContratoRuta" %>

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
       
            <h2>Contratos</h2>
            
            <br />
            <asp:Label ID="lblMensajeContrato" runat="server" ForeColor="Blue" EnableViewState="false"></asp:Label>
            <br />

           <div class="form-group">
            <label for="">Identificación del contrato:</label>
            <input type="text" class="form-control" id="idContrato" name="" runat="server"/>
          
           </div>

          <div class="form-group">
        <label for="">Matricula del vehículo:</label>
        <asp:DropDownList id="conductorContrato" runat="server" CssClass="form-control"> </asp:DropDownList>
       </div>

             <div class="form-group">
        <label for="">Nombre del vehículo:</label>
        <asp:DropDownList id="vehiculoContrato" runat="server" CssClass="form-control"> </asp:DropDownList>
       </div>


             <asp:Button class="btn btn-primary" id="insertarContrato" runat="server" Text="Insertar"/>
             <asp:Button class="btn btn-primary" id="actualizarContrato" runat="server" Text="Actualizar"/>
             <asp:Button class="btn btn-primary" id="listarContrato" runat="server" Text="Listar"/>
             <asp:Button class="btn btn-primary" id="eliminarContrato" runat="server" Text="Eliminar"/>

            <br />
            <br />
            <br />
         
       <asp:GridView ID="GridViewContrato" runat="server" AutoGenerateColumns="false">

            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Identificación del contrato"/>
                <asp:BoundField DataField="id_conductor" HeaderText="Identificación del conductor" />
                <asp:BoundField DataField="id_vehiculo" HeaderText="Identificación del vehículo" />
            </Columns>
       </asp:GridView>
    
   

       </div>

     <div class="col-6">
     
        <h2>Rutas</h2>  
          
           <br />
            <asp:Label ID="lblMensajeRuta" runat="server" ForeColor="Blue" EnableViewState="false"></asp:Label>
            <br />

           <div class="form-group">
            <label for="">Identificación de la ruta:</label>
            <input type="text" class="form-control" id="idRuta" name="" runat="server"/>
           </div>

           <div class="form-group">
            <label for="">Descripción de la estación:</label>
            <input type="text" class="form-control" id="estacion" name="" runat="server"/>
           </div>

          <div class="form-group">
        <label for="">Nombre del vehículo:</label>
        <asp:DropDownList id="vehiculoRuta" runat="server" CssClass="form-control"> </asp:DropDownList>
       </div>
            
                 <asp:Button class="btn btn-primary" id="insertarTipoVehiculo" runat="server" Text="Insertar"/>
                 <asp:Button class="btn btn-primary" id="actualizarTipoVehiculo" runat="server" Text="Actualizar"/>
                 <asp:Button class="btn btn-primary" id="listarTipoVehiculo" runat="server" Text="Listar"/>
                 <asp:Button class="btn btn-primary" id="eliminarTipoVehiculo" runat="server" Text="Eliminar"/>

          <br />
          <br />
          <br />
         
       <asp:GridView ID="GridViewRuta" runat="server" AutoGenerateColumns="false">

            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Identificación de la ruta"/>
                <asp:BoundField DataField="estacion" HeaderText="Estación" />
                <asp:BoundField DataField="id_vehiculo" HeaderText="Identificación del vehículo" />
            </Columns>
       </asp:GridView>
    
    </div>
  </div>
</div>
        
    </form>
</body>
</html>
