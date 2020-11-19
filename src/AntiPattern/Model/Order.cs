using System;
using System.Collections.Generic;

namespace AntiPattern.Model
{
	public class Order
	{
		public int Id { get; set; }
		public Guid Guid { get; set; }
		public int Version { get; set; }
		public long ShiftId { get; set; }
		public UnitShortInfo Unit { get; set; }
		public int OrderNumber { get; set; }
		public int BoxQuantity { get; set; }
		public OrderType Type { get; set; }
		public OrderSource Source { get; set; }
		public OrderState State { get; set; }
		public OrderStandards Standart { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime DateOfReceipt { get; set; }
		public DateTime? ExecutionDate { get; set; }
		public Price Price { get; set; }

		public Price PriceWithoutSaleTax { get; set; }
		public decimal RawPrice { get; set; }
		public PaymentType PaymentType { get; set; }
		public string PaymentCardTransId { get; set; }
		public string PaymentId { get; set; }
		public decimal? Note { get; set; }
		public ClientAddress ClientAddress { get; set; }
		public Client Client { get; set; }
		public Employee Courier { get; set; }
		public AppliedBonusAction BonusAction { get; set; }
		public OrderLine[] Composition { get; set; }
		public RegisteredPromoCode PromoCode { get; set; }
		public bool IsBlocked { get; set; }
		public CashBox CashBox { get; set; }
		public int? EmployeeId { get; set; }

		public string DeviceId { get; set; }
		public int TaskId { get; set; }
		public int CheckId { get; set; }
		public int? CashBoxSessionId { get; set; }
		public DateTime? CheckPrintDateTime { get; set; }
		public DateTime? ModifiedDateTime { get; set; }
		public int? ModifiedByEmployeeId { get; set; }
		public DateTime? SendOnDeliveryDate { get; set; }
		public int CreatedByUserId { get; set; }

		public string OrderEmail { get; set; }

		public int? LocalityId { get; set; }
		public Guid LocalityGuid { get; set; }

		public int? DefectedOrderId { get; set; }
		public Guid DefectedOrderGuid { get; set; }

		public int? TableNumber { get; set; }
	}
}

	