using UnityEngine;

public class HMDEmulator : MonoBehaviour
{
#if UNITY_EDITOR
    [Header("Yaw : Left Ctrl + Mouse Move")]
    [Header("Picth : Left Alt + Mouse Move")]
    private Transform camTr;
    public float yawSpeed = 2.0f;
    public float pitchSpeed = 2.0f;

    void Start()
    {
        camTr = GetComponent<Transform>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            Vector3 yaw = camTr.localEulerAngles + new Vector3(0, Input.GetAxis("Mouse X") * yawSpeed, 0);
            camTr.localRotation = Quaternion.Euler(yaw);
        }
        if (Input.GetKey(KeyCode.LeftAlt))
        {
            Vector3 pitch = camTr.localEulerAngles + new Vector3(-Input.GetAxis("Mouse Y") * pitchSpeed, 0, 0);
            camTr.localRotation = Quaternion.Euler(pitch);
        }

    }
#endif
}