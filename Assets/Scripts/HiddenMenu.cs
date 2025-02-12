using System.Collections;
using System.Collections.Generic;
using Unity.XR.PXR;
using UnityEngine;
using UnityEngine.InputSystem;

public class HiddenMenu : MonoBehaviour
{
    public GameObject hiddenMenu;
    private bool isActive = true;
    public InputActionReference menuBtn;

    // bool triggerValueR;
    // bool triggerValueL;
    // bool primaryValue;

    void Awake()
    {
        menuBtn.action.started += ShowHiddenMenu;
    }
    // Start is called before the first frame update
    void Start()
    {
        hiddenMenu.SetActive(false);

    }
    private void onDestroy()
    {
        menuBtn.action.started -= ShowHiddenMenu;
    }

    // Update is called once per frame
    void Update()
    {
        // var rightHandDevice = UnityEngine.XR.InputDevices.GetDeviceAtXRNode(UnityEngine.XR.XRNode.RightHand);
        // var leftHandDevice = UnityEngine.XR.InputDevices.GetDeviceAtXRNode(UnityEngine.XR.XRNode.LeftHand);
        
        // if (rightHandDevice.TryGetFeatureValue(UnityEngine.XR.CommonUsages.gripButton, out triggerValueR) && triggerValueR) {
        //     hideToggle = true;
        // }
        // else if (leftHandDevice.TryGetFeatureValue(UnityEngine.XR.CommonUsages.menuButton, out triggerValueL) && triggerValueL) {
        //     hideToggle = true;
        // }
        
        // if (menuBtn.action.triggered)
        // {
        //     Debug.Log("Menu pressed");
        //     ShowHiddenMenu();
        // }
    }

    void ShowHiddenMenu(InputAction.CallbackContext obj)
    {
        Debug.Log("secret menu Toggled dow");
        isActive = !isActive;
        hiddenMenu.SetActive(isActive);
    }
}
