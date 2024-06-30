# [WPF Book](../readme.md)

## Binary and Streams
When working with files and bytes there are multiple ways of reading, writing and storing them.

### Byte Array
Byte arrays hold as many bytes as defined and the size can't be changed. They use only as much memory as the bytes need.

### Byte List
Byte lists hold the same info as byte arrays but allow changing its size. This comes with an extra cost in memory usage and performance as opposed to byte arrays (Albeit very small)

### Streams
Streams can be used to sequentially read bytes from a source.

- MemoryStream keeps a byte array internally that is read and written to as needed.
- FileStream is used to read and write files. It does not hold a byte array internally so it can be used to efficiently read parts of a file.

Applying the "using" keyword is recommended to close the streams when the flow ends.

## Working with Bits

### Masking
Masking is a bitwise operation to isolate certain bits within a value.

| Operation    | Effect |
| -------- | ------- |
| &  | 1 bits in the mask will remain |
| \|  | 1 bits in the mask or the value will remain |
| ^  | 1 bits in the mask will be inverted |
| ~  | Inverts the bits in the mask |

    byte value = 0b10101100;  // Original value
    byte mask = 0b11110000;   // Mask to isolate the higher 4 bits
    byte mask2 = 0b00001111;   // Mask to set the lower 4 bits
    byte result = (byte)(value & mask);  // result is 0b10100000
    byte result = (byte)(value | mask2);  // result is 0b10101111
    byte result = (byte)(value ^ mask2);  // result is 0b10100011
    byte result = (byte)(value & ~mask);  // result is 0b00001100

### Shifting
Shifting moves bits to the left or right.

| Operation    | Direction |
| -------- | ------- |
| <<  | Left |
| >>  | Right |

    byte value = 0b10101100;  // Original value
    byte result = (byte)(value << 2);  // result is 0b10110000
    byte result = (byte)(value >> 2);  // result is 0b00101011