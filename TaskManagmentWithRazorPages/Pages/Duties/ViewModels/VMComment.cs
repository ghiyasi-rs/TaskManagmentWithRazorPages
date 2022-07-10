namespace TaskManagmentWithRazorPages.Pages.Duties.ViewModels
{
    public class VMComment
    {
        public int Id { get; set; }
        public int DutyId { get; set; }
        public DateTime AddedDate { get; set; } = DateTime.Now.Date;
        public string CommentText { get; set; }
        public int Type { get; set; }
        public DateTime ReminderDate { get; set; } = DateTime.Now.Date;
    }
  
}
