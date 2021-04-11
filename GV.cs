using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK_102190184_TranThiPhuong
{
    public class GV
    {
        public int MaGV { get; set; }
        public string TenGV { get; set; }
        public string SDT { get; set; }
        public DateTime NgaySinh { get; set; }
        public string MaCoSo { get; set; }
        public override string ToString()
        {
            return "TenGV:" + TenGV ;
        }
       
        public static bool Compare_MaGV(GV o1, GV o2)
        {
            if (o1.MaGV <= o2.MaGV)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Compare_TenGV(GV o1, GV o2)
        {
            if (String.Compare(o1.getName(), o2.getName()) < 0)
                return true;
            else
                return false;
        }
        public static bool Compare_MaCoSo(GV o1, GV o2)
        {
            if (String.Compare(o1.MaCoSo, o2.MaCoSo) <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Compare_SDT(GV o1, GV o2)
        {
            if (String.Compare(o1.SDT, o2.SDT) <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Compare_NgaySinh(GV o1, GV o2)
        {
            if (String.Compare(o1.NgaySinh.ToString(), o2.NgaySinh.ToString()) <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        public string getName()
        {
            string name = "";
            for (int i = TenGV.Length - 1; i >= 0; i--)
            {
                if (" " == TenGV[i].ToString())
                {
                    break;
                }
                else
                {
                    name += TenGV[i];
                }
            }
            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            return new string(nameArray);
        }
    }
}
