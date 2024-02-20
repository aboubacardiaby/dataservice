
namespace dataservice.Services
{
    public class ApiKeyRoleLink : IApiKeyRoleLink
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string ConfigurationKey { get; set; }
    }
}
