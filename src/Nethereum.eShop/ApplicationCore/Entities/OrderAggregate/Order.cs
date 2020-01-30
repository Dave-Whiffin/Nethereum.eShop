﻿using Nethereum.eShop.ApplicationCore.Interfaces;
using Ardalis.GuardClauses;
using System;
using System.Collections.Generic;

namespace Nethereum.eShop.ApplicationCore.Entities.OrderAggregate
{
    public class Order : BaseEntity, IAggregateRoot
    {
        private Order()
        {
            // required by EF
        }

        public Order(string buyerId, PostalAddress billToAddress, PostalAddress shipToAddress, List<OrderItem> items)
        {
            Guard.Against.NullOrEmpty(buyerId, nameof(buyerId));
            Guard.Against.Null(billToAddress, nameof(billToAddress));
            Guard.Against.Null(shipToAddress, nameof(shipToAddress));
            Guard.Against.Null(items, nameof(items));

            BuyerAddress = buyerId;
            ShipTo = shipToAddress;
            _orderItems = items;
        }

        /// <summary>
        /// The Buyer Address
        /// </summary>
        public string BuyerAddress { get; private set; }

        /// <summary>
        /// The Purhase Order Number
        /// </summary>
        public long? PONumber { get; private set; }

        public long BuyerNonce { get; set; } // po order counter per buyer

        /// <summary>
        /// eShop constant - one wallet expected per shop
        /// </summary>
        public string BuyerWalletAddress { get; set; } // buyer wallet address

        /// <summary>
        /// eShop Id - allow orders in the db to reference multiple shops
        /// </summary>
        public string SellerSysId { get; set; } 

        public DateTimeOffset? PoDate { get; set; }

        public DateTimeOffset OrderDate { get; private set; } = DateTimeOffset.Now;

        public PostalAddress BillTo { get; private set; }
        public PostalAddress ShipTo { get; private set; }

        // DDD Patterns comment
        // Using a private collection field, better for DDD Aggregate's encapsulation
        // so OrderItems cannot be added from "outside the AggregateRoot" directly to the collection,
        // but only through the method Order.AddOrderItem() which includes behavior.
        private readonly List<OrderItem> _orderItems = new List<OrderItem>();

        // Using List<>.AsReadOnly() 
        // This will create a read only wrapper around the private list so is protected against "external updates".
        // It's much cheaper than .ToList() because it will not have to copy all items in a new collection. (Just one heap alloc for the wrapper instance)
        //https://msdn.microsoft.com/en-us/library/e78dcd75(v=vs.110).aspx 
        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems.AsReadOnly();

        public decimal Total()
        {
            var total = 0m;
            foreach (var item in _orderItems)
            {
                total += item.UnitPrice * item.Quantity;
            }
            return total;
        }
    }
}
