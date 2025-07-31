public class Handler
{
    public Response HandleEvent(Event inputEvent)
    {
        return new Response
        {
            StatusCode = 200,
            Body = "hello world"
        };
    }
}
