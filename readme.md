#Overview

How do we enable using Visual Studio and nUnit/SpecFlow to test VFP code?

##Problems

- .NET can't natively talk with VFP
- VFP can't natively call .NET

##Solutions

.NET classes can be exposed to COM so object references can be passed from .NET into VFP i.e. read and assign from classes created in .NET from inside a VFP object.
Similarly, VFP can be COM-enabled to allow access from a .NET solution.

##Gotchas

VFP COM objects that will work with .NET do not have visual elements, so we can't tests forms directly through this approach.

##Visual FoxPro Example

The staff form has a button that is executing some behaviour (changing the form caption). Historically the code for this would be in the button event-handling method as a component of the form. All we do is separate this out to another object (the behaviour object).
The behaviour object is attached to the form on Init. This is all standard separation of concerns stuff.

The behaviour class has been marked as a COM class, internally to our VFP apps we can use the non-com interface as usual, and the COM interface can be used from .NET. The behaviour class is passed a reference to the form object to be manipulated, as VFP is dynamic this can be any object as long as it has the basic properties we are touching.

##.NET Example

A simple mock object has been constructed to wrap the basic form details, we can pass in this mock form to the VFP behaviour class and effectively exercise VFP behaviour using a .NET construct.

The examples include a test project using nUnit specifically and also a SpecFlow example.

##Getting Started

- Grab the code
    
````
git clone https://github.com/cmcguff/bdd.git		
```

- Build the VFP project as a single=thread DLL and register the dll (should happen by default, make sure you are running VFP as Administrator)

```
build dll vfp_automation.dll from vfp_automation.pjx
```

- Run the tests from .NET
