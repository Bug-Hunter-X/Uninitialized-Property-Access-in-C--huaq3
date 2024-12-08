# Uninitialized Property Access in C#

This repository demonstrates a common, yet subtle, error in C#: accessing a property before it's been initialized.  While this might not always lead to an immediate compiler error, it can cause unexpected behavior or runtime exceptions (NullReferenceException for reference types).

The `bug.cs` file shows the problematic code. The `bugSolution.cs` file demonstrates how to correct the issue.

**Problem:**  Accessing `MyProperty` in `MyMethod()` before assigning a value leads to undefined behavior. For value types (like `int`), you'll get the default value (0 for `int`).  For reference types, you'll get a `NullReferenceException` if you try to use the property.

**Solution:** Always initialize properties before use, either in the constructor or by providing a default value.