﻿namespace BitzArt.Pagination.Models
{
    public class PageRequest
    {
        public int Skip { get; set; }
        public int Take { get; set; }

        public PageRequest(int skip, int take)
        {
            Skip = skip;
            Take = take;
        }
    }
}
