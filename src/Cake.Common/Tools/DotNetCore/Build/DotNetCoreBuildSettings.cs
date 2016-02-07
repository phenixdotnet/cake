﻿using Cake.Core.IO;

namespace Cake.Common.Tools.DotNetCore.Build
{
    /// <summary>
    /// Contains settings used by <see cref="DotNetCoreBuilder" />.
    /// </summary>
    public class DotNetCoreBuildSettings : DotNetCoreSettings
    {
        /// <summary>
        /// Gets or sets the output directory.
        /// </summary>
        public DirectoryPath OutputDirectory { get; set; }

        /// <summary>
        /// Gets or sets the temporary output directory.
        /// </summary>
        public DirectoryPath TemporaryOutputDirectory { get; set; }

        /// <summary>
        /// Gets or sets the target runtime.
        /// </summary>
        public string Runtime { get; set; }

        /// <summary>
        /// Gets or sets a specific framework to compile.
        /// </summary>
        public string Framework { get; set; }

        /// <summary>
        /// Gets or sets the configuration under which to build.
        /// </summary>
        public string Configuration { get; set; }

        /// <summary>
        /// Gets or sets the architecture for which to compile.
        /// </summary>
        /// <remarks>
        /// <see cref="DotNetCoreArchitecture.x64"/> only currently supported.
        /// </remarks>
        public DotNetCoreArchitecture? Architecture { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to compile source to native machine code.
        /// </summary>
        public bool Native { get; set; }

        /// <summary>
        /// Gets or sets the command line arguments to be passed directly to ILCompiler.
        /// </summary>
        public string ILCompilerArguments { get; set; }

        /// <summary>
        /// Gets or sets the path to the folder containing custom built ILCompiler.
        /// </summary>
        public DirectoryPath ILCompilerPath { get; set; }

        /// <summary>
        /// Gets or sets the path to the folder containing ILCompiler application dependencies.
        /// </summary>
        public DirectoryPath ILCompilerSDKPath { get; set; }

        /// <summary>
        /// Gets or sets the path to the folder containing ILCompiler application dependencies.
        /// </summary>
        public DirectoryPath ApplicationDependencySDKPath { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to do native compilation with C++ code generator.
        /// </summary>
        public bool Cpp { get; set; }

        /// <summary>
        /// Gets or sets additional flags to be passed to the native compiler.
        /// </summary>
        public string CppCompilerFlags { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to print the incremental safety checks that prevent incremental compilation.
        /// </summary>
        public bool BuildProfile { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to mark the entire build as not safe for incrementality.
        /// </summary>
        public bool ForceIncrementalUnsafe { get; set; }
    }
}
