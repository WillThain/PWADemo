namespace PWADemo.API.Helpers
{
    public class PaginationHeader
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        
        public PaginationHeader(int CurrentPage, int TotalPages, int TotalItems, int ItemsPerPage)
        {
            this.CurrentPage = CurrentPage;
            this.TotalPages = TotalPages;
            this.TotalItems = TotalItems;
            this.ItemsPerPage = ItemsPerPage;
        }
    }
}