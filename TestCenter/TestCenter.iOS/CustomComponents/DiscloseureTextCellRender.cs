using TestCenter.iOS.CustomComponents;
using TestCenter.Views.CustomComponets;
using UIKit;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(TextCellExtended), typeof(DiscolosureTextCellRenderer))]

namespace TestCenter.iOS.CustomComponents
{
    public class DiscolosureTextCellRenderer : Xamarin.Forms.Platform.iOS.TextCellRenderer
    {
        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);

            var textCellExtended = item as TextCellExtended;

            if (textCellExtended.ShowDisclosure)
                cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;

            return cell;
        }
    }
}