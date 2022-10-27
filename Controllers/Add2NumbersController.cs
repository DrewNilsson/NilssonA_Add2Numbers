//Andrew Nilsson
//10/25/22
//Add 2 Numbers
//This is a webapi that takes 2 int inputs and returns the 2 inputs added
//Peer reviewed by: Jasmine Leek - program works as expected, clean code, nice work!


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NilssonA_Add2Numbers.Controllers
{
    [Route("[controller]")]
    public class Add2NumbersController : Controller
    {
       [HttpGet]
       [Route("Numbers/{num1}/{num2}")]

       public int Numbers(int num1, int num2)
       {
        return num1 + num2;
       }
    }
}