namespace HyperionHR_meta.Scripts.Class.HR_Operations
{
    public interface IApprovable
    {
        void Approve();
        void Reject();
        string GetStatus();
    }
}