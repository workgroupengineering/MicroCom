namespace MicroCom.Runtime
{
    public interface IMicroComShadowContainer
    {
        int ID { get; }
        MicroComShadow Shadow { get; set; }
        void OnReferencedFromNative();
        void OnUnreferencedFromNative();
    }
}
