using System;
using System.Collections.Generic;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> Items = new List<Item>{
                new Item {Name = "+5 Dexterity Vest ", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0}
                /*
                new Item {Name = "Elixir of the Mongoose ", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros ", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros ", SellIn = -1, Quality = 80},
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
				// this conjured item does not work properly yet
				new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            */
            }; 

            var app = new GildedRose(Items);


            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------------- Dia " + i + " ---------------");
                
                for (var j = 0; j < Items.Count; j++)
                {
                    Console.WriteLine("Nome: {0}", Items[j].Name);
                    Console.WriteLine("Dias Para vender: {0}",Items[j].SellIn);
                    Console.WriteLine("Qualidade: {0}",Items[j].Quality);
                    Console.WriteLine("\n---------------------------------------------------------\n");
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }

        }
        
    }
}
