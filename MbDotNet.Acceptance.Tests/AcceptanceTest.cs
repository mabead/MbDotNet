﻿
using System;
using MbDotNet.Acceptance.Tests.AcceptanceTests;

namespace MbDotNet.Acceptance.Tests
{
    internal static class AcceptanceTest
    {
        public static void CanCreateImposter(MountebankClient client) => new CanCreateImposterTest(client).Run();
        public static void CanDeleteImposter(MountebankClient client) => new CanDeleteImposter(client).Run();
    }
}