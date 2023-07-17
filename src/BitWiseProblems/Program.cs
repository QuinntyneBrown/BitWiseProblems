var index = 1;

var offset = 6;

var take = 8;

var size = (take + 7) >>> 3;

byte[] buffer = new byte[3] {

    0b01010101,
    
    0b11111111,

    0b00101010
};

List<byte> destination = new List<byte>();

var source = new Span<byte>(buffer, offset, size);

for(var i = 0; i < source.Length; i++)
{

    // 1. First Part

    // n  elements to isolate is (8 - offset)

    var mask = (1 << 8 - offset) - 1 << offset;

    // sets the first 2

    var result = (byte)((source[i + index] & mask) >> offset);



    // 2. Second Part

    destination.Add(result);
}
