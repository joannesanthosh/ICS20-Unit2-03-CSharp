// Created by: Joanne Santhosh
// Created on: Mar 2022
//
// This program provides your address

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This program provides your address
        int streetNumber;
        string streetName;
        Console.WriteLine("This program gets a user's street number and street name.");
        Console.WriteLine("");

        Console.WriteLine("Enter your street number.");
        streetNumber = (Convert.ToInt32(Console.ReadLine()));
        Console.Write("Enter your street name. ");
        streetName = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine("Your info is: " + streetNumber + " " + streetName + " ");

        Console.WriteLine("\nDone.");
    }
}