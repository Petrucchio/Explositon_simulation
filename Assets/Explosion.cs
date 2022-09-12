using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField]
    private float raio = 50.0f;
    private float poder = 15.5f;
    private Vector3 posBomb;
    private Collider[] colliders;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        posBomb = transform.position;
        colliders = Physics.OverlapSphere (posBomb, raio);

        foreach(Collider hit in colliders){
            rb = hit.GetComponent<Rigidbody> ();
            if(rb!= null)
                rb.AddExplosionForce(poder,posBomb,raio,1.0f,ForceMode.Impulse);
            
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = new Color (0,1,0,0.3f);
        Gizmos.DrawSphere (transform.position, raio);
    }
}
