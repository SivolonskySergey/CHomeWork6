
void CrossPoint(double b1, double k1, double b2, double k2)
{
    double x = ( b2 - b1 ) / (k1 - k2);
    double y = (k1 * x) + b1;
    Console.WriteLine($"Точка пересечения прямых - ({x}; {y})");
}

CrossPoint(2, 5, 4, 9);