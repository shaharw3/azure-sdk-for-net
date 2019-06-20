// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for IntegrationAccountsOperations.
    /// </summary>
    public static partial class IntegrationAccountsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of integration accounts by subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// The number of items to be included in the result.
            /// </param>
            public static IPage<IntegrationAccount> ListBySubscription(this IIntegrationAccountsOperations operations, int? top = default(int?))
            {
                return operations.ListBySubscriptionAsync(top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of integration accounts by subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// The number of items to be included in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IntegrationAccount>> ListBySubscriptionAsync(this IIntegrationAccountsOperations operations, int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of integration accounts by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='top'>
            /// The number of items to be included in the result.
            /// </param>
            public static IPage<IntegrationAccount> ListByResourceGroup(this IIntegrationAccountsOperations operations, string resourceGroupName, int? top = default(int?))
            {
                return operations.ListByResourceGroupAsync(resourceGroupName, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of integration accounts by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='top'>
            /// The number of items to be included in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IntegrationAccount>> ListByResourceGroupAsync(this IIntegrationAccountsOperations operations, string resourceGroupName, int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an integration account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            public static IntegrationAccount Get(this IIntegrationAccountsOperations operations, string resourceGroupName, string integrationAccountName)
            {
                return operations.GetAsync(resourceGroupName, integrationAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an integration account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IntegrationAccount> GetAsync(this IIntegrationAccountsOperations operations, string resourceGroupName, string integrationAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, integrationAccountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an integration account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='integrationAccount'>
            /// The integration account.
            /// </param>
            public static IntegrationAccount CreateOrUpdate(this IIntegrationAccountsOperations operations, string resourceGroupName, string integrationAccountName, IntegrationAccount integrationAccount)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, integrationAccountName, integrationAccount).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an integration account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='integrationAccount'>
            /// The integration account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IntegrationAccount> CreateOrUpdateAsync(this IIntegrationAccountsOperations operations, string resourceGroupName, string integrationAccountName, IntegrationAccount integrationAccount, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, integrationAccountName, integrationAccount, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an integration account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='integrationAccount'>
            /// The integration account.
            /// </param>
            public static IntegrationAccount Update(this IIntegrationAccountsOperations operations, string resourceGroupName, string integrationAccountName, IntegrationAccount integrationAccount)
            {
                return operations.UpdateAsync(resourceGroupName, integrationAccountName, integrationAccount).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an integration account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='integrationAccount'>
            /// The integration account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IntegrationAccount> UpdateAsync(this IIntegrationAccountsOperations operations, string resourceGroupName, string integrationAccountName, IntegrationAccount integrationAccount, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, integrationAccountName, integrationAccount, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an integration account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            public static void Delete(this IIntegrationAccountsOperations operations, string resourceGroupName, string integrationAccountName)
            {
                operations.DeleteAsync(resourceGroupName, integrationAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an integration account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IIntegrationAccountsOperations operations, string resourceGroupName, string integrationAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, integrationAccountName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the integration account callback URL.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='parameters'>
            /// The callback URL parameters.
            /// </param>
            public static CallbackUrl ListCallbackUrl(this IIntegrationAccountsOperations operations, string resourceGroupName, string integrationAccountName, GetCallbackUrlParameters parameters)
            {
                return operations.ListCallbackUrlAsync(resourceGroupName, integrationAccountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the integration account callback URL.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='parameters'>
            /// The callback URL parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CallbackUrl> ListCallbackUrlAsync(this IIntegrationAccountsOperations operations, string resourceGroupName, string integrationAccountName, GetCallbackUrlParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListCallbackUrlWithHttpMessagesAsync(resourceGroupName, integrationAccountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the integration account's Key Vault keys.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='listKeyVaultKeys'>
            /// The key vault parameters.
            /// </param>
            public static IEnumerable<KeyVaultKey> ListKeyVaultKeys(this IIntegrationAccountsOperations operations, string resourceGroupName, string integrationAccountName, ListKeyVaultKeysDefinition listKeyVaultKeys)
            {
                return operations.ListKeyVaultKeysAsync(resourceGroupName, integrationAccountName, listKeyVaultKeys).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the integration account's Key Vault keys.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='listKeyVaultKeys'>
            /// The key vault parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<KeyVaultKey>> ListKeyVaultKeysAsync(this IIntegrationAccountsOperations operations, string resourceGroupName, string integrationAccountName, ListKeyVaultKeysDefinition listKeyVaultKeys, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeyVaultKeysWithHttpMessagesAsync(resourceGroupName, integrationAccountName, listKeyVaultKeys, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Logs the integration account's tracking events.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='logTrackingEvents'>
            /// The callback URL parameters.
            /// </param>
            public static void LogTrackingEvents(this IIntegrationAccountsOperations operations, string resourceGroupName, string integrationAccountName, TrackingEventsDefinition logTrackingEvents)
            {
                operations.LogTrackingEventsAsync(resourceGroupName, integrationAccountName, logTrackingEvents).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Logs the integration account's tracking events.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='logTrackingEvents'>
            /// The callback URL parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task LogTrackingEventsAsync(this IIntegrationAccountsOperations operations, string resourceGroupName, string integrationAccountName, TrackingEventsDefinition logTrackingEvents, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.LogTrackingEventsWithHttpMessagesAsync(resourceGroupName, integrationAccountName, logTrackingEvents, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Regenerates the integration account access key.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='regenerateAccessKey'>
            /// The access key type.
            /// </param>
            public static IntegrationAccount RegenerateAccessKey(this IIntegrationAccountsOperations operations, string resourceGroupName, string integrationAccountName, RegenerateActionParameter regenerateAccessKey)
            {
                return operations.RegenerateAccessKeyAsync(resourceGroupName, integrationAccountName, regenerateAccessKey).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates the integration account access key.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='regenerateAccessKey'>
            /// The access key type.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IntegrationAccount> RegenerateAccessKeyAsync(this IIntegrationAccountsOperations operations, string resourceGroupName, string integrationAccountName, RegenerateActionParameter regenerateAccessKey, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateAccessKeyWithHttpMessagesAsync(resourceGroupName, integrationAccountName, regenerateAccessKey, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of integration accounts by subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<IntegrationAccount> ListBySubscriptionNext(this IIntegrationAccountsOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of integration accounts by subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IntegrationAccount>> ListBySubscriptionNextAsync(this IIntegrationAccountsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of integration accounts by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<IntegrationAccount> ListByResourceGroupNext(this IIntegrationAccountsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of integration accounts by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IntegrationAccount>> ListByResourceGroupNextAsync(this IIntegrationAccountsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}