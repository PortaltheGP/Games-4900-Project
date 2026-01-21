using UnityEngine;
using UnityEngine.UIElements;

public class CountdownChallenge : MonoBehaviour
{
    public float time=10;
    public float timePass = 0;
    public bool timesUp = false;
    public GameObject theBox;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        if (!timesUp)
        {
            timePass+=Time.deltaTime;
        }
        if (timePass >= 1 && !timesUp)
        {
            time --;
            Debug.Log("Time left: " + time);
            tickAction();
            timePass = 0;
        }
        if(time == 0)
        {
            timesUp=true;
        }

    }
    public void tickAction()
    {
        if (theBox.activeInHierarchy)
        {
            theBox.SetActive(false);
        }
        else
        {
            theBox.SetActive(true);
        }
    }
}
