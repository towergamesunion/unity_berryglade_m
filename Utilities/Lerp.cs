using UnityEngine;

namespace Nutela.Utilities
{
    
    public class Lerp
    {
        public static Vector3 LerpPosition(Vector3 positionA, Vector3 positionB, float t)
        {
            float x = positionA.x + (positionB.x - positionA.x) * t;
            float y = positionA.y + (positionB.y - positionA.y) * t;
            float z = positionA.z + (positionB.z - positionA.z) * t;
            
            return new Vector3(x,y,z);
        }
    }
}