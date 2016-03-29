﻿using System.Collections.Generic;
using Parliament.Common.Extensions;
using Parliament.Interact.Core.Domain;
using Parliament.Interact.Core.Services;
using Parliament.Interact.Web.Models;

namespace Parliament.Interact.Web.ViewModelBuilders
{
    public class IssueViewModelBuilder : IIssueViewModelBuilder
    {
        private readonly IIssueService _issueService;

        public IssueViewModelBuilder(IIssueService issueService)
        {
            _issueService = issueService;
        }

        public IList<IssueViewModel> Build()
        {
            var issues = _issueService.GetTopFiveIssues();
            return issues.SelectToList(BuildIssueViewModel);
        }

        public IssueViewModel Build(int id)
        {
            var issue = _issueService.GetIssueById(id);
            return BuildIssueViewModel(issue);
        }

        private FurtherReadingViewModel BuildFurtherReadingViewModel(IssueFurtherReading reading)
        {
            return new FurtherReadingViewModel
            {
                    LinkName = reading.LinkName,
                    LinkUrl = reading.LinkUrl,
                    DisplayExternalIcon = reading.DisplayExternalIcon
            };
        }

        private TimeLineViewModel BuildTimeLineViewModel(IssueTimeLine timeline)
        {
            return new TimeLineViewModel
            {
                TimelineType = timeline.TimelineType,
                HTMLContent = timeline.HTMLContent
            };
        }

        private IssueViewModel BuildIssueViewModel(Issue issue)
        {
            return new IssueViewModel
            {
                Content = issue.Content,
                Id = issue.Id,
                Title = issue.Title,
                FurtherReadings = issue.FurtherReadings.SelectToList(BuildFurtherReadingViewModel),
                TimeLines = issue.TimeLines.SelectToList(BuildTimeLineViewModel)
            };
        }
    }
}