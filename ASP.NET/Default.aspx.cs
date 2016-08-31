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

    protected void confirmLang_Click(object sender, EventArgs e)
    {
        
            langDisplayed.Text = DropDownList1.SelectedValue;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        foreach(ListItem item in CheckBoxList1.Items)
        {
            if (item.Selected)
            {
                LabelForIcecreams.Text += item.Value + "<br/>";
            }
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        foreach(ListItem item in ListBox1.Items)
        {
            if (item.Selected)
            {
                Label2.Text += item.Value + "<br/>";
            }
        }
    }
}