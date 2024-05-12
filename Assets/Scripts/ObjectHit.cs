using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer objectRenderer;

    private void Awake()
    {
        objectRenderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            objectRenderer.material.color = Color.red;
            gameObject.tag = "Hit";
        }
    }
}
