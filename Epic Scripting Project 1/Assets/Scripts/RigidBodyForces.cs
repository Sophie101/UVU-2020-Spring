using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidBodyForces : MonoBehaviour
{
   public Rigidbody rigidBodyObj;
   public float force = 100;
   private Vector3 forceVector;

   private void OnCollisionEnter(Collision other)
   {
       forceVector.y =force;
       rigidBodyObj.AddForce(forceVector);
   }

   private void Start()
   {
       rigidBodyObj = GetComponent<Rigidbody>();
   }
}
