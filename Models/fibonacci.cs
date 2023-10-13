using System.ComponentModel.DataAnnotations;
using System.Numerics;

public class FibonacciResultModel
{
    public int position { get; set; }
    public string result { get; set; } = "";
}

public class FibonacciBodyModel
{
    [Required]
    public int position { get; set; }
}

public class FibonacciNumberBodyModel
{
    [Required]
    public double number { get; set; }
}

public class FibonacciResultOnlyModel
{
    public string result { get; set; } = "";
}