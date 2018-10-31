using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lapTKB
{
    class cathe
    {
        public int soGV;
        public int  soPhong;
        public int [,] tkb;
        public int rank;
        public List<int> E;
        public cathe(int sp,int gv)
        {
            soGV = gv;
            soPhong = sp;
            for(int i = 0; i < 10; i++)
            {
                for (int j=0;j< soPhong; j++)
                {
                    Random rd = new Random();
                    int e = E[rd.Next(E.Count)];
                    tkb[i,j] = e;
                    E.Remove(e);

                }
            }
            rank = dk_gvday2lop() + dk_tansuatsudungphong();
        }
        bool in_con(int c, int[,] a)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (a[i, j] == c)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        int [,] copymang(int [,] a,int n,int m)
        {
            int[,] b = new int[n, m];
            for (int i=0;i<n;i++)
                for(int j = 0; j < m; j++)
                {
                    b[i, j] = a[i, j];
                }
            return b;
        }
        public cathe(cathe cha,cathe me)
        {
            soGV = cha.soGV;
            soPhong = cha.soPhong;
            int[,] tkbc = new int [10,soPhong];
            int [,]tkbm = new int[10, soPhong];
            tkbc = copymang(cha.tkb, 10, soPhong);
            tkbm = copymang(me.tkb, 10, soPhong);

            for (int i = 0; i < 10; i++)
            {
                for (int j=0; j < this.soPhong; j++)
                {
                    this.tkb[i,j] = -1;
                }
            }
            Random rd = new Random();
            int[,] m = new int [10,cha.soPhong];
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < cha.soPhong; j++)
                {
                    m[i, j] = rd.Next(1);
                }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < cha.soPhong; j++)
                {
                    bool co = false;
                    if (m[i,j] == 0)
                    {// lay a

                        for (int k = 0; k < 4; k++)
                        {
                            for (int l = 0; l < 4; l++)
                            {
                                if ((tkbc[k,l] != -1) && in_con(tkbc[k,l],this.tkb))
                                {
                                    this.tkb[i,j] = tkbc[k,l];
                                    co = true;
                                    tkbc[k,l] = -1;
                                    break;
                                }
                            }
                            if (co) break;
                        }
                    }
                    else
                    {
                        for (int k = 0; k < 10; k++)
                        {
                            for (int l = 0; l < this.soPhong; l++)
                            {
                                if ((tkbm[k,l] != -1) && in_con(tkbm[k,l],this.tkb))
                                {
                                    this.tkb[i,j] = tkbm[k,l];
                                    co = true;
                                    tkbm[k,l] = -1;
                                    break;
                                }
                            }
                            if (co) break;
                        }
                    }
                }
            }
            this.rank = dk_gvday2lop() + dk_tansuatsudungphong();
        }
        public cathe(cathe a, int v1,int v2,int v3,int v4)
        {
            soGV = a.soGV;
            soPhong = a.soPhong;
            int[,] tkbc = new int[10, soPhong];
            
            tkbc = copymang(a.tkb, 10, soPhong);
            
            tkbc[v1, v3] = tkbc[v2, v4];
            this.tkb = tkbc;
            this.rank = dk_gvday2lop() + dk_tansuatsudungphong();
        }
        public int dk_tansuatsudungphong()
        {
            int[] ts = new int[soPhong];
            for (int i = 0; i < soPhong; i++) { ts[i] = 0; }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < soPhong; j++) { if (tkb[i, j] != -1) ts[j]++; }
            }
            Array.Sort(ts);
            return ts[soPhong - 1];

        }
        public int get_gv(int e)
        {
            return 1;
        }
        public int dk_gvday2lop()
        {

            int dem = 0;
            for (int i = 0; i < 10; i++)
            {
                int[] gv = new int[soGV];
                for (int k = 0; k < soPhong; k++) { gv[i] = 0; }
                for (int j = 0; j < soPhong; j++) {
                    if (gv[get_gv(tkb[i, j])] == 0)
                        gv[get_gv(tkb[i, j])]++;
                    else
                        dem++;
                }
            }
            
            return dem;
        }
        
        
        



    }
}
