﻿namespace NET105_ASM.Models
{
	public class Combo
	{
		public int ComboId { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }
		public string Price { get; set; }

		public ICollection<ComboFastfood> ComboFastfood { get; set; }

	}
}
