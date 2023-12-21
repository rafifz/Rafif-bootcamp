### access modifier:

1. public: This access modifier means that the member can be accessed from anywhere. There are no restrictions on accessing a public member.

2. private: This access modifier means that the member can only be accessed from within the class where it is defined. If a class member is defined as private, it cannot be accessed by derived classes.

3. protected: This access modifier means that the member can only be accessed from within the class where it is defined, or from classes that inherit from that class. A protected member can be accessed from derived classes, but not from outside classes.

4. internal: This access modifier means that the member can be accessed from anywhere within the same assembly. However, it cannot be accessed from another assembly.

5. protected internal: This access modifier means that the member can be accessed from anywhere within the same assembly, or from classes that inherit from the class where it is defined, even if the classes are in other assemblies.

### keywords
1. public `readonly` int a; ----> only read, cannot be change, assign only using constructor
2. public `const` int b = 2; ----> must be assign first, cannot be change
In conclusion, const should be used when you want to prevent a variable from being reassigned, and readonly should be used when you want to allow a variable to be assigned only once.