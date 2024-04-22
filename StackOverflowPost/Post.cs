using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }

        public int VoteCount { get; private set; }

        public void UpVote(string upVote) 
        {
            VoteCount++;
        }

        public void DownVote(string downVote)
        {
            VoteCount--;
        }

    }
}
