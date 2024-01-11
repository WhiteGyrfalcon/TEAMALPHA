using System.Security.Claims;

namespace FunnyBunnyGames.Services.Infrastructure
{
	public static class ClaimPrincipalExtension
	{
		public static Guid GetUserId(this ClaimsPrincipal user)
		{
			string id = string.Empty;

			if (user != null)
			{
				id = user.FindFirstValue(ClaimTypes.NameIdentifier);
			}

			return Guid.Parse(id);
		}
	}
}
