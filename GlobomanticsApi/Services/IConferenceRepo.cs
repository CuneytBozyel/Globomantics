using System.Collections.Generic;
using Shared.Models;

namespace GlobomanticsApi.Services
{
    public interface IConferenceRepo
    {
        ConferenceModel Add(ConferenceModel model);
        IEnumerable<ConferenceModel> GetAll();
        ConferenceModel GetById(int id);
    }
}