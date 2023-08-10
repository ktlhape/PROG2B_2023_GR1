# PROGRAMMING 2B 2023 GR1

## LEARNING UNIT 1

### Theme 1 : Object Lifetime

1. Garbage collection (GC)- .NET's garbage collector manages the allocation and release of memory for your application. Each time you create a new object, the common language runtime allocates memory for the object from the managed heap.

    > [!Note]
   > GC collects unused resources in the background.
3. Finalizers / Destructors - Finalizers (historically referred to as destructors) are used to perform any necessary final clean-up when a class instance is being collected by the garbage collector.

    > [!IMPORTANT]
   > Only create destructors when you need to explicitly remove your custom objects
5. Disposable Objects - In the context of C#, dispose is an object method invoked to execute code required for memory cleanup and release and reset unmanaged resources, such as file handles and database connections.

    > [!Note]
    > To dispose any custom class object, the class has to implement the IDisposable interface.

4. Lazy Object Initialization - Lazy initialization is a technique that delays the creation of an object or a value until it is first accessed or needed. This can improve performance and memory usage, especially for expensive or rarely used resources.

