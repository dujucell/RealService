using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CustomErrors
/// </summary>
public static class CustomErrors
{
    public static string EMPTY_STRING = "";
    public static string ROW_DELETED_ERROR = " An error occurred while attempting to delete the row. ";
    public static string ERROR_UPDATING = " No records were updated, please try again. ";
    public static string ERROR_EMAIL_FAILED = " Failed to send email, please check your internet connection and try again. ";
    public static string DATE_OF_BIRTH_ERROR = " Date of birth cannot exceed today (mm/dd/yyyy). ";
    public static string NO_ACCOUNT = " It appears that you do not have an account with us, please contact our administrator!!";
    public static string REQUIRED_FIELD = " You have left out information for a required field. ";
    public static string NUMERIC_ERROR = " Ensure you have entered numbers in numeric/currency fees. ";
    public static string CHANGES_ACCEDTED_STATUS = " Changes Accepted: ";
    public static string PRICE_LESS_THAN_ZERO = " You cannot have a negative property value. ";
    public static string DATE_POSTED_ERROR = " Date posted cannot exceed today. ";
    public static string INTERESTS_EXISTS = " You are already watching this property. ";
    public static string WATCH_OWN_PROPERTY = " You cannot watch your own property. ";
    public static string EMAIL_SENT = " Thank you for using our messaging system, your email has been sent!! ";
    public static string NO_EMAIL_FOR_CLIENT = " There is no email address for this client!! OR <br/>You have no clients in your client list!! ";
    public static string GMAPS_DEFAULT_COORDS = "GMaps Coordinate defaulted to null. Valid coordinates may be used up to 15 decimal places.";
}
