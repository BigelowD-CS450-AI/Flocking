using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicBlendedMover : KinematicMover
{
    private List<BlendedSteeringBehavior> moveType;
    ///private Kinematic character;
    //private GameObject target;

    public void SetMoveType(BlendedSteeringBehavior moveType)
    {
       this.moveType.Add(moveType);
    }
}
