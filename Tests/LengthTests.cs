// Copyright 2022 Ben Voß
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files
// (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge,
// publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so,
// subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
// FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using Xunit;
using FluentAssertions;
using ImpulseRocketry.Units;

namespace ImpulseRocketry.Units.Tests;

public class LengthTests
{
    [Fact]
    public void Conversions()
    {
        Length.M.Value(1.234).To.M.Should().Be(1.234);
        Length.M.Value(1.234).To.Cm.Should().BeApproximately(123.4, 0.1);
        Length.M.Value(1.234).To.Mm.Should().Be(1234);
        Length.M.Value(1.234).To.Km.Should().Be(.001234);
    }
}