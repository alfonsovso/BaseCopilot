using BaseCopilot.Shared.Models.Project;
using Mapster;

namespace BaseCopilot.API.Data
{
    public class MapsterConfiguration
    {
        public static void Configure()
        {
            TypeAdapterConfig<Project, ProjectResponse>.NewConfig()
            .Map(dest => dest.Description, src => src.ProjectDetails != null ? src.ProjectDetails.Description : null)
            .Map(dest => dest.Start, src => src.ProjectDetails != null ? src.ProjectDetails.Start : null)
            .Map(dest => dest.End, src => src.ProjectDetails != null ? src.ProjectDetails.End : null);
        }
    }
}
