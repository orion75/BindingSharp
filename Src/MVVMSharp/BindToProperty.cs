using System;
using System.ComponentModel;

namespace MVVMSharp.Gtk
{
    public class BindToProperty : IBinder
    {
        private object view;
        private string viewProperty;

        public BindToProperty(object view, string property)
        {
            this.view = view ?? throw new System.ArgumentNullException(nameof(view));
            this.viewProperty = property ?? throw new System.ArgumentNullException(nameof(property));
        }

        public void Bind(object viewModel, string commandPropertyName)
        {
            if(viewModel == null)
                throw new ArgumentNullException(nameof(viewModel));

            var property = viewModel.GetType().GetProperty(commandPropertyName);

            if(property == null)
                throw new BindingException(viewModel, $"Property {commandPropertyName} is not a property of viewmodel.");

            if(!(viewModel is INotifyPropertyChanged))
                throw new BindingException(viewModel, $"ViewModel does not implement {nameof(INotifyPropertyChanged)}");

        }
    }
}