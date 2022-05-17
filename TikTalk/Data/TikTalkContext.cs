using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TikTalk.Models;

namespace TikTalk.Data
{
    public class TikTalkContext : DbContext
    {
        public TikTalkContext (DbContextOptions<TikTalkContext> options)
            : base(options)
        {
        }

        public DbSet<TikTalk.Models.Review>? Review { get; set; }
    }
}
