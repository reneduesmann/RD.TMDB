namespace RD.TMDB.Domain.Configurations;

public static class ErrorMessage
{
    public const string FailedToHandleChangeItem = "Failed to handle change item.";

    public const string PropertyNotFound = "Property {0} not found.";

    public const string ChangeKeyNotFound = "Change key {0} not found.";

    public const string ChangeKeyNotSupported = "Change key {0} is not supported.";

    public const string ChangeKeyDeserializationFailed = "Failed to deserialize value with change key {0}.";

    public const string TypeNotSupported = "Type {0} is not supported.";

    public const string TypeDeserializationFailed = "Failed to deserialize value with type {0}.";

    public const string FailedToParseReaderToNode = "Failed to parse reader to node.";

    public const string FailedToDeserializeType = "Failed to deserialize type to {0}.";

    public const string FailedToConvertType = "Failed to convert value {0} to type {1}.";

    public const string InvalidExternalSource = "Invalid external source: {0}.";

    public const string AtLeastOneSessionIdIsRequired = "At least one of the session ids must be provided.";

    public const string InvalidPropertyValue = "Invalid {0} value.";

    public const string ApiConfigurationMissingImageUrl = "Api configuration missing secure image url.";
}
