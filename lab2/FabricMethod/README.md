# Реалізація шаблону "Фабричний метод"
## Діаграма
![factory](https://github.com/ipzk241-svm/SoftwareDesign/blob/main/lab2/diagrams/factory.drawio.png)
## Структура проекту

### Основні компоненти
1. **Перерахування [`SubscriptionType`](classes/SubscriptionType.cs)**
   - Визначає доступні типи підписок: `DOMESTIC`, `EDUCATIONAL`, `PREMIUM`.
   - Використовується для вибору типу підписки під час створення.

2. **Інтерфейс [`ISubscription`](interfaces/ISubscription.cs)**
   - Визначає контракт для всіх типів підписок.
   - Включає властивості:
     - `Name` — назва підписки.
     - `MonthlyFee` — щомісячна плата.
     - `MinPeriod` — мінімальний період підписки.
     - `Channels` — список каналів.
     - `Features` — список особливостей.
     - `SubscriptionStartDate` — дата початку підписки.
     - `SubscriptionEndDate` — дата закінчення підписки.
     - `IsAutoRenewal` — прапорець автоматичного поновлення.

3. **Конкретні класи підписок**
   - [`DomesticSubscription`](classes/DomesticSubscription.cs) — внутрішня підписка.
   - [`EducationalSubscription`](classes/EducationalSubscription.cs) — освітня підписка.
   - [`PremiumSubscription`](classes/PremiumSubscription.cs) — преміум-підписка.
   - Кожен клас:
     - Реалізує [`ISubscription`](interfaces/ISubscription.cs).
     - Має конструктор за замовчуванням із типовими значеннями.
     - Має параметризований конструктор для кастомізації.
     - Перевизначає метод `ToString()` для зручного виведення інформації.

4. **Абстрактний клас [`SubscriptionFactory`](classes/SubscriptionFactory.cs)**  
   - Визначає абстрактний метод [`CreateSubscription(SubscriptionType type)`](classes/SubscriptionFactory.cs#L12) для створення підписок.
   - Є базовим класом для конкретних фабрик.

5. **Конкретні фабрики**
   - [`WebSite`](classes/WebSite.cs) — створення підписок через веб-сайт.
   - [`MobileApp`](classes/MobileApp.cs) — створення підписок через мобільний додаток.
   - [`ManagerCall`](classes/ManagerCall.cs) — створення підписок через дзвінок менеджеру.
   - Кожна фабрика:
     - Наслідує [`SubscriptionFactory`](classes/SubscriptionFactory.cs).
     - Реалізує `CreateSubscription`, повертаючи відповідний тип підписки залежно від [`SubscriptionType`](classes/SubscriptionType.cs).
     - Використовує вираз `switch` для вибору типу підписки.
     - Виводить повідомлення про спосіб створення.

## Як реалізовано "Фабричний метод"
1. **Відокремлення створення від використання**  
   - Клієнтський код не створює об’єкти підписок напряму (наприклад, через `new DomesticSubscription()`), а делегує це фабрикам ([`WebSite`](classes/WebSite.cs), [`MobileApp`](classes/MobileApp.cs), [`ManagerCall`](classes/ManagerCall.cs)).

2. **Поліморфізм**  
   - Усі фабрики наслідують абстрактний клас [`SubscriptionFactory`](classes/SubscriptionFactory.cs) і повертають об’єкти типу `ISubscription`, що дозволяє працювати з підписками узагальнено, незалежно від конкретного типу.

3. **Гнучкість**  
   - Додавання нового типу підписки (наприклад, `CorporateSubscription`) потребує лише створення нового класу, що реалізує `ISubscription`, та додавання відповідного кейсу у `switch` у кожній фабриці.

4. **Локалізація логіки створення**  
   - Кожна фабрика має власну логіку створення (у цьому випадку — виведення специфічного повідомлення), що дозволяє легко розширювати поведінку (наприклад, додати знижки при оформленні через додаток).
