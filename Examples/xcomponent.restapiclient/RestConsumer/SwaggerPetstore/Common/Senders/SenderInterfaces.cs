//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by XCTools.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace XComponent.SwaggerPetstore.Common.Senders
{
    using System;
    using XComponent.Common.ApiContext;
    using XComponent.SwaggerPetstore.Common;
    
	public interface IInitDefaultEventOnUpSwaggerPetstoreSenderInterface
    {
		
		
		
		
		
    }
	public interface IAddPetAddPetOnUpSwaggerPetstoreSenderInterface
    {
		void CreateAddPetHttpRequest(Context context);
		
		
		void CreateAddPetHttpRequest(Context context, XComponent.SwaggerPetstore.UserObject.AddPetOperation transitionEvent);
		
		
		void SendEvent(XComponent.SwaggerPetstore.UserObject.AddPetOperation evt);
			void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.AddPetOperation evt);
		
    }
	public interface IGetPetByIdGetPetByIdOnUpSwaggerPetstoreSenderInterface
    {
		void CreateGetPetByIdHttpRequest(Context context);
		
		
		void CreateGetPetByIdHttpRequest(Context context, XComponent.SwaggerPetstore.UserObject.GetPetByIdOperation transitionEvent);
		
		
		void SendEvent(XComponent.SwaggerPetstore.UserObject.GetPetByIdOperation evt);
			void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.GetPetByIdOperation evt);
		
    }
	public interface ICreateAddPetHttpRequestAddPetOperationOnSendingRequestAddPetOperationSenderInterface
    {
		
		
		void SendRequest_AddPetOperation(Context context, XComponent.Common.Event.DefaultEvent transitionEvent);
		void ReceiveSuccess_AddPetOperation(Context context, XComponent.SwaggerPetstore.UserObject.SuccessResponse transitionEvent);
		void ReceiveError_AddPetOperation(Context context, XComponent.SwaggerPetstore.UserObject.ErrorResponse transitionEvent);
		
		
		void SendEvent(XComponent.Common.Event.DefaultEvent evt);
			void SendEvent(StdEnum stdEnum, XComponent.Common.Event.DefaultEvent evt);
		void SendEvent(XComponent.SwaggerPetstore.UserObject.SuccessResponse evt);
			void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.SuccessResponse evt);
		void SendEvent(XComponent.SwaggerPetstore.UserObject.ErrorResponse evt);
			void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.ErrorResponse evt);
		
    }
	public interface ICreateGetPetByIdHttpRequestGetPetByIdOperationOnSendingRequestGetPetByIdOperationSenderInterface
    {
		
		
		void SendRequest_GetPetByIdOperation(Context context, XComponent.Common.Event.DefaultEvent transitionEvent);
		void ReceiveSuccess_GetPetByIdOperation(Context context, XComponent.SwaggerPetstore.UserObject.SuccessResponse transitionEvent);
		void ReceiveError_GetPetByIdOperation(Context context, XComponent.SwaggerPetstore.UserObject.ErrorResponse transitionEvent);
		
		
		void SendEvent(XComponent.Common.Event.DefaultEvent evt);
			void SendEvent(StdEnum stdEnum, XComponent.Common.Event.DefaultEvent evt);
		void SendEvent(XComponent.SwaggerPetstore.UserObject.SuccessResponse evt);
			void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.SuccessResponse evt);
		void SendEvent(XComponent.SwaggerPetstore.UserObject.ErrorResponse evt);
			void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.ErrorResponse evt);
		
    }
	
}
