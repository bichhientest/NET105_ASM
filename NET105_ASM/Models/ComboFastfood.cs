﻿namespace NET105_ASM.Models
{
	public class ComboFastfood
	{
		public int ComboId { get; set; }
		public Combo Combo { get; set; }

		public int FastfoodId { get; set; }
		public Fastfood Fastfood { get; set; } 
	}
}
