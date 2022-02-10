using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flocker : KinematicBlendedMover
{
    Flocker()
    {
        this.SetMoveType(new BlendedSteeringBehavior());
    }
}
