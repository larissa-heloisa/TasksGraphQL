using FluentValidation.Results;
using System;
using System.Collections.Generic;

namespace TaskApi.BusinessRules.Responses
{
    public class UpsertTaskResponse
    {
        public UpsertTaskPayload Payload { get; set; }
        public List<ValidationFailure> Errors { get; set; }
    }

    public class UpsertTaskPayload
    {
        public Guid? Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool Done { get; set; }

        public DateTime? DateDone { get; set; }

    }
}
