# Direct Field Access Bypassing Property Setter in C#

This repository demonstrates a common coding error in C#: directly accessing a class field within a method instead of using the corresponding property. This can lead to issues such as breaking encapsulation and losing the benefits of property-based access control, including validation or other logic. 

The `bug.cs` file shows the problematic code, while `bugSolution.cs` presents the corrected version, using the property consistently for both setting and getting field values.