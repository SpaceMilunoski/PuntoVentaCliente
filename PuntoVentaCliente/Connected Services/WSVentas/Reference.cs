﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PuntoVentaCliente.WSVentas {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://microsoft.com/webservices/", ConfigurationName="WSVentas.WSVentasSoap")]
    public interface WSVentasSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento ConsultarVentasResult del espacio de nombres http://microsoft.com/webservices/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/ConsultarVentas", ReplyAction="*")]
        PuntoVentaCliente.WSVentas.ConsultarVentasResponse ConsultarVentas(PuntoVentaCliente.WSVentas.ConsultarVentasRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/ConsultarVentas", ReplyAction="*")]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSVentas.ConsultarVentasResponse> ConsultarVentasAsync(PuntoVentaCliente.WSVentas.ConsultarVentasRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento json del espacio de nombres http://microsoft.com/webservices/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/InsertarVentaGeneral", ReplyAction="*")]
        PuntoVentaCliente.WSVentas.InsertarVentaGeneralResponse InsertarVentaGeneral(PuntoVentaCliente.WSVentas.InsertarVentaGeneralRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/InsertarVentaGeneral", ReplyAction="*")]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSVentas.InsertarVentaGeneralResponse> InsertarVentaGeneralAsync(PuntoVentaCliente.WSVentas.InsertarVentaGeneralRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento json del espacio de nombres http://microsoft.com/webservices/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/InsertarVentaDetalles", ReplyAction="*")]
        PuntoVentaCliente.WSVentas.InsertarVentaDetallesResponse InsertarVentaDetalles(PuntoVentaCliente.WSVentas.InsertarVentaDetallesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/InsertarVentaDetalles", ReplyAction="*")]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSVentas.InsertarVentaDetallesResponse> InsertarVentaDetallesAsync(PuntoVentaCliente.WSVentas.InsertarVentaDetallesRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento empleado del espacio de nombres http://microsoft.com/webservices/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/BuscarVentas", ReplyAction="*")]
        PuntoVentaCliente.WSVentas.BuscarVentasResponse BuscarVentas(PuntoVentaCliente.WSVentas.BuscarVentasRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/BuscarVentas", ReplyAction="*")]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSVentas.BuscarVentasResponse> BuscarVentasAsync(PuntoVentaCliente.WSVentas.BuscarVentasRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento DetallesVentaResult del espacio de nombres http://microsoft.com/webservices/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/DetallesVenta", ReplyAction="*")]
        PuntoVentaCliente.WSVentas.DetallesVentaResponse DetallesVenta(PuntoVentaCliente.WSVentas.DetallesVentaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/DetallesVenta", ReplyAction="*")]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSVentas.DetallesVentaResponse> DetallesVentaAsync(PuntoVentaCliente.WSVentas.DetallesVentaRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento busqueda del espacio de nombres http://microsoft.com/webservices/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/BuscarProductoParaVenta", ReplyAction="*")]
        PuntoVentaCliente.WSVentas.BuscarProductoParaVentaResponse BuscarProductoParaVenta(PuntoVentaCliente.WSVentas.BuscarProductoParaVentaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/BuscarProductoParaVenta", ReplyAction="*")]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSVentas.BuscarProductoParaVentaResponse> BuscarProductoParaVentaAsync(PuntoVentaCliente.WSVentas.BuscarProductoParaVentaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultarVentasRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConsultarVentas", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSVentas.ConsultarVentasRequestBody Body;
        
        public ConsultarVentasRequest() {
        }
        
        public ConsultarVentasRequest(PuntoVentaCliente.WSVentas.ConsultarVentasRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ConsultarVentasRequestBody {
        
        public ConsultarVentasRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultarVentasResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConsultarVentasResponse", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSVentas.ConsultarVentasResponseBody Body;
        
        public ConsultarVentasResponse() {
        }
        
        public ConsultarVentasResponse(PuntoVentaCliente.WSVentas.ConsultarVentasResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class ConsultarVentasResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ConsultarVentasResult;
        
        public ConsultarVentasResponseBody() {
        }
        
        public ConsultarVentasResponseBody(string ConsultarVentasResult) {
            this.ConsultarVentasResult = ConsultarVentasResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarVentaGeneralRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarVentaGeneral", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSVentas.InsertarVentaGeneralRequestBody Body;
        
        public InsertarVentaGeneralRequest() {
        }
        
        public InsertarVentaGeneralRequest(PuntoVentaCliente.WSVentas.InsertarVentaGeneralRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class InsertarVentaGeneralRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string json;
        
        public InsertarVentaGeneralRequestBody() {
        }
        
        public InsertarVentaGeneralRequestBody(string json) {
            this.json = json;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarVentaGeneralResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarVentaGeneralResponse", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSVentas.InsertarVentaGeneralResponseBody Body;
        
        public InsertarVentaGeneralResponse() {
        }
        
        public InsertarVentaGeneralResponse(PuntoVentaCliente.WSVentas.InsertarVentaGeneralResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class InsertarVentaGeneralResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool InsertarVentaGeneralResult;
        
        public InsertarVentaGeneralResponseBody() {
        }
        
        public InsertarVentaGeneralResponseBody(bool InsertarVentaGeneralResult) {
            this.InsertarVentaGeneralResult = InsertarVentaGeneralResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarVentaDetallesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarVentaDetalles", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSVentas.InsertarVentaDetallesRequestBody Body;
        
        public InsertarVentaDetallesRequest() {
        }
        
        public InsertarVentaDetallesRequest(PuntoVentaCliente.WSVentas.InsertarVentaDetallesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class InsertarVentaDetallesRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string json;
        
        public InsertarVentaDetallesRequestBody() {
        }
        
        public InsertarVentaDetallesRequestBody(string json) {
            this.json = json;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarVentaDetallesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarVentaDetallesResponse", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSVentas.InsertarVentaDetallesResponseBody Body;
        
        public InsertarVentaDetallesResponse() {
        }
        
        public InsertarVentaDetallesResponse(PuntoVentaCliente.WSVentas.InsertarVentaDetallesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class InsertarVentaDetallesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool InsertarVentaDetallesResult;
        
        public InsertarVentaDetallesResponseBody() {
        }
        
        public InsertarVentaDetallesResponseBody(bool InsertarVentaDetallesResult) {
            this.InsertarVentaDetallesResult = InsertarVentaDetallesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarVentasRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarVentas", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSVentas.BuscarVentasRequestBody Body;
        
        public BuscarVentasRequest() {
        }
        
        public BuscarVentasRequest(PuntoVentaCliente.WSVentas.BuscarVentasRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class BuscarVentasRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string empleado;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string fechaInicio;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string fechaFinal;
        
        public BuscarVentasRequestBody() {
        }
        
        public BuscarVentasRequestBody(string empleado, string fechaInicio, string fechaFinal) {
            this.empleado = empleado;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarVentasResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarVentasResponse", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSVentas.BuscarVentasResponseBody Body;
        
        public BuscarVentasResponse() {
        }
        
        public BuscarVentasResponse(PuntoVentaCliente.WSVentas.BuscarVentasResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class BuscarVentasResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string BuscarVentasResult;
        
        public BuscarVentasResponseBody() {
        }
        
        public BuscarVentasResponseBody(string BuscarVentasResult) {
            this.BuscarVentasResult = BuscarVentasResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DetallesVentaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DetallesVenta", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSVentas.DetallesVentaRequestBody Body;
        
        public DetallesVentaRequest() {
        }
        
        public DetallesVentaRequest(PuntoVentaCliente.WSVentas.DetallesVentaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class DetallesVentaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public DetallesVentaRequestBody() {
        }
        
        public DetallesVentaRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DetallesVentaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DetallesVentaResponse", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSVentas.DetallesVentaResponseBody Body;
        
        public DetallesVentaResponse() {
        }
        
        public DetallesVentaResponse(PuntoVentaCliente.WSVentas.DetallesVentaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class DetallesVentaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string DetallesVentaResult;
        
        public DetallesVentaResponseBody() {
        }
        
        public DetallesVentaResponseBody(string DetallesVentaResult) {
            this.DetallesVentaResult = DetallesVentaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarProductoParaVentaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarProductoParaVenta", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSVentas.BuscarProductoParaVentaRequestBody Body;
        
        public BuscarProductoParaVentaRequest() {
        }
        
        public BuscarProductoParaVentaRequest(PuntoVentaCliente.WSVentas.BuscarProductoParaVentaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class BuscarProductoParaVentaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string busqueda;
        
        public BuscarProductoParaVentaRequestBody() {
        }
        
        public BuscarProductoParaVentaRequestBody(string busqueda) {
            this.busqueda = busqueda;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarProductoParaVentaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarProductoParaVentaResponse", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSVentas.BuscarProductoParaVentaResponseBody Body;
        
        public BuscarProductoParaVentaResponse() {
        }
        
        public BuscarProductoParaVentaResponse(PuntoVentaCliente.WSVentas.BuscarProductoParaVentaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class BuscarProductoParaVentaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string BuscarProductoParaVentaResult;
        
        public BuscarProductoParaVentaResponseBody() {
        }
        
        public BuscarProductoParaVentaResponseBody(string BuscarProductoParaVentaResult) {
            this.BuscarProductoParaVentaResult = BuscarProductoParaVentaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSVentasSoapChannel : PuntoVentaCliente.WSVentas.WSVentasSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSVentasSoapClient : System.ServiceModel.ClientBase<PuntoVentaCliente.WSVentas.WSVentasSoap>, PuntoVentaCliente.WSVentas.WSVentasSoap {
        
        public WSVentasSoapClient() {
        }
        
        public WSVentasSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSVentasSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSVentasSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSVentasSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PuntoVentaCliente.WSVentas.ConsultarVentasResponse PuntoVentaCliente.WSVentas.WSVentasSoap.ConsultarVentas(PuntoVentaCliente.WSVentas.ConsultarVentasRequest request) {
            return base.Channel.ConsultarVentas(request);
        }
        
        public string ConsultarVentas() {
            PuntoVentaCliente.WSVentas.ConsultarVentasRequest inValue = new PuntoVentaCliente.WSVentas.ConsultarVentasRequest();
            inValue.Body = new PuntoVentaCliente.WSVentas.ConsultarVentasRequestBody();
            PuntoVentaCliente.WSVentas.ConsultarVentasResponse retVal = ((PuntoVentaCliente.WSVentas.WSVentasSoap)(this)).ConsultarVentas(inValue);
            return retVal.Body.ConsultarVentasResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSVentas.ConsultarVentasResponse> PuntoVentaCliente.WSVentas.WSVentasSoap.ConsultarVentasAsync(PuntoVentaCliente.WSVentas.ConsultarVentasRequest request) {
            return base.Channel.ConsultarVentasAsync(request);
        }
        
        public System.Threading.Tasks.Task<PuntoVentaCliente.WSVentas.ConsultarVentasResponse> ConsultarVentasAsync() {
            PuntoVentaCliente.WSVentas.ConsultarVentasRequest inValue = new PuntoVentaCliente.WSVentas.ConsultarVentasRequest();
            inValue.Body = new PuntoVentaCliente.WSVentas.ConsultarVentasRequestBody();
            return ((PuntoVentaCliente.WSVentas.WSVentasSoap)(this)).ConsultarVentasAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PuntoVentaCliente.WSVentas.InsertarVentaGeneralResponse PuntoVentaCliente.WSVentas.WSVentasSoap.InsertarVentaGeneral(PuntoVentaCliente.WSVentas.InsertarVentaGeneralRequest request) {
            return base.Channel.InsertarVentaGeneral(request);
        }
        
        public bool InsertarVentaGeneral(string json) {
            PuntoVentaCliente.WSVentas.InsertarVentaGeneralRequest inValue = new PuntoVentaCliente.WSVentas.InsertarVentaGeneralRequest();
            inValue.Body = new PuntoVentaCliente.WSVentas.InsertarVentaGeneralRequestBody();
            inValue.Body.json = json;
            PuntoVentaCliente.WSVentas.InsertarVentaGeneralResponse retVal = ((PuntoVentaCliente.WSVentas.WSVentasSoap)(this)).InsertarVentaGeneral(inValue);
            return retVal.Body.InsertarVentaGeneralResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSVentas.InsertarVentaGeneralResponse> PuntoVentaCliente.WSVentas.WSVentasSoap.InsertarVentaGeneralAsync(PuntoVentaCliente.WSVentas.InsertarVentaGeneralRequest request) {
            return base.Channel.InsertarVentaGeneralAsync(request);
        }
        
        public System.Threading.Tasks.Task<PuntoVentaCliente.WSVentas.InsertarVentaGeneralResponse> InsertarVentaGeneralAsync(string json) {
            PuntoVentaCliente.WSVentas.InsertarVentaGeneralRequest inValue = new PuntoVentaCliente.WSVentas.InsertarVentaGeneralRequest();
            inValue.Body = new PuntoVentaCliente.WSVentas.InsertarVentaGeneralRequestBody();
            inValue.Body.json = json;
            return ((PuntoVentaCliente.WSVentas.WSVentasSoap)(this)).InsertarVentaGeneralAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PuntoVentaCliente.WSVentas.InsertarVentaDetallesResponse PuntoVentaCliente.WSVentas.WSVentasSoap.InsertarVentaDetalles(PuntoVentaCliente.WSVentas.InsertarVentaDetallesRequest request) {
            return base.Channel.InsertarVentaDetalles(request);
        }
        
        public bool InsertarVentaDetalles(string json) {
            PuntoVentaCliente.WSVentas.InsertarVentaDetallesRequest inValue = new PuntoVentaCliente.WSVentas.InsertarVentaDetallesRequest();
            inValue.Body = new PuntoVentaCliente.WSVentas.InsertarVentaDetallesRequestBody();
            inValue.Body.json = json;
            PuntoVentaCliente.WSVentas.InsertarVentaDetallesResponse retVal = ((PuntoVentaCliente.WSVentas.WSVentasSoap)(this)).InsertarVentaDetalles(inValue);
            return retVal.Body.InsertarVentaDetallesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSVentas.InsertarVentaDetallesResponse> PuntoVentaCliente.WSVentas.WSVentasSoap.InsertarVentaDetallesAsync(PuntoVentaCliente.WSVentas.InsertarVentaDetallesRequest request) {
            return base.Channel.InsertarVentaDetallesAsync(request);
        }
        
        public System.Threading.Tasks.Task<PuntoVentaCliente.WSVentas.InsertarVentaDetallesResponse> InsertarVentaDetallesAsync(string json) {
            PuntoVentaCliente.WSVentas.InsertarVentaDetallesRequest inValue = new PuntoVentaCliente.WSVentas.InsertarVentaDetallesRequest();
            inValue.Body = new PuntoVentaCliente.WSVentas.InsertarVentaDetallesRequestBody();
            inValue.Body.json = json;
            return ((PuntoVentaCliente.WSVentas.WSVentasSoap)(this)).InsertarVentaDetallesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PuntoVentaCliente.WSVentas.BuscarVentasResponse PuntoVentaCliente.WSVentas.WSVentasSoap.BuscarVentas(PuntoVentaCliente.WSVentas.BuscarVentasRequest request) {
            return base.Channel.BuscarVentas(request);
        }
        
        public string BuscarVentas(string empleado, string fechaInicio, string fechaFinal) {
            PuntoVentaCliente.WSVentas.BuscarVentasRequest inValue = new PuntoVentaCliente.WSVentas.BuscarVentasRequest();
            inValue.Body = new PuntoVentaCliente.WSVentas.BuscarVentasRequestBody();
            inValue.Body.empleado = empleado;
            inValue.Body.fechaInicio = fechaInicio;
            inValue.Body.fechaFinal = fechaFinal;
            PuntoVentaCliente.WSVentas.BuscarVentasResponse retVal = ((PuntoVentaCliente.WSVentas.WSVentasSoap)(this)).BuscarVentas(inValue);
            return retVal.Body.BuscarVentasResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSVentas.BuscarVentasResponse> PuntoVentaCliente.WSVentas.WSVentasSoap.BuscarVentasAsync(PuntoVentaCliente.WSVentas.BuscarVentasRequest request) {
            return base.Channel.BuscarVentasAsync(request);
        }
        
        public System.Threading.Tasks.Task<PuntoVentaCliente.WSVentas.BuscarVentasResponse> BuscarVentasAsync(string empleado, string fechaInicio, string fechaFinal) {
            PuntoVentaCliente.WSVentas.BuscarVentasRequest inValue = new PuntoVentaCliente.WSVentas.BuscarVentasRequest();
            inValue.Body = new PuntoVentaCliente.WSVentas.BuscarVentasRequestBody();
            inValue.Body.empleado = empleado;
            inValue.Body.fechaInicio = fechaInicio;
            inValue.Body.fechaFinal = fechaFinal;
            return ((PuntoVentaCliente.WSVentas.WSVentasSoap)(this)).BuscarVentasAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PuntoVentaCliente.WSVentas.DetallesVentaResponse PuntoVentaCliente.WSVentas.WSVentasSoap.DetallesVenta(PuntoVentaCliente.WSVentas.DetallesVentaRequest request) {
            return base.Channel.DetallesVenta(request);
        }
        
        public string DetallesVenta(int id) {
            PuntoVentaCliente.WSVentas.DetallesVentaRequest inValue = new PuntoVentaCliente.WSVentas.DetallesVentaRequest();
            inValue.Body = new PuntoVentaCliente.WSVentas.DetallesVentaRequestBody();
            inValue.Body.id = id;
            PuntoVentaCliente.WSVentas.DetallesVentaResponse retVal = ((PuntoVentaCliente.WSVentas.WSVentasSoap)(this)).DetallesVenta(inValue);
            return retVal.Body.DetallesVentaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSVentas.DetallesVentaResponse> PuntoVentaCliente.WSVentas.WSVentasSoap.DetallesVentaAsync(PuntoVentaCliente.WSVentas.DetallesVentaRequest request) {
            return base.Channel.DetallesVentaAsync(request);
        }
        
        public System.Threading.Tasks.Task<PuntoVentaCliente.WSVentas.DetallesVentaResponse> DetallesVentaAsync(int id) {
            PuntoVentaCliente.WSVentas.DetallesVentaRequest inValue = new PuntoVentaCliente.WSVentas.DetallesVentaRequest();
            inValue.Body = new PuntoVentaCliente.WSVentas.DetallesVentaRequestBody();
            inValue.Body.id = id;
            return ((PuntoVentaCliente.WSVentas.WSVentasSoap)(this)).DetallesVentaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PuntoVentaCliente.WSVentas.BuscarProductoParaVentaResponse PuntoVentaCliente.WSVentas.WSVentasSoap.BuscarProductoParaVenta(PuntoVentaCliente.WSVentas.BuscarProductoParaVentaRequest request) {
            return base.Channel.BuscarProductoParaVenta(request);
        }
        
        public string BuscarProductoParaVenta(string busqueda) {
            PuntoVentaCliente.WSVentas.BuscarProductoParaVentaRequest inValue = new PuntoVentaCliente.WSVentas.BuscarProductoParaVentaRequest();
            inValue.Body = new PuntoVentaCliente.WSVentas.BuscarProductoParaVentaRequestBody();
            inValue.Body.busqueda = busqueda;
            PuntoVentaCliente.WSVentas.BuscarProductoParaVentaResponse retVal = ((PuntoVentaCliente.WSVentas.WSVentasSoap)(this)).BuscarProductoParaVenta(inValue);
            return retVal.Body.BuscarProductoParaVentaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSVentas.BuscarProductoParaVentaResponse> PuntoVentaCliente.WSVentas.WSVentasSoap.BuscarProductoParaVentaAsync(PuntoVentaCliente.WSVentas.BuscarProductoParaVentaRequest request) {
            return base.Channel.BuscarProductoParaVentaAsync(request);
        }
        
        public System.Threading.Tasks.Task<PuntoVentaCliente.WSVentas.BuscarProductoParaVentaResponse> BuscarProductoParaVentaAsync(string busqueda) {
            PuntoVentaCliente.WSVentas.BuscarProductoParaVentaRequest inValue = new PuntoVentaCliente.WSVentas.BuscarProductoParaVentaRequest();
            inValue.Body = new PuntoVentaCliente.WSVentas.BuscarProductoParaVentaRequestBody();
            inValue.Body.busqueda = busqueda;
            return ((PuntoVentaCliente.WSVentas.WSVentasSoap)(this)).BuscarProductoParaVentaAsync(inValue);
        }
    }
}
