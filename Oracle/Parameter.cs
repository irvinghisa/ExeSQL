namespace ExeSQL
{
    class Parameter
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public Parameter(string n, string v)
        {
            Name = n;
            Value = v;
        }
    }
}