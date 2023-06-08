using System;
using System.Reflection;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 666)]
public struct HelloWorld
{
    [FieldOffset(0)]
    private byte[] _greetingBytes;
    [FieldOffset(666 - 11)]
    private Func<string>[] _greetingActions;

    public HelloWorld(IntPtr handle)
    {
        _greetingBytes = new byte[] { 72, 101, 108, 108, 111, 32, 87, 111, 114, 108, 100 };
        _greetingActions = new Func<string>[1];
        _greetingActions[0] = () => Marshal.PtrToStringAnsi(handle);

        Console.WriteLine(string.Join("", GetGreeting()));
    }

    private string GetGreeting()
    {
        MethodInfo methodInfo = GetType().GetMethod("\u0047\u0065\u0074\u0047\u0072\u0065\u0065\u0074\u0069\u006e\u0067", BindingFlags.NonPublic | BindingFlags.Instance);
        return ((Func<string>)methodInfo.CreateDelegate(typeof(Func<string>), this))();
    }

    private string \u0047\u0065\u0074\u0047\u0072\u0065\u0065\u0074\u0069\u006e\u0067()
    {
        return new string(_greetingBytes.Select(b => (char)(b + 13)).ToArray());
    }
}

public class Program
{
    public static void Main()
    {
        IntPtr handle = IntPtr.Zero;
        try
        {
            handle = Marshal.StringToHGlobalAnsi("SGVsbG8gV29ybGQh");
            new HelloWorld(handle);
        }
        finally
        {
            if (handle != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(handle);
            }
        }
    }
}
