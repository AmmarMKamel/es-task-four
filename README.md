# Exception Handling

---

Exception handling in C# is a mechanism to handle runtime errors, allowing the program to continue executing or to terminate gracefully.

---

### **Key Concepts**

1. **Exceptions**: Runtime errors that occur during program execution (e.g., dividing by zero, accessing a null object, or file not found).
2. **Try-Catch Block**: Used to catch and handle exceptions.
3. **Finally Block**: Ensures that code is executed regardless of whether an exception occurs.
4. **Throw Statement**: Used to explicitly throw an exception.

---

### **Exception Handling Keywords**

1. **`try`**: Encloses the code that might throw an exception.
2. **`catch`**: Catches and handles the exception.
3. **`finally`**: Executes code regardless of whether an exception occurs.
4. **`throw`**: Throws an exception manually.

---

### **Basic Syntax**

```csharp
try
{
    // Code that might throw an exception
}
catch (ExceptionType ex)
{
    // Handle the exception
}
finally
{
    // Code that always executes (optional)
}
```

---

### **Example: Handling Exceptions**

```csharp
using System;

class Program
{
    static void Main()
    {
        try
        {
            int a = 10;
            int b = 0;
            int result = a / b; // This will throw a DivideByZeroException
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Cannot divide by zero. Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("This block always executes.");
        }
    }
}
```

---

### **Key Points**

1. **Multiple `catch` Blocks**: You can have multiple `catch` blocks to handle different types of exceptions. The most specific exceptions should be caught first.
2. **Base Exception Class**: All exceptions inherit from the `System.Exception` class.
3. **Custom Exceptions**: You can create your own exceptions by deriving from the `Exception` class.
4. **Finally Block**: Use it for cleanup code (e.g., closing files or releasing resources).

---

### **Custom Exceptions**

You can define your own exceptions by creating a class that inherits from `Exception`.

```csharp
public class MyCustomException : Exception{
    public MyCustomException(string message) : base(message)
    {
    }
}

// Usage
try
{
    throw new MyCustomException("This is a custom exception.");
}
catch (MyCustomException ex)
{
    Console.WriteLine(ex.Message);
}
```

---

### **Common Exception Types**

- `DivideByZeroException`: Division by zero.
- `NullReferenceException`: Accessing a null object.
- `FileNotFoundException`: File not found.
- `ArgumentNullException`: Null argument passed to a method.
- `IndexOutOfRangeException`: Accessing an array index out of bounds.

---

### **Best Practices**

1. Catch specific exceptions rather than using a generic `catch` block.
2. Avoid catching exceptions you cannot handle.
3. Use `finally` for resource cleanup.
4. Log exceptions for debugging and monitoring.
5. Avoid throwing exceptions for normal control flow (e.g., use conditional checks instead).

---
