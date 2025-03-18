using System;
class Program
{
    static void Main(){
        double result;
        double firstValue;
        double secondValue;
        string operation;
        Console.WriteLine("first value : ");
        while (true)
        {
            
            try
            {
                firstValue=Convert.ToDouble(Console.ReadLine());      
                break;
            }
            catch (System.Exception)
            {
                Console.WriteLine("first value : ");
            }
            
        }
        Console.WriteLine("second value : ");
        while (true)
        {
           
            try
            {
                secondValue=Convert.ToDouble(Console.ReadLine());  
                break;   
            }
            catch (System.Exception)
            {
                Console.WriteLine("second value : ");
            }
            
        }
        Console.WriteLine("operation : ");
        while (true)
        {
                 
            operation=Console.ReadLine();   
            if (operation =="+" || operation =="-" || operation =="*" || operation =="/" )
            {
                break;
            }else
            {
                Console.WriteLine("operation : ");
            }
        }

   
        switch (operation)
        {
            case "+":
            result=firstValue+secondValue;
            break;
            case "-":
            result=firstValue-secondValue;
            break;
            case "*":
            result=firstValue*secondValue;
            break;
            case "/":
            result=firstValue/secondValue;
            break;
            
            default:
                result=0;
                break;
        }
        Console.WriteLine("result = "+result);


    }
    
}