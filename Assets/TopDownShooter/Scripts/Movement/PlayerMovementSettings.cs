using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.PlayerMovement
{
    [CreateAssetMenu(menuName = "Topdown Shooter/Player/Movement Settings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        public float HorizontalSpeed = 5;
        public float VerticalSpeed = 5;
        public Vector3 JumpForce = new Vector3(0, 5, 0);
    }
}
