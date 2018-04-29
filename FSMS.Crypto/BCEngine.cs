using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Crypto
{
    public class BCEngine
    {
        private readonly Encoding _encoding;
        private readonly IBlockCipher _blockCipher;
        private PaddedBufferedBlockCipher _cipher;
        private IBlockCipherPadding _padding;

        string key = "zxcasdqwe123#123";
        string textToBeEncrypted = "Original text. Please encrypt me.";
        string txtEncryptedText = string.Empty;
        string txtDecryptedText = string.Empty;

        public BCEngine(IBlockCipher blockCipher, Encoding encoding)
        {
            _blockCipher = blockCipher;
            //_encoding = encoding;

            _encoding = Encoding.ASCII;
            Pkcs7Padding pkcs = new Pkcs7Padding();
            _padding = pkcs;
        }

        public string AESEncryption(string plain, bool fips)
        {
            BCEngine bcEngine = new BCEngine(new AesEngine(), _encoding);
            bcEngine.SetPadding(_padding);
            return bcEngine.Encrypt(plain, key);
        }
        public string AESDecryption(string cipher, bool fips)
        {
            BCEngine bcEngine = new BCEngine(new AesEngine(), _encoding);
            bcEngine.SetPadding(_padding);
            return bcEngine.Decrypt(cipher, key);
        }



        public void SetPadding(IBlockCipherPadding padding)
        {
            if (padding != null)
                _padding = padding;
        }

        public string Encrypt(string plain, string key)
        {
            byte[] result = BouncyCastleCrypto(true, _encoding.GetBytes(plain), key);
            return Convert.ToBase64String(result);
        }

        public string Decrypt(string cipher, string key)
        {
            byte[] result = BouncyCastleCrypto(false, Convert.FromBase64String(cipher), key);
            return _encoding.GetString(result);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="forEncrypt"></param>
        /// <param name="input"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="CryptoException"></exception>
        private byte[] BouncyCastleCrypto(bool forEncrypt, byte[] input, string key)
        {
            try
            {
                _cipher = _padding == null ? new PaddedBufferedBlockCipher(_blockCipher) : new PaddedBufferedBlockCipher(_blockCipher, _padding);
                byte[] keyByte = _encoding.GetBytes(key);
                _cipher.Init(forEncrypt, new KeyParameter(keyByte));
                return _cipher.DoFinal(input);
            }
            catch (Org.BouncyCastle.Crypto.CryptoException ex)
            {
                throw new CryptoException(ex.Message);
            }
        }
    }
}
