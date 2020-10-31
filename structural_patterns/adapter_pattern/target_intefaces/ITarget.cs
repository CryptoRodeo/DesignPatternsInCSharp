namespace adapter_pattern.target_intefaces
{
    // The target defines the domain-specific interface used by the client code.
    public interface ITarget
    {
         string GetRequest();
    }
}