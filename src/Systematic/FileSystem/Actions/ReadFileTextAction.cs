﻿namespace Systematic.FileSystem.Actions
{
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    using Systematic.Actions;
    using Systematic.FileSystem.Data;
    using Systematic.Text.Data;

    /// <summary>
    /// An action to read file content as a text.
    /// </summary>
    public class ReadFileTextAction : ActionUnit<FileData, TextData>
    {
        /// <summary>
        /// The name of the action.
        /// </summary>
        public const string ActionName = "Read file as text";

        /// <inheritdoc />
        public override string Name => ActionName;

        /// <inheritdoc />
        public override Task<TextData> PerformAsync(FileData input, CancellationToken cancellationToken)
        {
            var text = File.ReadAllText(input.Path);

            var result = new TextData(text);
            return Task.FromResult(result);
        }
    }
}
