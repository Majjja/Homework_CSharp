using System;
using System.Collections.Generic;
using System.Text;

namespace GenerationOfId
{
    public class GenerateId
    {
        public static int RandomGenerateId()
        {
            int id = new Random().Next(1, 10);
            
            return id;
        }
    }
}
