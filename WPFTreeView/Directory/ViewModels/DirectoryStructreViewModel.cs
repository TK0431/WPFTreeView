using System.Collections.ObjectModel;
using System.Linq;

namespace WPFTreeView
{
    /// <summary>
    /// The view model for teh applications main Directory view
    /// </summary>
    public class DirectoryStructreViewModel:BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// A list of all directories on the machine
        /// </summary>
        public ObservableCollection<DirectoryItemViewModel> Items { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public DirectoryStructreViewModel()
        {
            // Get the logical drives
            var childeren = DirectoryStructure.GetLogicalDrives();

            // Create the view models from the data
            this.Items = new ObservableCollection<DirectoryItemViewModel>(
                childeren.Select(drive => new DirectoryItemViewModel(drive.FullPath, DirectoryItemType.Drive)));
        }

        #endregion
    }
}
