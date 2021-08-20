namespace series_registration
{
    public class Serie : BaseEntity
    {
        private Genre Genre { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }
        private bool Deleted { get; set; }

        public Serie(int id, Genre genre, string title, string description, int year)
        {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.Deleted = false;
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

        public void MarkAsDeleted()
        {
            this.Deleted = true;
        }
    }
}
