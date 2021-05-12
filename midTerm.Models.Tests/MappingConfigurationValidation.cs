using midTerm.Models.Profiles;
using midTerm.Models.Tests.Internal;
using System;
using Xunit;

namespace midTerm.Models.Tests
{
    public class MappingConfigurationValidation
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var configuration = AutoMapperModule.CreateMapperConfiguration<SurveyUserProfile>();


            // Act
            configuration.AssertConfigurationIsValid();
        }
    }
}
