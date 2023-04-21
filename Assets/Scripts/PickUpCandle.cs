using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCandle : MonoBehaviour
{
    public GameObject candle;
    public Rigidbody rb;
    public BoxCollider coll;
    public Transform player, candleContainer, fpsCam;

    public float pickUpRange;
    public float dropFowardForce, dropUpwardForce;

    public bool equipped;
    public static bool slotFull;

    
    private void Start(){
        equipped = false;
        if (!equipped)
        {
            rb.isKinematic = false;
            coll.isTrigger = false;
        }
        if (equipped)
        {
            rb.isKinematic = true;
            coll.isTrigger = true;
            slotFull = true;
        }
    }

    private void Update(){
    Vector3 distanceToPlayer = player.position - transform.position;

    if (!equipped && distanceToPlayer.magnitude <= pickUpRange && Input.GetKeyDown(KeyCode.E) && !slotFull)
    {
        PickUp();
    }
    else if (equipped && Input.GetKeyDown(KeyCode.E))
    {
        Drop();
    }
    }

    private void PickUp()
    {
        equipped = true;
        slotFull = true;

        transform.SetParent(candleContainer);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.Euler(Vector3.zero);
        transform.localScale = Vector3.one;


        rb.isKinematic = true;
        coll.isTrigger = true;

    }

    private void Drop()
    {
        equipped = false;
        slotFull = false;

        transform.SetParent(null);

        rb.isKinematic = false;
        coll.isTrigger = false;



 

    }

}
