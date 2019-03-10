namespace Models
{
	/// <summary>
	/// User calss.
	/// </summary>
	public class User : object
	{
		/// <summary>
		/// Costrucor user.
		/// </summary>
		public User() : base()
		{

		}

		/// <summary>
		/// FirstName username.
		/// </summary>
		public string FirstName { get; set; }

		/// <summary>
		/// LastName username.
		/// </summary>
		public string LastName { get; set; }

		/// <summary>
		/// Birth username
		/// </summary>
		public System.DateTime BirthDate { get; set; }

		/// <summary>
		/// Password username.
		/// </summary>
		public string Password { get; set; }

		/// <summary>
		/// E-mail username.
		/// </summary>
		public string Email { get; set; }

		/// <summary>
		/// Gender username.
		/// </summary>
		public Models.Enums.Gender Gender { get; set; }

		/// <summary>
		/// Security questions can be used to access the account.
		/// </summary>
		public Models.Enums.Question SecutrityQuestion { get; set; }

		/// <summary>
		/// Which pages have visited
		/// </summary>
		public string GetDirection { get; set; }

		/// <summary>
		/// What files have uploaded
		/// </summary>
		public string GetUploadFile { get; set; }

		/// <summary>
		/// What files to download
		/// </summary>
		public string GetDownloadFile { get; set; }

		/// <summary>
		/// With what IP has been communicated.
		/// </summary>
		public int CommunicationIP { get; set; }

		/// <summary>
		/// Connection time to network
		/// </summary>
		public System.Timers.Timer ConnectionTime { get; set; }

	}
}
