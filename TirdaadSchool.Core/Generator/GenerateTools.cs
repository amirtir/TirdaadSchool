using System;
using System.Collections.Generic;
using System.Text;

namespace TirdaadSchool.Core.Generator
{
    public class GenerateTools
    {

public static string GenerateCode()
        {
            return Guid.NewGuid().ToString().Replace("-", "");

        }


    }
}
