namespace Zurii_Core.GenericResponse;

public class JsonResponseDto
{
    public int code { get; set; }
    public dynamic message { get; set; }
    public dynamic data { get; set; }
}