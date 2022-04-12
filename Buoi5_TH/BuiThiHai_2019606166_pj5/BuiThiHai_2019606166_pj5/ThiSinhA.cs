using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiThiHai_2019606166_pj5
{
    class ThiSinhA
    {       private string id; 
            private string name; 
            private string diaChi; 
            private float diemToan; 
            private float diemHoa; 
            private float diemLy; 
            private float diemUT; 
            private float tongDiem;
        public ThiSinhA()
        {

        }
        public ThiSinhA(string id, string name, string diaChi, float diemToan, float diemHoa, float diemLy, float diemUT, float tongDiem)
        {
            this.id = id;
            this.name = name;
            this.diaChi = diaChi;
            this.diemToan = diemToan;
            this.diemHoa = diemHoa;
            this.diemLy = diemLy;
            this.diemUT = diemUT;
            this.tongDiem = tongDiem;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public float DiemToan { get => diemToan; set => diemToan = value; }
        public float DiemHoa { get => diemHoa; set => diemHoa = value; }
        public float DiemLy { get => diemLy; set => diemLy = value; }
        public float DiemUT { get => diemUT; set => diemUT = value; }
       
        public float TongDiem { get { return diemToan + diemHoa + diemLy + diemUT ; } }

        public override string ToString()
        {
            return String.Format("SBD:{0,-5} Tên:{1,-10} Địa Chỉ:{2,-15} điểm Toán:{3,-5} điểm Lý:{4,-5} điểm Hoá:{5,-5}diểm ưu tiên:{6,-5} tổng điểm:{7,-5}", id, name, diaChi, diemToan,  diemHoa,diemLy, diemUT, TongDiem);
        }
    }
}
