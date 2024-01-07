using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApp.Extensions;

public static class StringExtensions
{
    public static string GenerateCenteredString(this string text, int width)
    {
        if (text.Length >= width)
        {
            return text.Substring(0, width);
        }

        int leftPadding = (width - text.Length) / 2;
        int rightPadding = width - text.Length - leftPadding;

        return new string(' ', leftPadding) + text + new string(' ', rightPadding);
    }

    public static List<string> WrapString(this string text, int width)
    {
        string[] words = text.Split(' ');
        List<string> result = new List<string>();

        string part = string.Empty;

        foreach (var word in words)
        {
            var resultLength = string.IsNullOrEmpty(part) ? word.Length : word.Length + 1;
            if (String.IsNullOrEmpty(part) && word.Length >= width)
            {
                result.Add(word);
            }
            else if (part.Length + resultLength < width)
            {
                part += string.IsNullOrEmpty(part) ? word : " " + word;
            }
            else
            {
                result.Add(part);
                part = word;
            }
        }
        result.Add(part);

        return result;
    }
}
