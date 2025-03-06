# Реалізація шаблону "Будівельник" (Builder)
## Діаграма
![Builder](https://github.com/ipzk241-svm/SoftwareDesign/blob/main/lab2/diagrams/builder.drawio.png)
## Структура проекту

### Основні компоненти
1. **Інтерфейс [`ICharacter`](interfaces/ICharacter.cs)**  
   - Визначає контракт для персонажів гри.
   - Властивості:
     - `Name`, `Height`, `Build`, `HairColor`, `ActiveWeapon`, `EyeColor`, `Clothing` — базові характеристики.
     - `Inventory` — список предметів (`List<string>`).
     - `Deeds` — список діянь (`List<string>`).
   - Методи:
     - `DisplayInfo()` — виводить інформацію про персонажа.
     - `DoSomething(string something)` — дозволяє персонажу виконувати дію.

2. **Клас [`Character`](classes/Character.cs)**  
   - Реалізує [`ICharacter`](interfaces/ICharacter.cs).
   - Містить усі властивості та методи, визначені в інтерфейсі.
   - Додає метод `Attack(ICharacter character)` для демонстрації взаємодії між персонажами.

3. **Інтерфейс [`ICharacterBuilder`](interfaces/ICharacterBuilder.cs)**  
   - Визначає методи для покрокового створення персонажа з текучим інтерфейсом:
     - `SetName()`, `SetHeight()`, `SetBuild()`, `SetHairColor()`, `SetActiveWeapon()`, `SetEyeColor()`, `SetClothing()`.
     - `AddInventoryItem()`, `AddDeed()` — для додавання елементів до списків.
     - `Build()` — повертає готовий об’єкт `ICharacter`.

4. **Будівельники**  
   - [`HeroBuilder`](classes/HeroBuilder.cs):
     - Створює героїв із "добрими діяннями".
   - [`EnemyBuilder`](classes/EnemyBuilder.cs):
     - Створює ворогів із "злими діяннями".
   - Обидва повертають `this` у всіх методах (крім `Build()`), забезпечуючи текучий інтерфейс.
   - Мають метод Reset() для створення нового об’єкта після виклику Build().
5. **Клас [`CharacterDirector`](classes/CharacterDirector.cs)**  
   - Керує процесом створення персонажів.
   - Методи:
     - `NoobHero()` — створює початкового героя.
     - `ProHero()` — створює досвідченого героя.
     - `MobEnemy()` — створює звичайного ворога.
     - `BossEnemy()` — створює боса.

## Як реалізовано "Будівельник"
1. **Покрокове створення**  
   - Будівельники ([`HeroBuilder`](classes/HeroBuilder.cs), [`EnemyBuilder`](classes/EnemyBuilder.cs)) дозволяють поступово задавати атрибути персонажа через ланцюжок методів.

2. **Текучий інтерфейс (Fluent Interface)**  
   - Кожен метод повертає [`ICharacterBuilder`](interfaces/ICharacterBuilder.cs) (тобто `this`), що дозволяє викликати методи в ланцюжку, наприклад:  
     ```csharp
     builder.SetName("Герой").SetHeight(180).SetClothing("Броня");
