//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by XCTools.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace XComponent.Order.Common.Senders
{
    using System;
    using XComponent.Order.Common;
    
    
    public class SenderManager
    {
		private static ExecuteExecutionInputOnExecutedOrderSender m_executeExecutionInputOnExecutedOrderSender;
        
        public static ExecuteExecutionInputOnExecutedOrderSender ExecuteExecutionInputOnExecutedOrderSender
        {
            get
            {
                if ((m_executeExecutionInputOnExecutedOrderSender == null))
                {
                    m_executeExecutionInputOnExecutedOrderSender = new ExecuteExecutionInputOnExecutedOrderSender();
                }
                return m_executeExecutionInputOnExecutedOrderSender;
            }
        }
		private static PartiallyExecuteExecutionInputOnPartiallyExecutedOrderSender m_partiallyExecuteExecutionInputOnPartiallyExecutedOrderSender;
        
        public static PartiallyExecuteExecutionInputOnPartiallyExecutedOrderSender PartiallyExecuteExecutionInputOnPartiallyExecutedOrderSender
        {
            get
            {
                if ((m_partiallyExecuteExecutionInputOnPartiallyExecutedOrderSender == null))
                {
                    m_partiallyExecuteExecutionInputOnPartiallyExecutedOrderSender = new PartiallyExecuteExecutionInputOnPartiallyExecutedOrderSender();
                }
                return m_partiallyExecuteExecutionInputOnPartiallyExecutedOrderSender;
            }
        }
		private static CreateOrderOrderInputOnPendingOrderSender m_createOrderOrderInputOnPendingOrderSender;
        
        public static CreateOrderOrderInputOnPendingOrderSender CreateOrderOrderInputOnPendingOrderSender
        {
            get
            {
                if ((m_createOrderOrderInputOnPendingOrderSender == null))
                {
                    m_createOrderOrderInputOnPendingOrderSender = new CreateOrderOrderInputOnPendingOrderSender();
                }
                return m_createOrderOrderInputOnPendingOrderSender;
            }
        }
		private static PublishOrderCreationOrderCreationOnCreatedCreationFacadeSender m_publishOrderCreationOrderCreationOnCreatedCreationFacadeSender;
        
        public static PublishOrderCreationOrderCreationOnCreatedCreationFacadeSender PublishOrderCreationOrderCreationOnCreatedCreationFacadeSender
        {
            get
            {
                if ((m_publishOrderCreationOrderCreationOnCreatedCreationFacadeSender == null))
                {
                    m_publishOrderCreationOrderCreationOnCreatedCreationFacadeSender = new PublishOrderCreationOrderCreationOnCreatedCreationFacadeSender();
                }
                return m_publishOrderCreationOrderCreationOnCreatedCreationFacadeSender;
            }
        }
		private static PublishOrderFilledOrderExecutionOnFilledExecutionFacadeSender m_publishOrderFilledOrderExecutionOnFilledExecutionFacadeSender;
        
        public static PublishOrderFilledOrderExecutionOnFilledExecutionFacadeSender PublishOrderFilledOrderExecutionOnFilledExecutionFacadeSender
        {
            get
            {
                if ((m_publishOrderFilledOrderExecutionOnFilledExecutionFacadeSender == null))
                {
                    m_publishOrderFilledOrderExecutionOnFilledExecutionFacadeSender = new PublishOrderFilledOrderExecutionOnFilledExecutionFacadeSender();
                }
                return m_publishOrderFilledOrderExecutionOnFilledExecutionFacadeSender;
            }
        }
		private static PublishOrderPartiallyFilledOrderExecutionOnPartiallyFilledPartialExecutionFacadeSender m_publishOrderPartiallyFilledOrderExecutionOnPartiallyFilledPartialExecutionFacadeSender;
        
        public static PublishOrderPartiallyFilledOrderExecutionOnPartiallyFilledPartialExecutionFacadeSender PublishOrderPartiallyFilledOrderExecutionOnPartiallyFilledPartialExecutionFacadeSender
        {
            get
            {
                if ((m_publishOrderPartiallyFilledOrderExecutionOnPartiallyFilledPartialExecutionFacadeSender == null))
                {
                    m_publishOrderPartiallyFilledOrderExecutionOnPartiallyFilledPartialExecutionFacadeSender = new PublishOrderPartiallyFilledOrderExecutionOnPartiallyFilledPartialExecutionFacadeSender();
                }
                return m_publishOrderPartiallyFilledOrderExecutionOnPartiallyFilledPartialExecutionFacadeSender;
            }
        }
		
    }
}