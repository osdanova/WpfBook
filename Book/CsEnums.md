# [WPF Book](../readme.md)

## Enums
Enums are a set of defined constants.

    public enum Colors
    {
        Red, // 0
        Green, // 1
        Blue // 2
    }

By default enums have a value starting from 0 but this can be changed.

    public enum Colors
    {
        Red = 2,
        Green = 4,
        Blue = 8
    }

When changing its type they must be cast.

    int myRed = (int)Colors.Red;
    Colors myRed = (Colors)2;