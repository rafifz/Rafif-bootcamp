public readonly int a; ----> only read, cannot be change, assign only using constructor
public const int b = 2; ----> must be assign first, cannot be change
In conclusion, const should be used when you want to prevent a variable from being reassigned, and readonly should be used when you want to allow a variable to be assigned only once.