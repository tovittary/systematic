﻿namespace Systematic.Setup.Text.Assertions
{
    using Systematic.Assertions;
    using Systematic.Setup.Assertions;
    using Systematic.Text.Assertions;
    using Systematic.Text.Data;

    /// <summary>
    /// A setup of an assertion used to check if a text is not empty.
    /// </summary>
    public class TextNotEmptyAssertionSetup : AssertionSetup<TextData>
    {
        /// <inheritdoc/>
        public override string Name { get; } = "Text not empty";

        /// <inheritdoc />
        protected override PlainAssertion<TextData> BuildAssertion() => new TextNotEmptyAssertion();
    }
}
