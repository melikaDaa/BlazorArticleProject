using Blazorise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Client.Helpers
{
    public class MyIdGenerator : IIdGenerator
    {
        private int currentId = 0;

        string IIdGenerator.Generate => throw new NotImplementedException();

        public string Generate()
        {
            // تولید یک شناسه منحصر به فرد
            // در این مثال از یک شمارنده استفاده می‌کنیم
            currentId++;
            return "id_" + currentId.ToString();
        }
    }
}
