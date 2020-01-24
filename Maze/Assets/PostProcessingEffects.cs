using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessingEffects : MonoBehaviour
{
    public PostProcessVolume volume;
    private LensDistortion lensdistortion;
    private ChromaticAberration chromaticAberration;
    private Grain grain;
    public int lensDistortionStrenght = 30;
    public float lensDistortionSpeed = 2;
    public float chromaticAberrationStrenght = 2;
    public float chromaticAberrationSpeed = 2;
    public float grainStrenght = 2;
    public float grainSpeed = 2;
    public float grainSize = 2;
    public float grainSizeSpeed = 2;
    void Start()
    {
        volume.profile.TryGetSettings(out lensdistortion);
        volume.profile.TryGetSettings(out chromaticAberration);
        volume.profile.TryGetSettings(out grain);
    }

    // Update is called once per frame
    void Update()
    {
        lensdistortion.intensity.value = Mathf.Sin(Time.realtimeSinceStartup * lensDistortionSpeed) * lensDistortionStrenght;
        float chromaticValue= Mathf.Sin(Time.realtimeSinceStartup * chromaticAberrationSpeed) * chromaticAberrationStrenght;
        if(chromaticValue < 0) { chromaticValue = -chromaticValue; }
        chromaticAberration.intensity.value = chromaticValue;
        float grainValue = Mathf.Sin(Time.realtimeSinceStartup * grainSpeed) * grainStrenght;
        if (grainValue < 0) { grainValue = -grainValue; }
        grain.intensity.value = grainValue;
        float grainSizeValue = Mathf.Sin(Time.realtimeSinceStartup * grainSizeSpeed) * grainSize;
        if (grainSizeValue < 0) { grainSizeValue = -grainSizeValue; }
        grain.size.value = grainSizeValue;
    }
}
