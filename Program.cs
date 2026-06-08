using System;
using System.ComponentModel;
using System.Data;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Threading;
using System.Xml;
using static Advanced.Program;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
    #region Quistion1

    //    Q1: What is a generic class? Why use generics?
    //        A generic class is a blueprint for a class that allows you to defer the specification of the exact data type until 
    //        the class is declared and instantiated by client code.It uses a placeholder (usually T) for the data type.

    //        Why Use Generics?
    //            *Type Safety.
    //            *Code Reusability.
    //            *Performance.
        #endregion

    #region Quistion2
        //Q2: Write a generic class Container<T> with Add and Get methods.
        //    public class Container<T>
        //{
        //    private T _item;

        //    public void Add(T item)
        //    {
        //        _item = item;
        //    }

        //    public T Get()
        //    {
        //        return _item;
        //    }
        //}
        #endregion

    #region Quistion3

        //Q3:What are multiple type parameters? Write Pair<TKey, TValue>.
        //    Multiple type parameters allow a generic class or method to handle more than one flexible data type at the same time.
        //    You separate them using commas inside the angle brackets<>.
        //    public class Pair<TKey, TValue>
        //{
        //    public TKey Key { get; set; }
        //    public TValue Value { get; set; }

        //    public Pair(TKey key, TValue value)
        //    {
        //    Key = key;
        //    Value = value;
        //    }
        //}
    #endregion

    #region Quistion4

    //Q4: What is a generic method? Write Swap<T> method.
    //     A generic method is a method declared with type parameters, allowing it to operate on different data types regardless
    //    of whether the containing class itself is generic.

    //    public class Utility
    //{
    //    public static void Swap<T>(ref T a , ref T b)
    //    {
    //        T temp = a;
    //        a = b;
    //        b = temp;
    //    }
    //}
    #endregion

    #region Quistion5

    //Q5: Write a generic method FindMax<T> that finds maximum value

    //    public class MathUtility
    //{
    //    public static T FindMaxValue<T>(T[] arr) where T : IComparable<T>
    //    {
    //        T max = arr[0];
    //        foreach (T item in arr)
    //        {
    //            if (item.CompareTo(max) > 0)
    //            {
    //                max = item;
    //            }
    //        }
    //        return max;
    //    }
    //}
    #endregion

    #region Quistion6

    //Q6: What is a generic interface? Write IRepository<T>.

    //    A generic interface defines a contract of methods, properties, or events without tying them to a specific data type.
    //    It is widely used in patterns like the Repository Pattern for data access.
    //    public interface IRepository<T>
    //{
    //    void Add(T entity);
    //    T GetById(int id);
    //    IEnumerable<T> GetAll();
    //    void Remove(T entity);
    //}
    #endregion

    #region Quistion7
    //Q7: What is the 'struct' constraint? Write an example.
    //    The where T : struct constraint specifies that the type argument must be 
    //    a value type(like int, bool, double, or custom structs). It excludes nullable value types.
    //    public class Contaner<T> where T : struct
    //{
    //    public  Contaner (ref T value)
    //    {
    //        T Value = value;
    //    }
    //    public T Value { get; set; }
    //}
    #endregion

    #region Quistion8

    //Q8: What is the 'class' constraint? Write an example.
    //    The where T : class constraint specifies that the type argument must be a reference
    //    type(like string, arrays,interfaces, or classes).
    //    public class ReferenceTypeLogger<T> where T : class
    //{
    //    public void LogIfNotNull(T item)
    //    {
    //        if (item != null)
    //        {
    //            Console.WriteLine(item.ToString());
    //        }
    //    }
    //}
    #endregion

    #region Quistion9
    //Q9: What is the 'new()' constraint? Write an example.
    //    The where T : new () constraint specifies that a type argument must have a public parameterless constructor.
    //    This allows you to instantiate the type inside the generic class using new T().
    //    public class Factory<T> where T : new()
    //{
    //    public T CreateInstance()
    //    {
    //        return new T();
    //    }
    //}
    #endregion

    #region Quistion10
    //Q10:  What is the interface constraint? Write an example.
    //    The interface constraint restricts the type argument to only those types that implement a specific interface.
    //    public interface IDisposable
    //{
    //    void Dispose();
    //}

    //public class ResourceCleaner<T> where T : IDisposable
    //{
    //    public void UseAndDispose(T resource)
    //    {
    //        resource.Dispose();
    //    }
    //}
    #endregion

    #region Quistion11
    //Q11: What is the base class constraint? Write an example.
    //    The base class constraint limits the type argument to a specific base class or any of its derived subclasses.
    //    public class Animal { public string Name { get; set; } }
    //public class Dog : Animal { }

    //public class AnimalShelter<T> where T : Animal
    //{
    //    public void PrintAnimalName(T animal)
    //    {
    //        // Safe to access properties of Animal
    //        Console.WriteLine(animal.Name);
    //    }
    //}
    #endregion

    #region Quistion12
    //Q12: How do you apply multiple constraints? Write an example.
    //    You can chain multiple constraints for a single type parameter by separating them with commas.
    //    If you have multiple parameters, use separate where clauses.
    //    public class AdvancedContainer<TKey, TValue>
    //where TKey : struct
    //where TValue : class, IComparable<TValue>, new()
    //{
    //    // TKey must be a value type
    //    // TValue must be a reference type, implement IComparable, and have a parameterless constructor
    //}

    #endregion

    #region Quistion13
//    Q13: What does the 'default' keyword do in generics?
//        In generics, the default keyword returns the default literal value of a type parameter at runtime.

//For reference types, it returns null.

//For numeric value types, it returns 0.

//For structs, it returns an instance with all fields initialized to zero/null.

    #endregion

    #region Quistion14
//    Q14: Write a SafeList<T> that returns default when the index is invalid.
//            using System.Collections.Generic;

//public class SafeList<T>
//    {
//        private List<T> _list = new List<T>();

//        public void Add(T item) => _list.Add(item);

//        public T GetAt(int index)
//        {
//            if (index < 0 || index >= _list.Count)
//            {
//                return default(T); // Returns null for reference types, 0 for ints, etc.
//            }
//            return _list[index];
//        }
//    }

    #endregion

    #region Quistion15
    //Q15: What is covariance? Explain the 'out' keyword.
    //    Covariance enables you to use a more derived type(child) than originally specified.
    //    In C#, you enable covariance on generic interfaces or delegates using the out keyword.
    //    Covariance only applies to output positions(return types of methods).

    //    public interface ICovariant<out T>
    //{
    //    T GetItem(); 
    // }
    //     ICovariant<string> strProvider = null;
    //    ICovariant<object> objProvider = strProvider;

    #endregion

    #region Quistion16
//    Q16: What is contravariance? Explain the 'in' keyword.
//        Contravariance enables you to use a more generic(base) type than originally specified.
//        In C#, you enable contravariance using the in keyword.

//        Contravariance only applies to input positions (parameters of methods).

//        public interface IContravariant<in T>
//    {
//        void ProcessItem(T item);
//}
//IContravariant<object> objProcessor = null;
//        IContravariant<string> strProcessor = objProcessor;


    #endregion

    #region Quistion17
    Q17: What is the difference between covariance and contravariance?
     --Covariance
        Keyword:out.
        Direction:Converts from derived to base (IEnumerable<String> to IEnumerable<Object>)
        Position Allowed:Only on Return positions(Output)

     --Contravariance
        Keyword:in.
        Direction:Converts from base to derived(IComparer<Object> to IComparer<String>)
        Position Allowed:Only on Parameter positions(Input)

    #endregion

    #region Quistion18
    Q18: How do static members work in generic types?
        Static fields and members are not shared across different closed generic type instances.
        Each unique type combination gets its own independent set of static variables.
        public class GenericCounter<T>
    {
        public static int Count { get; set; }
    }

    GenericCounter<int>.Count = 5;
    GenericCounter<string>.Count = 10;

    Console.WriteLine(GenericCounter<int>.Count); 
    Console.WriteLine(GenericCounter<string>.Count);

    #endregion

    #region Quistion19
    Q19: How can you inherit from a generic class?
        A subclass can inherit from a generic base class in three main ways:

1. Close the generic type argument explicitly
public class BaseClass<T> { }
    public class DerivedClass : BaseClass<int> { } // Closed inheritance
2. Keep the subclass generic
public class BaseClass<T> { }
    public class DerivedClass<T> : BaseClass<T> { } // Open generic inheritance
3. Add or modify type parameters
public class BaseClass<T> { }
    public class DerivedClass<T, U> : BaseClass<T> { }

    #endregion

    #region Quistion20
    Q20: Complete Exercise - Create a generic Cache<TKey, TValue>with Add, Get, Remove, Contains, and expiration support.

    #endregion
}

