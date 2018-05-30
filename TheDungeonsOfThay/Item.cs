﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDungeonsOfThay
{
    public class Item : IItem
    {
        public Item(string onPickUp, string name, float GoldValue, int quantity, float weight, string effect, string lore)
        {
            this.OnPickUp = onPickUp;
            this.Name = name;
            this.GoldValue = GoldValue;
            this.Quantity = quantity;
            this.Weight = weight;
            this.Effect = effect;
            this.Lore = lore;


        }
        public string OnPickUp { get; set; }
        public float Weight { get; set; }
        public float GoldValue { get; set; }
        public int Quantity { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Effect { get; set; }
        public string Lore { get; set; }
        public string Ondrop { get; set; }


            public string GainItem()
            {
            return $"You've added {Name} into your inventory. \nWeight: {Weight} \nValue:{GoldValue}"; // add logic to pick up and add to inventory
        }
            public string DropItem()
            {
            return $"You've dropped {Name}."; // remove item from inventory

            }

            public string Inspect()
            {
            return $"Name:{Name} Value:{GoldValue} Quantity:{Quantity} Weight:{Weight} Effect:{Effect} Lore{Lore} "; // add logic to inspect
        }



        }
    }
