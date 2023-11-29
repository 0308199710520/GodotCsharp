namespace Testingcsharp.Scripts.PlayerScript.PlayerStates;

public abstract class BasePlayerState
{
    public abstract void EnterState(PlayerStateManager player);
    public abstract void Ready(PlayerStateManager player);

    public abstract void Process(PlayerStateManager player, double delta);

    public abstract void PhyProcess(PlayerStateManager player, double delta);

    public abstract void LeaveState(PlayerStateManager player);
    
}