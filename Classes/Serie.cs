using System;

namespace series_registration
{
    public class Serie : BaseEntity
    {
        private Genre Genre { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }

        public Serie (int id, Genre genre, string title, string description, int year)
        {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = description;
            this.Year = year;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public int GetId()
        {
            return this.Id;
        }

        public string GetTitle()
        {
            return this.Title;
        }
    }
}
