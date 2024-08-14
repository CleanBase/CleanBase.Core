using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Security
{
	public static class CryptoGraphyHelper
	{
		public static RsaSecurityKey SigningKey(string modules, string expo)
		{
			RSA rsa = RSA.Create();
			rsa.ImportParameters(new RSAParameters()
			{
				Exponent = Base64UrlEncoder.DecodeBytes(expo),
				Modulus = Base64UrlEncoder.DecodeBytes(modules)
			});
			
			return new RsaSecurityKey(rsa);	
		}
	}
}
