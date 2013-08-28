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
using System.Collections.Generic;

namespace RadTreeViewContainerBindings
{
	public class Organization : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private string name;
		private bool selected = false;
		private bool expanded = false;

		public Organization(string name)
		{
			this.name = name;
			Departments = new List<Department>();
		}
		
		public Organization(string name, bool selected, bool expanded)
		{
			this.name = name;
			this.selected = selected;
			this.expanded = expanded;
			Departments = new List<Department>();
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
					NotifyPropertyChanged("Name");
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

		public bool Expanded
		{
			get
			{
				return this.expanded;
			}
			set
			{
				if (value != this.expanded)
				{
					this.expanded = value;
					NotifyPropertyChanged("Expanded");
				}
			}
		}

		public List<Department> Departments
		{
			get;
			set;
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
