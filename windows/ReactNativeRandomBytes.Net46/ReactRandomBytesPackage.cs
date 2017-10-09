using ReactNative.Bridge;
using ReactNative.Modules.Core;
using ReactNative.UIManager;
using System;
using System.Collections.Generic;

namespace ReactNativeRandomBytes
{
    public class ReactRandomBytesPackage : IReactPackage
    {
        public IReadOnlyList<Type> CreateJavaScriptModulesConfig()
        {
            return Array.Empty<Type>();
        }

        public IReadOnlyList<INativeModule> CreateNativeModules(ReactContext reactContext)
        {        
            return new List<INativeModule>
            {
                new ReactRandomBytesModule(reactContext)
            };
        }

        public IReadOnlyList<IViewManager> CreateViewManagers(ReactContext reactContext)
        {
            return new List<IViewManager>(0);
        }
    }
}
