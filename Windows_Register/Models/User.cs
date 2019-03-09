namespace Models
{
    /// <summary>
    /// User calss.
    /// </summary>
     public class User: object
    {
        /// <summary>
        /// Costrucor user.
        /// </summary>
        public User():base()
        {

        }

        /// <summary>
        /// Firs username.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last user name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gender user.
        /// </summary>
        public Models.Enums.Gender Gender { get; set; }       

        /// <summary>
        /// Security questions can be used to access the account.
        /// </summary>
        public Models.Enums.Question SecutrityQuestion { get; set; }
        
    }
}
