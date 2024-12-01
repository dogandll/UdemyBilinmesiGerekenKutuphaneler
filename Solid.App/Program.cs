#region OCP-Example

//using Solid.App.OCPBad;
//using Solid.App.OCPGood2;

//SalaryCalculator salaryCalculator = new SalaryCalculator();

//Bad Way

//Console.WriteLine($"Low salary :{salaryCalculator.Calculate(1000, SalaryType.Low)}");
//Console.WriteLine($"Medium salary :{salaryCalculator.Calculate(2000, SalaryType.Medium)}");
//Console.WriteLine($"Hight salary :{salaryCalculator.Calculate(3000, SalaryType.High)}");


//Good Way
//Console.WriteLine($"Low salary :{salaryCalculator.Calculate(1000, new LowSalaryCalculate())}");
//Console.WriteLine($"Medium salary :{salaryCalculator.Calculate(2000, new MiddleSalaryCalculate())}");
//Console.WriteLine($"Hight salary :{salaryCalculator.Calculate(3000, new HighSalaryCalculate())}");
//Console.WriteLine($"Manager salary :{salaryCalculator.Calculate(3000, new ManagerSalaryCalculate())}");

//Good Way2
//Console.WriteLine($"Low salary :{salaryCalculator.Calculate(1000, new LowSalaryCalculate().Calculate)}");
//Console.WriteLine($"Medium salary :{salaryCalculator.Calculate(2000, new MiddleSalaryCalculate().Calculate)}");
//Console.WriteLine($"Hight salary :{salaryCalculator.Calculate(3000, new HighSalaryCalculate().Calculate)}");
//Console.WriteLine($"Manager salary :{salaryCalculator.Calculate(3000, new ManagerSalaryCalculate().Calculate)}");

//Delegate kullandığımız için custom değer verebiliyoruz

//Console.WriteLine($"Custom salary :{salaryCalculator.Calculate(3000, x =>
//{
//    return x * 10;
//})}");

#endregion
#region LSP-Example

// Bad
//using Solid.App.LSPBad;

//BasePhone phone = new IPhone();
//phone.Call();
//phone.TakePhoto();

//phone = new Nokia3310();

//phone.Call();
//phone.TakePhoto();

//Good


//using Solid.App.LSPGood;

//BasePhone phone = new IPhone();
//phone.Call();
//((ITakePhoto)phone).TakePhoto();

//phone = new Nokia3310();
//phone.Call();

#endregion
#region DIP-Example 

//Bad

//var ProductService = new ProductService(new ProductRepositoryFromSqlServer());
//ProductService.GetAll().ForEach(x => Console.WriteLine(x));

//Good

using Solid.App.DIPGoodAndBad; 
using static Solid.App.DIPGoodAndBad.ProductGoodService;

var ProductService = new ProductGoodService(new ProductRepositoryFromOracle());
ProductService.GetAll().ForEach(x => Console.WriteLine(x));
#endregion
