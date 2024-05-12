using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer objectRenderer;

    private void Awake() {
        objectRenderer = GetComponent<MeshRenderer>();
    }
    private void OnCollisionEnter(Collision other) {
        objectRenderer.material.color = Color.red;
    }
}
