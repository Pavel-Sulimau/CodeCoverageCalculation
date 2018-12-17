using System;
using System.Collections.Generic;
using CodeCoverageCalculation.Common.Utils;
using Xunit;

namespace CodeCoverageCalculation.Common.Tests.Utils
{
    public class DictionaryExtensionsTests
    {
        [Fact]
        public void TryGetValue_DictionaryHasNoValueForKey_DefaultValueForTypeIsRetured()
        {
            // Arrange
            var dictionary = new Dictionary<string, object>();

            // Act
            var operationSucceeded = dictionary.TryGetValue<int>("key1", out int actualValue);

            // Assert
            Assert.False(operationSucceeded);
            Assert.Equal(default(int), actualValue);
        }

        [Fact]
        public void TryGetValue_NullKeyIsPassed_ArgumentNullExceptionIsThrown()
        {
            // Arrange
            var dictionary = new Dictionary<string, object>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => dictionary.TryGetValue<int>(null, out int actualValue));
        }

        [Fact]
        public void TryGetValue_DictionaryHasValueOfAnotherType_ArgumentNullExceptionIsThrown()
        {
            // Arrange
            var dictionary = new Dictionary<string, object>();
            var key = "key1";
            dictionary[key] = 12.5;

            // Act
            var operationSucceeded = dictionary.TryGetValue<int>(key, out int actualValue);

            // Assert
            Assert.False(operationSucceeded);
            Assert.Equal(default(int), actualValue);
        }

        [Fact]
        public void TryGetValue_DictionaryHasRequestedValue_TypedValueForSpecifiedKeyIsReturned()
        {
            // Arrange
            var dictionary = new Dictionary<string, object>();
            var key = "key1";
            int value = 5;
            dictionary[key] = value;

            // Act
            var operationSucceeded = dictionary.TryGetValue<int>(key, out int actualValue);

            // Assert
            Assert.True(operationSucceeded);
            Assert.Equal(value, actualValue);
        }
    }
}
