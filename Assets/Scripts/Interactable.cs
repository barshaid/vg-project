using UnityEngine;

public class Item
{
    public int num;
}
public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    public Vector3 PickUpPos;
    public Vector3 PickUpRot;

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
        
            gameObject.transform.SetParent(col.transform.Find("arm(r)"), true);
            gameObject.transform.localPosition = PickUpPos;
            gameObject.transform.localEulerAngles = PickUpRot;
            gameObject.transform.GetComponent<CapsuleCollider>().radius = 0;
            Vector3 temp;
            temp = gameObject.transform.localScale;
            temp.x = 2;
            temp.y = 5;
            temp.z = 2;
            gameObject.transform.localScale = temp;
            col.transform.GetComponent<Movement>().heldItem = 1;

        }
    }
}
