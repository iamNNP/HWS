using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.Metrics;

public class HelloWorld
{
    class Item
    {
        private string name;
        private double weight;
        private int sector;
        public Item(string input_name, double input_weight)
        {
            name = input_name;
            weight = input_weight;
        }
        public int Sector
        {
            set
            {
                sector = value;
            }
            get
            {
                return sector;
            }
        }
        public string GetName()
        {
            return name;
        }
        public double GetWeight()
        {
            return weight;
        }
        public string GetInfo()
        {
            string info = $"Item's '{name}' weight is {weight}";
            return info;
        }
    }
    class Warehouse
    {
        private List<Item> items;
        private int[] sectors;
        public Warehouse(List<Item> input_items, int[] input_sectors)
        {
            items = input_items;
            sectors = input_sectors;
        }
        // Возвращает количество грузов в секторе
        protected int CountSectorItems(int sector)
        {
            int count = 0;
            foreach (Item item in items)
            {
                if (item.Sector == sector)
                {
                    count++;
                }
            }
            return count;
        }
        // Возвращает индекс сектора с минимальным количеством груза
        protected int MinSectorItems(int[] sectors_items)
        {
            int min = 0;
            for (int i = 0; i < sectors_items.Length; i++)
            {
                if (sectors_items[i] < sectors_items[min])
                {
                    min = i;
                }
            }
            return min;
        }
        public bool AddNewItem(Item item)
        {
            int[] sectors_items = new int[sectors.Length];
            for (int i = 0; i < sectors.Length; i++)
            {
                sectors_items[i] = CountSectorItems(sectors[i]);
            }
            int sector_index = MinSectorItems(sectors_items);
            if (sectors_items[sector_index] >= 10)
            {
                return false;
            }
            item.Sector = sectors[sector_index];
            items.Add(item);
            return true;
        }
        public void ShipItem(string name)
        {
            foreach (Item item in items.ToList())
            {
                if (item.GetName() == name)
                {
                    items.Remove(item);
                }
            }
        }
        public Item this[string name]
        {
            get
            {
                foreach (Item item in items)
                {
                    if (item.GetName() == name)
                    {
                        return item;
                    }
                }
                Console.WriteLine("No items with the provided name.");
                return items[0];
            }
        }
        public List<Item> GetAllBySector(int sector)
        {
            List<Item> sector_items = new List<Item>() { };
            foreach (Item item in items)
            {
                if (item.Sector == sector)
                {
                    sector_items.Add(item);
                }
            }
            return sector_items;
        }
        public double GetTotalWeight()
        {
            double total = 0;
            foreach (Item item in items)
            {
                total += item.GetWeight();
            }
            return total;
        }
        public string GetInfo()
        {
            string info = "";
            for (int i = 0; i < sectors.Length; i++)
            {
                info += "Sector " + sectors[i] + ": ";
                foreach (Item item in GetAllBySector(sectors[i]))
                {
                    info += $"({item.GetName()}, {item.GetWeight()}) ";
                }
            }
            return info;
        }
    }
    public static void Main(string[] args)
    {
        Item item1 = new Item("Chocolate", 200);
        item1.Sector = 100;
        Console.WriteLine(item1.GetInfo());
        Item item2 = new Item("Milk", 1000);
        item2.Sector = 101;
        Console.WriteLine(item2.GetInfo());
        Item item3 = new Item("Bread", 500);
        item3.Sector = 102;
        Console.WriteLine(item3.GetInfo());
        Item item4 = new Item("Noodles", 300);
        item4.Sector = 102;
        Console.WriteLine(item4.GetInfo());
        Item item5 = new Item("Tea", 100);
        item5.Sector = 101;
        Console.WriteLine(item5.GetInfo());
        List<Item> input_items = new List<Item>() { item1, item2, item3, item4, item5 };
        int[] input_sectors = new int[3] { 100, 101, 102 };
        Warehouse warehouse = new Warehouse(input_items, input_sectors);
        Console.WriteLine("Initialized warehouse: ");
        Console.WriteLine(warehouse.GetInfo());
        Console.WriteLine("Adding rice: ");
        Item new_item = new Item("Rice", 300);
        warehouse.AddNewItem(new_item);
        Console.WriteLine(warehouse.GetInfo());
        Console.WriteLine("Removing rice: ");
        warehouse.ShipItem("Rice");
        Console.WriteLine(warehouse.GetInfo());
        Console.WriteLine("Chocolate info from an indexator: ");
        Console.WriteLine(warehouse["Chocolate"].GetInfo());
        Console.WriteLine("Items in 101 sector: ");
        foreach (Item sector_item in warehouse.GetAllBySector(101))
        {
            Console.WriteLine(sector_item.GetInfo());
        }
        double total_weight = warehouse.GetTotalWeight();
        Console.WriteLine($"Total weight: {total_weight}");
    }
}