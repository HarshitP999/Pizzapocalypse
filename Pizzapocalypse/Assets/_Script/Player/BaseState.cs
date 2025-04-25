public abstract class BaseState
{
    public abstract void EnterState(PlayerController controller);
    public abstract void UpdateState();
    public abstract void FixedUpdateState();
    public abstract void ExitState();

}
