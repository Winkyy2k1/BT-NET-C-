using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_BuiThiHai_2019606166_DE01
{
    class ThiSinh
    {
        protected string sbd;
        protected string hoten;
        protected float diemtoan;
        protected float diemly;
        protected float diemhoa;
        public ThiSinh()
        {

        }
        public ThiSinh(string sbd, string hoten, float diemtoan, float diemly, float diemhoa)
        {
            this.sbd = sbd;
            this.hoten = hoten;
            this.diemtoan = diemtoan;
            this.diemly = diemly;
            this.diemhoa = diemhoa;
        }

        public string Sbd { get => sbd; set => sbd = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public float Diemtoan { get => diemtoan; set => diemtoan = value; }
        public float Diemly { get => diemly; set => diemly = value; }
        public float Diemhoa { get => Diemhoa; set => Diemhoa = value; }

        public virtual float Tongdiem()
        {
            return diemtoan + diemly + diemhoa;
        }
           
        
        public string XetTuyen(float diemsan)
        {
            if ( Tongdiem() >= diemsan) return "Thi đỗ";
            else return "Thi Trượt";
            
        }
    }
}
