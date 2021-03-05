﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Castle.DynamicProxy;

namespace Azure.Core.TestFramework
{
    internal class InstrumentClientInterceptor : IInterceptor
    {
        private readonly ClientTestBase _testBase;

        public InstrumentClientInterceptor(ClientTestBase testBase)
        {
            _testBase = testBase;
        }

        public void Intercept(IInvocation invocation)
        {
            invocation.Proceed();

            var result = invocation.ReturnValue;
            if (result == null)
            {
                return;
            }

            var type = result.GetType();
            // We don't want to instrument generated rest clients.
            if ((type.Name.EndsWith("Client") && !type.Name.EndsWith("RestClient")) ||
                // Generated ARM clients will have a property containing the sub-client that ends with Operations.
                (invocation.Method.Name.StartsWith("get_") && type.Name.EndsWith("Operations")) ||
                // Instrument the subscription client that hangs off of the new AzureResouceManagementClient
                (type.Name.EndsWith("DefaultSubscription")))
            {
                invocation.ReturnValue = _testBase.InstrumentClient(type, result, Array.Empty<IInterceptor>());
            }
        }
    }
}
