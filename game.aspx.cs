using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        point.Enabled = false; aim.Enabled = false;

    }
    protected void Page_PreInit(object sender, EventArgs e)
    {
        List<string> keys = Request.Form.AllKeys.Where(key => key.Contains("d")).ToList();
        int i = 0;
        foreach (string key in keys)
        {

            i++;
        }
        int k = (int)Math.Sqrt(i);
        this.createbox1(k);

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (val.Text != "")
        {
            int n = int.Parse(val.Text); int c = 0;
            if (n > 3 && n < 9)
            { Button1.Enabled = false; val.Enabled = false; }
            else
            {
                Response.Write("Row and Coloum Condition Not Matched"); c++;
            }
            if (c == 0)
            {
                createbox();

            }
        }
      
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (val.Text != "")
        {
            List<string> keys = Request.Form.AllKeys.Where(key => key.Contains("d")).ToList();
            int i = 0;
            foreach (string key in keys)
            {

                i++;
            }
            int k = (int)Math.Sqrt(i);
            int[,] a; string v;
            a = new int[k + 1, k + 1];
            int c, r, box = 0, u = 0;
            for (r = 1; r <= k; r++)
            {
                for (c = 1; c <= k; c++)
                {
                    u++;
                    TextBox t = Panel1.FindControl("d" + u.ToString()) as TextBox;
                    v = t.Text;
                    if (v == "")
                    {
                        box++; break;
                    }
                    else
                    {
                        int o = int.Parse(v);
                        a[r, c] = o;
                    }

                }
            }
            if (box == 0)
            {
                int sumR = 0, sumC = 0, n, total, count = 0; n = int.Parse(val.Text); total = ((n * ((n * n) + 1)) / 2);
                double points = 0.0, per;
                per = 10 / (double)n;

                for (r = 1; r <= k; r++)
                {
                    sumR = 0; sumC = 0;
                    for (c = 1; c <= k; c++)
                    {
                        sumR = sumR + a[r, c];
                        sumC = sumC + a[c, r];

                    }
                    if (sumR != total)
                    {
                        Response.Write("Condition Not Matched Row No:" + r);
                        break;
                    }
                    else if (sumC != total)
                    {
                        Response.Write("Condition Not Matched Coloum No:" + r);
                        break;
                    }
                    count++;
                }
                points = count * per;
                point.Text = points.ToString();
                if (points == 10.0)
                {
                    Response.Write("PUZZLE SOLVED.WELL DONE...........");
                    Button2.Enabled = false;
                }
            }
            else
            {
                Response.Write("Fill All The Boxes.....");
            }
        }

    }
    void createbox()
    {
        Panel1.Controls.Clear();
        int i, j, l, n, tp = 1, z, b, q, te;
        int[] index, valu;

        l = 0;
        n = int.Parse(val.Text);
        tp = ((n * n) * 40) / 100;
        index = new int[tp + 1]; valu = new int[n + 1]; Random rn = new Random();

        i = 1;
        while (i <= tp)
        {
            z = rn.Next(1, (n * n)); q = 0; b = 1;
            while (b < i)
            {
                if (index[b] == z)
                {
                    q++;
                    break;
                }
                b++;

            }
            if (q == 0)
            {
                index[i] = z; i++;
            }


        }

        for (i = 1; i <= tp - 1; i++)
        {
            for (j = 1; j <= tp - i; j++)
            {
                if (index[j] > index[j + 1])
                {
                    te = index[j];
                    index[j] = index[j + 1];
                    index[j + 1] = te;

                }
            }
        }


        int to = (((n * ((n * n) + 1)) / 2) / n); int total = 0; i = 1;
        while (i < n)
        {
            z = rn.Next(1, to); q = 0; b = 1;
            while (b < i)
            {



                if (valu[b] == z)
                {
                    q++;
                    break;

                }
                b++;

            }
            if (q == 0)
            {
                valu[i] = z; total = total + valu[i]; i++;
            }
        }
        valu[i] = ((n * ((n * n) + 1)) / 2) - total;

        int[,] sol;
        sol = new int[n + 1, n + 1]; int si = 0;
        int w = rn.Next(1, 3);
        if (w == 1)
        {
            for (i = 1; i <= n; i++)
            {
                si = i;
                for (j = 1; j <= n; j++)
                {
                    if (si <= n)
                    {
                        sol[i, j] = valu[si];
                        si++;
                    }
                    else
                    {
                        si = 1;
                        sol[i, j] = valu[si]; si++;
                    }
                }
            }
        }
        else
        {
            for (i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    si = i;
                }
                else
                {
                    si = (n + 2) - i;
                }
                for (j = 1; j <= n; j++)
                {
                    if (si <= n)
                    {
                        sol[i, j] = valu[si];
                        si++;
                    }
                    else
                    {
                        si = 1;
                        sol[i, j] = valu[si]; si++;
                    }
                }
            }
        }


        int y;

        for (i = 1; i <= n; i++)
        {
            for (j = 1; j <= n; j++)
            {
                l++;
                TextBox t = new TextBox();
                t.Width = 50;
                t.Height = 20;
                t.ID = "d" + l.ToString();
                Panel1.Controls.Add(t);
                for (y = 1; y <= tp; y++)
                {
                    if (l == index[y])
                    {


                        TextBox m = Panel1.FindControl("d" + l.ToString()) as TextBox;

                        m.Text = sol[i, j].ToString();
                        m.BackColor = Color.Yellow;

                        break;

                    }


                }

            }
            Panel1.Controls.Add(new LiteralControl("<br />"));
        }
        aim.Text = ((n * ((n * n) + 1)) / 2).ToString();
        
    }
    void createbox1(int c)
    {

        Panel1.Controls.Clear();
        int i, j, l; l = 0;

        for (i = 1; i <= c; i++)
        {
            for (j = 1; j <= c; j++)
            {
                l++;
                TextBox t = new TextBox();
                t.Width = 50;
                t.Height = 20;
                t.ID = "d" + l.ToString();
                Panel1.Controls.Add(t);
            }
            Panel1.Controls.Add(new LiteralControl("<br />"));
        }

     }
    protected void point_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("home.aspx");
    }
}
