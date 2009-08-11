﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using Xunit.Extensions;
using Hello.Bot;
using Hello.Repo;

namespace Hello.Tests
{
    public class ProcessedTweetTests
    {
        [Fact]
        public static void BlankTest()
        {
            var pt = new ProcessedTweet("");

            Assert.Equal(pt.Friends.Count, 0);
            Assert.Equal(pt.SeatPassword, null);
            Assert.Equal(pt.Tags.Count, 0);
            Assert.Equal(pt.Token, null);
            Assert.Equal(pt.UserType, null);
        }

        [Fact]
        public static void MetTest()
        {
            var pt = new ProcessedTweet("met ryan matt kier");

            Assert.Equal(pt.Friends.Count, 3);
            Assert.True(pt.Friends.Contains("ryan"));
            Assert.True(pt.Friends.Contains("matt"));
            Assert.True(pt.Friends.Contains("kier"));
        }
    }
}
