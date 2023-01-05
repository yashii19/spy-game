using UnityEngine;

public class CameraSystemBridge : MonoBehaviour
{
    // Active ou desactive le syst�me
    public void PauseCameraSystem(bool value)
    {
        // Comment faire pour mettre le syst�me en pause puis le relancer
        CameraSystem.instance.Pause = value;
    }

    public void locateAgent(LinkedWith agent)
    {
        CameraSystem.instance.focusOnAgent(agent.target);
    }
}
