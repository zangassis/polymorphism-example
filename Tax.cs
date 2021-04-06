using System;

public class Tax 
{
  public virtual void MealAllowance(double salary)
  {

      double discountCalculated = 0;

      discountCalculated = salary * 0.1;

    Console.WriteLine("Standard Meal Allowance discount US: {0}", discountCalculated);
  }
  
  public virtual void TransitPass(double salary)
  {
      double discountCalculated = 0;

      discountCalculated = salary * 00.6;

    Console.WriteLine("Standard Transit Pass discount US: {0}", discountCalculated);
  }
  
}