using System.ComponentModel;
using System.Windows.Input;

namespace Binding.Test.TestData
{
    public class ViewModel
    {
        public interface WithCommandProperty 
        {
            object ObjectProperty { get; }
            ICommand CommandProperty { get; }
        }

        public interface WithoutINotifyPropertyChangedImplementation
        {
            object ObjectProperty { get; }
        }

        public interface WithINotifyPropertyChangedImplementation : INotifyPropertyChanged
        {
            object ObjectProperty { get; set; }
        }
    }
}