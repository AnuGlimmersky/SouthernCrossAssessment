using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouthernCrossAssessment.Helpers
{
    public static class Resources
    {
        public static string RegistrationPageUrl = "prod/users";
        public static string UserAlreadyExists=> "UsernameExistsException: User already exists";
        public static string InvalidPasswordMissingUpperCase => "InvalidPasswordException: Password did not conform with policy: Password must have uppercase characters";
        public static string InvalidPasswordMissingSymbol=> "InvalidPasswordException: Password did not conform with policy: Password must have symbol characters";
        public static string InvalidPasswordMissingLowerCase=> "InvalidPasswordException: Password did not conform with policy: Password must have lowercase characters";
        public static string InvalidPasswordlength => "InvalidParameter: 1 validation error(s) found. - minimum field size of 6, SignUpInput.Password.";
  
    
    }
}
