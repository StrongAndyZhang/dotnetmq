﻿/* This code file is generated by MDSService Proxy Generator tool.
 * 
 * Service Name    : MyMailSmsService
 * Service version : 1.0.0.0
 * Generating date : 2011-04-04 22:07:02
 */

using System;
using MDS.Client;
using MDS.Client.MDSServices;

namespace SampleService
{
    /// <summary>
    /// This class is a proxy class to use MyMailSmsService service.
    /// Service Description: This service is a sample mail/sms service.
    /// </summary>
    public partial class MyMailSmsServiceProxy : MDSServiceProxyBase
    {
        #region Constructor
        
        /// <summary>
        /// Creates a new instance of MyMailSmsServiceProxy.
        /// </summary>
        /// <param name="serviceConsumer">Reference to a MDSServiceConsumer object to send/receive MDS messages</param>
        /// <param name="remoteEndPoint">Remote application end point to send requests</param>
        public MyMailSmsServiceProxy(MDSServiceConsumer serviceConsumer, MDSRemoteAppEndPoint remoteEndPoint)
            : base(serviceConsumer, remoteEndPoint, "MyMailSmsService")
        {
            
        }
        
        #endregion
        
        #region MyMailSmsService methods
        
        /// <summary>
        /// This method is used send an SMS.
        /// </summary>
        /// <param name="phone">Phone number to send SMS.</param>
        /// <param name="smsText">SMS text to be sent.</param>
        public void SendSms(string phone, string smsText)
        {
            InvokeRemoteMethod("SendSms", phone, smsText);
        }
        
        /// <summary>
        /// No method summary available.
        /// </summary>
        public void SendEmail(string emailAddress, string header, string body)
        {
            InvokeRemoteMethod("SendEmail", emailAddress, header, body);
        }
        
        /// <summary>
        /// No method summary available.
        /// </summary>
        /// <param name="phone">Phone number to send SMS.</param>
        /// <returns>True, if phone number is valid.</returns>
        public bool IsValidPhone(string phone)
        {
            return (bool) InvokeRemoteMethodAndGetResult("IsValidPhone", phone);
        }
        
        #endregion
        
        #region Default (predefined) service methods
        
        /// <summary>
        /// This method generates client proxy class to use this service. Clients can update it's proxy classes via calling this method remotely.
        /// </summary>
        /// <param name="namespaceName">Namespace of generating proxy class</param>
        /// <returns>Proxy class code to use this service</returns>
        public string GenerateProxyClass(string namespaceName)
        {
            return (string) InvokeRemoteMethodAndGetResult("GenerateProxyClass", namespaceName);
        }
        
        /// <summary>
        /// This method can be used to check if service is available.
        /// </summary>
        /// <param name="message">A message to reply</param>
        /// <returns>Reply to message as formatted: 'RE: message'</returns>
        public string CheckServiceIsAvailable(string message)
        {
            return (string) InvokeRemoteMethodAndGetResult("CheckServiceIsAvailable", message);
        }
        
        #endregion
    }
}

