using PropertyChanged;
using System.ComponentModel;

namespace WPFTreeView
{
    [AddINotifyPropertyChangedInterface]
    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// The event that is fired
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender,e) => { };
    }
}
