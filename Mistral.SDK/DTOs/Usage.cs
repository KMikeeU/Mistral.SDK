﻿using System.Text.Json.Serialization;

namespace Mistral.SDK.DTOs
{
    public class Usage
    {
        [JsonPropertyName("prompt_tokens")]
        public int PromptTokens { get; set; }

        /// <summary>
        /// Gets or Sets CompletionTokens
        /// </summary>
        /// <example>93</example>
        [JsonPropertyName("completion_tokens")]
        public int CompletionTokens { get; set; }

        /// <summary>
        /// Gets or Sets TotalTokens
        /// </summary>
        /// <example>107</example>
        [JsonPropertyName("total_tokens")]
        public int TotalTokens { get; set; }
    }
}
