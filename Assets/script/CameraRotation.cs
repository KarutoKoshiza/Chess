using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public Transform whiteView;
    public Transform blackView;
    public float transitionSpeed = 2.0f;

    private Transform targetView;
    private bool isWhiteTurn = true;
    private bool isTransitioning = false;

    void Start()
    {
        targetView = whiteView;
        transform.position = targetView.position;
        transform.rotation = targetView.rotation;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchCamera();
        }

        if (isTransitioning)
        {
            transform.position = Vector3.Lerp(transform.position, targetView.position, Time.deltaTime * transitionSpeed);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetView.rotation, Time.deltaTime * transitionSpeed);

            if (Vector3.Distance(transform.position, targetView.position) < 0.05f)
            {
                transform.position = targetView.position;
                transform.rotation = targetView.rotation;
                isTransitioning = false;
            }
        }
    }

    public void SwitchCamera()
    {
        isWhiteTurn = !isWhiteTurn;
        targetView = isWhiteTurn ? whiteView : blackView;
        isTransitioning = true;
    }
}
