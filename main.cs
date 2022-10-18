using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class Program
{
  public static void Main() {
    
    string[] months = new string[12] 
    {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul","Aug","Sep","Oct","Nov","Dec"};

  Random rnd = new Random();

  int month = rnd.Next(1,13);

  Console.WriteLine("Month is {0}", months[month-1]);
  RangeTest(); 
  RoundTest();
  Truncate();
  Length("Hello");
  Letter("Hello", 0);
  SubString("Hello", 2, 2);
  Combine("Hello", "World");
  Conversion("17.23");
  ConversionToInt("7");
}
  public static void RangeTest() {

  IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x* x);

    foreach(int num in squares) {
    Console.WriteLine(num);
    }
  }
  public static void RoundTest() {
    float originalNumber1 = 1.23f;
    float originalNumber2 = 3.15f;
    float originalNumber3 = 1.9f;

    float roundednumber1 = (float)Math.Ceiling(originalNumber1);
    float roundednumber2 = (float)Math.Round(originalNumber2, 1);
    float roundednumber3 = (float)Math.Floor(originalNumber3);

    Console.WriteLine("roundedNumber1 is " + roundednumber1);
    Console.WriteLine("roundedNumber2 is " + roundednumber2);
    Console.WriteLine("roundedNumber3 is " + roundednumber3);
  }
  public static void Truncate () {
    decimal decimalNumber;
    decimalNumber = 32.7865m;
    Console.WriteLine(Math.Truncate(decimalNumber));
    decimalNumber = -32.9012m;
    Console.WriteLine(Math.Truncate(decimalNumber));
  }
  public static void Length(string str) {
    int length;
    length = str.Length;
    Console.WriteLine("{0} is {1} characters long.", str, length);
  }
  public static void Letter(string str, int whichLetter) {
    char singleLetter;
    singleLetter = str[whichLetter];
    Console.WriteLine("Character {0} of {1} is {2}", whichLetter, str, singleLetter);
  }
  public static void SubString(string str, int startPos, int howMany) {
    string subString;
    subString = str.Substring(startPos, howMany);
    Console.WriteLine("Substring is {0}", subString);
  }
  public static void Combine(string str, string str1) {
    string combined;
    combined = str + " " + str1;
    Console.WriteLine("Joined saying is {0}", combined);
  }
  public static void Conversion(string str) {
    float myNumber = 0;
    myNumber = float.Parse(str);
    Console.WriteLine("My number, 100 times bigger is {0}", myNumber * 100);
  }
  public static void ConversionToInt(string str) {
    int myNumber = 0;
    myNumber = int.Parse(str);
    Console.WriteLine("My number, subtract 1 is {0}", myNumber - 1);
  }
  
}