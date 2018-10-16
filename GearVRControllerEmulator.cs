using UnityEngine;

public class GearVRControllerEmulator : MonoBehaviour {
#if UNITY_EDITOR
    public Transform controller;
    public float hDamping = 2.0f;
    public float vDamping = 2.0f;

    private float xAngle, yAngle;

	void Start () {
        Invoke("InitController", 0.5f);
	}

    void InitController()
    {
        if (controller != null)
        {
            controller.Find("GearVrControllerModel").gameObject.SetActive(true);
        }
    }
    void Update()
    {
        xAngle += Input.GetAxis("Mouse Y");
        yAngle += Input.GetAxis("Mouse X");
        controller.localEulerAngles = new Vector3(  xAngle * hDamping
                                                  , yAngle * vDamping
                                                  , 0f);
    }
#endif
}
