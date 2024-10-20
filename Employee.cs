namespace TestEdu;
// пример программы с использованием принципа ООП: Наследование
// Наследование позволяет создавать классы наследники
// наследники дополняют новую функциональность существующему классу

class Employee { // главный класс
    public string Name {get; set;}

    public Employee(string name) { // конструктор
        Name = name;
    }

    public virtual void Work() {
        Console.WriteLine($"{Name} is working.");
    }
}

class Manager : Employee { // наследник Manager от Employee
    public Manager(string name) : base(name) { }

    public override void Work() {
        Console.WriteLine($"{Name} is managing.");
    }
}

class Developer : Employee {
    public Developer(string name) : base(name) { }

    public override void Work() {
        Console.WriteLine($"{Name} is writing code.");
    }
}
