// See https://aka.ms/new-console-template for more information


int imageWidth = 256;
int imageHeight = 256;

Console.WriteLine("P3");
Console.WriteLine($"{imageWidth} {imageHeight}");
Console.WriteLine("255");

foreach (var j in Enumerable.Range(0, imageHeight))
{
    foreach (var i in Enumerable.Range(0, imageWidth))
    {
        var r = (double)i / (imageWidth - 1);
        var g = (double)j / (imageHeight - 1);
        var b = 0.5 * ( i + j);

        var ir = (int)(255.999 * r);
        var ig = (int)(255.999 * g);
        var ib = (int)(255.999 * b);

        Console.WriteLine($"{ir} {ig} {ib}");
    }
}