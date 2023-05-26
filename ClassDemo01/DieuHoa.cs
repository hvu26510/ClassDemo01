using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo01
{
    internal class DieuHoa
    {
        public string NSX;
        private string mauSac;
        private int CongSuat;

        private int curTempature;

        public DieuHoa()
        {

        }

        public DieuHoa(string nSX, string mauSac)
        {
            NSX = nSX;
            this.mauSac = mauSac;
        }

        public DieuHoa(string nSX, string mauSac, int congSuat, int curTempature)
        {
            NSX = nSX;
            this.mauSac = mauSac;
            CongSuat = congSuat;
            this.curTempature = curTempature;
        }

        public string getNSX()
        {
            return this.NSX;
        }

        public string getMauSac()
        {
            return (this.mauSac);
        }

        public int getCongSuat()
        {
            return this.CongSuat;
        }

        public void setCongSuat(int congSuat)
        {
            this.CongSuat = congSuat;
        }

        public void setMauSac(string mausac)
        {
            this.mauSac = mausac;
        }

        public void TangNhietDo()
        {
            curTempature = curTempature + 1;
        }



    }
}
