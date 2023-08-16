using AuthenticationRefactor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationRefactorTest.Tests
{
    public class JWTTest
    {
        private readonly JWT _sut;
        public JWTTest()
        {
            _sut = new JWT();
        }
        [Fact]
        public void JWT_GetToken_ShouldReturnsToken()
        {
            //arrange
            var expected = "JWT Get New Token";
            //act
            var result = _sut.GetTokenJWT();
            //assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void JWT_IsTokenValid_ShouldReturnsFalseWhenTokenHasexpired()
        {
            //arrange
            var expiredToken = "2024";
          
            //act
            var result = _sut.IsTokenValidJWT(expiredToken);
            //assert
            Assert.False(result);
        }
        [Fact]
        public void JWT_IsTokenValid_ShouldReturnsTrueWhenTokenStillValid()
        {
            //arrange
            var validToken = "2023";
         
            //act
            var result = _sut.IsTokenValidJWT(validToken);
            //assert
            Assert.True(result);
        }
    }
}
