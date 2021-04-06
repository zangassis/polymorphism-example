using System;

public class Manager : Tax
{
  public override void MealAllowance(double salary)
  {
    double discountCalculated = 0;

    discountCalculated = salary * 0.012;

    Console.WriteLine("Manager Meal Allowance discount US: {0}", discountCalculated);
  }
  
}