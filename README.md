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





## База SQL

## Технологии