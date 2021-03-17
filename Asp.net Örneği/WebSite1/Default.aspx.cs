using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int miktar, vade, tur;
        miktar = Convert.ToInt32(TextBox1.Text);
        vade = Convert.ToInt32(TextBox2.Text);
        tur = Convert.ToInt32(DropDownList1.SelectedIndex);
        double faiz,aylık,toplam;
        if (tur == 1)
        {
            faiz = 0.0108;
            aylık = (miktar * faiz) / (1 - 1 / Math.Pow((1 + faiz), vade));
            toplam = aylık * vade;
            Label1.Text = aylık.ToString() + " TL";
            Label2.Text = toplam.ToString() + " TL";
            Label1.Visible = true;
            Label2.Visible = true;
        }
        else if (tur == 2)
        {
            faiz = 0.0125;
            aylık = (miktar * faiz) / (1 - 1 / Math.Pow((1 + faiz), vade));
            toplam = aylık * vade;
            Label1.Text = aylık.ToString() + " TL";
            Label2.Text = toplam.ToString() + " TL";
            Label1.Visible = true;
            Label2.Visible = true;
        }

    }
}