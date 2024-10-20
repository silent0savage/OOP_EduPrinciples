namespace TestEdu;
// пример программы с использованием принципа ООП - Полиморфизм
// Polymorphism позволяет объектам разных классов
// быть использованными через один и тот же интерфейс или базовый класс
// Абстрактный класс
public abstract class Animal {
    public abstract void Speak(); // Абстрактный метод
}

// Класс Dog
public class Dog : Animal {
    // Переопределение метода Speak
    public override void Speak() {
        Console.WriteLine("Гав!");
    }
}

// Класс Cat
public class Cat : Animal {
    // Переопределение метода Speak
    public override void Speak() {
        Console.WriteLine("Мяу!");
    }
}

