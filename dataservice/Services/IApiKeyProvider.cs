namespace dataservice.Services
{
    public interface IApiKeyProvider
    {
        string HeaderName { get; }

        IReadOnlyCollection<IApiKeyRoleLink> ApiKeyRoleLinks { get; }
    }

    public interface IApiKeyRoleLink
    {
        /// A unique identifer for the role.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// A Frendly name for the role.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The configuration key containing the underlying ApiKey value.
        /// </summary>
        string ConfigurationKey { get; }
    }
}
