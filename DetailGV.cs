using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK_102190184_TranThiPhuong
{
    public partial class DetailGV : Form
    {
        public delegate void LoadData(String MaCoSo);
        public LoadData asyncData;
        public int MaGV { get; set; }
        public string MaCS { get; set; }
        public DetailGV()
        {
            InitializeComponent();
            SetCbbCoSo();
        }
        public void SetCbbCoSo()
        {
            foreach (CoSo i in CSDL_OOP.Instance.setAllCS())
            {

                cbbCoSo.Items.Add(new CBB_Item()
                {
                    Text = i.TenCoSo,
                    Value = i.MaCoSo
                });
            }
        }
        public void setType(int MaGV, string MaCoSo)
        {
            this.MaGV = MaGV;
            this.MaCS = MaCoSo;
            if (MaGV == -1)
            {
                gb_ttsv.Text = "Thêm Giảng Viên mới";
            }
            else
            {
                gb_ttsv.Text = "Chỉnh sửa thông tin Giảng Viên";
                getInforEdit(MaGV, MaCoSo);

            }

        }
        private void getInforEdit(int MaGV, string MaCoSo)
        {
            GV s = CSDL_OOP.Instance.get1GV(MaGV);
            txt_magv.Enabled = false;
            txt_magv.Text = s.MaGV.ToString();
            txt_tengv.Text = s.TenGV;
            txt_SDT.Text = s.SDT;
            dtp_ngaysinh.Value = Convert.ToDateTime(s.NgaySinh);
            int indexClass = CSDL_OOP.Instance.IndexOfCoSo(MaCoSo);
            cbbCoSo.SelectedIndex = indexClass + 1;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if ( validateForm() != 0 )
            {
                switch(validateForm())
                {
                    case 1:
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin ");
                        break;
                    case 2:
                        MessageBox.Show("Vui Lòng Nhập Mã GV không chứa kí tự!");
                        break;
                    case 3:
                        MessageBox.Show("Vui Lòng Nhập Đúng Định Dạng SDT !");
                        break;
                }    
            }
            else
            {
                if (MaGV != -1)
                {
                    CSDL_OOP.Instance.updateGV(setGV());
                    MessageBox.Show("Chỉnh sửa GV thành công !");
                    asyncData(this.MaCS);
                    this.Dispose();
                }
                else
                {
                    if (CSDL_OOP.Instance.addGV(setGV()))
                    {
                        MessageBox.Show("Thêm GV thành công !");
                        string mcs = setGV().MaCoSo;
                        asyncData(this.MaCS);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Mã GV đã tồn tại!\nHoặc vượt quá số lượng GV!");
                    }
                }
            }


        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public GV setGV()
        {
            GV s = new GV();
            s.MaGV = Convert.ToInt32(txt_magv.Text);
            s.TenGV = txt_tengv.Text;
            s.SDT = txt_SDT.Text;           
            s.NgaySinh = dtp_ngaysinh.Value;
            s.MaCoSo = ((CBB_Item)cbbCoSo.SelectedItem).Value;
            return s;
        }
        private int validateForm()
        {
            if (txt_magv.Text == "" || txt_tengv.Text == "" || txt_SDT.Text == "" || cbbCoSo.SelectedItem == null)
            {
              
                return 1;

            }
            for (int i = 0; i < txt_magv.Text.Length; i++)
            {
                if (char.IsLetter(txt_magv.Text[i]) == true)
                {
                    return 2;
                }

            }
            if (txt_SDT.Text.Length != 10 && txt_SDT.Text[0] != 0)
            {
                return 3;
            }
            return 0;
        }
    }
}
