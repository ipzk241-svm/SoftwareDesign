# Реалізація шаблону "Адаптер" (Adapter)

## Структура проекту

### Основні компоненти

1. **Інтерфейс [`ILogger`](interfaces/ILogger.cs)**  
   - Визначає контракт для логування з методами:  
     - `Log(string message)`: звичайне повідомлення.  
     - `Error(string message)`: повідомлення про помилку.  
     - `Warn(string message)`: попередження.  

2. **Консольний логер [`Logger`](classes/Logger.cs)**  
   - Реалізує [`ILogger`](interfaces/ILogger.cs) та виводить повідомлення у консоль із кольоровим форматуванням.  

3. **Клас [`FileWriter`](classes/FileWriter.cs)**  
   - Використовується для запису даних у файл.  
   - Містить методи:
     - [`Write(string content)`](classes/FileWriter.cs#L19-L22): запис без нового рядка.  
     - [`WriteLine(string content)`](classes/FileWriter.cs#L24-L27): запис із новим рядком.  

4. **Адаптер [`FileLoggerAdapter`](classes/FileLoggerAdapter.cs)**  
   - Реалізує [`ILogger`](interfaces/ILogger.cs), використовуючи [`FileWriter`](classes/FileWriter.cs) для запису логів у файл.  
   - Додає відповідні префікси (`[LOG]`, `[ERROR]`, `[WARN]`) перед записом.  

## Як реалізовано "Адаптер"

1. **Несумісні інтерфейси**  
   - [`ILogger`](interfaces/ILogger.cs) визначає логування, а [`FileWriter`](classes/FileWriter.cs) просто записує текст у файл.  
   - Вони не можуть взаємодіяти безпосередньо, оскільки [`FileWriter`](classes/FileWriter.cs) не реалізує [`ILogger`](interfaces/ILogger.cs).  

2. **Створення адаптера**  
   - [`FileLoggerAdapter`](classes/FileLoggerAdapter.cs) реалізує [`ILogger`](interfaces/ILogger.cs) і використовує [`FileWriter`](classes/FileWriter.cs) для запису логів.  
   - Це дозволяє клієнтському коду працювати через [`ILogger`](interfaces/ILogger.cs), незалежно від того, чи логування виконується в консоль або у файл.  

3. **Гнучкість та розширюваність**  
   - Клієнтський код працює з [`ILogger`](interfaces/ILogger.cs), тому можна легко додати нові адаптери (наприклад, для запису в базу даних або відправки логів через мережу) без зміни логіки.  


  
