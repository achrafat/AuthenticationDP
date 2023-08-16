using AuthenticationRefactor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationRefactorTest.Tests
{
    public class AuthenticationProtocolFactoryTestcs
    {
        private readonly AuthenticationProtocolFactory _sut;
        public AuthenticationProtocolFactoryTestcs()
        {
            _sut = new AuthenticationProtocolFactory();
        }
        [Fact]
        public void AuthenticationProtocolFactory_InstantiateProtocol_ShouldInstantiate_OAuthInstance_WhenTypeIsOAuth()
        {
            //arrange
            var protocolType = AuthenticationProtocolEnum.OAUTH;
            //act
            var result= _sut.InstantiateProtocol(protocolType);
            //assert
            Assert.IsType<OAuth>(result);
        }

        [Fact]
        public void AuthenticationProtocolFactory_InstantiateProtocol_ShouldInstantiate_JWTInstance_WhenTypeIsJWT()
        {
            //arrange
            var protocolType = AuthenticationProtocolEnum.JWT;
            //act
            var result = _sut.InstantiateProtocol(protocolType);
            //assert
            Assert.IsType<JWTAdapter>(result);
        }
    }
}
