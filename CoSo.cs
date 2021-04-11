using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK_102190184_TranThiPhuong
{
    class CoSo
    {
        public string MaCoSo { get; set; }
        public string TenCoSo { get; set; }
        public int SLGV { get; set; }

       
        public override string ToString()
        {
            return "id:" + MaCoSo + ", Name:" + TenCoSo;
        }
    }
}
