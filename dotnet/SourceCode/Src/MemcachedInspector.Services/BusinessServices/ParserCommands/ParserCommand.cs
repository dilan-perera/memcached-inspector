using MemcachedInspector.Common;
using MemcachedInspector.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedInspector.Services.BusinessServices.ParserCommands
{
    internal abstract class ParserCommand
    {

        private static class ResponseElements
        {

            public const string SuccessTermination = "END";

            public const string ErrorTermination = "ERROR";

        }

        private static readonly string[] CachedLineDelimiter = 
            new string[] { OperatingEnvironment.NewLine  };

        private static readonly string[] CachedElementDelimiter =
            new string[] { " " };

        public string Content
        {
            get;
            private set;
        }

        protected string NewLine
        {
            get
            {
                return OperatingEnvironment.NewLine;
            }
        }

        protected string[] LineDelimiter
        {
            get
            {
                return ParserCommand.CachedLineDelimiter;
            }
        }

        protected string[] ElementDelimiter
        {
            get
            {
                return ParserCommand.CachedElementDelimiter;
            }
        }

        protected ParserCommand(string content)
        {
            this.Content = content;
        }

        public virtual void Parse()
        {
            this.CheckErrorResponse();

            this.ParseText();
        }

        protected abstract void ParseText();

        protected void CheckErrorResponse()
        {
            this.CheckErrorResponse(this.Content);
        }

        protected void CheckErrorResponse(string response)
        {
            if (response.StartsWith(ParserCommand.ResponseElements.ErrorTermination))
            {
                throw new CacheServerException();
            }
        }

        protected string GetPayload()
        {
            return this.GetPayload(this.Content);
        }

        protected string GetPayload(string response)
        {
            string payload = string.Empty;

            string cleanedResponse = response.TrimEnd();

            if (cleanedResponse.EndsWith(ParserCommand.ResponseElements.SuccessTermination))
            {
                payload = cleanedResponse.Substring(
                    0,
                    cleanedResponse.Length - ParserCommand.ResponseElements.SuccessTermination.Length);
            }
            else
            {
                payload = cleanedResponse;
            }

            return payload;
        }

    }
}
