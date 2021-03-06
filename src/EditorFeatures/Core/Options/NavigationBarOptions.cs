// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Microsoft.CodeAnalysis.Options;

namespace Microsoft.CodeAnalysis.Editor.Options
{
    internal static class NavigationBarOptions
    {
        public const string FeatureName = "Navigation Bar";

        [ExportOption]
        public static readonly PerLanguageOption<bool> ShowNavigationBar = new PerLanguageOption<bool>(FeatureName, "Show Navigation Bar", defaultValue: true);
    }
}
