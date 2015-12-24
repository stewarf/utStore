using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace utStore.Library
{
    public class Validation
    {
        public enum ValidTypeEnum
        {
            Numeric,
            Alpha,
            AlphaNumeric,
            Email,
            Money,
            Decimal
        }

        public static bool IsValid(ValidTypeEnum validType, string validString, bool canBeEmpty=false)
        {
            string pattern = string.Empty;

            switch (validType)
            {
                case ValidTypeEnum.Numeric:
                    pattern = @"^-?[0-9]+$";
                    break;
                case ValidTypeEnum.Alpha:
                    pattern = @"^[a-zA-Z]+$";
                    break;
                case ValidTypeEnum.AlphaNumeric:
                    pattern = @"^[a-zA-Z0-9]+$";
                    break;
                case ValidTypeEnum.Email:
                    pattern = @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$";
                    break;
                case ValidTypeEnum.Money:
                    pattern = @"^\$?[0-9,]*[0-9]+(\.[0-9]+)?$";
                    break;
                case ValidTypeEnum.Decimal:
                    pattern = @"^-?[0-9]+(\.[0-9]*)?$";
                    break;
            }

            Regex rg = new Regex(pattern);
            return (canBeEmpty && validString == String.Empty) ? true : rg.IsMatch(validString);
        }
    }
}
