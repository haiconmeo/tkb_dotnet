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
            this.soluong = 200;
            this.tyledotbien = 10;
            this.tylelaighep = 50;
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
          //  MessageBox.Show("tao chay roi nha");
            int i = 0;
            int n = this.soluong;
            while (i < n * this.tylelaighep / 100)
            {
                cathe c = new cathe(ct[i], ct[i + 1]);
                if (c.rank <= 0.4) {
                    ct.Add(c);
                    soluong++;
                    
                }
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
                if (c.rank <= 0.4)
                {
                    ct.Add(c);
                    soluong++;
                    
                }
            }
        }
        public int[,]  loc()
        {
            
            khoitao();
            MessageBox.Show("khoi tao xong");
            ct.Sort(delegate (cathe x, cathe y) {
                return x.rank.CompareTo(y.rank);
            });
            //MessageBox.Show(ct[0].rank.ToString());
            int vt = 0;
            while (ct[vt].rank >0 )
            {
                dotbien();
                laighep();
                //Console.WriteLine(soluong);
                //MessageBox.Show("hazz");
                // sap xep quan the


                /*for (int i = 0; i < soluong - 1; i++)
                {
                    for (int j = 0; j < soluong ; j++)
                        if (ct[i].rank < ct[j].rank)
                        {
                            cathe c = ct[i];
                            ct[i] = ct[j];
                            ct[j] = c;
                        }
                }*/
               // Console.WriteLine(soluong);
                // loai bo ca the chi de so luong o muc 200
                ct.Sort(delegate (cathe x, cathe y) {
                    return x.rank.CompareTo(y.rank);
                });
                //MessageBox.Show(ct[0].rank.ToString());
                int i = 200;
                while(soluong > 200)
                {
                    //MessageBox.Show("dmm");
                    ct.Remove(ct[i]);
                    soluong--;
                }
               
            }
            MessageBox.Show(ct[vt].rank.ToString());
            MessageBox.Show(this.soluong.ToString());
            return ct[vt].tkb;
        }


    }
}
