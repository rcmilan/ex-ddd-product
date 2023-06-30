using ProductApi.Models.Users.Accounts;

namespace ProductApi.Models.Users;

public record Account(UserProductCollection Products) : User;