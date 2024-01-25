namespace WorkForAll.Constants.Enums;

#region MaritalStatusCode
public enum MaritalStatus
{
    //'M' -> 77 * 10 (decimal) + 'D' -> 68
    Divorced = 838,
    LifePartner = 846,
    Married = 847,
    Single = 853,
    Widowed = 857,
    //'M' -> 77 * 10 (decimal) + ('S' -> 83 + 'e' -> 101)/2 -> 92
    Separated = 862
}
#endregion