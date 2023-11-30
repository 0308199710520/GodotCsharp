using Godot;
using Testingcsharp.Scripts.Interfaces;
using Testingcsharp.Scripts.PlayerScript.PlayerStates;

namespace Testingcsharp.Scripts.PlayerScript;

public partial class PlayerStateManager : CharacterBody3D
{
	private readonly PlayerWalkingState _walkingState = new();
	private BasePlayerState _currState;
	
	public override void _Ready()
	{
		base._Ready();
		GD.Print("Hello World");
		_currState = _walkingState;
		_currState.Ready(this);
	}

	public override void _Process(double delta)
	{
		base._Process(delta);
		_currState.Process(this, delta);
	}

	public override void _PhysicsProcess(double delta)
	{
		base._PhysicsProcess(delta);
		_currState.PhyProcess(this, delta);
	}

	public void _ChangeState(BasePlayerState state)
	{
		_currState.LeaveState(this);
		_currState = state;
		_currState.EnterState(this);
	}
}
