using System;
using System.Collections.Generic;
using System.Text;

namespace TirdaadSchool.Core.Generator
{
    public class GenerateTools
    {

public static string GenerateActiveCode()
        {
            return Guid.NewGuid().ToString().Replace("-", "");

        }


    }
}
