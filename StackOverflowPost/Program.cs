using StackOverflowPost;

Post post = new Post();

    Console.Write("Enter post title: ");
    post.Title = Console.ReadLine();
    Console.Write("Enter post description: ");
    post.Description = Console.ReadLine();

    post.CreatedAt = DateTime.Now;
    Console.WriteLine($"Created on: {post.CreatedAt}");

while (true)
{
    Console.Write("Enter: 'up' to Upvote, 'down' to downvote or 'exit' to exit: ");
    var input = Console.ReadLine();

    if (input.ToLower() == "exit")
    {
        Console.WriteLine("Exited");
        break;
    }

    else if (input.ToLower() == "up")
    {
        post.UpVote(input);
        Console.WriteLine($"Votes: {post.VoteCount}");
    }
    else if (input.ToLower() == "down")
    {
        post.DownVote(input);
        Console.WriteLine($"Votes: {post.VoteCount}");

    }

    else
    {
        Console.WriteLine("Invalid input");
        continue;
    }

}
