using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK_102190184_TranThiPhuong
{
    class CSDL
    {
        public DataTable DTCS { get; set; }
        public DataTable DTGV { get; set; }
        internal static CSDL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CSDL();
                }
                return _Instance;

            }
            private set
            {
            }
        }
        private static CSDL _Instance;
        private CSDL()
        {
            // Dữ liệu Cơ sở
            DTCS = new DataTable();
            DTCS.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MaCoSo", typeof(String)),
                new DataColumn("TenCoSo", typeof(String)),
                new DataColumn("SLGV", typeof(int))
            });
            DataRow dr1 = DTCS.NewRow();
            dr1["MaCoSo"] = "00001";
            dr1["TenCoSo"] = "CS1";
            dr1["SLGV"] = 5;
            DTCS.Rows.Add(dr1);

            DataRow dr2 = DTCS.NewRow();
            dr2["MaCoSo"] = "00002";
            dr2["TenCoSo"] = "CS2";
            dr2["SLGV"] = 5;
            DTCS.Rows.Add(dr2);

            DataRow dr3 = DTCS.NewRow();
            dr3["MaCoSo"] = "00003";
            dr3["TenCoSo"] = "CS3";
            dr3["SLGV"] = 5;
            DTCS.Rows.Add(dr3);

            // Dữ liệu Giảng viên
            DTGV = new DataTable();
            DTGV.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MaGV", typeof(int)),
                new DataColumn("TenGV", typeof(String)),
                new DataColumn("SDT", typeof(String)),
                new DataColumn("NgaySinh", typeof(DateTime)),
                new DataColumn("MaCoSo", typeof(String)),
            });

            DataRow gv1 =DTGV.NewRow();
            gv1["MaGV"] = 1;
            gv1["TenGV"] = "Tran Van A";
            gv1["SDT"] = "0123123121";
            DateTime d1 = new DateTime(2000, 07, 12);
            gv1["NgaySinh"] = d1;
            gv1["MaCoSo"] = "00001";
            DTGV.Rows.Add(gv1);

            DataRow gv2 = DTGV.NewRow();
            gv2["MaGV"] = 2;
            gv2["TenGV"] = "Tran Van D";
            gv2["SDT"] = "0123123122";
            DateTime d2 = new DateTime(2000, 07, 1);
            gv2["NgaySinh"] = d2;
            gv2["MaCoSo"] = "00002";
            DTGV.Rows.Add(gv2);

            DataRow gv3 = DTGV.NewRow();
            gv3["MaGV"] = 3;
            gv3["TenGV"] = "Tran Van B";
            gv3["SDT"] = "0123123123";
            DateTime d3 = new DateTime(2000, 08, 1);
            gv3["NgaySinh"] = d3;
            gv3["MaCoSo"] = "00003";
            DTGV.Rows.Add(gv3);


            DataRow gv4 = DTGV.NewRow();
            gv4["MaGV"] = 4;
            gv4["TenGV"] = "Nguyen Van C";
            gv4["SDT"] = "0123123124";
            DateTime d4 = new DateTime(1999, 07, 1);
            gv4["NgaySinh"] = d4;
            gv4["MaCoSo"] = "00001";
            DTGV.Rows.Add(gv4);
        }
    }
}
