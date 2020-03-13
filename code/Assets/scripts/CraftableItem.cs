using System.Collections.Generic;
using UnityEngine;

namespace Eses.SimpleCrafting
{
    
    // Copyright Sami S.

    // use of any kind without a written permission 
    // from the author is not allowed.

    // DO NOT:
    // Fork, clone, copy or use in any shape or form.

    [System.Serializable]
    public class CraftableItem
    {
        public string name;
        public List<Ingredient> ingredients = new List<Ingredient>();
        public GameObject item;

        public CraftableItem(string name)
        {
            this.name = name;
        }

        public void AddIngredient(params Ingredient[] components)
        {
            foreach (var item in components)
            {
                ingredients.Add(item);
            }
        }

    }

}
