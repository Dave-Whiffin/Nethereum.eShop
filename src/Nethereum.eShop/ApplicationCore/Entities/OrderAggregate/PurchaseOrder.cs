﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Nethereum.eShop.ApplicationCore.Entities.OrderAggregate
{
    /*
pragma solidity ^0.6.1;

interface IPoTypes
{
    enum PoItemStatus
    {
        Initial,                // 0  expect never to see this
        PoCreated,              // 1  PO item has been created in the contract                                    | 0->1 managed by buyer waller contract fn call from buyer UI
        PoAcceptedSoCreated,    // 2  PO item has been accepted by the seller and a corresponding SO item created | 1->2 managed by seller wallet contract fn call from seller UI
        GoodsIssue,             // 3  PO item has been posted or issued by the seller                             | 2->3 managed by seller wallet contract fn call from seller UI
        GoodsReceived,          // 4  PO item has been received by the buyer or escrow time exceeded              | 3->4 managed by buyer wallet contract fn call from buyer OR po main contract 30 days or Seller UI
        CompletedPaid,          // 5  PO item is complete and escrow funds released to the buyer wallet           | 4->5 managed by seller wallet contract fn call from seller UI
        CancelledRefund         // 6  PO item has been successfully cancelled and funds refunded to buyer wallet  | 1->6 or 2->6 managed by seller wallet contract fn call from seller UI, at discretion of seller (poss break out into own field of po item payment status)
    }

    enum PoItemCancelStatus
    {
        Initial,                // 0  default to empty, no request made
        RequestMade,            // 1  PO item has had cancellation requested | 0->1 managed by buyer wallet contract fn call from buyer UI
        RequestRejected,        // 2  PO item has had cancellation rejected  | 1->2 managed by seller wallet contract fn call from seller UI 
        RequestAccepted         // 3  PO item has had cancellation accepted  | 1->3 managed by seller wallet contract fn call from seller UI 
    }

    struct PoItem
    {
        uint8 poItemNumber;                // contract managed, PO item key

        bytes32 soNumber;                  // seller system (eg eShop) managed (any numbering allowed, could be same as PO number and PO item)
        bytes32 soItemNumer;               // seller system (eg eShop) managed (any numbering allowed, could be same as PO number and PO item)

        bytes32 productId;                 // buyer UI managed, product id from product registry

        uint32 quantity;                   // buyer UI managed, regular quantity, eg 4
        bytes32 unit;                      // buyer UI managed, regular quantity units, eg PC pieces (TODO are there ISO codes for this?)        
        bytes32 quantityErc20Symbol;       // TODO who manages, symbol of the ERC20 that represents this productId (assume token quantity same as quantity above)
        address quantityErc20Address;      // TODO who manages, contract address of the ERC20 that represents this productId

        uint32 value;                      // buyer UI managed, value in the units of the ERC20 that is making the payment eg DAI has token precision 18, so 1120000000000000000 DAI is 1.12 USD
        bytes32 currencyErc20Symbol;       // buyer UI managed, symbol of the ERC20 that is making payment, eg DAI
        address currencyErc20Address;      // buyer UI managed, contract address of the ERC20 that is making payment 

        PoItemStatus status;               // contract managed for create, then seller system managed
        uint goodsIssueDate;               // contract managed at point of goods issue, the goods issue unix timestamp
        uint escrowReleaseDate;            // contract managed at point of goods issue, it is the goods issue unix timestamp + escrow days eg 30 days        
        PoItemCancelStatus cancelStatus;   // contract managed from buyer UI and seller UI fn calls
    }

    struct Po
    {
        uint poNumber;                     // contract managed, PO header key, leave blank at PO creation time

        address buyerAddress;              // contract managed, buyer EoA address holding currency and "owner" of the PO
        address buyerWalletAddress;        // contract managed, buyer wallet contract address, needed to locate contract when sending events from PoMain contract        
        uint buyerNonce;                   // contract managed, buyer UI assigned. buyerAddress+buyerNonce uniquely identifies a single poNumber

        bytes32 sellerSysId;               // buyer UI managed, allocated by seller system to identify their shop

        uint poCreateDate;                 // buyer UI managed, po creation unix timestamp

        PoItem[] poItems;                  // dynamic array of po items, TODO impose configurable max of eg 16, low enough that contract can iterate all
    }

}
     */

    public class PurchaseOrder
    {
        //[Parameter("uint64", "ethPurchaseOrderNumber", 1)]
        public virtual ulong EthPurchaseOrderNumber { get; set; }

        //[Parameter("bytes32", "buyerSysId", 2)]
        public virtual string BuyerSysId { get; set; }

        //[Parameter("bytes32", "buyerPurchaseOrderNumber", 3)]
        public virtual string BuyerPurchaseOrderNumber { get; set; }

        //[Parameter("bytes32", "buyerViewVendorId", 4)]
        public virtual string BuyerViewVendorId { get; set; }

        //[Parameter("bytes32", "sellerSysId", 5)]
        public virtual string SellerSysId { get; set; }

        //[Parameter("bytes32", "sellerSalesOrderNumber", 6)]
        public virtual string SellerSalesOrderNumber { get; set; }

        //[Parameter("bytes32", "sellerViewCustomerId", 7)]
        public virtual string SellerViewCustomerId { get; set; }

        //[Parameter("bytes32", "buyerProductId", 8)]
        public virtual string BuyerProductId { get; set; }

        //[Parameter("bytes32", "sellerProductId", 9)]
        public virtual string SellerProductId { get; set; }

        //[Parameter("bytes32", "currency", 10)]
        public virtual string Currency { get; set; }
        
        //[Parameter("address", "currencyAddress", 11)]
        public virtual string CurrencyAddress { get; set; }

        //[Parameter("uint32", "totalQuantity", 12)]
        public virtual uint TotalQuantity { get; set; }

        //[Parameter("uint32", "totalValue", 13)]
        public virtual uint TotalValue { get; set; }

        //[Parameter("uint32", "openInvoiceQuantity", 14)]
        public virtual uint OpenInvoiceQuantity { get; set; }

        //[Parameter("uint32", "openInvoiceValue", 15)]
        public virtual uint OpenInvoiceValue { get; set; }

        //[Parameter("uint8", "poStatus", 16)]
        public virtual byte PoStatus { get; set; }

        //[Parameter("uint8", "wiProcessStatus", 17)]
        public virtual byte WiProcessStatus { get; set; }
    }

    public enum SalesOrderStatus
    {
        CreationNotAttempted,
        SalesOrderApproved,
        CancellationApproved,
        Blocked,
        Completed
    }

    public class ErpSalesOrderData 
    {
        public string SellerSysId { get; }
        public string SalesOrderNumber { get; }
        /// <summary>
        /// Global Purchase Order number will be called Buyer Reference number or similar in the source seller system
        /// This is a ulong formatted as string, max 20 chars long
        /// </summary>
        public string BuyerReferenceNumber { get; }
        public string SellerProductId { get; }
        public string SellerCustomerNumber { get; }
        public decimal TotalValue { get; }
        public string Currency { get; }
        public decimal TotalQuantity { get; }
        public string Units { get; }
        public SalesOrderStatus Status { get; }
    }

}
