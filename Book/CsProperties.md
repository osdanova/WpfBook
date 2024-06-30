# [WPF Book](../readme.md)

## Properties
If a field has a explicit get and set it is called a Property.

    int Number;                 // Normal Field
    int Number { get; set; }    // Property

Properties are more flexible when it comes to public fields and binding, thus they are preferred in those situations.

Normal fields are better suited for local variables.