using System;
using Godot;

namespace Testingcsharp.Scripts.PlayerScript.PlayerStates;

public class PlayerWalkingState : BasePlayerState
{
    public override void EnterState(PlayerStateManager player)
    {
        
    }

    public override void Ready(PlayerStateManager player)
    {
        
    }

    public override void Process(PlayerStateManager player, double delta)
    {
        Gravity(player);
        player.MoveAndSlide();
    }

    private void Gravity(PlayerStateManager player)
    {
        if (!player.IsOnFloor())
        {
            player.Velocity = Vector3.Down;
        }
    }

    public override void PhyProcess(PlayerStateManager player, double delta)
    {
        
    }

    public override void LeaveState(PlayerStateManager player)
    {
        
    }
    
}