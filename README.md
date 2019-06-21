EdgeDetection
===
[![](https://img.shields.io/github/release/AGM-GR/EdgeDetection.svg?label=latest%20version)](https://github.com/AGM-GR/EdgeDetection/releases)
[![](https://img.shields.io/github/release-date/AGM-GR/EdgeDetection.svg)](https://github.com/AGM-GR/EdgeDetection/releases)
![](https://img.shields.io/badge/unity-5.6.1%2B-green.svg)
[![](https://img.shields.io/github/license/AGM-GR/EdgeDetection.svg)](https://github.com/AGM-GR/EdgeDetection/blob/master/LICENSE.txt)
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-orange.svg)](http://makeapullrequest.com)

<br>
## Description

Unity post-processing Edge Detection and Outline.
This repository is a fork of [EdgeDetect-PostProcessingUnity](https://github.com/jean-moreno/EdgeDetect-PostProcessingUnity), that ports legacy Unity "Edge Detect Normals" image effect to Post Processing Stack **v2**, adding features and modifications.

- [Edge Detect Effect Normals - Unity Documentation](https://docs.unity3d.com/550/Documentation/Manual/script-EdgeDetectEffectNormals.html)
- [Post Processing Stack v2 - Unity Technologies GitHub](https://github.com/Unity-Technologies/PostProcessing/tree/v2)

## Installation

This effect require [Post Processing Stack v2](https://github.com/Unity-Technologies/PostProcessing/tree/v2) added to your project. You can add it by Package Manager or Asset Store.
Place the `EdgeDetection` folder anywhere in your project and it will be available in your PostProcessing Volume Profile.

## Usage

The new effect should be available for a post processing profile with different injection points:

- `Add effect... > Unity Legacy > Edge Detection (Before Transparent)`
Will render the Edge Detect effect before transparent objects are rendered, recommended for Legacy renderer (doesn't work with Scriptable Render Pipelines at time of writing - september 2018)
- `Add effect... > Unity Legacy > Edge Detection (Before Stack)`
Will render the Edge Detect effect before the built-in Post Processing Stack effects, recommended for Scriptable Render Pipelines
- `Add effect... > Unity Legacy > Edge Detection (After Stack)`
Will render the Edge Detect effect after the built-in Post Processing Stack effects, if you want the edges to appear on top of everything
