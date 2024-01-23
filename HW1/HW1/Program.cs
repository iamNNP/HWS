using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

class Class
{
    public class BankClient
    {
        public string name;
        public decimal balance;

        public static decimal ConvertToRubles(string currency, decimal moneyInCurrency)
        {
            if (currency == "dollar")
            {
                return moneyInCurrency * (decimal)93.65;
            }
            else if (currency == "euro")
            {
                return moneyInCurrency * (decimal)98.88;
            }
            else
            {
                return moneyInCurrency;
            }
        }
    }
    public static void ShowBankClients(BankClient[] bank_clients)
    {
        for (int i = 0; i < bank_clients.Length; i++)
        {
            Console.WriteLine($"{bank_clients[i].name} {bank_clients[i].balance}");
        }
    }
    public static string[] ClientsNames(BankClient[] bank_clients)
    {
        string[] clients_names = new string[bank_clients.Length];
        for (int i = 0; i < bank_clients.Length; i++)
        {
            clients_names[i] = bank_clients[i].name;
        }
        return clients_names;
    }
    public static void AddMoneyToBankClient(ref BankClient[] bank_clients, string name, decimal money, string currency)
    {
        for (int i = 0; i < bank_clients.Length; i++)
        {
            if (bank_clients[i].name == name)
            {
                bank_clients[i].balance = bank_clients[i].balance + BankClient.ConvertToRubles(currency, money);
                Console.WriteLine($"Success! {bank_clients[i].balance}");
            }
        }
    }
    public static void WithdrawMoneyFromClient(ref BankClient[] bank_clients, string name, decimal money, string currency)
    {
        for (int i = 0; i < bank_clients.Length; i++)
        {
            if (bank_clients[i].name == name)
            {
                if (money <= bank_clients[i].balance)
                {
                    bank_clients[i].balance = bank_clients[i].balance - BankClient.ConvertToRubles(currency, money);
                    Console.WriteLine($"Success! {bank_clients[i].balance}");
                }
                else
                {
                    Console.WriteLine("Access denied. Insufficient funds");
                }
            }
        }
    }
    public static void DividentsByPercent(ref BankClient[] bank_clients, int percent)
    {
        for (int i = 0; i < bank_clients.Length; i++)
        {
            bank_clients[i].balance = bank_clients[i].balance + bank_clients[i].balance * percent / 100;
        }
        Console.WriteLine("Success!!!");
    }
    static void Main()
    {
        bool amount_parse_result = int.TryParse(Console.ReadLine(), out int amount);
        if (amount_parse_result)
        {
            BankClient[] bank_clients = new BankClient[amount];
            for (int i = 0; i < amount; i++)
            {
                BankClient client = new BankClient();
                string[] input_data = Console.ReadLine().Split(" ");
                string input_name = input_data[0];
                client.name = input_name;
                bool balance_parse_result = decimal.TryParse(input_data[1], out decimal balance);
                if (balance_parse_result)
                {
                    client.balance = balance;
                    bank_clients[i] = client;
                }
                else
                {
                    Console.WriteLine("Incorrect input data.");
                }
            }
            Console.WriteLine("Success!!!");

            string input = Console.ReadLine();
            while (input != "Exit")
            {
                string[] input_commands = input.Split(" ");
                if (input_commands[0] == "Show")
                {
                    ShowBankClients(bank_clients);
                }
                else if (input_commands[0] == "Add")
                {
                    string[] names = ClientsNames(bank_clients);
                    string name = input_commands[1];
                    bool money_parse_result = decimal.TryParse(input_commands[2], out decimal money);
                    string currency = input_commands[3];
                    if (money_parse_result && names.Contains(name) && (currency == "rub" || currency == "euro" || currency == "dollar"))
                    {
                        AddMoneyToBankClient(ref bank_clients, name, money, currency);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input data. Try again");
                    }
                }
                else if (input_commands[0] == "Withdraw")
                {
                    string[] names = ClientsNames(bank_clients);
                    string name = input_commands[1];
                    bool money_parse_result = decimal.TryParse(input_commands[2], out decimal money);
                    string currency = input_commands[3];
                    if (money_parse_result && names.Contains(name) && (currency == "rub" || currency == "euro" || currency == "dollar"))
                    {
                        WithdrawMoneyFromClient(ref bank_clients, name, money, currency);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input data. Try again");
                    }
                }
                else if (input_commands[0] == "Dividents")
                {
                    bool percent_parse_result = int.TryParse(input_commands[1], out int percent);
                    if (percent_parse_result)
                    {
                        DividentsByPercent(ref bank_clients, percent);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input data. Try again");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect input data. Try again");
                }
                input = Console.ReadLine();
            }
        }
    }
}