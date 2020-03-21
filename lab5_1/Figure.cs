namespace lab5_1
{
    abstract class Figure //абстрактний клас
    {
        abstract public double P(); //абстрактний метод обчислення периметра 
        abstract public double S(); //абстрактний метод обчислення площі
        abstract public void Show(); //абстрактний метод виведення інформації
                                     //про фігуру на екран
    }
}