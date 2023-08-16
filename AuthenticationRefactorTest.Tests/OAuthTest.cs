using AuthenticationRefactor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationRefactorTest.Tests
{
    public class OAuthTest
    {
        private readonly OAuth _sut;
        public OAuthTest()
        {
            _sut = new OAuth();
        }
        [Fact]
        public void OAuth_GetToken_ShouldReturnsToken()
        {
            //arrange
            var expected = "Oauth Get New Token";
            //act
            var result = _sut.GetToken();
            //assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void OAuth_IsTokenValid_ShouldReturnsFalseWhenTokenHasexpired()
        {
            //arrange
            var expiredToken = "2024";
            var apiurl = "";
            //act
            var result=_sut.IsTokenValid(expiredToken, apiurl);
            //assert
            Assert.False(result);
        }
        [Fact]
        public void OAuth_IsTokenValid_ShouldReturnsTrueWhenTokenStillValid()
        {
            //arrange
            var validToken = "2023";
            var apiurl = "";
            //act
            var result = _sut.IsTokenValid(validToken, apiurl);
            //assert
            Assert.True(result);
        }
    }
}
