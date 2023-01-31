﻿using System.Threading.Tasks;
using Synology.Api.Client.Apis.DownloadStation.Task.Models;
using Synology.Api.Client.Shared.Models;

namespace Synology.Api.Client.Apis.DownloadStation.Task
{
    public interface IDownloadStationTaskEndpoint
    {
        Task<DownloadStationTaskListResponse> ListAsync();
        
        Task<BaseApiResponse> CreateAsync(DownloadStationTaskCreateRequest request);

        Task<DownloadStationTaskDeleteResponse> DeleteAsync(DownloadStationTaskDeleteRequest data);
    }
}
