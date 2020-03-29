<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gestionTipoConductorVehiculo.aspx.cs" Inherits="Transporte.gestionTipoConductorVehiculo" %>

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
       
            <h2>Tipo de conductores</h2>
            
            <br />
            <asp:Label ID="lblMensajeTipoConductor" runat="server" ForeColor="Blue" EnableViewState="false"></asp:Label>
            <br />

           <div class="form-group">
            <label for="">Identificación del conductor:</label>
            <input type="text" class="form-control" id="idTipoConductor" name="" runat="server"/>
          
           </div>

           <div class="form-group">
            <label for="">Nombre del conductor:</label>
            <input type="text" class="form-control" id="nombreTipoConductor" name="" runat="server"/>
           </div>
             <asp:Button class="btn btn-primary" id="insertarTipoConductor" runat="server" Text="Insertar" OnClick="InsertarTipoConductor_Click"/>
             <asp:Button class="btn btn-primary" id="actualizarTipoConductor" runat="server" Text="Actualizar"/>
             <asp:Button class="btn btn-primary" id="listarTipoConductor" runat="server" Text="Listar" OnClick="ListarTipoConductor_Click"/>
             <asp:Button class="btn btn-primary" id="eliminarTipoConductor" runat="server" Text="Eliminar"/>

            <br />
            <br />
            <br />
         
       <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="false">

            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id conductor"/>
                <asp:BoundField DataField="nombre" HeaderText="Nombre conductor" />
            </Columns>
       </asp:GridView>
    
   

       </div>

     <div class="col-6">
     
        <h2>Tipo de vehiculo</h2>  
          
           <br />
            <asp:Label ID="lblMensajeTipoVehiculo" runat="server" ForeColor="Blue" EnableViewState="false"></asp:Label>
            <br />

           <div class="form-group">
            <label for="">Identificación del vehículo:</label>
            <input type="text" class="form-control" id="idTipoVehiculo" name="" runat="server"/>
           </div>

           <div class="form-group">
            <label for="">Descripción del vehículo:</label>
            <input type="text" class="form-control" id="nombreTipoVehiculo" name="" runat="server"/>
           </div>
            
                 <asp:Button class="btn btn-primary" id="insertarTipoVehiculo" runat="server" Text="Insertar" OnClick="InsertarTipoVehiculo_Click"/>
                 <asp:Button class="btn btn-primary" id="actualizarTipoVehiculo" runat="server" Text="Actualizar"/>
                 <asp:Button class="btn btn-primary" id="listarTipoVehiculo" runat="server" Text="Listar" OnClick="ListarTipoVehiculo_Click"/>
                 <asp:Button class="btn btn-primary" id="eliminarTipoVehiculo" runat="server" Text="Eliminar"/>

          <br />
          <br />
          <br />
         
       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">

            <Columns>
                <asp:BoundField DataField="id_vehiculo" HeaderText="Id vehículo"/>
                <asp:BoundField DataField="nombre" HeaderText="Descripción vehículo" />
            </Columns>
       </asp:GridView>
    
    </div>
  </div>
</div>

</form>
</body>
</html>
