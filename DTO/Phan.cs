using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phan
    {
        public int MaPhan { get; set; }
        public string TenPhan { get; set; }

        // Add a constructor that accepts both MaPhan and TenPhan
        public Phan(int maPhan, string tenPhan)
        {
            MaPhan = maPhan;
            TenPhan = tenPhan;
        }

        // Optionally, you can add a parameterless constructor as well
        public Phan() { }
    }

}
