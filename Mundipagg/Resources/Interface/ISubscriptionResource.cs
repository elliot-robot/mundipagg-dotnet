﻿using Mundipagg.Models.Request;
using Mundipagg.Models.Response;

namespace Mundipagg.Resources.Interface
{
    /// <summary>
    /// Subscription manager
    /// </summary>
    public interface ISubscriptionResource : IResource
    {
        #region Subscription

        /// <summary>
        /// Creates a new subscription
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a subscription</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse> CreateSubscription(CreateSubscriptionRequest body);

        /// <summary>
        /// Gets a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse> GetSubscription(string subscriptionId);

        /// <summary>
        /// Lists all subscriptions
        /// </summary>
        /// <return>Returns BaseResponse<ListSubscriptionsResponse> response from the API call</return>
        BaseResponse<ListSubscriptionsResponse> ListSubscriptions(ListSubscriptionsRequest request);

        /// <summary>
        /// Cancels a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Optional parameter: Request for cancelling a subscription</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse> CancelSubscription(string subscriptionId, CreateCancelSubscriptionRequest request = null);

        /// <summary>
        /// Updates the metadata from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="request">Required parameter: Request for updating the subscrption metadata</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse> UpdateSubscriptionMetadata(string subscriptionId, UpdateMetadataRequest request);

        /// <summary>
        /// Updates the payment method from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for updating the paymentmethod from a subscription</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse> UpdateSubscriptionPaymentMethod(string subscriptionId, UpdateSubscriptionPaymentMethodRequest request);

        /// <summary>
        /// Updates the start at date from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="request">Required parameter: Request for updating the subscription start date</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse> UpdateSubscriptionStartAt(string subscriptionId, UpdateSubscriptionStartAtRequest request);

        /// <summary>
        /// Updates the credit card from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for updating a card</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse> UpdateSubscriptionCard(string subscriptionId, UpdateSubscriptionCardRequest request);

        /// <summary>
        /// Updates the boleto due days from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="request">Required parameter: Request for updating due date </param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse> UpdateSubscriptionDueDays(string subscriptionId, UpdateSubscriptionDueDaysRequest request);

        /// <summary>
        /// Updates subscription minimum price
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="request">Required parameter: Request for updating minimum price</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse> UpdateSubscriptionMiniumPrice(string subscriptionId, UpdateSubscriptionMinimumPriceRequest request);

        /// <summary>
        /// Updates the billing date from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for updating the subscription billing date</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse> UpdateSubscriptionBillingDate(string subscriptionId, UpdateSubscriptionBillingDateRequest request);

        /// <summary>
        /// Update cycle end date
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for updating the end date of the current signature cycle</param>
        /// <return>Returns BaseResponse<GetSubscriptionItemResponse> response from the API call</return>
        BaseResponse<GetSubscriptionItemResponse> UpdateCurrentCycleEndDate(string subscriptionId, UpdateCurrentCycleEndDateRequest request);

        /// <summary>
        /// Update subuscription gateway affiliation
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Example: </param>
        /// <param name="request">Required parameter: Request for updating a subscription affiliation id</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse> UpdateSubscriptionAffiliationId(string subscriptionId, UpdateSubscriptionAffiliationIdRequest request);

        #endregion

        #region Subscription Item

        /// <summary>
        /// Creates a new Subscription item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for creating a subscription item</param>
        /// <return>Returns BaseResponse<GetSubscriptionItemResponse> response from the API call</return>
        BaseResponse<GetSubscriptionItemResponse> CreateSubscriptionItem(string subscriptionId, CreateSubscriptionItemRequest request);

        /// <summary>
        /// Get Subscription Item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="itemId">Required parameter: Item id</param>
        /// <return>Returns BaseResponse<GetSubscriptionItemResponse> response from the API call</return>
        BaseResponse<GetSubscriptionItemResponse> GetSubscriptionItem(string subscriptionId, string itemId);

        /// <summary>
        /// Lists Subscription Items
        /// </summary>
        /// <return>Returns BaseResponse<ListSubscriptionItemsResponse> response from the API call</return>
        BaseResponse<ListSubscriptionItemsResponse> ListSubscriptionItems(ListSubscriptionItemsRequest request);

        /// <summary>
        /// Updates a subscription item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="itemId">Required parameter: Item id</param>
        /// <param name="body">Required parameter: Request for updating a subscription item</param>
        /// <return>Returns BaseResponse<GetSubscriptionItemResponse> response from the API call</return>
        BaseResponse<GetSubscriptionItemResponse> UpdateSubscriptionItem(string subscriptionId, string itemId, UpdateSubscriptionItemRequest body);

        /// <summary>
        /// Deletes a subscription item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="subscriptionItemId">Required parameter: Subscription item id</param>
        /// <return>Returns BaseResponse<GetSubscriptionItemResponse> response from the API call</return>
        BaseResponse<GetSubscriptionItemResponse> DeleteSubscriptionItem(string subscriptionId, string subscriptionItemId);

        #endregion 

        #region Increment

        /// <summary>
        /// Get subscription increment
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="incrementId">Required parameter: Increment Id</param>
        /// <return>Returns BaseResponse<GetIncrementResponse> response from the API call</return>
        BaseResponse<GetIncrementResponse> GetIncrement(string subscriptionId, string incrementId);

        /// <summary>
        /// Creates a increment
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for creating a increment</param>
        /// <return>Returns BaseResponse<GetIncrementResponse> response from the API call</return>
        BaseResponse<GetIncrementResponse> CreateIncrement(string subscriptionId, CreateIncrementRequest request);

        /// <summary>
        /// Lists subscription increments
        /// </summary>
        /// <return>Returns BaseResponse<ListIncrementsResponse> response from the API call</return>
        BaseResponse<ListIncrementsResponse> ListIncrements(ListIncrementsRequest request);

        /// <summary>
        /// Deletes a increment
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="incrementId">Required parameter: Increment id</param>
        /// <return>Returns BaseResponse<GetIncrementResponse> response from the API call</return>
        BaseResponse<GetIncrementResponse> DeleteIncrement(string subscriptionId, string incrementId);

        #endregion

        #region Discount

        /// <summary>
        /// Creates a discount
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for creating a discount</param>
        /// <return>Returns BaseResponse<GetDiscountResponse> response from the API call</return>
        BaseResponse<GetDiscountResponse> CreateDiscount(string subscriptionId, CreateDiscountRequest request);

        /// <summary>
        /// Deletes a discount
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="discountId">Required parameter: Discount Id</param>
        /// <return>Returns BaseResponse<GetDiscountResponse> response from the API call</return>
        BaseResponse<GetDiscountResponse> DeleteDiscount(string subscriptionId, string discountId);

        /// <summary>
        /// Get subscription discount
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="discountId">Required parameter: Example: </param>
        /// <return>Returns BaseResponse<GetDiscountResponse> response from the API call</return>
        BaseResponse<GetDiscountResponse> GetDiscount(string subscriptionId, string discountId);

        /// <summary>
        /// Lists subscription discounts
        /// </summary>
        /// <return>Returns BaseResponse<ListDiscountsResponse> response from the API call</return>
        BaseResponse<ListDiscountsResponse> ListDiscounts(ListDiscountsRequest request);

        #endregion

        #region Usage

        /// <summary>
        /// Creates a usage
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="itemId">Required parameter: Item id</param>
        /// <param name="body">Optional parameter: Request for creating a usage</param>
        /// <return>Returns BaseResponse<GetUsageResponse> response from the API call</return>
        BaseResponse<GetUsageResponse> CreateUsage(string subscriptionId, string itemId, CreateUsageRequest body = null);

        /// <summary>
        /// Deletes a usage
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="itemId">Required parameter: The subscription item id</param>
        /// <param name="usageId">Required parameter: The usage id</param>
        /// <return>Returns BaseResponse<GetUsageResponse> response from the API call</return>
        BaseResponse<GetUsageResponse> DeleteUsage(string subscriptionId, string itemId, string usageId);

        /// <summary>
        /// Get current usage details
        /// </summary>
        /// <return>Returns BaseResponse<GetUsagesDetailsResponse> response from the API call</return>
        BaseResponse<GetUsagesDetailsResponse> GetCurrentUsages(ListUsageDetailsRequest request);

        /// <summary>
        /// Lists all usages from a subscription item
        /// </summary>
        /// <return>Returns BaseResponse<ListUsagesResponse> response from the API call</return>
        BaseResponse<ListUsagesResponse> ListUsages(ListUsagesRequest request);

        #endregion
    }
}