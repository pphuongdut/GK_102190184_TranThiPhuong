using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK_102190184_TranThiPhuong
{
    class CSDL_OOP
    {
        public delegate bool Compare(GV a, GV b);
        public Compare cmp;

        private static CSDL_OOP _Instance;

        internal static CSDL_OOP Instance
        {
            get
            {
                if( _Instance == null)
                {
                    _Instance = new CSDL_OOP();
                }
                return _Instance;
            }
            set
            {

            }
        }
        private CSDL_OOP()
        {
        }

        private CoSo set1CS(DataRow dr)
        {
            CoSo cs = new CoSo();
            cs.MaCoSo = dr["MaCoSo"].ToString();
            cs.TenCoSo = dr["TenCoSo"].ToString();
            cs.SLGV = Convert.ToInt32(dr["SLGV"].ToString());
            return cs;
        }
        private GV set1GV(DataRow dr )
        {
            GV g = new GV();
            g.MaGV = Convert.ToInt32(dr["MaGV"].ToString());
            g.TenGV = dr["TenGV"].ToString();
            g.SDT = dr["SDT"].ToString();
            g.NgaySinh = Convert.ToDateTime(dr["NgaySinh"].ToString());
            g.MaCoSo = dr["MaCoSo"].ToString();
            return g;
        }
        public List<CoSo> setAllCS()
        {
            List<CoSo> ListCoSo = new List<CoSo>();
            foreach( DataRow dr in CSDL.Instance.DTCS.Rows)
            {
                ListCoSo.Add(set1CS(dr));
            }
            return ListCoSo;
        }
        public List<GV> setAllGV()
        {
            List<GV> ListGV = new List<GV>();
            foreach (DataRow dr in CSDL.Instance.DTGV.Rows)
            {
                ListGV.Add(set1GV(dr));
            }
            return ListGV;
        }

        public void updateGV(GV g)
        {
            List<GV> ListGV = setAllGV();
            int index = IndexOfGV(g.MaGV);
            GV gv1 = ListGV[index];
            gv1.MaGV = g.MaGV;
            gv1.TenGV = g.TenGV;
            gv1.SDT = g.SDT;
            gv1.NgaySinh = g.NgaySinh;
            gv1.MaCoSo = g.MaCoSo;
            syncData(ListGV);
        }

       
        public bool addGV(GV s)
        {
            List<GV> ListGV = setAllGV();
            List<GV> l = getGVbyMaCoSo(s.MaCoSo);
            int SLGV = Get1CoSo(s.MaCoSo).SLGV;
            if ( !isExist(s.MaGV) && (l.Count < SLGV))
            {
                ListGV.Add(s);
                syncData(ListGV);
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool delGV(int MaGV, string MaCoSo)
        {
            List<GV> ListGV = setAllGV();
            List<GV> l = getGVbyMaCoSo(MaCoSo);
            if( l.Count <= 1 )
            {
                return false;
            }
            else
            {
                foreach (GV i in ListGV)
                {
                    if (i.MaGV == MaGV)
                    {
                        ListGV.Remove(i);
                        syncData(ListGV);
                        return true;
                    }
                }
            }
            return true;
        }
       
        public List<GV> filterGV(string type, string search_key, string MaCoSo)
        {

            List<GV> l = new List<GV>() ;
            List<GV> result = new List<GV>();
            l = getGVbyMaCoSo(MaCoSo);
            switch (type)
            {
                case "":
                    result = l;
                    break;
                case "MaGV":
                    result = l.FindAll(i => i.MaGV.ToString().Contains(search_key));
                    break;
                case "TenGV":
                    result = l.FindAll(i => i.TenGV.ToString().Contains(search_key));
                    break;
                case "SDT":
                    result = l.FindAll(i => i.SDT.ToString().Contains(search_key));
                    break;
                case "NgaySinh":
                    result = l.FindAll(i => i.NgaySinh.ToString().Contains(search_key));
                    break;
                case "MaCoSo":
                    result = l.FindAll(i => i.MaCoSo.ToString().Contains(search_key));
                    break;
                    
            }

            return result;
        }

        public List<GV> sortGV(string type, string MaCoSo)
        {

            List<GV> l = new List<GV>();
            if ("MaGV" == type)
            {
                cmp = GV.Compare_MaGV;
            }
            if ("MaCoSo" == type)
            {
                cmp = GV.Compare_MaCoSo;
            }
            if ("TenGV" == type)
            {
                cmp = GV.Compare_TenGV;
            }
            if ("SDT" == type)
            {
                cmp = GV.Compare_SDT;
            }
            if ("NgaySinh" == type)
            {
                cmp = GV.Compare_NgaySinh;
            }
            foreach (GV i in getGVbyMaCoSo(MaCoSo))
            {
                l.Add(i);
            }
            for (int i = 0; i < l.Count; i++)
            {
                for (int j = i + 1; j < l.Count; j++)
                {
                    if (cmp(l[j], l[i]))
                    {
                        GV temp = new GV();
                        temp = l[i];
                        l[i] = l[j];
                        l[j] = temp;
                    }
                }

            }
            return l;
        }

        public List<GV> getGVbyMaCoSo(string MaCoSo)
        {
            List<GV> ListGV = setAllGV();
            List<GV> list = new List<GV>();

            if (MaCoSo == "00000")
            {
                list = ListGV;
            }
            else
            {
                foreach (GV i in ListGV)
                {
                    if (Convert.ToInt32(i.MaCoSo) == Convert.ToInt32(MaCoSo))
                    {
                        list.Add(i);
                    }
                }
            }
            return list;
        }


        public GV get1GV(int MaGV)
        {

            List<GV> ListBaiHat = setAllGV();
            foreach (GV i in ListBaiHat)
            {
                if (i.MaGV == MaGV)
                {
                    return i;
                }
            }
            return null;
        }
        public CoSo Get1CoSo(string MaCoSo)
        {
            List<CoSo> ListCoSo = setAllCS();
            foreach (CoSo i in ListCoSo)
            {
                if (String.Compare(i.MaCoSo, MaCoSo ) == 0)
                {
                    return i;
                }
            }
            return null;
           
        }
      
        public bool isExist( int MaGV)
        {
            List<GV> ListBaiHat = setAllGV();
            foreach (GV i in ListBaiHat)
            {
                if (i.MaGV == MaGV)
                {
                    return true;
                }
            }
            return false;
        }
        public int IndexOfCoSo(string MaCoSo)
        {
            List<CoSo> ListCoSo = setAllCS();
            return ListCoSo.IndexOf(Get1CoSo(MaCoSo));
        }
        public int IndexOfGV(int MaGV)
        {

            List<GV> ListGV = setAllGV();
            foreach (GV i in ListGV)
            {
                if (i.MaGV == MaGV)
                {
                    return ListGV.IndexOf(i);
                }
            }
            return -1;
        }
        public void syncData(List<GV> ListGV)
        {
            DataTable DTGV = new DataTable();
            DTGV.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MaGV", typeof(int)),
                new DataColumn("TenGV", typeof(String)),
                new DataColumn("SDT", typeof(String)),
                new DataColumn("NgaySinh", typeof(DateTime)),
                new DataColumn("MaCoSo", typeof(String)),
            });
            foreach (GV g in ListGV)
            {
                DataRow gv1 = DTGV.NewRow();
                gv1["MaGV"] = g.MaGV;
                gv1["TenGV"] = g.TenGV;
                gv1["SDT"] = g.SDT;
                gv1["NgaySinh"] = g.NgaySinh;
                gv1["MaCoSo"] = g.MaCoSo;
                DTGV.Rows.Add(gv1);
            }
            CSDL.Instance.DTGV.Rows.Clear();
            CSDL.Instance.DTGV = DTGV;
        }
    }
}
