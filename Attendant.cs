using System;

public class Attendant : Tax
{
  public override void MealAllowance(double salary)
  {
    double discountCalculated = 0;

    discountCalculated = salary * 0.12;

    Console.WriteLine("Attendant Meal Allowance discount US: {0}", discountCalculated);
  }
}