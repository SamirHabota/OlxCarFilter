namespace OlxCarFilter.Models;

public class EnumValue<T>
{
	public T Enum { get; set; } = default(T)!;
	public string Value { get; set; } = null!;
}
