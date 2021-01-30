namespace CommonComponents
{
    public interface IAccessTypeEventArgs
    {
        AccessTypeEventArgs.AccesType AccesTypeValue { get; set; }
        bool ValuesWereChanged { get; set; }
    }
}