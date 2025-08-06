public class Handler
{
    public static Response HandleEvent(Event inputEvent)
    {
        return new Response
        {
            StatusCode = 200,
            Body = "{\"msg\": \"hello world\"}"
        };
    }
}