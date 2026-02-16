using Umbraco.Cms.Api.Management.ViewModels.PublicAccess;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Services.OperationStatus;

namespace Umbraco.Cms.Api.Management.Factories;

public interface IPublicAccessPresentationFactory
{
    Attempt<PublicAccessResponseModel?, PublicAccessOperationStatus> CreatePublicAccessResponseModel(PublicAccessEntry entry, Guid contentKey);

    [Obsolete("Use the overload taking both PublicAccessEntry and contentKey. contentKey is required to determine if the entry is for the current content or an ancestor.")]
    Attempt<PublicAccessResponseModel?, PublicAccessOperationStatus> CreatePublicAccessResponseModel(PublicAccessEntry entry);

    PublicAccessEntrySlim CreatePublicAccessEntrySlim(PublicAccessRequestModel requestModel, Guid contentKey);
}