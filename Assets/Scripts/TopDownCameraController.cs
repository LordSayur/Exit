using Cinemachine;
using System.Collections;
using UnityEngine;

public class TopDownCameraController : MonoBehaviour
{
    private CinemachineFreeLook cinemachineFree;

    void Start()
    {
        cinemachineFree = GetComponent<CinemachineFreeLook>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(RotateCamera(1));
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(RotateCamera(-1));
        }
    }

    private IEnumerator RotateCamera(int direction)
    {
        float timer = 0;

        float initialAngle = cinemachineFree.m_XAxis.Value;

        while (timer <= 1.1f )
        {
            cinemachineFree.m_XAxis.Value = initialAngle;
            cinemachineFree.m_XAxis.Value = Mathf.Lerp(cinemachineFree.m_XAxis.Value, cinemachineFree.m_XAxis.Value + 90 * direction, timer);
            timer += 2f * Time.fixedDeltaTime;
            yield return new WaitForFixedUpdate();
        }
    }
}
