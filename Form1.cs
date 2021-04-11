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
    public partial class Form1 : Form
    {
        
        DialogResult result;
        public Form1()
        {
            InitializeComponent();
            SetCbbCoSo();
            SetCbbSort();
            SetCbbSearch();
            show(getCoSoCurrent());
        }
        public void SetCbbCoSo()
        {
            cbbCoso.Items.Add(new CBB_Item()
            {
                Text = "All",
                Value = "00000"
            });
            foreach (CoSo i in CSDL_OOP.Instance.setAllCS())
            {

                cbbCoso.Items.Add(new CBB_Item()
                {
                    Text = i.TenCoSo,
                    Value = i.MaCoSo
                });
            }
            cbbCoso.SelectedItem = cbbCoso.Items[0];

        }
        public void SetCbbSort()
        {
            GV s = new GV();
            foreach (var property in s.GetType().GetProperties())
            {
                cbb_Sort.Items.Add(property.Name);
            }
            cbb_Sort.Text = "Chọn kiểu sắp xếp";
        }
        public void SetCbbSearch()
        {
            GV s = new GV();
            foreach (var property in s.GetType().GetProperties())
            {
                cbb_search_type.Items.Add(property.Name);
            }
            cbb_Sort.Text = "Chọn kiểu tìm kiếm ";
        }
        
        private void cbbCoso_SelectedIndexChanged(object sender, EventArgs e)
        {
            show(getCoSoCurrent());
        }
        private void show(string MaCoSo)
        {
                datagridview_dsGV.DataSource = CSDL_OOP.Instance.filterGV("","", getCoSoCurrent());
        }
        
        private void btn_sort_Click(object sender, EventArgs e)
        {
            if (cbb_Sort.SelectedItem != null)
            {
                // get current class id for sort in that class
                string MaTheLoai = getCoSoCurrent();
                datagridview_dsGV.DataSource = CSDL_OOP.Instance.sortGV(cbb_Sort.SelectedItem.ToString(), MaTheLoai);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn kiểu sắp xếp !");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DetailGV f = new DetailGV();
            f.setType(-1, "");
            f.asyncData += show;
            f.ShowDialog();
            show(getCoSoCurrent());
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = datagridview_dsGV.SelectedRows[0];
            // get maGV 
            int MaGV = Convert.ToInt32(dr.Cells["MaGV"].Value);
            // get MaCS
            string MaCoSo = dr.Cells["MaCoSo"].Value.ToString();           
            DetailGV f = new DetailGV();
            f.setType(MaGV, MaCoSo);
            f.asyncData += show;
            f.ShowDialog();
            show(getCoSoCurrent());
        }
     
        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            search();
        }
        private void search()
        {
            if (cbb_search_type.SelectedItem != null)
            {
                string type = cbb_search_type.SelectedItem.ToString();
                string search_key = txt_search.Text;
                string MaCoSo = getCoSoCurrent();
                datagridview_dsGV.DataSource = CSDL_OOP.Instance.filterGV(type, search_key, MaCoSo);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn và nhập nội dung tìm kiếm !");
            }
        }
       

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = datagridview_dsGV.SelectedRows;
           
            if (r == null || r[0].Cells["MaGV"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn SV để xóa !");

            }
            else
            {
                string s = "";
                foreach (DataGridViewRow i in r)
                {
                    s += i.Cells["TenGV"].Value.ToString() + " ";
                    result = MessageBox.Show("Bạn chắc chắn muốn xóa GV " + s + " ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        int MaGV = Convert.ToInt32(i.Cells["MaGV"].Value);
                        string MaCoSo = i.Cells["MaCoSo"].Value.ToString();
                        if (CSDL_OOP.Instance.delGV(MaGV, MaCoSo))
                        {
                            MessageBox.Show("Xóa thành công!");
                            show(getCoSoCurrent());
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa !\nTồn tại ít nhất một GV trong Cơ Sở!");
                            s = "";
                            continue;
                        }
                    }
                    else
                    {
                        s = "";
                        continue;
                    }
                }
            }

        }

        private string getCoSoCurrent()
        {
            return ((CBB_Item)cbbCoso.SelectedItem).Value;
        }
    }
}
