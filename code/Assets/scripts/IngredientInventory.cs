using System.Collections.Generic;
using UnityEngine;

namespace Eses.SimpleCrafting
{
    
    // Copyright Sami S.

    // use of any kind without a written permission 
    // from the author is not allowed.

    // DO NOT:
    // Fork, clone, copy or use in any shape or form.

    public enum Ingredient
    {
        None,
        Wood,
        Stone,
        Metal,
        Leather
    }

    [System.Serializable]
    public class IngredientCount
    {
        public Ingredient kind;
        public int amount;
    }


    [System.Serializable]
    public class IngredientInventory
    {
        public List<IngredientCount> ingredients = new List<IngredientCount>();


        // Worker methods

        public bool Contains(Ingredient ingredient)
        {
            var item = ingredients.Find((i) => i.kind == ingredient);

            return item != null;
        }

        public void AddItem(Ingredient ingredient)
        {
            var item = ingredients.Find((i) => i.kind == ingredient);

            if (item != null)
            {
                item.amount++;
            }
            else
            {
                var newItem = new IngredientCount { kind = ingredient, amount = 1 };
                ingredients.Add(newItem);
            }
        }

        public Ingredient TakeItem(Ingredient ingredient)
        {
            var item = ingredients.Find((i) => i.kind == ingredient);

            item.amount--;

            if (item.amount <= 0)
            {
                ingredients.Remove(item);
            }

            return item.kind;
        }

    }

}
