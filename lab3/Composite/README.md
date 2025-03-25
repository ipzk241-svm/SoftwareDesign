# Реалізація шаблону "Компонувальник" (Composite)

### Основні компоненти

1. **Абстрактний клас [`LightNode`](classes/LightNode.cs)**  
   - Визначає спільний інтерфейс для всіх вузлів дерева.  
   - Містить дві властивості:  
     - `OuterHTML`: повертає HTML-подання вузла.  
     - `InnerHTML`: повертає внутрішній HTML вузла.  

2. **Клас [[`LightElementNode`](classes/LightElementNode.cs)](classes/LightElementNode.cs) (складений елемент)**  
   - Представляє HTML-тег (наприклад, `<div>`, `<span>`).  
   - Може містити вкладені вузли ([`LightNode`](classes/LightNode.cs)), тобто підтримує деревоподібну структуру.  
   - Основні методи та властивості:  
     - [`AddChild(LightNode child)`](classes/LightElementNode.cs#L26-L29): додає дочірній елемент.  
     - [`ChildCount`](classes/LightElementNode.cs#L26-L29): повертає кількість дочірніх елементів.  
     - [`OuterHTML`](classes/LightElementNode.cs#L33-L39): повертає HTML-код вузла разом з дочірніми елементами.  
     - [`InnerHTML`](classes/LightElementNode.cs#L88-L95): повертає HTML-код без зовнішнього тега.  
     - [`BuildHTML`](classes/LightElementNode.cs#L41-L86): будує зовнішню HTML структуру.
     - [`BuildInnerHTML`](classes/LightElementNode.cs#L97-L126): будує внутрішню HTML структуру.

3. **Клас [[`LightTextNode`](classes/LightTextNode.cs)](classes/LightTextNode.cs) (листовий елемент)**  
   - Представляє текстовий вузол (наприклад, звичайний текст у HTML-документі).  
   - Не може мати дочірніх елементів.  
   - Реалізує `OuterHTML` та `InnerHTML`, які повертають текстовий вміст.  

## Як реалізовано "Компонувальник"

1. **Деревоподібна структура**  
   - Всі елементи ([`LightElementNode`](classes/LightElementNode.cs) і [`LightTextNode`](classes/LightTextNode.cs)) є підтипами `LightNode`, що дозволяє створювати ієрархічні структури.  
   - [`LightElementNode`](classes/LightElementNode.cs) може містити інші `LightNode`, що дозволяє рекурсивно створювати HTML-дерево.  

2. **Принцип єдиної відповідальності (SRP)**  
   - [`LightElementNode`](classes/LightElementNode.cs) відповідає за структуру дерева та формування HTML.  
   - [`LightTextNode`](classes/LightTextNode.cs) зберігає та відображає текст.  

3. **Принцип підстановки Барбари Лісков (LSP)**  
   - [`LightTextNode`](classes/LightTextNode.cs) і [`LightElementNode`](classes/LightElementNode.cs) можуть використовуватися однаково через `LightNode`, не порушуючи поведінку системи.  

4. **Гнучкість**  
   - Додаючи нові вузли (наприклад, `LightCommentNode` для HTML-коментарів), можна розширювати функціональність без зміни існуючого коду.  

