using Xamarin.Forms;

namespace TestCenter.Views.CustomComponets
{
    public class TextCellExtended : TextCell
    {
        public static readonly BindableProperty ShowDisclosureProperty = BindableProperty.Create<TextCellExtended, bool>(p => p.ShowDisclosure, default(bool));

        public bool ShowDisclosure
        {
            get { return (bool)GetValue(ShowDisclosureProperty); }
            set { SetValue(ShowDisclosureProperty, value); }
        }
    }
}
