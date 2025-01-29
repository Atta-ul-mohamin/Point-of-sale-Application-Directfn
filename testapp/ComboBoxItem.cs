using System;

namespace POINT_OF_SALE_APPLICATION
{
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString() // This will be used to display the name in the dropdown
        {
            return Text;
        }
    }
}
