using System.Text.Json.Serialization;

namespace LogScope.Models
{
    public class LogModel
    {
        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }

        [JsonPropertyName("level")]
        public string Level { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("correlationId")]
        public string CorrelationId { get; set; }

        #region timestamp aliases

        [JsonInclude]
        [JsonPropertyName("Timestamp")]
        private string TimestampUpper { set => Timestamp ??= value; }

        [JsonInclude]
        [JsonPropertyName("time")]
        private string Time { set => Timestamp ??= value; }

        [JsonInclude]
        [JsonPropertyName("Time")]
        private string TimeUpper { set => Timestamp ??= value; }

        [JsonInclude]
        [JsonPropertyName("@timestamp")]
        private string AtTimestamp { set => Timestamp ??= value; }

        #endregion

        #region level aliases
        [JsonInclude]
        [JsonPropertyName("Level")]
        private string LevelUpper { set => Level ??= value; }

        [JsonInclude]
        [JsonPropertyName("severity")]
        private string Severity { set => Level ??= value; }

        [JsonInclude]
        [JsonPropertyName("Severity")]
        private string SeverityUpper { set => Level ??= value; }

        [JsonInclude]
        [JsonPropertyName("logLevel")]
        private string LogLevel { set => Level ??= value; }

        [JsonInclude]
        [JsonPropertyName("LogLevel")]
        private string LogLevelUpper { set => Level ??= value; }

        #endregion

        #region message aliases

        [JsonInclude]
        [JsonPropertyName("Message")]
        private string MessageUpper { set => Message ??= value; }

        [JsonInclude]
        [JsonPropertyName("msg")]
        private string Msg { set => Message ??= value; }

        [JsonInclude]
        [JsonPropertyName("Msg")]
        private string MsgUpper { set => Message ??= value; }

        [JsonInclude]
        [JsonPropertyName("text")]
        private string Text { set => Message ??= value; }

        [JsonInclude]
        [JsonPropertyName("Text")]
        private string TextUpper { set => Message ??= value; }

        #endregion

        #region correlationId aliases

        [JsonInclude]
        [JsonPropertyName("CorrelationId")]
        private string CorrelationIdUpper { set => CorrelationId ??= value; }

        [JsonInclude]
        [JsonPropertyName("correlation_id")]
        private string CorrelationSnakeId { set => CorrelationId ??= value; }

        [JsonInclude]
        [JsonPropertyName("CorrelationID")]
        private string CorrelationIDUpper { set => CorrelationId ??= value; }

        [JsonInclude]
        [JsonPropertyName("requestId")]
        private string RequestId { set => CorrelationId ??= value; }

        [JsonInclude]
        [JsonPropertyName("RequestId")]
        private string RequestIdUpper { set => CorrelationId ??= value; }

        [JsonInclude]
        [JsonPropertyName("traceId")]
        private string TraceId { set => CorrelationId ??= value; }

        [JsonInclude]
        [JsonPropertyName("TraceId")]
        private string TraceIdUpper { set => CorrelationId ??= value; }

        #endregion
    }
}