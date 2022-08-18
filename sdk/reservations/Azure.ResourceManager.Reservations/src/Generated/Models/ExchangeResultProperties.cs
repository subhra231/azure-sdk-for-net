// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Exchange response properties. </summary>
    public partial class ExchangeResultProperties
    {
        /// <summary> Initializes a new instance of ExchangeResultProperties. </summary>
        internal ExchangeResultProperties()
        {
            ReservationsToPurchase = new ChangeTrackingList<ReservationToPurchaseExchange>();
            ReservationsToExchange = new ChangeTrackingList<ReservationToReturnForExchange>();
        }

        /// <summary> Initializes a new instance of ExchangeResultProperties. </summary>
        /// <param name="sessionId"> Exchange session identifier. </param>
        /// <param name="netPayable"></param>
        /// <param name="refundsTotal"></param>
        /// <param name="purchasesTotal"></param>
        /// <param name="reservationsToPurchase"> Details of the reservations being purchased. </param>
        /// <param name="reservationsToExchange"> Details of the reservations being returned. </param>
        /// <param name="policyResult"> Exchange policy errors. </param>
        internal ExchangeResultProperties(Guid? sessionId, PurchasePrice netPayable, PurchasePrice refundsTotal, PurchasePrice purchasesTotal, IReadOnlyList<ReservationToPurchaseExchange> reservationsToPurchase, IReadOnlyList<ReservationToReturnForExchange> reservationsToExchange, ExchangePolicyErrors policyResult)
        {
            SessionId = sessionId;
            NetPayable = netPayable;
            RefundsTotal = refundsTotal;
            PurchasesTotal = purchasesTotal;
            ReservationsToPurchase = reservationsToPurchase;
            ReservationsToExchange = reservationsToExchange;
            PolicyResult = policyResult;
        }

        /// <summary> Exchange session identifier. </summary>
        public Guid? SessionId { get; }
        /// <summary> Gets the net payable. </summary>
        public PurchasePrice NetPayable { get; }
        /// <summary> Gets the refunds total. </summary>
        public PurchasePrice RefundsTotal { get; }
        /// <summary> Gets the purchases total. </summary>
        public PurchasePrice PurchasesTotal { get; }
        /// <summary> Details of the reservations being purchased. </summary>
        public IReadOnlyList<ReservationToPurchaseExchange> ReservationsToPurchase { get; }
        /// <summary> Details of the reservations being returned. </summary>
        public IReadOnlyList<ReservationToReturnForExchange> ReservationsToExchange { get; }
        /// <summary> Exchange policy errors. </summary>
        internal ExchangePolicyErrors PolicyResult { get; }
        /// <summary> Exchange Policy errors. </summary>
        public IReadOnlyList<ExchangePolicyError> PolicyErrors
        {
            get => PolicyResult?.PolicyErrors;
        }
    }
}
