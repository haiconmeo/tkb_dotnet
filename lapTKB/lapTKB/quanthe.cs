using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lapTKB
{
    public class quanthe
    {
        public int soQH;
        public int soPhong;
        public int soGV;
        List<cathe> ct;
        int soluong;
        public List<int> phancong;
        public List<int> gv;
        int tylelaighep;
        int tyledotbien;
        public quanthe(int qh, int sp, int sgv, List<int> _phancong, List<int> _gv)
        {
            this.phancong = new List<int>();
            phancong.AddRange(_phancong);
            this.gv = new List<int>();
            gv.AddRange(_gv);
            this.soQH = qh;
            this.soPhong = sp;
            this.soGV = sgv;
            this.ct = new List<cathe>();
            this.soluong = 100;
            this.tyledotbien = 3;
            this.tylelaighep = 80;
        }
        public void khoitao()
        {
            int i = 0;
            while (i < this.soluong)
            {
                ct.Add(new cathe(this.soPhong, this.soGV, this.soQH, this.phancong, this.gv));
                i++;
            }
        }
        public void laighep()
        {
            int i = 0;
            int n = this.soluong;
            while (i < n * this.tylelaighep / 100)
            {
                cathe c = new cathe(ct[i], ct[i + 1]);
                ct.Add(c);
                soluong++;
                i++;
            }

        }

        public void dotbien()
        {
            int sodotbien = this.soluong * this.tyledotbien / 100;
            for (int i = 0; i < sodotbien; i++)
            {
                Random rd = new Random();
                int x = rd.Next(soluong);
                int vt1 = rd.Next(10);
                int vt2 = rd.Next(10);
                int vt3 = rd.Next(soPhong);
                int vt4 = rd.Next(soPhong);
                cathe c = new cathe(ct[x], vt1, vt2, vt3, vt4);
                ct.Add(c);
                this.soluong++;
            }
        }
        public int[,]  loc()
        {
            khoitao();
            int min = 10000;
            int vt = 0;
            while (ct[vt].rank >3 )
            {
                laighep();
                dotbien();


                for (int i = 0; i < soluong; i++)
                {
                    if (min > ct[i].rank)
                    {
                        vt = i;
                        min = ct[i].rank;
                    }
                }
            }
            MessageBox.Show(ct[vt].rank.ToString());
            return ct[vt].tkb;
        }


    }
}
