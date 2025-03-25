# Вопросы к собеседованию

## База С#

## Продвинутые С#

### Как завершать Task принудительно?
Task это абстракция над потоком. Принимает делегат Action или лямбду. 
Запускается 3 способами Start(), Task.Factory.StartNew(лямбда), Task.Run(лямбда): 

'''Task task1 = new Task(() => Console.WriteLine("Task1 is executed"));
task1.Start();
 
Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Task2 is executed"));
 
Task task3 = Task.Run(() => Console.WriteLine("Task3 is executed"));'''

Ожидание завершения task1.Wait()

Продожение task1.ContinueWith()

Ожидание результатов сразу нескольких тасок WhenAll - int[] results = await Task.WhenAll(task1, task2, task3); или хотябы одной WhenAny

Принудительная отмена - прокидывается CancellationToken 





С#
1. Почему лучше НЕ использовать async void
------------------------------------------
IEnumerable, HashSet, dictionary OZON!! 
------------------------------------------
Индексаторы
------------------------------------------
Полиморфизм new, virtual override, виды полиморфизма, реализации разных типов
------------------------------------------
с какой версии GC асинхронный
------------------------------------------
Generic:

В методе проверки на null во входном параметре лучше использовать T а не object т.к если проверяем Nullable<int> сасает от boxing

SQL:
1. Уровни изоляции транзакций:
Read uncommitted - чтение незафиксированных данных; 
Read committed - чтение зафиксированных данных;
Repeatable read - повторяющееся чтение;
Serializable - упорядочиваемость.

ACID (atomicity - атомарность, consistency - согласованность, isolation - изолированность и durability - надежность)

Уровни изоляции позволяет справиться с несколькими из них:
dirty read - с чтением данных, которые могут пропасть после отката;
non repeatable read - с повторным чтением, которое может вернуть изменившиеся данные;
phantom read - с повторным чтением, которое может вернуть отличающееся количество строк;
lost update - с потерянным измением.




Транзакции в микросервисах





## База SQL

## Технологии