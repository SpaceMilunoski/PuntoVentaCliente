﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PuntoVentaCliente.WSUnidades {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://microsoft.com/webservices/", ConfigurationName="WSUnidades.WSUnidadesSoap")]
    public interface WSUnidadesSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento ConsultarUnidadesResult del espacio de nombres http://microsoft.com/webservices/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/ConsultarUnidades", ReplyAction="*")]
        PuntoVentaCliente.WSUnidades.ConsultarUnidadesResponse ConsultarUnidades(PuntoVentaCliente.WSUnidades.ConsultarUnidadesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/ConsultarUnidades", ReplyAction="*")]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSUnidades.ConsultarUnidadesResponse> ConsultarUnidadesAsync(PuntoVentaCliente.WSUnidades.ConsultarUnidadesRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento unidad del espacio de nombres http://microsoft.com/webservices/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/InsertarUnidad", ReplyAction="*")]
        PuntoVentaCliente.WSUnidades.InsertarUnidadResponse InsertarUnidad(PuntoVentaCliente.WSUnidades.InsertarUnidadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/InsertarUnidad", ReplyAction="*")]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSUnidades.InsertarUnidadResponse> InsertarUnidadAsync(PuntoVentaCliente.WSUnidades.InsertarUnidadRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento unidad del espacio de nombres http://microsoft.com/webservices/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/EliminarUnidad", ReplyAction="*")]
        PuntoVentaCliente.WSUnidades.EliminarUnidadResponse EliminarUnidad(PuntoVentaCliente.WSUnidades.EliminarUnidadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/EliminarUnidad", ReplyAction="*")]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSUnidades.EliminarUnidadResponse> EliminarUnidadAsync(PuntoVentaCliente.WSUnidades.EliminarUnidadRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultarUnidadesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConsultarUnidades", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSUnidades.ConsultarUnidadesRequestBody Body;
        
        public ConsultarUnidadesRequest() {
        }
        
        public ConsultarUnidadesRequest(PuntoVentaCliente.WSUnidades.ConsultarUnidadesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ConsultarUnidadesRequestBody {
        
        public ConsultarUnidadesRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultarUnidadesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConsultarUnidadesResponse", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSUnidades.ConsultarUnidadesResponseBody Body;
        
        public ConsultarUnidadesResponse() {
        }
        
        public ConsultarUnidadesResponse(PuntoVentaCliente.WSUnidades.ConsultarUnidadesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class ConsultarUnidadesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ConsultarUnidadesResult;
        
        public ConsultarUnidadesResponseBody() {
        }
        
        public ConsultarUnidadesResponseBody(string ConsultarUnidadesResult) {
            this.ConsultarUnidadesResult = ConsultarUnidadesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarUnidadRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarUnidad", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSUnidades.InsertarUnidadRequestBody Body;
        
        public InsertarUnidadRequest() {
        }
        
        public InsertarUnidadRequest(PuntoVentaCliente.WSUnidades.InsertarUnidadRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class InsertarUnidadRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string unidad;
        
        public InsertarUnidadRequestBody() {
        }
        
        public InsertarUnidadRequestBody(string unidad) {
            this.unidad = unidad;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarUnidadResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarUnidadResponse", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSUnidades.InsertarUnidadResponseBody Body;
        
        public InsertarUnidadResponse() {
        }
        
        public InsertarUnidadResponse(PuntoVentaCliente.WSUnidades.InsertarUnidadResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class InsertarUnidadResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool InsertarUnidadResult;
        
        public InsertarUnidadResponseBody() {
        }
        
        public InsertarUnidadResponseBody(bool InsertarUnidadResult) {
            this.InsertarUnidadResult = InsertarUnidadResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EliminarUnidadRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EliminarUnidad", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSUnidades.EliminarUnidadRequestBody Body;
        
        public EliminarUnidadRequest() {
        }
        
        public EliminarUnidadRequest(PuntoVentaCliente.WSUnidades.EliminarUnidadRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class EliminarUnidadRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string unidad;
        
        public EliminarUnidadRequestBody() {
        }
        
        public EliminarUnidadRequestBody(string unidad) {
            this.unidad = unidad;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EliminarUnidadResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EliminarUnidadResponse", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSUnidades.EliminarUnidadResponseBody Body;
        
        public EliminarUnidadResponse() {
        }
        
        public EliminarUnidadResponse(PuntoVentaCliente.WSUnidades.EliminarUnidadResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class EliminarUnidadResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool EliminarUnidadResult;
        
        public EliminarUnidadResponseBody() {
        }
        
        public EliminarUnidadResponseBody(bool EliminarUnidadResult) {
            this.EliminarUnidadResult = EliminarUnidadResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSUnidadesSoapChannel : PuntoVentaCliente.WSUnidades.WSUnidadesSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSUnidadesSoapClient : System.ServiceModel.ClientBase<PuntoVentaCliente.WSUnidades.WSUnidadesSoap>, PuntoVentaCliente.WSUnidades.WSUnidadesSoap {
        
        public WSUnidadesSoapClient() {
        }
        
        public WSUnidadesSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSUnidadesSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSUnidadesSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSUnidadesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PuntoVentaCliente.WSUnidades.ConsultarUnidadesResponse PuntoVentaCliente.WSUnidades.WSUnidadesSoap.ConsultarUnidades(PuntoVentaCliente.WSUnidades.ConsultarUnidadesRequest request) {
            return base.Channel.ConsultarUnidades(request);
        }
        
        public string ConsultarUnidades() {
            PuntoVentaCliente.WSUnidades.ConsultarUnidadesRequest inValue = new PuntoVentaCliente.WSUnidades.ConsultarUnidadesRequest();
            inValue.Body = new PuntoVentaCliente.WSUnidades.ConsultarUnidadesRequestBody();
            PuntoVentaCliente.WSUnidades.ConsultarUnidadesResponse retVal = ((PuntoVentaCliente.WSUnidades.WSUnidadesSoap)(this)).ConsultarUnidades(inValue);
            return retVal.Body.ConsultarUnidadesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSUnidades.ConsultarUnidadesResponse> PuntoVentaCliente.WSUnidades.WSUnidadesSoap.ConsultarUnidadesAsync(PuntoVentaCliente.WSUnidades.ConsultarUnidadesRequest request) {
            return base.Channel.ConsultarUnidadesAsync(request);
        }
        
        public System.Threading.Tasks.Task<PuntoVentaCliente.WSUnidades.ConsultarUnidadesResponse> ConsultarUnidadesAsync() {
            PuntoVentaCliente.WSUnidades.ConsultarUnidadesRequest inValue = new PuntoVentaCliente.WSUnidades.ConsultarUnidadesRequest();
            inValue.Body = new PuntoVentaCliente.WSUnidades.ConsultarUnidadesRequestBody();
            return ((PuntoVentaCliente.WSUnidades.WSUnidadesSoap)(this)).ConsultarUnidadesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PuntoVentaCliente.WSUnidades.InsertarUnidadResponse PuntoVentaCliente.WSUnidades.WSUnidadesSoap.InsertarUnidad(PuntoVentaCliente.WSUnidades.InsertarUnidadRequest request) {
            return base.Channel.InsertarUnidad(request);
        }
        
        public bool InsertarUnidad(string unidad) {
            PuntoVentaCliente.WSUnidades.InsertarUnidadRequest inValue = new PuntoVentaCliente.WSUnidades.InsertarUnidadRequest();
            inValue.Body = new PuntoVentaCliente.WSUnidades.InsertarUnidadRequestBody();
            inValue.Body.unidad = unidad;
            PuntoVentaCliente.WSUnidades.InsertarUnidadResponse retVal = ((PuntoVentaCliente.WSUnidades.WSUnidadesSoap)(this)).InsertarUnidad(inValue);
            return retVal.Body.InsertarUnidadResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSUnidades.InsertarUnidadResponse> PuntoVentaCliente.WSUnidades.WSUnidadesSoap.InsertarUnidadAsync(PuntoVentaCliente.WSUnidades.InsertarUnidadRequest request) {
            return base.Channel.InsertarUnidadAsync(request);
        }
        
        public System.Threading.Tasks.Task<PuntoVentaCliente.WSUnidades.InsertarUnidadResponse> InsertarUnidadAsync(string unidad) {
            PuntoVentaCliente.WSUnidades.InsertarUnidadRequest inValue = new PuntoVentaCliente.WSUnidades.InsertarUnidadRequest();
            inValue.Body = new PuntoVentaCliente.WSUnidades.InsertarUnidadRequestBody();
            inValue.Body.unidad = unidad;
            return ((PuntoVentaCliente.WSUnidades.WSUnidadesSoap)(this)).InsertarUnidadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PuntoVentaCliente.WSUnidades.EliminarUnidadResponse PuntoVentaCliente.WSUnidades.WSUnidadesSoap.EliminarUnidad(PuntoVentaCliente.WSUnidades.EliminarUnidadRequest request) {
            return base.Channel.EliminarUnidad(request);
        }
        
        public bool EliminarUnidad(string unidad) {
            PuntoVentaCliente.WSUnidades.EliminarUnidadRequest inValue = new PuntoVentaCliente.WSUnidades.EliminarUnidadRequest();
            inValue.Body = new PuntoVentaCliente.WSUnidades.EliminarUnidadRequestBody();
            inValue.Body.unidad = unidad;
            PuntoVentaCliente.WSUnidades.EliminarUnidadResponse retVal = ((PuntoVentaCliente.WSUnidades.WSUnidadesSoap)(this)).EliminarUnidad(inValue);
            return retVal.Body.EliminarUnidadResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSUnidades.EliminarUnidadResponse> PuntoVentaCliente.WSUnidades.WSUnidadesSoap.EliminarUnidadAsync(PuntoVentaCliente.WSUnidades.EliminarUnidadRequest request) {
            return base.Channel.EliminarUnidadAsync(request);
        }
        
        public System.Threading.Tasks.Task<PuntoVentaCliente.WSUnidades.EliminarUnidadResponse> EliminarUnidadAsync(string unidad) {
            PuntoVentaCliente.WSUnidades.EliminarUnidadRequest inValue = new PuntoVentaCliente.WSUnidades.EliminarUnidadRequest();
            inValue.Body = new PuntoVentaCliente.WSUnidades.EliminarUnidadRequestBody();
            inValue.Body.unidad = unidad;
            return ((PuntoVentaCliente.WSUnidades.WSUnidadesSoap)(this)).EliminarUnidadAsync(inValue);
        }
    }
}
