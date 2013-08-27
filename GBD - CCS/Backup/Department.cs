using System.Collections.Generic;
using System.ComponentModel;

namespace RadTreeViewContainerBindings
{
	public class Department : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private string name;
		private bool selected = false;
		private bool expanded = false;

		public Department(string name)
		{
			this.name = name;
			Employees = new List<Person>();
		}

		public Department(string name, bool selected, bool expanded)
		{
			this.name = name;
			this.selected = selected;
			this.expanded = expanded;
			Employees = new List<Person>();
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

		public List<Person> Employees
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
