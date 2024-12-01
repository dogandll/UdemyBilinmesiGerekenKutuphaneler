namespace Solid.App.OCPBad
{

    //Open - Closed Principle (Açık kapalı prensibi) - Kötü Kod
    //Yeni bir maaş tipi geldiği zaman mevcut kod üzerinde değiştirdiğimiz için bu prensibi ihlal etmektedir.
    // Business (iş süreçleri) değiştiği zaman da aşağıdaki kod sürekli değişecek ve gelişime açık değişime kapalı olan bu prensip ihlal edilecek.

    public class SalaryCalculator
    {
        public decimal Calculate(decimal salary, SalaryType salaryType)
        {
            decimal newSalary = 0;
            switch (salaryType)
            {
                case SalaryType.Low:
                    newSalary = salary * 2;
                    break;
                case SalaryType.Medium:
                    newSalary = salary * 4;
                    break;
                case SalaryType.High:
                    newSalary = salary * 6;
                    break;
                default:
                    break;
            }
            return newSalary;
        }
    }

    public enum SalaryType
    {
        Low,
        Medium,
        High
    }
}
