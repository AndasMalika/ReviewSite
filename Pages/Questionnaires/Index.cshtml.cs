using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ReviewSite.Data;
using ReviewSite.Model;

namespace ReviewSite.Pages.Questionnaires
{
    public class IndexModel : PageModel
    {
		private readonly ApplicationDbContext _db;
		public IEnumerable<FriendshipQuestionnaire> Questionnaires { get; set; }
		public IndexModel(ApplicationDbContext db)
		{
			_db = db;
		}

		public void OnGet()
		{
			Questionnaires = _db.FriendshipQuestionnaire;
		}
	}
}
