﻿using System.Collections.Generic;
using Assets.Scripts.InventoryFolder;
using Assets.Scripts.InventoryFolder.CraftFolder;
using UnityEngine;

namespace Assets.Script.InventoryFolder
{
    public enum EItemState
    {
        None,
        Inventory,
        Drop,
        Armor   
    }

    public class ComponentItem : MonoBehaviour
    {
        public int ID { get; set; }
        public Sprite Icon { get; set; }
        public string Name { get; set; }
        public EType Type { get; set; }
        public ESubtype Subtype { get; set; }
        public EProfession EProfession { get; set; }
        public List<ItemStats> ItemStats { get; set; }
        public int Chance { get; set; }
        public List<CraftItem> CraftItems { get; set; }
        public int Loot { get; set; }
        public int Quantity { get; set; }
        public int MaximumStack { get; set; }
        public int ActualStack { get; set; }
        public uint BuyPrice { get; set; }
        public uint SellPrice { get; set; }
        public int ProfesionLevelNeed { get; set; }
        public int ProfesionExperiences { get; set; }
        public GameObject CraftingObject { get; set; }
        public EItemState EItemState { get; set; }
        private void Start()
        {

        }


       /* public static NewItem ComponentItemToNewItem(int id)
        {
            return new NewItem(NewItem.IdToItem(id));
        }*/
    }
}