﻿using System;

namespace TaskApi.BusinessRules.Requests
{
    public class UpsertTaskRequest
    {
        public Guid? Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool Done { get; set; }
    }
}
