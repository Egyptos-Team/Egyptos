namespace Egyptos.Domain.Consts;

public static class DefaultRoles
{
    public partial class Admin
    {
        public const string Name = nameof(Admin);
        public const string Id = "0191d311-2918-7f76-bd8a-0bded8535075";
        public const string ConcurrencyStamp = "0191d311-2918-7f76-bd8a-0be08dd83078";
    }


    public partial class User
    {
        public const string Name = nameof(User);
        public const string Id = "0191d311-2918-7f76-bd8a-0bdf740adff8";
        public const string ConcurrencyStamp = "0191d311-2918-7f76-bd8a-0be100f11384";
    }

    public partial class Employee
    {
        public const string Name = nameof(Employee);
        public const string Id = "ce2fd704-7a3c-4a03-846e-c5479a8b921d";
        public const string ConcurrencyStamp = "aacecacd-28e1-43cc-92da-decb1f9b32c4";
    }

    public partial class TourGuide
    {
        public const string Name = nameof(TourGuide);
        public const string Id = "6CCF2454-C7FE-4F58-89FB-F565AE5643E3";
        public const string ConcurrencyStamp = "B1F115C4-D298-4C6D-AA7B-6C7DC785A1C5";
    }

}
