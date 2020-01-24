using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessingEffects : MonoBehaviour
{
    public PostProcessVolume volume;
    private Bloom bloom;
    private LensDistortion lensdistortion;
    private ChromaticAberration chromaticAberration;
    private Grain grain;

    public int lensDistortionStrenght = 45;
    public int lensDistortionSpeed = 1;
    public float chromaticAberrationStrenght = 1.5f;
    public float chromaticAberrationSpeed = 2;
    public float grainSizeStrenght = 2;
    public float grainSpeed = 2;

    // Start is called before the first frame update
    void Start()
    {
        volume.profile.TryGetSettings(out bloom);
        volume.profile.TryGetSettings(out lensdistortion);
        volume.profile.TryGetSettings(out chromaticAberration);
        volume.profile.TryGetSettings(out grain);
    }

    // Update is called once per frame
    void Update()
    {
        lensdistortion.intensity.value = Mathf.Sin(Time.realtimeSinceStartup* lensDistortionSpeed) * lensDistortionStrenght;
        grain.size.value = Mathf.Sin(Time.realtimeSinceStartup* grainSpeed) * grainSizeStrenght;
        float chromaticValue = Mathf.Sin(Time.realtimeSinceStartup * chromaticAberrationSpeed) * chromaticAberrationStrenght;
        if (chromaticValue<0)
        {
            chromaticValue = -chromaticValue;
        }
        chromaticAberration.intensity.value = chromaticValue;
    }
}
