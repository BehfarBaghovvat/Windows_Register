namespace Windows_Register
{
    /// <summary>
    /// User calss.
    /// </summary>
    class User
    {
        /// <summary>
        /// Costrucor user.
        /// </summary>
        public User()
        {

        }

        /// <summary>
        /// Firs user name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last user name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gender user.
        /// </summary>
        public string Gender { get; set; }       

        /// <summary>
        /// Email to verify your account.
        /// </summary>
        public string VerificationEmail { get; set; }

        /// <summary>
        /// Confirm email user.
        /// </summary>
        public string ConformEmail { get; set; }

        /// <summary>
        /// Password for user account security.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Confirm password.
        /// </summary>
        public string ConfigPassword { get; set; }

        /// <summary>
        /// Set up the phone to perform password recovery operations.
        /// </summary>
        public int SetPhonNumber { get; set; }

        /// <summary>
        /// Import multiple photos for use in password recovery.
        /// </summary>
        public object ImagePassword { get; set; }

        /// <summary>
        /// Verification code to confirm user account.
        /// </summary>
        public string VerificationCode { get; }        

        /// <summary>
        /// To receive the password,
        /// the user's registered email will be received.
        /// </summary>
        public string ResetPasswordEmail { get; set; }

        /// <summary>
        /// To receive the code via SMS,
        /// the registered user's phone is received.
        /// </summary>
        public int ResetPasswordPhone { get; set; }

        /// <summary>
        /// In order to log in to the user account,
        /// the photos must be identified.
        /// </summary>
        public object RessetPasswordPicture { get; set; }

        /// <summary>
        /// Security questions can be used to access the account.
        /// </summary>
        public string SecutrityQuestion { get; set; }

        /// <summary>
        /// Your answer to the security question provides access.
        /// </summary>
        public string UserAnswer { get; set; }
    }
}
