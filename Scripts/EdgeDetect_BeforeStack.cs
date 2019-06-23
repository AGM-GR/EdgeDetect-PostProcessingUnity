using UnityEngine.Rendering.PostProcessing;

[System.Serializable]
[PostProcess(typeof(EdgeDetectPostProcessingRenderer_BeforeStack), PostProcessEvent.BeforeStack, "Edge Detection/Edge Detection (Before Stack)")]
public sealed class EdgeDetect_BeforeStack : EdgeDetectPostProcessing { }

//--------------------------------------------------------------------------------------------------------------------------------

public sealed class EdgeDetectPostProcessingRenderer_BeforeStack : EdgeDetectPostProcessingRenderer<EdgeDetect_BeforeStack> { }
