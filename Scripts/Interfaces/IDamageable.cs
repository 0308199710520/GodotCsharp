﻿namespace Testingcsharp.Scripts.Interfaces;

public interface IDamageable
{
    public void Damage(int amount);
    public void OnDeath();
}