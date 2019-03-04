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
        /// Post User
        /// </summary>
        public string Post { get; set; }

        /// <summary>
        /// User access level to software.
        /// </summary>
        public string AccessRate { get; set; }

        /// <summary>
        /// Birthday.
        /// </summary>
        public int Day { get; set; }

        /// <summary>
        /// birth month.
        /// </summary>
        public string Month { get; set; }

        /// <summary>
        /// Year of birth.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Email to verify your account.
        /// </summary>
        public string VerificationEmail { get; set; }

        /// <summary>
        /// Confirm email user.
        /// </summary>
        public string ConformEmail  { get; set; }

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

        public object ImagePassword { get; set; }


        /// <summary>
        /// Verification code to confirm user account.
        /// </summary>
        public string VerificationCode
        {
            get
            {
                string Code = SecurityCode();

                return Code;
            }            
        }

        /// <summary>
        /// 
        /// </summary>
        public string ResetPasswordEmail { get; set; }

        public int ResetPasswordPhone { get; set; }

        public object RessetPasswordPicture { get; set; }




        /// <summary>
        /// Security code generation method.
        /// </summary>
        /// <returns>Result</returns>
        private string SecurityCode()
        {
            string result = null;
            System.Random R = new System.Random();

            for (int index = 0; index == 5; index++)
            {
                result += (char)R.Next(65, 90);
            }

            return result;
        }


        

    }
}
