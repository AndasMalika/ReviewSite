using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ReviewSite.Data;
using ReviewSite.Model;

namespace ReviewSite.Pages.Questionnaires
{
	[BindProperties]
	public class CreateModel : PageModel
	{
		private readonly ApplicationDbContext _db;
		public FriendshipQuestionnaire Questionnaire { get; set; }
		public CreateModel(ApplicationDbContext db)
		{
			_db = db;
		}
		public void OnGet()
		{
		}
		public async Task<IActionResult> OnPost()
		{
			if (ModelState.IsValid)
			{
				await _db.FriendshipQuestionnaire.AddAsync(Questionnaire);
				await _db.SaveChangesAsync();
				TempData["success"] = "Анкета успешно создана";
				return RedirectToPage("Index");
			}
			return Page();
		}
	}
}
