using Xunit;
using baseballdll;
using System;
using System.Collections.Generic;

namespace baseballtest;

public class ServiceTest
{
    [Fact]
    public void Service_returns_last_word()
    {
        Service service = new Service();
        List<String> words = new List<String>();
        words.Add("hello");
        words.Add("world");

        var output = service.GetLastWord(words);
        var expected = "world";

        Assert.Equal(expected, output);
    }

    [Fact]
    public void Service_returns_empty_string_when_no_words()
    {
        Service service = new Service();
        List<String> words = new List<String>();

        var output = service.GetLastWord(words);
        var expected = "";

        Assert.Equal(expected, output);
    }

    [Fact]  
    public void Service_Suma_Normal_Return_Sum()
    {
        Service service = new Service();
        var x = 5;
        var y = 10;

        var output = service.SumaNormal(x, y);
        var expected = 15;

        Assert.Equal(expected, output);
    }
}