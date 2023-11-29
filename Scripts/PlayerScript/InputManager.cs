
/*
using System.Collections.Generic;
using Godot;

namespace Testingcsharp.Scripts.PlayerScript;

public static class InputManager
{
    Dictionary<string, Button> input = new Dictionary<string, Button>();


    public InputManager()
    {
        input.Add("forward", new Button());
        input.Add("back", new Button());
        input.Add("left", new Button());
        input.Add("Right", new Button());
        input.Add("Shoot", new Button());
    }

    public override void _Input(InputEvent @event)
    {
        base._Input(@event);
        
        
        
    }
}


public enum ButtonState
{
    Set,
    Unset
}

public class Button
{
    public ButtonState State = ButtonState.Unset;
    public bool consumed = false;
}

public class InputHandler : Node
{
    
}
*/