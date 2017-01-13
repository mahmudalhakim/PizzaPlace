﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaPlace.Entities;

namespace PizzaPlace.Models
{
	public class ViewModel
	{
		public List<Customer> Customers { get; set; }
		public List<Food> Foods { get; set; }
		public List<FoodType> FoodTypes { get; set; }
		public List<Ingredient> Ingredients { get; set; }
		public List<FoodIngredient> FoodIngredients { get; set; }

		public Customer Customer { get; set; }
		public Food Food { get; set; }
		public FoodType FoodType { get; set; }
		public Ingredient Ingredient { get; set; }
		public FoodIngredient FoodIngredient { get; set; }
		public Cart Cart { get; set; }


	}
}