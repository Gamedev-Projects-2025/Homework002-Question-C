using UnityEngine;
using UnityEngine.InputSystem;

public class camCtrl : MonoBehaviour
{
    [SerializeField]
    private InputAction changeCam = new InputAction(type: InputActionType.Button);

    [SerializeField]
    private GameObject camOne,camTwo, bar;

    private Camera camOnectrl, camTwoctrl;

    [SerializeField]
    private bool isHorizontal = true;

    private void OnEnable()
    {
        changeCam.Enable();
    }

    private void OnDisable()
    {
        changeCam.Disable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        camOnectrl = camOne.GetComponent<Camera>();
        camTwoctrl = camTwo.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (changeCam.WasPerformedThisFrame())
        {
            if (isHorizontal)
            {
                camOnectrl.rect = new Rect(0f, 0f, 0.5f, 1f);
                camTwoctrl.rect = new Rect(0.5f, 0f, 0.5f, 1f);
                bar.transform.rotation = Quaternion.Euler(0f, 0f, 90f);
            }
            else
            {
                camOnectrl.rect = new Rect(0f, 0f, 1f, 0.5f);
                camTwoctrl.rect = new Rect(0f, 0.5f, 1f, 0.5f);
                bar.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }
            isHorizontal = !isHorizontal;
        }
    }
}
