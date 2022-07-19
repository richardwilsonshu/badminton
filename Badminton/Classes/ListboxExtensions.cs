using System.ComponentModel;

namespace Badminton.Classes
{
    public static class ListboxExtensions
    {
        public static void BindPlayers(this ListBox listBox, IBindingList players)
        {
            Bind(listBox, players, nameof(Player.FullName), nameof(Player.Id));
        }

        public static void Bind(this ListBox listBox, IBindingList bindingList, string displayMember, string valueMember)
        {
            listBox.DisplayMember = displayMember;
            listBox.ValueMember = valueMember;
            listBox.DataSource = bindingList;
        }
    }
}
