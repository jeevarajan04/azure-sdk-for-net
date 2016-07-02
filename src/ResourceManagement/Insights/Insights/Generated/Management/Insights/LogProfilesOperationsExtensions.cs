// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Insights;
using Microsoft.Azure.Management.Insights.Models;

namespace Microsoft.Azure.Management.Insights
{
    public static partial class LogProfilesOperationsExtensions
    {
        /// <summary>
        /// Create or update the log profile.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Insights.ILogProfilesOperations.
        /// </param>
        /// <param name='name'>
        /// Required. The name of the log profile.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the operation.
        /// </param>
        /// <returns>
        /// Generic empty response. We only pass it to ensure json error
        /// handling
        /// </returns>
        public static EmptyResponse CreateOrUpdate(this ILogProfilesOperations operations, string name, LogProfileCreatOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ILogProfilesOperations)s).CreateOrUpdateAsync(name, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create or update the log profile.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Insights.ILogProfilesOperations.
        /// </param>
        /// <param name='name'>
        /// Required. The name of the log profile.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the operation.
        /// </param>
        /// <returns>
        /// Generic empty response. We only pass it to ensure json error
        /// handling
        /// </returns>
        public static Task<EmptyResponse> CreateOrUpdateAsync(this ILogProfilesOperations operations, string name, LogProfileCreatOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(name, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes the log profile.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Insights.ILogProfilesOperations.
        /// </param>
        /// <param name='name'>
        /// Required. The name of the log profile.
        /// </param>
        /// <returns>
        /// Generic empty response. We only pass it to ensure json error
        /// handling
        /// </returns>
        public static EmptyResponse Delete(this ILogProfilesOperations operations, string name)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ILogProfilesOperations)s).DeleteAsync(name);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes the log profile.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Insights.ILogProfilesOperations.
        /// </param>
        /// <param name='name'>
        /// Required. The name of the log profile.
        /// </param>
        /// <returns>
        /// Generic empty response. We only pass it to ensure json error
        /// handling
        /// </returns>
        public static Task<EmptyResponse> DeleteAsync(this ILogProfilesOperations operations, string name)
        {
            return operations.DeleteAsync(name, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the log profile.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Insights.ILogProfilesOperations.
        /// </param>
        /// <param name='name'>
        /// Required. The name of the log profile.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static LogProfileGetResponse Get(this ILogProfilesOperations operations, string name)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ILogProfilesOperations)s).GetAsync(name);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the log profile.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Insights.ILogProfilesOperations.
        /// </param>
        /// <param name='name'>
        /// Required. The name of the log profile.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<LogProfileGetResponse> GetAsync(this ILogProfilesOperations operations, string name)
        {
            return operations.GetAsync(name, CancellationToken.None);
        }
        
        /// <summary>
        /// List the log profiles.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Insights.ILogProfilesOperations.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static LogProfileListResponse List(this ILogProfilesOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ILogProfilesOperations)s).ListAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// List the log profiles.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Insights.ILogProfilesOperations.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<LogProfileListResponse> ListAsync(this ILogProfilesOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
    }
}