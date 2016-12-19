using System;
using Xamarin.Forms;

namespace App1.Controls
{
    class TextEntry : Frame
    {
        public TextEntry()
        {
            this.Padding = 0;
            _entry = new Entry();
            _entry.Margin = new Thickness(5,0,5,-10);
            this.Content = _entry;
        }

        private static Entry _entry;

        public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string),
            typeof(TextEntry), null, BindingMode.Default, null, OnTextChanged);

        private static void OnTextChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            _entry.Text = (string)newvalue;
        }

        public string Value
        {
            get
            {
                return (string)GetValue(TextProperty);
            }
            set
            {
                SetValue(TextProperty, value);
            }
        }
    }
}
