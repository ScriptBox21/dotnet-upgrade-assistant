﻿using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Microsoft.DotNet.UpgradeAssistant.Extensions.Default.CSharp.Analyzers
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class HelperResultAnalyzer : IdentifierMigrationAnalyzer
    {
        public const string DiagnosticId = "AM0009";
        private const string Category = "Migration";

        public override IEnumerable<IdentifierMapping> IdentifierMappings { get; } = new[]
        {
            new IdentifierMapping("System.Web.WebPages.HelperResult", "Microsoft.AspNetCore.Mvc.Razor.HelperResult")
        };

        private static readonly LocalizableString Title = new LocalizableResourceString(nameof(Resources.HelperResultTitle), Resources.ResourceManager, typeof(Resources));
        private static readonly LocalizableString MessageFormat = new LocalizableResourceString(nameof(Resources.HelperResultMessageFormat), Resources.ResourceManager, typeof(Resources));
        private static readonly LocalizableString Description = new LocalizableResourceString(nameof(Resources.HelperResultDescription), Resources.ResourceManager, typeof(Resources));

        private static readonly DiagnosticDescriptor Rule = new(DiagnosticId, Title, MessageFormat, Category, DiagnosticSeverity.Warning, isEnabledByDefault: true, description: Description);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get { return ImmutableArray.Create(Rule); } }

        protected override Diagnostic CreateDiagnostic(Location location, ImmutableDictionary<string, string?> properties, params object[] messageArgs) => Diagnostic.Create(Rule, location, properties, messageArgs);
    }
}