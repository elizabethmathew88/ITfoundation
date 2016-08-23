using System;


struct Database
{
    public int Id;
    public string Name;
    public float Price;
    public int Quantity;
    public float Cost;
    public float Value;

}

namespace My_Project
{
    class Program
    {
        static void Main()
        {
            int index = 0;
            Database[] dbarray = new Database[50];
            Database[] temparray = new Database[1];
            while (true)
            {
            Begin:;
                Console.Write(" 1:Add an item\n 2:Change an item\n 3:Delete an item\n 4:List all items in the database\n 5:List all items in ascending order of its Value\n 6:Quit\n\n Select an option from 1 to 6: ");
                string str = Console.ReadLine();
                int num = int.Parse(str);

                switch (num)
                {
                    case 1:
                        {

                            Console.WriteLine(" ");
                            Console.Write("Enter the item ID: ");
                            string idstr = Console.ReadLine();
                            int idnum = int.Parse(idstr);
                            dbarray[index].Id = idnum;

                            for (int i = 0; i < index; i++)
                            {
                                if (dbarray[i].Id == idnum)
                                {
                                    Console.WriteLine("The Id already exist");
                                    Console.WriteLine(" ");
                                    goto Begin;
                                }
                            }

                            Console.Write("Enter the name of item: ");
                            dbarray[index].Name = Console.ReadLine();

                            Console.Write("Enter the price per item: ");
                            string pricestr = Console.ReadLine();
                            dbarray[index].Price = float.Parse(pricestr);

                            Console.Write("Enter the total quantity: ");
                            string quantitystr = Console.ReadLine();
                            dbarray[index].Quantity = int.Parse(quantitystr);

                            Console.Write("Enter the cost per item: ");
                            string coststr = Console.ReadLine();
                            dbarray[index].Cost = float.Parse(coststr);

                            dbarray[index].Value = dbarray[index].Price * dbarray[index].Quantity;
                            index++;
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(" ");
                            if (index == 0)
                            {
                                Console.WriteLine("There are no items in the database");
                            }
                            else
                            {
                                Console.WriteLine("Item#   Item Id   Item Name    Price    Quantity   Cost     Value");
                                Console.WriteLine("-----   -------   ---------    -----    --------   -----    -----");
                                for (int i = 0; i < index; i++)
                                {

                                    Console.Write("{0,-8}", i + 1);
                                    Console.Write("{0,-10}", dbarray[i].Id);
                                    Console.Write("{0,-13}", dbarray[i].Name);
                                    Console.Write("{0,-9:C}", dbarray[i].Price);
                                    Console.Write("{0,-11}", dbarray[i].Quantity);
                                    Console.Write("{0,-9:C}", dbarray[i].Cost);
                                    Console.Write("{0,-5:C}", dbarray[i].Value);
                                    Console.WriteLine(" ");
                                }
                                Console.WriteLine(" ");

                                Console.Write("Enter the Id of the item to be changed: ");
                                string idstr_change = Console.ReadLine();
                                int idnum_change = int.Parse(idstr_change);
                                bool flag = false;
                                for (int i = 0; i < index; i++)
                                {
                                    if (dbarray[i].Id == idnum_change)
                                    {
                                        flag = true;
                                        int k = i;
                                        Console.Write("Enter the Id of the new item: ");
                                        string idstr_new = Console.ReadLine();
                                        dbarray[k].Id = int.Parse(idstr_new);

                                        Console.Write("Enter the name of item: ");
                                        dbarray[k].Name = Console.ReadLine();

                                        Console.Write("Enter the price per item: ");
                                        string pricestr_new = Console.ReadLine();
                                        dbarray[k].Price = float.Parse(pricestr_new);

                                        Console.Write("Enter the total quantity: ");
                                        string quantitystr_new = Console.ReadLine();
                                        dbarray[k].Quantity = int.Parse(quantitystr_new);

                                        Console.Write("Enter the cost per item: ");
                                        string coststr_new = Console.ReadLine();
                                        dbarray[k].Cost = float.Parse(coststr_new);

                                        dbarray[k].Value = dbarray[k].Price * dbarray[k].Quantity;
                                    }
                                }
                                if (flag == false)
                                {
                                    Console.WriteLine("Id not found");
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(" ");
                            if (index == 0)
                            {
                                Console.WriteLine("There are no items in the database");
                            }
                            else
                            {
                                Console.WriteLine("Item#   Item Id   Item Name    Price    Quantity   Cost     Value");
                                Console.WriteLine("-----   -------   ---------    -----    --------   -----    -----");
                                for (int i = 0; i < index; i++)
                                {

                                    Console.Write("{0,-8}", i + 1);
                                    Console.Write("{0,-10}", dbarray[i].Id);
                                    Console.Write("{0,-13}", dbarray[i].Name);
                                    Console.Write("{0,-9:C}", dbarray[i].Price);
                                    Console.Write("{0,-11}", dbarray[i].Quantity);
                                    Console.Write("{0,-9:C}", dbarray[i].Cost);
                                    Console.Write("{0,-5:C}", dbarray[i].Value);
                                    Console.WriteLine(" ");
                                }
                                Console.WriteLine(" ");

                                Console.Write("Enter the Id of the item to be deleted: ");
                                string idstr_delete = Console.ReadLine();
                                int idnum_delete = int.Parse(idstr_delete);
                                bool flag = false;
                                for (int i = 0; i < index; i++)
                                {
                                    if (dbarray[i].Id == idnum_delete)
                                    {
                                        flag = true;
                                        for (int j = i; j < index; j++)
                                        {
                                            dbarray[i].Id = dbarray[i + 1].Id;
                                            dbarray[i].Name = dbarray[i + 1].Name;
                                            dbarray[i].Price = dbarray[i + 1].Price;
                                            dbarray[i].Quantity = dbarray[i + 1].Quantity;
                                            dbarray[i].Cost = dbarray[i + 1].Cost;
                                            dbarray[i].Value = dbarray[i + 1].Value;

                                        }
                                        Console.WriteLine("Item deleted");
                                        index--;
                                    }

                                }
                                if (flag == false)
                                {
                                    Console.WriteLine("Id not found");
                                }
                            }
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine(" ");
                            if (index == 0)
                            {
                                Console.WriteLine("There are no items in the database");
                            }
                            else
                            {

                                Console.WriteLine("Item#   Item Id   Item Name    Price    Quantity   Cost     Value");
                                Console.WriteLine("-----   -------   ---------    -----    --------   -----    -----");
                                for (int i = 0; i < index; i++)
                                {

                                    Console.Write("{0,-8}", i + 1);
                                    Console.Write("{0,-10}", dbarray[i].Id);
                                    Console.Write("{0,-13}", dbarray[i].Name);
                                    Console.Write("{0,-9:C}", dbarray[i].Price);
                                    Console.Write("{0,-11}", dbarray[i].Quantity);
                                    Console.Write("{0,-9:C}", dbarray[i].Cost);
                                    Console.Write("{0,-5:C}", dbarray[i].Value);
                                    Console.WriteLine(" ");
                                }
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine(" ");
                            if (index == 0)
                            {
                                Console.WriteLine("There are no items in the database");
                            }
                            else
                            {

                                for (int j = 0; j < index; j++)
                                {
                                    for (int k = j + 1; k < index; k++)
                                    {
                                        if (dbarray[j].Value > dbarray[k].Value)
                                        {
                                            temparray[0] = dbarray[j];
                                            dbarray[j] = dbarray[k];
                                            dbarray[k] = temparray[0];
                                        }
                                    }
                                }
                                
                                Console.WriteLine("Item#   Item Id   Item Name    Price    Quantity   Cost     Value");
                                Console.WriteLine("-----   -------   ---------    -----    --------   -----    -----");
                                for (int i = 0; i < index; i++)
                                {

                                    Console.Write("{0,-8}", i + 1);
                                    Console.Write("{0,-10}", dbarray[i].Id);
                                    Console.Write("{0,-13}", dbarray[i].Name);
                                    Console.Write("{0,-9:C}", dbarray[i].Price);
                                    Console.Write("{0,-11}", dbarray[i].Quantity);
                                    Console.Write("{0,-9:C}", dbarray[i].Cost);
                                    Console.Write("{0,-5:C}", dbarray[i].Value);
                                    Console.WriteLine(" ");
                                }
                            }
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Are you sure you want to exit(Y/N)");
                            string abc = Console.ReadLine();
                            if ((abc == "N") || (abc == "n"))
                            {
                                goto Begin;
                            }
                            else
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("Thank you");
                                Console.Write("Press Enter to continue...");
                                Console.ReadLine();
                                break;
                            }
                        }

                    default:
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Invalid option,try again.");
                            break;
                        }
                }
                Console.WriteLine(" ");               
            }
        }
    }
}
