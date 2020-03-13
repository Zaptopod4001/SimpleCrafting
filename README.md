# Simple Crafting System (Unity / C#)

![Simple Crafting image](/doc/simple_crafting_ui.png)

## What is it?

An example how one could setup simple crafting system where user has an inventory of ingredients (kind and amount).

This is a code only example, there are no visuals. 


 

# Steps

User can select a template of an item he would like to craft, and then try to craft it. 

If user ingredient inventory doesn't have required ingredients, crafting will fail. 

If user ingredient inventory has required ingredients, inventory count of ingredients is reduced by the amount item requires.

![Crafting step one](/doc/simple_crafting_step1.png)
 
User is given the crafted item(s).
 
![Crafting step two](/doc/simple_crafting_step2.png)
 
 
# Classes

##  CraftingForge.cs
Main crafting class, can be used to craft items.

## IngredientInventory.cs
An inventory class that contains a list of each collected ingredient king and its count. Add and remove ingredients.

## CraftableItem.cs
Item template that contains information about which ingredients are needed and what the end result will be.


# How to use
Note: there is demo region in CraftingForge.cs which contains sample how to use this system.

First create your craftable item templates:

```C#
// Create item templates (somewhere in your code)
item1 = new CraftableItem("Stone axe");
item1.AddIngredient(Ingredient.Wood, Ingredient.Stone);

item2 = new CraftableItem("Metal shovel");
item2.AddIngredient(Ingredient.Wood, Ingredient.Stone, Ingredient.Metal);
```

Then add ingredients to player ingredient inventory:
```C#
// Add ingredients
inventory.AddItem(Ingredient.Wood);
inventory.AddItem(Ingredient.Wood);
inventory.AddItem(Ingredient.Stone);
inventory.AddItem(Ingredient.Stone);
inventory.AddItem(Ingredient.Leather);
inventory.AddItem(Ingredient.Metal);
```


# About
I created this simple crafting system for myself, as a learning experience.

# Copyright 
Created by Sami S. use of any kind without a written permission from the author is not allowed. But feel free to take a look.
