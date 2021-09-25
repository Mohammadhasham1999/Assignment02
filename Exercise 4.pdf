Consider the three different constructs in C#:

Class
Struct
Record

Explain some of the key differences between the three and give examples of where you would use each of them.

Classes and records are reference types (allocation on heap) whereas structs are value types (allocation on stack). Classes have no limitations in the sense that they can be 
mutable (changeable) and immutable (not changeable). The same rule applies for structs as well. This is not the case with records as their variables/fields are immutable. 
So you can't replace a value for a particular variable which was set upon instantiation of the record. Classes and records support inheritance as opposed to structs which don't.
There are multiple other differences between these three constructs, but I feel that those above are the key ones (especially the first two).

In case of applying the three constructs, records are useful when you want constant values for the variables. Structs can be applied when you don't need polymorphism and want
to work with primitive data types (int, boolean etc.). Also consider structs when you want faster performance in terms of memory, since heaps are slower than 
stacks for allocation. 
