namespace WebApiExample.Services;

public class OopExampleService : IOopExampleService
{
    public void DifferenceOverrideAndNewDemo()
    {
        BaseClass bc = new BaseClass();  
        DerivedClass dc = new DerivedClass();  
        BaseClass bcdc = new DerivedClass();  
        
        bc.OverrideMethod1();  //Базовый - Method1
        bc.Method2();  //Базовый - Method2
        
        //пока работает одинаково
        dc.OverrideMethod1();  //Наследник - Method1 - переопределение в наследнке
        dc.NewMethod2();  //Наследник - Method2 - сокрытие в наследнике
        
        // тут основное различие
        
        //Наследник - Method1 - Несмотря на то, что переменная объявлена как BaseClass, реальный объект — DerivedClass
        //Работает полиморфно: вызывается версия метода того типа, который реально хранится в переменной (а не тип переменной)
        bcdc.OverrideMethod1(); 
            
        
        //Хотя реальный объект — DerivedClass, переменная объявлена как BaseClass.
        //Работает не полиморфно: вызывается версия метода, соответствующая типу переменной (а не реальному типу объекта).
        bcdc.Method2(); //Базовый - Method2  
        
        //override — меняет поведение метода на всех уровнях (полиморфизм).
        //new — создаёт новый метод, который существует параллельно со старым (без полиморфизма).
    }
}

class BaseClass  
{  
    public virtual void OverrideMethod1()  
    {  
        Console.WriteLine("Базовый - Method1");  
    }  
  
    public virtual void Method2()  
    {  
        Console.WriteLine("Базовый - Method2");  
    }  
}  
  
class DerivedClass : BaseClass  
{  
    public override void OverrideMethod1()  
    {  
        Console.WriteLine("Наследник - Method1");  
    }  
  
    public new void NewMethod2()  
    {  
        Console.WriteLine("Наследник - Method2");  
    }  
}  