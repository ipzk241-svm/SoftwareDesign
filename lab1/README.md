# Used principles of programming 
## DRY (Don't Repeat Yourself)
+ Код є досить модульним, зокрема, є окремі класи для [Money](./lab1/Classes/Money.cs), [Product](./lab1/Classes/Product.cs),
[Warehouse](./lab1/Classes/Warehouse.cs), [Reporter](./lab1/Classes/Reporter.cs), тощо.
+ У класах [Product](./lab1/Classes/Product.cs), [FoodProduct](./lab1/Classes/FoodProduct.cs), [ClothingProduct](./lab1/Classes/ClothingProduct.cs)
зберігається загальна логіка відображення через ToString(), що запобігає дублюванню.
## KISS (Keep It Simple, Stupid)
+ Код досить простий і зрозумілий. Кожен клас виконує одну конкретну відповідальність, що полегшує його підтримку.
+ У класі [Money](./lab1/Classes/Money.cs) операції [додавання](./lab1/Classes/Money.cs), [віднімання](./lab1/Classes/Money.cs),
[множення](./lab1/Classes/Money.cs) та [ділення](./lab1/Classes/Money.cs) написані у зрозумілому вигляді, без надмірних ускладнень.
## SOLID
### S — Single Responsibility Principle (SRP)
Кожен клас виконує єдину відповідальність
+ Клас [Money](./lab1/Classes/Money.cs) відповідає лише за представлення грошей та арифметичні операції, обмін валюти винесено в окремий клас
[CurrencyConverter](./lab1/Classes/CurrencyConverter.cs), що дотримується SRP.
+ [Reporter](./lab1/Classes/Reporter.cs) займається виключно звітністю та інвентаризацією, не змінюючи стан складу.
### O — Open/Closed Principle (OCP)
+ Метод [AddExchangeRate()](./lab1/Classes/CurrencyConverter.cs) дозволяє додавати нові валютні курси без зміни існуючого коду.
+ Використання абстрактного класу [Product](./lab1/Classes/Product.cs) дозволяє розширювати асортимент без зміни базового коду.
### L — Liskov Substitution Principle (LSP)
+ [FoodProduct](./lab1/Classes/FoodProduct.cs) і [ClothingProduct](./lab1/Classes/ClothingProductProduct.cs) є підкласами [Product](./lab1/Classes/Product.cs) і можуть використовуватися замість базового класу без порушення логіки програми.
### I — Interface Segregation Principle (ISP)
+ Інтерфейси [IWarehouseItem](./lab1/Interface/IWarehouseItem.cs), [IWarehouse](./lab1/Interface/IWarehouse.cs) та [IReporter](./lab1/Interface/IReporter.cs) розділяють відповідальності між різними класами.
## D — Dependency Inversion Principle (DIP)
+ [Reporter](./lab1/Classes/Reporter.cs) залежить не від конкретного [Warehouse](./lab1/Classes/Warehouse.cs), а від інтерфейсу [IWarehouse](./lab1/Interface/IWarehouse.cs), що спрощує тестування та можливість зміни реалізації.
## YAGNI (You Ain’t Gonna Need It)
![image](https://github.com/user-attachments/assets/7dc27797-ef4f-4076-acab-f5341f04ea6c)
## Composition Over Inheritance
+ Замість наслідування використовується композиція.
+ Наприклад, [Warehouse](./lab1/Classes/Warehouse.cs) містить [Reporter](./lab1/Classes/Reporter.cs), а не успадковується від нього.
+ [IWarehouseItem](./lab1/Interface/IWarehouseItem.cs) містить [Product](./lab1/Classes/Product.cs), що дозволяє легко змінювати структуру без жорсткої прив’язки до батьківських класів.
## Program to Interfaces, not Implementations
+ У коді використовуються інтерфейси ([IMoney](./lab1/Interface/IMoney.cs), [IProduct](./lab1/Interface/IProduct.cs), [IWarehouseItem](./lab1/Interface/IWarehouseItem.cs), [IWarehouse](./lab1/Interface/IWarehouse.cs),
+  [IReporter](./lab1/Interface/IReporter.cs)), що дозволяє легко змінювати реалізації без модифікації основного коду.
+ Наприклад, [Warehouse](./lab1/Classes/Warehouse.cs) працює з [IWarehouseItem](./lab1/Interface/IWarehouseItem.cs), а не з конкретним WareHouseItem.
## Fail Fast
+ Перевірки запобігають подальшому виконанню програми у разі помилки:
   - У WareHouseItem.ChangeCount() є перевірка, щоб count не був меншим за 0.
   - У SetLastDeliveryDate() перевіряється, що нова дата не раніше за поточну.
