namespace Author.Signup;

public class Endpoint : Endpoint<Request, EmptyResponse>
{
    public override void Configure()
    {
        Post("/author/signup");
        AllowAnonymous();
    }

    public override async Task HandleAsync(Request req, CancellationToken ct)
    {
        await SendAsync(new EmptyResponse()
        {
            // TODO: add stuff
        });
    }
}
