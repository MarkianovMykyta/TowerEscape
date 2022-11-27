﻿using Items;
using UnityEngine;
using UnityEngine.UI;

namespace Inventory
{
    public class ClosestItemSlotView : MonoBehaviour
    {
        [SerializeField] private Image _icon;
        
        public ItemData Item { get; private set; }

        public void Init(ItemData item)
        {
            Item = item;
            
            _icon.sprite = item.Icon;
        }
    }
}