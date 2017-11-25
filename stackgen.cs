using System;
using System.Collections.Generic;
using System.Collections;
namespace NewStack1
{
    
    class Program
    {
        public class NewStack1<T>
        {
          int top=-1;
          int maxsize;
          T[] Stack;        
           T element;
          public void push(T Element)
          {
            if(top==maxsize-1)
            {
                 Console.WriteLine("STACK OVER FLOW");
            }
            else
            {
                top=top+1;
                Stack[top]=element;
            }
          }
          public void pop()
          {
            T PoppedElement;
            T temp=default(T);
            if(!(top<=0))
            {
                PoppedElement = Stack[top];
                top= top-1;
            
            }
             
          }
          public void peek(int pos)
          {
            
            if(pos < maxsize && pos >= 0)
            {
               Console.WriteLine("position is"+Stack[pos]);
            }
        
          }
        
        }
    
           static void Main(string[] args)
        {  
            
            Console.WriteLine("Enter the maxsize");
            int maxsize=Convert.ToInt32(Console.ReadLine());
            Stack<string> mystack=new Stack<string>();
            while(true)
            {
               Stack<string> mystack1=new Stack<string>();

                Console.WriteLine("choose from the below");
                Console.WriteLine("1.PUSH");
                 Console.WriteLine("2.POP");
                Console.WriteLine("3.peek");
                int value=Convert.ToInt32(Console.ReadLine());

               if(value==1)
               {
                 Console.WriteLine("Enter the element to be pushed");
                 string temp= Console.ReadLine();
                 int E = Stack.push(temp);
                 if(E!=-1)
                 {
                     Console.WriteLine("Element Pushed");
                 }
                 else
                 {
                     Console.WriteLine("OVERFLOW");
                 }

               } 
              else if(value==2)
              {
                  string E=Stack.pop();
                  if(E!=null)
                  {
                      Console.WriteLine("element deleted");
                  }
                  else
                  {
                      Console.WriteLine("stack underflow");
                  }
                }
              else
               {
                 Console.WriteLine("Enter the position to be peeped");
                 int pos=Convert.ToInt32(Console.ReadLine());
                 string E=Stack.peep(pos);
                 if(E!=null)
                 {
                     Console.WriteLine("Element at position"+pos+"is"+E);
                 }
                 else
                 {
                   Console.WriteLine("Element not present");
                 }
            }  

                
               
            
            }  
            
            
        }

}   

} 
    




