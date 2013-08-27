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
using System.Collections.Generic;

namespace RadTreeViewContainerBindings
{
	public class DataSource : List<Organization>
	{
		public DataSource()
		{
			Organization telerik = new Organization("Telerik", false, true);
			Department silverlight = new Department("Silverlight", false, true);
			Department wpf = new Department("WPF", false, false);

			telerik.Departments.Add(silverlight);
			telerik.Departments.Add(wpf);

			silverlight.Employees.Add(new Person("John", true));
			silverlight.Employees.Add(new Person("Ben", false));
			silverlight.Employees.Add(new Person("Ann", false));

			wpf.Employees.Add(new Person("Karoline", false));
			wpf.Employees.Add(new Person("Simone", false));
			wpf.Employees.Add(new Person("Eduard", false));

			this.Add(telerik);
		}
	}
}