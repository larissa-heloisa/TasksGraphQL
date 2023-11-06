using System;

namespace TaskApi
{

    public class Task
    {
        public Guid? Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool Done { get; set; }

        public DateTime? DateDone { get; set; }
    }
}

