using UnityEngine;

public class AtomRocket : MonoBehaviour
{
    [SerializeField] AnimationCurve animationCurve;

    Vector3 finalPositionY = new Vector3(11f, 50f, 0f);
    Vector3 startPosition;
    float duration = 5f;
    float time;
    float percentageComplete;
    bool isLaunching;

    private void Start()
    {
        // Subscribing to be notified when fuell is loaded and start the rocket launch
        GameManager.Instance.OnFuelMax += GameManager_OnFuelMax;
        startPosition = transform.position;
    }

    // Moment when we get notified for go for launch
    private void GameManager_OnFuelMax(object sender, System.EventArgs e)
    {
        isLaunching = true;
    }

    private void Update()
    {
        // if fuell is max the rocket will start the launch
        if (isLaunching)
        {
            // ABSTRACTION
            RocketLaunch();
        }
    }

    private void RocketLaunch()
    {
        time += Time.deltaTime;
        percentageComplete = time / duration;
        transform.position = Vector3.Lerp(startPosition, finalPositionY, animationCurve.Evaluate(percentageComplete));
        
        // Stops the running RocketLaunch method
        if (transform.position == finalPositionY)
            isLaunching = false;
    }

    private void OnDisable()
    {
        GameManager.Instance.OnFuelMax -= GameManager_OnFuelMax;
    }
}
