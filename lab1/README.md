# Used principles of programming 
## DRY (Don't Repeat Yourself)
+ Код є досить модульним, зокрема, є окремі класи для [Money](./Code/Classes/Money.cs), [Product](./Code/Classes/Product.cs),
[Warehouse](./Code/Classes/Warehouse.cs), [Reporter](./Code/Classes/Reporter.cs), тощо.
+ У класах [Product](./Code/Classes/Product.cs#L25-L28), [FoodProduct](./Code/Classes/FoodProduct.cs#L19-L22), [ClothingProduct](./Code/Classes/ClothingProduct.cs#L21-L24)
зберігається загальна логіка відображення через ToString(), що запобігає дублюванню.
## KISS (Keep It Simple, Stupid)
+ Код досить простий і зрозумілий. Кожен клас виконує одну конкретну відповідальність, що полегшує його підтримку.
+ У класі [Money](./Code/Classes/Money.cs) операції [додавання](./Code/Classes/Money.cs#L63-L76), [віднімання](./Code/Classes/Money.cs#L47-L62),
[множення](./Code/Classes/Money.cs#L78-L90) та [ділення](./Code/Classes/Money.cs#L93-L105) написані у зрозумілому вигляді, без надмірних ускладнень.
## SOLID
### S — Single Responsibility Principle (SRP)
Кожен клас виконує єдину відповідальність
+ Клас [Money](./Code/Classes/Money.cs) відповідає лише за представлення грошей та арифметичні операції, обмін валюти винесено в окремий клас
[CurrencyConverter](./Code/Classes/CurrencyConverter.cs), що дотримується SRP.
+ [Reporter](./Code/Classes/Reporter.cs) займається виключно звітністю та інвентаризацією, не змінюючи стан складу.
### O — Open/Closed Principle (OCP)
+ Метод [AddExchangeRate()](./Code/Classes/CurrencyConverter.cs#L22-L28) дозволяє додавати нові валютні курси без зміни існуючого коду.
+ Використання абстрактного класу [Product](./Code/Classes/Product.cs) дозволяє розширювати асортимент без зміни базового коду.
### L — Liskov Substitution Principle (LSP)
+ [FoodProduct](./Code/Classes/FoodProduct.cs) і [ClothingProduct](./Code/Classes/ClothingProductProduct.cs) є підкласами [Product](./Code/Classes/Product.cs) і можуть використовуватися замість базового класу без порушення логіки програми.
### I — Interfaces Segregation Principle (ISP)
+ Інтерфейси [IWarehouseItem](./Code/Interfaces/IWarehouseItem.cs), [IWarehouse](./Code/Interfaces/IWarehouse.cs) та [IReporter](./Code/Interfaces/IReporter.cs) розділяють відповідальності між різними класами.
## D — Dependency Inversion Principle (DIP)
+ [Reporter](./Code/Classes/Reporter.cs) залежить не від конкретного [Warehouse](./Code/Classes/Warehouse.cs), а від інтерфейсу [IWarehouse](./Code/Interfaces/IWarehouse.cs), що спрощує тестування та можливість зміни реалізації.
## YAGNI (You Ain’t Gonna Need It)
![image](https://github.com/user-attachments/assets/7dc27797-ef4f-4076-acab-f5341f04ea6c)
## Composition Over Inheritance
+ Замість наслідування використовується композиція.
+ Наприклад, [Warehouse](./Code/Classes/Warehouse.cs) містить [Reporter](./Code/Classes/Reporter.cs), а не успадковується від нього.
+ [IWarehouseItem](./Code/Interfaces/IWarehouseItem.cs) містить [Product](./Code/Classes/Product.cs), що дозволяє легко змінювати структуру без жорсткої прив’язки до батьківських класів.
## Program to Interfacess, not Implementations
+ У коді використовуються інтерфейси ([IMoney](./Code/Interfaces/IMoney.cs), [IProduct](./Code/Interfaces/IProduct.cs), [IWarehouseItem](./Code/Interfaces/IWarehouseItem.cs), [IWarehouse](./Code/Interfaces/IWarehouse.cs),
+  [IReporter](./Code/Interfaces/IReporter.cs)), що дозволяє легко змінювати реалізації без модифікації основного коду.
+ Наприклад, [Warehouse](./Code/Classes/Warehouse.cs) працює з [IWarehouseItem](./Code/Interfaces/IWarehouseItem.cs), а не з конкретним WareHouseItem.
## Fail Fast
+ Перевірки запобігають подальшому виконанню програми у разі помилки:
   - У [WareHouseItem.ChangeCount()](./Code/Classes/WareHouseItem.cs#L23-L30) є перевірка, щоб count не був меншим за 0.
   - У [SetLastDeliveryDate()](./Code/Classes/WareHouseItem.cs#L31-L37) перевіряється, що нова дата не раніше за поточну.
