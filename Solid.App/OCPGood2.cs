namespace Solid.App.OCPGood2
{

    //Open - Closed Principle (Açık kapalı prensibi) - İyi Kod
    //Yeni bir maaş tipi geldiği zaman mevcut kod üzerinde değişiklik yapmadan  mesela manager maaş tipi eklenecek aşağıdaki gibi class oluşuturup ekleyebiliriz.



    public class LowSalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 2;
        }
    }
    public class MiddleSalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 4;
        }
    }
    public class HighSalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 6;
        }
    }
    public class ManagerSalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 10;
        }
    }

    public class SalaryCalculator
    {
        //Action Delegate -> parametre almayan void değer döndüren
        //Predicate -> parametre alan geriye bool dönen
        //Func -> parametre alan geriye istediğimiz dönebiliriz

        public decimal Calculate(decimal salary, Func<decimal, decimal> calculateDelegate)
        {
            return calculateDelegate(salary);

        }
    }
}
