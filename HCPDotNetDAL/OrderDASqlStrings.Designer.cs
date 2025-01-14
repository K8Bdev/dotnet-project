﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HCPDotNetDAL {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class OrderDASqlStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal OrderDASqlStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HCPDotNetDAL.OrderDASqlStrings", typeof(OrderDASqlStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select IFNULL(SUM(IFNULL(availableQuantity,0)),0) as Quantity from sv_inventory where Sku =@sku.
        /// </summary>
        internal static string ActualOnHandCountSql {
            get {
                return ResourceManager.GetString("ActualOnHandCountSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select IFNULL(SUM(IFNULL(availableQuantity,0)),0) as Quantity from sv_inventory where Sku = @sku;.
        /// </summary>
        internal static string AvailableQuantityFromSkuVaultBySkuSql {
            get {
                return ResourceManager.GetString("AvailableQuantityFromSkuVaultBySkuSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE FROM `dotnet`.`partpurchase` WHERE `OrderCount` = 0.
        /// </summary>
        internal static string DeleteAllPartPurchasesWithOrderCountZeroSql {
            get {
                return ResourceManager.GetString("DeleteAllPartPurchasesWithOrderCountZeroSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE FROM `dotnet`.`partpurchase` WHERE `PartPurchaseId` = @partPurchaseId.
        /// </summary>
        internal static string DeletePartPurchaseSql {
            get {
                return ResourceManager.GetString("DeletePartPurchaseSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select 
        ///pp1.PartPurchaseId,
        ///pp1.PO_Number,
        ///pp1.PartNumber,
        ///pp1.OrderCount,
        ///pp1.OrderDateTime,
        ///pp1.OrderStatus,
        ///pp1.DotNetQtyOnHand,
        ///pp1.DotNetNetQtyOnHand,
        ///pp1.DotNetListPrice,
        ///pp1.DotNetYourCost,
        ///pp1.DotNetTAMSErrorMsg,
        ///pp1.Comments 
        ///from `dotnet`.`partpurchase` pp1 
        ///INNER JOIN
        ///(SELECT PO_Number, PartNumber, Count(1) 
        ///FROM `dotnet`.`partpurchase`
        ///GROUP BY PO_Number, PartNumber
        ///Having Count(1) &gt; 1) pp2 ON pp1.PO_Number = pp2.PO_Number and pp1.PartNumber = pp2.PartNumber
        ///order by pp1.PO_Number,pp1.PartN [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GetAllPartPurchasesSql {
            get {
                return ResourceManager.GetString("GetAllPartPurchasesSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT DISTINCT PO_Number from `dotnet`.`partpurchase` where OrderStatus = @orderStatus.
        /// </summary>
        internal static string GetDistinctPONumbersByOrderStatusSql {
            get {
                return ResourceManager.GetString("GetDistinctPONumbersByOrderStatusSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select InvoiceSummaryId from `dotnet`.`smp_invoicesummary`
        ///WHERE PO_Number = @po_Number AND InvoiceNumber = @invoiceNumber LIMIT 1.
        /// </summary>
        internal static string GetInvoiceSummaryIdByPoNumberAndInvoiceNumberSql {
            get {
                return ResourceManager.GetString("GetInvoiceSummaryIdByPoNumberAndInvoiceNumberSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select InvoiceSummaryId from `dotnet`.`smp_invoicesummary`
        ///WHERE PO_Number = @po_Number AND InvoiceNumber = &apos;NOINVOICE&apos; LIMIT 1.
        /// </summary>
        internal static string GetInvoiceSummaryIdWithBlankInvoiceByPoNumberSql {
            get {
                return ResourceManager.GetString("GetInvoiceSummaryIdWithBlankInvoiceByPoNumberSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM `dotnet`.`smp_manualpurchaseorders` WHERE ProcessingStatus = @processingStatus;.
        /// </summary>
        internal static string GetManualPurchaseOrdersByStatus {
            get {
                return ResourceManager.GetString("GetManualPurchaseOrdersByStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select psim.*, p.PartNumber, p.AutoOrderEnabled, psm.PackageQuantity from `dotnet`.`partskuinventorymetrics` psim
        ///INNER JOIN `dotnet`.`partskumaster` psm ON psim.SKU = psm.SKU
        ///INNER JOIN `dotnet`.`parts` p ON psm.PartNumber = p.PartNumber .
        /// </summary>
        internal static string GetPartInventorySkuMetricQueryPredicate {
            get {
                return ResourceManager.GetString("GetPartInventorySkuMetricQueryPredicate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT pit.*,p.AutoOrderEnabled 
        ///FROM `dotnet`.`partinventorytarget` pit 
        ///INNER JOIN `dotnet`.`parts`p on pit.PartNumber = p.PartNumber 
        ///WHERE pit.OrderCountOverride &gt; 0.
        /// </summary>
        internal static string GetPartInventoryTargetWithOrderCountOverrideSql {
            get {
                return ResourceManager.GetString("GetPartInventoryTargetWithOrderCountOverrideSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select PartPurchaseId,
        ///PO_Number,
        ///PartNumber,
        ///OrderCount,
        ///OrderDateTime,
        ///OrderStatus,
        ///DotNetQtyOnHand,
        ///DotNetNetQtyOnHand,
        ///DotNetListPrice,
        ///DotNetYourCost,
        ///DotNetTAMSErrorMsg,
        ///Comments
        ///from `dotnet`.`partpurchase` where PO_Number = @po_Number;.
        /// </summary>
        internal static string GetPartPurchasesByPONumber {
            get {
                return ResourceManager.GetString("GetPartPurchasesByPONumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select PartRecevingId,ReceivingStatus from `dotnet`.`smp_partreceiving`
        ///WHERE PO_Number = @po_Number AND PartNumber = @partNumber AND InvoiceNumber = @invoiceNumber LIMIT 1.
        /// </summary>
        internal static string GetPartReceivingIdByPoNumberAndPartNumberAndInoviceNumberSql {
            get {
                return ResourceManager.GetString("GetPartReceivingIdByPoNumberAndPartNumberAndInoviceNumberSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select PartRecevingId from `dotnet`.`smp_partreceiving`
        ///WHERE PO_Number = @po_Number AND PartNumber = @partNumber AND InvoiceNumber = &apos;NOINVOICE&apos; LIMIT 1.
        /// </summary>
        internal static string GetPartReceivingIdWithBlankInvoiceByPoNumberAndPartNumberSql {
            get {
                return ResourceManager.GetString("GetPartReceivingIdWithBlankInvoiceByPoNumberAndPartNumberSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO `dotnet`.`smp_invoicesummary`
        ///(
        /// StoreID, PO_Number, InvoiceNumber,
        /// TransactionType, ErrorMsg, InvoiceTotal,
        /// InvoiceDate, CounterPersonID, SalesPersonID,
        /// OtherCharges, NonTaxableTotal, TaxableTotal,
        /// Tax1Total, Tax2Total, AdjustmentTotal, Attention
        ///)
        ///VALUES
        ///(
        /// @storeID, @po_Number, @invoiceNumber,
        /// @transactionType, @errorMsg, @invoiceTotal,
        /// @invoiceDate,  @counterPersonID, @salesPersonID,
        /// @otherCharges, @nonTaxableTotal, @taxableTotal,
        /// @tax1Total, @tax2Total, @adjustmentTotal, [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InsertInvoiceSummarySql {
            get {
                return ResourceManager.GetString("InsertInvoiceSummarySql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO `dotnet`.`partpurchase`
        ///(
        ///PO_Number,
        ///PartNumber,
        ///OrderCount,
        ///OrderDateTime,
        ///OrderStatus,
        ///DotNetQtyOnHand,
        ///DotNetNetQtyOnHand,
        ///DotNetPriceType,
        ///DotNetListPrice,
        ///DotNetYourCost,
        ///DotNetTAMSErrorMsg,
        ///Comments,
        ///OrderCountOverriden
        ///)
        ///VALUES
        ///(
        ///@po_Number,
        ///@partNumber,
        ///@orderCount,
        ///@orderDateTime,
        ///@orderStatus,
        ///@dotnetQtyOnHand,
        ///@dotnetNetQtyOnHand,
        ///@dotnetPriceType,
        ///@dotnetListPrice,
        ///@dotnetYourCost,
        ///@dotnetTAMSErrorMsg,
        ///@comments,
        ///@orderCountOverriden
        ///);.
        /// </summary>
        internal static string InsertPartPurchaseSql {
            get {
                return ResourceManager.GetString("InsertPartPurchaseSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO `dotnet`.`smp_partreceiving`
        ///(
        /// PO_Number, PartNumber, OrderCount, InvoiceNumber,
        /// ReportedShippedcount, ActualReceivedCount, ReportVsActualDiff,
        /// ReceivedDateTime, ReceivingStatus, ReceivingNotes,
        /// UnitPrice, Taxed, InvoiceMsgLine
        ///)
        ///VALUES
        ///(
        /// @po_Number, @partNumber, @orderCount, @invoiceNumber,
        /// @reportedShippedcount, @actualReceivedCount, @reportVsActualDiff,
        /// @receivedDateTime, @receivingStatus, @receivingNotes,
        /// @unitPrice, @taxed, @invoiceMsgLine
        ///);.
        /// </summary>
        internal static string InsertPartReceivingSql {
            get {
                return ResourceManager.GetString("InsertPartReceivingSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select PartNumber,OrderStatus,IFNULL(SUM(IFNULL(OrderCount,0)),0) as OrderCount from dotnet.partpurchase
        ///WHERE OrderStatus in (&apos;##OnOrder##&apos;,&apos;##InTransit##&apos;)
        ///GROUP BY PartNumber,OrderStatus;.
        /// </summary>
        internal static string OnOrderInTransitCountSql {
            get {
                return ResourceManager.GetString("OnOrderInTransitCountSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select count(1) as Quantity from 
        ///(
        ///Select OrderNumber from dotnet.ss_orders where item1Sku = @sku and orderStatus  in (&apos;shipped&apos;,&apos;awaiting_shipment&apos;,&apos;on_hold&apos;) and orderDate &gt;= @cutoffDate
        ///union
        ///Select OrderNumber from dotnet.ss_orders where item2Sku = @sku and orderStatus  in (&apos;shipped&apos;,&apos;awaiting_shipment&apos;,&apos;on_hold&apos;) and orderDate &gt;= @cutoffDate
        ///union
        ///Select OrderNumber from dotnet.ss_orders where item3Sku = @sku and orderStatus  in (&apos;shipped&apos;,&apos;awaiting_shipment&apos;,&apos;on_hold&apos;) and orderDate &gt;= @cutoffDate
        ///union
        ///Se [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string OrderCountBySkuAndSalesVelocityInDaysSql {
            get {
                return ResourceManager.GetString("OrderCountBySkuAndSalesVelocityInDaysSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT SUM(IFNULL(sumTable.Quantity,0)) as Quantity FROM 
        ///(Select IFNULL(Sum(IFNULL(item1Quantity,0)),0) as Quantity from ss_orders where item1Sku = @sku and orderStatus  in (&apos;shipped&apos;,&apos;awaiting_shipment&apos;,&apos;on_hold&apos;) and orderDate &gt;= @cutoffDate
        ///UNION
        ///Select IFNULL(Sum(IFNULL(item2Quantity,0)),0) as Quantity from ss_orders where item2Sku = @sku and orderStatus  in (&apos;shipped&apos;,&apos;awaiting_shipment&apos;,&apos;on_hold&apos;) and orderDate &gt;= @cutoffDate
        ///UNION
        ///Select IFNULL(Sum(IFNULL(item3Quantity,0)),0) as Quantity from s [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string OrderQuantityBySkuAndSalesVelocityInDaysSql {
            get {
                return ResourceManager.GetString("OrderQuantityBySkuAndSalesVelocityInDaysSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE `dotnet`.`partinventorytarget`SET OrderCountOverride = 0 where PartNumber = @partNumber.
        /// </summary>
        internal static string ResetPartInventoryTargetOrderCountOverrideSql {
            get {
                return ResourceManager.GetString("ResetPartInventoryTargetOrderCountOverrideSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE `dotnet`.`smp_invoicesummary`
        ///SET 
        ///	StoreID = @storeID,  
        ///	InvoiceNumber = @invoiceNumber,
        ///	TransactionType = @transactionType, 
        ///	ErrorMsg = @errorMsg,
        ///	InvoiceTotal = @invoiceTotal,
        ///	InvoiceDate = @invoiceDate,
        ///	CounterPersonID = @counterPersonID,
        ///	SalesPersonID = @salesPersonID,
        ///	OtherCharges = @otherCharges,
        ///	NonTaxableTotal = @nonTaxableTotal,
        ///	TaxableTotal = @taxableTotal,
        ///	Tax1Total = @tax1Total,
        ///	Tax2Total = @tax2Total, 
        ///	AdjustmentTotal = @adjustmentTotal, 
        ///	Attention = @attenti [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string UpdateInvoiceSummarySql {
            get {
                return ResourceManager.GetString("UpdateInvoiceSummarySql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE `dotnet`.`smp_manualpurchaseorders` SET ProcessingStatus = @processingStatus, ProcessedDate = @processedDate WHERE ManualPurchaseOrderId = @manualPurchaseOrderId.
        /// </summary>
        internal static string UpdateManualPurchaseOrderStatus {
            get {
                return ResourceManager.GetString("UpdateManualPurchaseOrderStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE `dotnet`.`partpurchase` SET Comments = @comments WHERE PartPurchaseId = @partPurchaseId.
        /// </summary>
        internal static string UpdatePartPurchaseComments {
            get {
                return ResourceManager.GetString("UpdatePartPurchaseComments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE `dotnet`.`partpurchase` 
        ///SET 
        ///OrderCount = @orderCount, 
        ///DotNetQtyOnHand = @dotnetQtyOnHand,
        ///DotNetNetQtyOnHand = @dotnetNetQtyOnHand
        ///WHERE `PartPurchaseId` = @partPurchaseId.
        /// </summary>
        internal static string UpdatePartPurchaseCounts {
            get {
                return ResourceManager.GetString("UpdatePartPurchaseCounts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE `dotnet`.`partpurchase` SET OrderStatus = @orderStatus WHERE PartPurchaseId = @partPurchaseId.
        /// </summary>
        internal static string UpdatePartPurchaseOrderStatusSql {
            get {
                return ResourceManager.GetString("UpdatePartPurchaseOrderStatusSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE `dotnet`.`smp_partreceiving`
        ///SET
        ///	InvoiceNumber = @invoiceNumber,
        ///	ReportedShippedcount = @reportedShippedcount, 
        ///	UnitPrice = @unitPrice, 
        ///	Taxed = @taxed, 
        ///	InvoiceMsgLine = @invoiceMsgLine
        ///WHERE PartRecevingId = @partReceivingID;.
        /// </summary>
        internal static string UpdatePartReceivingSql {
            get {
                return ResourceManager.GetString("UpdatePartReceivingSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE dotnet.partskuinventorymetrics psim
        ///INNER JOIN dotnet.partskumaster psm ON psim.SKU = psm.SKU
        /// SET psim.OrderingStatus = @orderingStatus, psim.OrderDate = LOCALTIME() 
        ///WHERE psm.PartNumber = @partNumber.
        /// </summary>
        internal static string UpdatePartSkuInventoryMetricOrderingStatusByPartSql {
            get {
                return ResourceManager.GetString("UpdatePartSkuInventoryMetricOrderingStatusByPartSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE `dotnet`.`partskuinventorymetrics` SET
        ///ActualOnHand_SKU = @actualOnHand_SKU,
        ///ActualOnHand_Part = @actualOnHand_Part,
        ///LeadTimeInDays = @leadTimeInDays,
        ///OnOrder_SKU = @onOrder_SKU,
        ///OnOrder_Part = @onOrder_Part,
        ///InTransit_SKU = @inTransit_SKU,
        ///InTransit_Part = @inTransit_Part,
        ///IncomingUnits_SKU = @incomingUnits_SKU,
        ///IncomingUnits_Part = @incomingUnits_Part,
        ///DaysInStock = @daysInStock,
        ///QuantitySoldInLastXDays_SKU = @quantitySoldInLastXDays_SKU,
        ///QuantitySoldInLastXDays_Part = @quantitySoldInLast [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string UpdatePartSkuInventoryMetricSql {
            get {
                return ResourceManager.GetString("UpdatePartSkuInventoryMetricSql", resourceCulture);
            }
        }
    }
}
