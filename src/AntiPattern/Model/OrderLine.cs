using System;

namespace AntiPattern.Model
{
	public class OrderLine
	{
		public int Id { get; set; }
		public Guid Guid { get; set; }
		public int OrderId { get; set; }
		public DepartmentProduct Product { get; set; }
		public ProductionStage State { get; set; }
		public Price Price { get; set; }
		public Price PriceWithoutSaleTax { get; set; }
		public AppliedBonusAction BonusAction { get; set; }
		public string Customizations { get; set; }
		public string[] RemovedIngredients { get; set; }
		public AddedIngredient[] AddedIngredients { get; set; }
		public Half[] Halves { get; set; } = new Half[0];

		public int? DuplicateId { get; set; }
		public Guid DuplicateGuid { get; set; }
		public bool IsCanceled { get; set; }

		public int? ShopWindowCellPosition { get; set; }
		public Guid ShopWindowItemGuid { get; set; }
		public int? ToPieceProductId { get; set; }
		public Guid ToPieceProductGuid { get; set; }
		public Guid ShopWindowCompositionGuid { get; set; }
		public Guid HeadOrderLineGuid { get; set; }


		public ProductionStage? NextState { get; set; }
		public DateTime StartDateTimeCooking { get; set; }
		public DateTime? StartTimeOfRequirements { get; set; }
		public int Version { get; set; }
		public Guid ComboTemplateGuid { get; set; }
		public Guid ComboTemplateLineGuid { get; set; }
		public string ComboTemplateName { get; set; }
		public bool ProductIsBaked { get; set; }
	}
}