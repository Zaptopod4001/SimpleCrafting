using System.Collections;
using UnityEngine;

namespace Eses.SimpleCrafting
{
    
    // Copyright Sami S.

    // use of any kind without a written permission 
    // from the author is not allowed.

    // DO NOT:
    // Fork, clone, copy or use in any shape or form.

    public class CraftingForge : MonoBehaviour
    {
        [Header("Item templates")]
        public CraftableItem item1;
        public CraftableItem item2;

        [Header("Player ingredient inventory")]
        public IngredientInventory inventory;


        void Start()
        {
            // Demo
            // Disable later steps to see the process
            FillInventory();
            CreateItemTemplates();
            CraftDemoItems();
        }


        #region demo

        void FillInventory()
        {
            inventory.AddItem(Ingredient.Wood);
            inventory.AddItem(Ingredient.Wood);
            inventory.AddItem(Ingredient.Stone);
            inventory.AddItem(Ingredient.Stone);
            inventory.AddItem(Ingredient.Leather);

            // disable to prevent item2 crafting
            inventory.AddItem(Ingredient.Metal);
        }

        void CreateItemTemplates()
        {
            item1 = new CraftableItem("Stone axe");
            item1.AddIngredient(Ingredient.Wood, Ingredient.Stone);

            item2 = new CraftableItem("Metal shovel");
            item2.AddIngredient(Ingredient.Wood, Ingredient.Stone, Ingredient.Metal);
        }

        void CraftDemoItems()
        {
            Debug.Log("Trying to Craft items");

            if (HasIngredientsFor(item1))
            {
                CraftItem(item1);
            }
            else
            {
                Debug.Log("You are missing ingredients to craft: " + item1.name);
            }

            if (HasIngredientsFor(item2))
            {
                CraftItem(item2);
            }
            else
            {
                Debug.Log("You are missing ingredients to craft: " + item2.name);
            }
        }

        #endregion



        // Worker methods ------

        public bool HasIngredientsFor(CraftableItem item)
        {
            foreach (var ingredient in item.ingredients)
            {
                var found = inventory.ingredients.Find((i) => i.kind == ingredient);

                if (found == null)
                {
                    return false;
                }
            }

            return true;
        }

        public GameObject CraftItem(CraftableItem item)
        {
            foreach (var ingredient in item.ingredients)
            {
                inventory.TakeItem(ingredient);
                Debug.Log("Used:" + ingredient);
            }

            // Item, normally would 
            // return some item asset
            var craftedItem = new GameObject(item.name);

            Debug.Log("Successfully crafted: " + craftedItem.name);

            return craftedItem;
        }

    }

}
