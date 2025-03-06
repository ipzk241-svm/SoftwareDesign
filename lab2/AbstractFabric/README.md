# Реалізація шаблону "Абстрактна фабрика"

## Діаграма
![abstract factory](https://github.com/ipzk241-svm/SoftwareDesign/blob/main/lab2/diagrams/abstractFactory.drawio.png)
## Структура проекту

### Основні компоненти
1. **Інтерфейси продуктів**  
   - [`ILaptop`](interfaces/ILaptop.cs) — інтерфейс для ноутбуків (властивості: `Name`, `Model`, `Price`, `RAM`, `Storage`).
   - [`INetbook`](interfaces/INetbook.cs) — інтерфейс для нетбуків (властивості: `Name`, `Processor`, `RAM`, `Storage`, `ScreenSize`).
   - [`IEBook`](interfaces/IEBook.cs) — інтерфейс для електронних книг (властивості: `Model`, `BatteryLife`, `ScreenType`).
   - [`ISmartphone`](interfaces/ISmartphone.cs) — інтерфейс для смартфонів (властивості: `Name`, `Model`, `Price`, `ReleaseDate`).
   - Кожен інтерфейс містить метод `ShowInfo()` для виведення інформації про пристрій.

2. **Конкретні продукти**  
   - Для кожного бренду (`Epple`, `Kiaomi`, `Balaxy`) реалізовано по чотири класи продуктів:
     - [`EppleLaptop`](classes/Products/EppleLaptop.cs), [`EppleNetbook`](classes/Products/EppleNetbook.cs), [`EppleEBook`](classes/Products/EppleEBook.cs), [`EppleSmartphone`](classes/Products/EppleSmartphone.cs).
     - [`KiaomiLaptop`](classes/Products/KiaomiLaptop.cs), [`KiaomiNetbook`](classes/Products/KiaomiNetbook.cs), [`KiaomiEBook`](classes/Products/KiaomiEBook.cs), [`KiaomiSmartphone`](classes/Products/KiaomiSmartphone.cs).
     - [`BalaxyLaptop`](classes/Products/BalaxyLaptop.cs), [`BalaxyNetbook`](classes/Products/BalaxyNetbook.cs), [`BalaxyEBook`](classes/Products/BalaxyEBook.cs), [`BalaxySmartphone`](classes/Products/BalaxySmartphone.cs).
   - Кожен клас:
     - Реалізує відповідний інтерфейс.
     - Має конструктор за замовчуванням із типовими значеннями.
     - Має параметризований конструктор для кастомізації.
     - Реалізує `ShowInfo()` для виведення характеристик.

3. **Абстрактна фабрика ([`IDeviceFactory`](interfaces/IDeviceFactory.cs))**  
   - Інтерфейс, який визначає методи для створення кожного типу пристрою:
     - `CreateLaptop()`
     - `CreateNetbook()`
     - `CreateEBook()`
     - `CreateSmartphone()`

4. **Конкретні фабрики**  
   - [`EppleFactory`](classes/Factories/EppleFactory.cs) — створює пристрої бренду `Epple`.
   - [`KiaomiFactory`](classes/Factories/KiaomiFactory.cs) — створює пристрої бренду `Kiaomi`.
   - [`BalaxyFactory`](classes/Factories/BalaxyFactory.cs) — створює пристрої бренду `Balaxy`.
   - Кожна фабрика реалізує [`IDeviceFactory`](interfaces/IDeviceFactory.cs) і повертає відповідні продукти свого бренду.

## Як реалізовано "Абстрактну фабрику"
1. **Сімейства продуктів**  
   - Кожна фабрика ([`EppleFactory`](classes/Factories/EppleFactory.cs), [`KiaomiFactory`](classes/Factories/KiaomiFactory.cs), [`BalaxyFactory`](classes/Factories/BalaxyFactory.cs) створює повний набір пристроїв одного бренду, забезпечуючи їхню сумісність і консистентність.

2. **Відокремлення створення**  
   - Клієнтський код працює з інтерфейсом [`IDeviceFactory`](interfaces/IDeviceFactory.cs), а не з конкретними класами продуктів, що дозволяє легко змінювати бренд, не змінюючи логіку використання.

3. **Поліморфізм**  
   - Усі продукти повертаються через абстрактні інтерфейси ([`ILaptop`](interfaces/ILaptop.cs), [`INetbook`](interfaces/INetbook.cs) тощо), що дозволяє працювати з ними узагальнено, незалежно від бренду.

4. **Розширюваність**  
   - Додавання нового бренду (наприклад, `Samsung`) потребує лише створення нової фабрики та відповідних класів продуктів без зміни існуючого коду.
