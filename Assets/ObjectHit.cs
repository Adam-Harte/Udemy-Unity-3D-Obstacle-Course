using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        Debug.Log($"{other} bumped into the wall");
    }
}
