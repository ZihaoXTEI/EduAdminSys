using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduAdminSys.frmMang.classes
{
    class ComboBoxItem
{
    private string text;
    private string values;

    public string Text
    {
        get { return this.text; }
        set { this.text = value; }
    }

    public string Values
    {
        get { return this.values; }
        set { this.values = value; }
    }

    public ComboBoxItem(string _Text, string _Values)
    {
        Text = _Text;
        Values = _Values;
    }


    public override string ToString()
    {
        return Text;
    }
}
}
