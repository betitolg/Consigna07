using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void LateUpdate()
    {
        transform.position = target.transform.position;
    }
}