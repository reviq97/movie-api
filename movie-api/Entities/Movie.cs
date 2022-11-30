namespace movie_api.Entities
{
    public class Movie
    {
		private long _id;
		private string _title;
		private string _director;
		private int _year;
		private int _rate;

		public int Rate
		{
			get { return _rate; }
			init { _rate = value; }
		}

		public int Year
		{
			get { return _year; }
			init { _year = value; }
		}

		public string Director
		{
			get { return _director; }
			init { _director = value; }
		}

		public string Title
		{
			get { return _title; }
			init { _title = value; }
		}

		public long Id
		{
			get { return _id; }
			init { _id = value; }
		}

	}
}
