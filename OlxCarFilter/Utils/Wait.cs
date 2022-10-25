namespace OlxCarFilter.Utils;

public static class Wait
{
	public static void ForASecond() => Thread.Sleep(1000);
	public static void Forever() => Thread.Sleep(1000000000);
}
