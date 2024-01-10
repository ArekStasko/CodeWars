using CodeWars;
using CodeWars.ArrayHelpers;
using CodeWars.FormatNumber;
using CodeWars.MissingArray;

Console.WriteLine("Should be: 3");
Console.WriteLine(MissingArray.GetLengthOfMissingArray(new object[][] { null, new object[] { 4, 5, 1, 1 }, new object[] { 1 }, new object[] { 5, 6, 7, 8, 9 }} ));