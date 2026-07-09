namespace CliParser.CliArgs
{
    public class VerbParserFactory : Dictionary<ICliArg, ICliArgParser>, IVerbParserFactory
    {
        public ICliArgParser this[string key]
        {
            get
            {
                var dictionaryKey = Keys.FirstOrDefault(k => k.Name.Contains(key));
                return dictionaryKey == null ? null : base[dictionaryKey];
            }
        }
    }
}
