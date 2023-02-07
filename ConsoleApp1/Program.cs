
var fractions = new List<Fraction>();

var fraction1 = new Fraction()
{
    numerator = 1,
    denominator = 3,
};
var fraction2 = new Fraction()
{
    numerator = 2,
    denominator = 3,
};
var fraction3 = new Fraction()
{
    numerator = 11,
    denominator = 6,
};

fractions.Add(fraction1);
fractions.Add(fraction2);
fractions.Add(fraction3);


foreach (var fraction in fractions)
{
    Console.WriteLine(fraction.numerator);
    Console.WriteLine(fraction.denominator);
    Console.WriteLine();
}