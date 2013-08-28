using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace RadTreeViewContainerBindings
{
	public class Person : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		private string name;
		private bool selected = false;

		public Person(string name)
		{
			this.name = name;
		}

		public Person(string name, bool selected)
		{
			this.name = name;
			this.selected = selected;
		}

		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				if (value != this.name)
				{
					this.name = value;
					this.NotifyPropertyChanged("Name");
				}
			}
		}

		public bool Selected
		{
			get
			{
				return this.selected;
			}
			set
			{
				if (value != this.selected)
				{
					this.selected = value;
					NotifyPropertyChanged("Selected");
				}
			}
		}

		private void NotifyPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
