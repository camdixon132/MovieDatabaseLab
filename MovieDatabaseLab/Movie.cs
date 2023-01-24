using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseLab
{
	public class Movie
	{
		//properties
		public string Title { get; set; }
		public string Category { get; set; }

		//constructors
		public Movie(string _title, string _category)
		{
			Title = _title;
			Category = _category;
		}

		//methods
		public string MovieTitle()
		{
			return Title;
		}
		public string MovieCategory()
		{
			return Category;
		}
	}
}

