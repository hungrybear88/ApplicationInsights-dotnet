﻿namespace Microsoft.ApplicationInsights.AspNetCore.Tests
{
    public class SdkVersionTestUtils
    {
#if NET452 || NET46 || NET461
        public const string VersionPrefix = "aspnet5f:";
#else
        public const string VersionPrefix = "aspnet5c:";
#endif
    }
}
