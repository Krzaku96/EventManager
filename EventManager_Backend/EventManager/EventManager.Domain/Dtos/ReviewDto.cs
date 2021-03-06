using System;
using System.Collections.Generic;
using System.Text;

namespace EventManager.Domain.Dtos
{
    public class ReviewDto
    {
        public int Id { get; set; }

        public int LectureId { get; set; }

        public int ReviewerId { get; set; }

        public int Rate { get; set; }

        public string Nickname { get; set; }

        public string Comment { get; set; }
    }
}
