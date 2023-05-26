using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo01
{
    internal class SinhVien
    {
        private int idSV;
        private double diem;

        public void setDiem(double diem)
        {
            if (diem >= 0 && diem <= 10)
            {
                this.diem = diem;
            }
            else
            {
                Console.WriteLine("Nhap vao khoang tu 0-10");
            }
        }
        public double getDiem()
        {
            return this.diem;
        }

        public void setSV(int id,double d)
        {
            this.idSV = id;
            setDiem(d);
        }

        public string PrintHL()
        {
            if(this.diem > 8)
            {
                return "gioi";
            }

            return "TB";
        }

    }
}
