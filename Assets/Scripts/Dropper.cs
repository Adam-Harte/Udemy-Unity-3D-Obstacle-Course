using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]
    float timeToWait = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait) {
            Debug.Log($"{timeToWait}s has passed");
        }
    }
}
