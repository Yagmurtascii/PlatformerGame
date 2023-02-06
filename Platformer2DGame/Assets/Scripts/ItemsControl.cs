using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platform
{
    public enum Items
    {
        Coin,
        Health,
        Diamond,
    }

    public class ItemsControl : MonoBehaviour
    {
        public static ItemsControl items;
        public Items Type;
        public int Amount;
    }
}
