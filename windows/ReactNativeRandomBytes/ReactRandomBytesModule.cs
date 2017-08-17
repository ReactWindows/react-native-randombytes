using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ReactNativeRandomBytes
{
    public class ReactRandomBytesModule : ReactContextNativeModuleBase
    {
        private RandomNumberGenerator rng = RandomNumberGenerator.Create();
        private const string SEED_KEY = "seed";
   
        public ReactRandomBytesModule(ReactContext reactContext)
            : base(reactContext)
        {
        }
        
        public override string Name 
        {
            get 
            {
                return "RNRandomBytes";
            }
        }

        [ReactMethod]
        public void randomBytes(int size, ICallback callback) {
            callback.Invoke(null, getRandomBytes(size));
        }

        public override IReadOnlyDictionary<string, object> Constants
        {
            get
            {
                return new Dictionary<string, object>
                {
                    { SEED_KEY, getRandomBytes(4096) },
                };
            }
        }

        private String getRandomBytes(int size) {
            byte[] output = new byte[size];
            rng.GetBytes(output);
            return Convert.ToBase64String(output);
        }
    }
}