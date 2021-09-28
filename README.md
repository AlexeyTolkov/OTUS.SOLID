# OTUS.SOLID

### Single Responsibility Principle (Принцип единственной обязанности)
Класс GameGuessTheNumber ответственем за игру, логика по генерации числа вынесена в RandomNumberGenarator, 
логика ответсвенная за взаимодействие с пользователем реализована в ConsoleGameInterface. 
Таком образом каждый класс отвечает за свою задачу.

### Open/Closed Principle (Принцип открытости/закрытости)
Можно создать новые классы на основе интерфейсов INumberGenerator и IGameInterface и получить другую логику работы приложения
Классы закрыты на изменение, но открыты для расширения

### Liskov Substitution Principle (Принцип подстановки Лисков)


### Interface Segregation Principle (Принцип разделения интерфейсов)
Интерфейс IGameInterface имплементирует: IGameInput, IGameOutput для вводы/вывода данных.

### Dependency Inversion Principle (Принцип инверсии зависимостей)
Для каждого класса реализован интерфейс, зависимостей нет.
