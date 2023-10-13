
using System.Numerics;
using Microsoft.AspNetCore.Mvc;
namespace FibonacciApi.Controllers;


[Route("api/[controller]")]
[ApiController]
public class FibonacciController : ControllerBase
{
    
    [HttpPost("calculate")]
    public ActionResult<FibonacciResultModel> Get([FromBody] FibonacciBodyModel model)
    {
        int n = model.position;

        if (n < 0)
        {
            return BadRequest("n must greater than 0.");
        }

        BigInteger result = CalculateFibonacci(n);
        // ulong result2 = Convert.ToUInt64(result);
        Console.WriteLine(result.ToString());

        var fiboModel = new FibonacciResultModel
        {
            position = n,
            result = result.ToString()
        };
        return Ok(fiboModel);
    }


    private BigInteger CalculateFibonacci(int n)
    {
        if (n == 0)
        {
            return BigInteger.Zero;
        }
        else if (n == 1)
        {
            return BigInteger.One;
        }

        BigInteger a = BigInteger.Zero;
        BigInteger b = BigInteger.One;
        BigInteger result = BigInteger.Zero;

        for (int i = 2; i <= n; i++)
        {
            result = BigInteger.Add(a, b);
            a = b;
            b = result;
        }
        return result;
    }
}