namespace TestEdu;
// пример программы с использованием принципа ООП: Инкапсуляция
// Инкапсуляция - сокрытие внутренних деталей объекта
// и предоставление доступа к данным, через методы (геттеры и сеттеры)
public class BankAccount(decimal initialBalance) {
    private decimal _balance = initialBalance;
    
    // ввод денег на счет
    public void Deposit(decimal amount) { // косвенный сеттер
        if (amount > 0) {
            _balance += amount;
        }
    }

    // пополнение счёта
    public bool Withdraw(decimal amount) { // косвенный сеттер
        if (amount > 0 && amount <= _balance) {
            _balance -= amount;
            return true;
        }
        return false;
    }

    public decimal GetBalance() { // геттер
        return _balance;
    }
}