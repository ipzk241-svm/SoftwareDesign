# Реалізація шаблону "Легковаговик" (Flyweight)

## Структура проекту

### Основні компоненти

1. **Клас [[`HtmlElementFlyweight`](classes/HtmlElementFlyweight.cs)](classes/HtmlElementFlyweight.cs) (легковаговий об'єкт)**  
   - Містить спільні (незмінні) дані HTML-елемента:  
     - `TagName`: назва HTML-тега (наприклад, `div`, `p`).  
     - `IsBlock`: чи є елемент блочним.  
     - `IsSelfClosing`: чи є тег самозакритим (`<br>`, `<img>` тощо).  
     - `CssClasses`: список CSS-класів.  
   - Зберігається у фабриці для багаторазового використання.  

2. **Клас [`FlyweightFactory`](classes/FlyweightFactory.cs) (фабрика легковагових об'єктів)**  
   - Відповідає за створення та повторне використання [`HtmlElementFlyweight`](classes/HtmlElementFlyweight.cs).  
   - Якщо об'єкт із тими ж параметрами вже існує, повертає його, замість створення нового.  
   - Використовує `Dictionary<string, HtmlElementFlyweight>` для збереження унікальних комбінацій атрибутів.  

3. **Клас [`LightElementNode`](classes/LightElementNode.cs) (компонент з легковаговим елементом)**  
   - Представляє HTML-елемент, що використовує [`HtmlElementFlyweight`](classes/HtmlElementFlyweight.cs).  
   - Містить посилання на [`HtmlElementFlyweight`](classes/HtmlElementFlyweight.cs), що зменшує використання пам’яті.  
   - Може мати дочірні елементи (`LightNode`).  
   - Основні методи та властивості:  
     - `AddChild(LightNode child)`: додає дочірній вузол.  
     - `OuterHTML`: повертає повний HTML-код разом з дочірніми елементами.  
     - `InnerHTML`: повертає HTML-код без зовнішнього тега.  

## Як реалізовано "Легковаговик"

1. **Розподіл стану на внутрішній і зовнішній**  
   - Внутрішній стан ([`HtmlElementFlyweight`](classes/HtmlElementFlyweight.cs)) спільний для багатьох елементів і не змінюється.  
   - Зовнішній стан ([`LightElementNode`](classes/LightElementNode.cs)) містить індивідуальні атрибути (вкладені вузли).  

2. **Зменшення використання пам’яті**  
   - Замість зберігання дубльованих об'єктів HTML-елементів, вони отримуються через фабрику `FlyweightFactory`.  
   - Це знижує навантаження на пам’ять у випадку великої кількості однакових HTML-тегів.  

3. **Гнучкість та повторне використання**  
   - Легко розширити підтримку нових HTML-елементів без збільшення пам'яті.  
   - Додавання нового способу рендерингу не впливає на структуру [`HtmlElementFlyweight`](classes/HtmlElementFlyweight.cs).  

## Результати використання
![1](images/1.jpg)
![2](images/2.jpg)




