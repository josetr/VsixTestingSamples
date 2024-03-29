﻿using Microsoft;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using System;
using Xunit;
using Task = System.Threading.Tasks.Task;

namespace VsAsyncPackage.Tests
{
    public class AsyncPackageTests
    {
        [VsTheory(Version = "2017-")]
        [InlineData(VSPackage.PackageGuidString, true)]
        [InlineData("11111111-2222-3333-4444-555555555555", false)]
        async Task LoadTestAsync(string guidString, bool expectedSuccess)
        {
            var shell = (IVsShell7)ServiceProvider.GlobalProvider.GetService(typeof(SVsShell));
            Assumes.Present(shell);

            var guid = Guid.Parse(guidString);

            if (expectedSuccess)
                await shell.LoadPackageAsync(ref guid);
            else
                await Assert.ThrowsAnyAsync<Exception>(async () => await shell.LoadPackageAsync(ref guid));
        }
    }
}
