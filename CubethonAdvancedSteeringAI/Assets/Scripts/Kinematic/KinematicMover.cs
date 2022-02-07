using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicMover
{
    private SteeringBehavior moveType;
    private SteeringBehavior rotateType;
    ///private Kinematic character;
    //private GameObject target;

    public void SetMoveType(SteeringBehavior moveType)
    {
        this.moveType = moveType;
    }

    public void SetRotateType(SteeringBehavior rotateType)
    {
        this.rotateType = rotateType;
    }
    public void SetCharacter(Kinematic character)
    {
        //this.character = character;
        moveType.character = character;
        rotateType.character = character;
    }
    public void SetTarget(GameObject target)
    {
        //this.target = target;
        moveType.target = target;
        rotateType.target = target;
    }
    public void SetMaxAcceleration(float maxAcceleration)
    {
        moveType.maxAcceleration = maxAcceleration;
    }
    public void SetMaxAngularAcceleration(float maxAngularAcceleration)
    {
        rotateType.maxAcceleration = maxAngularAcceleration;
    }

    public Vector3 Accelerate()
    {
        return moveType.getSteering().linear;
    }
    public float AngularAccelerate()
    {
        return rotateType.getSteering().angular;
    }
}
