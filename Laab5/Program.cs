using System;

/// <summary>
///  Интерфейс Animal
/// <param name="MakeSound">Метод, позволяющий выводить звук животкого</param>
/// </summary>
interface IAnimal
{
    void MakeSound();
}

/// <summary>
///  Cat - объект интерфейса IAnimal
/// <param name="MakeSound">Метод для работы объекта</param>
/// </summary>
/// <remarks>Выводит на консоль сообщение Животного</remarks>
class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

/// <summary>
/// Null Case: этот NullAnimal class будет сздавать экземпляр и использоваться как Null Object 
/// <param name="MakeSound">Метод для работы Null объекта</param>
/// </summary>
class NullAnimal : IAnimal
{
    public void MakeSound()
    {
        // do nothing
    }
}


static class Program
{
    /// <summary>
    /// Точка входа для приложения.
    /// </summary>
    /// <param name="cat">Объект IAnimal для проверки класса Cat</param>
    /// <param name="unknown">Объект IAnimal для проверки работы с Null Object</param> 
    /// <remarks>Переменные созданы для проверки приложения. Заместо того, чтобы использовать Null c#, используем NullObject (в случае этого приложения NullAnimal)
    /// Использование такого паттерна проектирования не приведет у ошибке System.NullReferenceException, как в случае использования простого с# null</remarks>
    static void Main()
    {
        IAnimal cat = new Cat();
        cat.MakeSound();  

        IAnimal unknown = new NullAnimal(); //<< заменяет: IAnimal unknown = null;
        unknown.MakeSound(); 
    }
}
