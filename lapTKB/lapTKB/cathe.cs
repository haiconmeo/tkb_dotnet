using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lapTKB
{
    public class cathe
    {
        
        
            public List<int> phancong;
            public List<int> gv;
            public int soQH;
            public int soGV;
            public int soPhong;
            public int[,] tkb;
            public double rank;
            public List<int> E;
            public List<int> gv2;
            public bool kt(int x, List<int> a)
            {
                foreach (int i in a)
                {
                    if (i == x) return false;
                }
                return true;
            }
            public cathe(int sp, int sogv, int sqh, List<int> _phancong, List<int> _gv)
            {


                this.phancong = new List<int>();
                this.phancong.AddRange(_phancong);
                this.gv = new List<int>();
                this.gv2 = new List<int>();
                this.gv.AddRange(_gv);
            List<int> p = new List<int>();
            for (int i = 0; i < soPhong; i++)
            {
                p.Add(i);
            }
            List<int> t = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                t.Add(i);
            }
            foreach (int i in gv)
                {
                    if (kt(i, gv2)) this.gv2.Add(i);
                }
                soQH = sqh;
                soGV = sogv;
                soPhong = sp;
                this.tkb = new int[10, soPhong];
                E = new List<int>();
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < soPhong; j++) tkb[i, j] = -1;
                }
                for (int i = 0; i < 10 * soPhong; i++)
                {
                    E.Add(i);
                }
            Random rd = new Random();
            for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < soPhong; j++)
                    {
                        
                    
                    
                   // int tam1 = p[rd1.Next(p.Count)];
                    //int tam2 = t[rd0.Next(t.Count)];
                    int e = E[rd.Next(E.Count)];
                    tkb[i, j] = e;
                    E.Remove(e);
                    //p.Remove(tam1);
                    //t.Remove(tam2);
                    
                }
                }
                
                rank = 0.1*dk_gvday2lop(gv2, gv) + 0.5*dk_tansuatsudungphong();
            }
            bool in_con(int c, int[,] a)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < soPhong; j++)
                    {
                        if (a[i, j] == c)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            int[,] copymang(int[,] a, int n, int m)
            {
                int[,] b = new int[n, m];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                    {
                        b[i, j] = a[i, j];
                    }
                return b;
            }
            public cathe(cathe cha, cathe me)
            {
                soGV = cha.soGV;
                soPhong = cha.soPhong;
                soQH = cha.soQH;
                int[,] tkbc = new int[10, soPhong];
                int[,] tkbm = new int[10, soPhong];
                tkbc = copymang(cha.tkb, 10, soPhong);
                tkbm = copymang(me.tkb, 10, soPhong);
                this.tkb = new int[10, soPhong];
                this.gv2 = new List<int>();
                this.gv = new List<int>();
                gv.AddRange(cha.gv);
                foreach (int i in gv)
                {
                    if (kt(i, gv2)) this.gv2.Add(i);
                }
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < this.soPhong; j++)
                    {
                        this.tkb[i, j] = -1;
                    }
                }
                Random rd = new Random();
                int[,] m = new int[10, cha.soPhong];
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
                        if (m[i, j] == 0)
                        {// lay a

                            for (int k = 0; k < 10; k++)
                            {
                                for (int l = 0; l < soPhong; l++)
                                {
                                    if ((tkbc[k, l] != -1) && in_con(tkbc[k, l], this.tkb))
                                    {
                                        this.tkb[i, j] = tkbc[k, l];
                                        co = true;
                                        tkbc[k, l] = -1;
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
                                    if ((tkbm[k, l] != -1) && in_con(tkbm[k, l], this.tkb))
                                    {
                                        this.tkb[i, j] = tkbm[k, l];
                                        co = true;
                                        tkbm[k, l] = -1;
                                        break;
                                    }
                                }
                                if (co) break;
                            }
                        }
                    }
                }
            rank = 0.1 * dk_gvday2lop(gv2, gv) + 0.5 * dk_tansuatsudungphong();
        }
            public cathe(cathe a, int v1, int v2, int v3, int v4)
            {
                soGV = a.soGV;
                soPhong = a.soPhong;
                soQH = a.soQH;
                this.gv2 = new List<int>();
                this.gv = new List<int>();
                gv.AddRange(a.gv);
                foreach (int i in gv)
                {
                    if (kt(i, gv2)) this.gv2.Add(i);
                }
                int[,] tkbc = new int[10, soPhong];

                tkbc = copymang(a.tkb, 10, soPhong);
                
                tkbc[v1, v3] = tkbc[v2, v4];
                this.tkb = tkbc;
            rank = 0.1 * dk_gvday2lop(gv2, gv) + 0.5 * dk_tansuatsudungphong();
        }
            public int dk_tansuatsudungphong()
            {
                int[] ts = new int[soPhong];
                for (int i = 0; i < soPhong; i++) { ts[i] = 0; }
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < soPhong; j++) { if (tkb[i, j] < this.soQH) ts[j]++; }
                }
                Array.Sort(ts);
            // return ts[soPhong - 1];
            return 0;

            }
            public int get_gv(int e, List<int> gv)
            {
                //string cmd = "select TeacherID from phancong where phancongID='" + e + "'";
                if (e >= soQH || e== -1)
                {
                    return -1;
                }
                return gv[e];

            }
        
            public int dk_gvday2lop(List<int> gv2, List<int> gv)
            {
                int dem = 0;
                for (int k = 0; k < this.gv2.Count; k++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        int c = 0;
                        for (int j = 0; j < soPhong; j++)
                        {
                            if (get_gv(tkb[i, j], gv) == gv2[k])
                            {
                                c = c + 1;

                            }

                        }
                        if (c > 1) dem = dem + (c - 1);
                        //if (dem >= 1) return 10;
                    }
                //return dem;
                }

                return dem;
            }
            
            public void in_ra()
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < soPhong; j++)
                    {
                        Console.Write("{0}  ", tkb[i, j]);
                    }
                    Console.WriteLine();
                }
            }





        }
    }

    
