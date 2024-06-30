# [WPF Book](../readme.md)

## C# Standards and Conventions

| Item    | Convention |
| -------- | ------- |
| Classes  | PascalCase |
| Interfaces  | IPascalCase |
| Methods  | PascalCase |
| Public Variables  | PascalCase |
| Private Variables  | _camelCase |
| Constant Variables  | UPPER_CASE |
| Local Variables  | camelCase |
| Method Arguments  | camelCase |

- Avoid using System data types for variables (Use int instead of Int32)
- Class names should be nouns
- Method names should start with a verb
- Properly organize folders and make sure Namespaces follow suit
- When using disposable types (Eg: StreamReader) alwat use the "using" keyword, as this automatically disposes the object when the flow ends.

## Curly Braces
It is recommended to always use vertical braces.

    public Account()
    {
        // ...
    }

As a **personal** exception to this rule, I write same line braces for one liners.

    public void printName() {
        //Print(Name);
    }

Similar to that, for lists of related one liners I may use a single line.

    public void printByte(byte x)   //Print(x);
    public void printShort(short x) //Print(x);
    public void printInt(int x)     //Print(x);

For else statements I go one line down. That way it's clearer for me and I can collapse the if statement without collapsing the else statement.

    if()
    {
        // ...
    }
    else
    {
        // ...
    }