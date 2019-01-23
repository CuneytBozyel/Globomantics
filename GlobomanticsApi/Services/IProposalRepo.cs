﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace GlobomanticsApi.Services
{
    public interface IProposalRepo
    {
        ProposalModel Add(ProposalModel model);
        ProposalModel Approve(int proposalId);
        IEnumerable<ProposalModel> GetAllForConference(int conferenceId);
        ProposalModel GetById(int id);
    }
}