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
This repository is a fork of [EdgeDetect-PostProcessingUnity](https://github.com/jean-moreno/EdgeDetect-PostProcessingUnity), that ports legacy Unity "Edge Detect Normals" image effect to **Post Processing Stack v2**, adding new features and modifications.

- [Edge Detect Effect Normals - Unity Documentation](https://docs.unity3d.com/550/Documentation/Manual/script-EdgeDetectEffectNormals.html)
- [Post Processing Stack v2 - Unity Technologies GitHub](https://github.com/Unity-Technologies/PostProcessing/tree/v2)

|Edge Detection|Screenshot|
|-|-|
|Edge Detection Off|<img src="https://user-images.githubusercontent.com/9071269/59957254-c5707e80-9496-11e9-9482-ff0461f17caf.png" width="200px">|
|Triangle Depth Normals|<img src="https://user-images.githubusercontent.com/9071269/59957252-c5707e80-9496-11e9-8e14-c4a3607e8582.png" width="200px">|
|Roberts Cross Depth Normals|<img src="https://user-images.githubusercontent.com/9071269/59957249-c4d7e800-9496-11e9-8d28-75e4b67f1c9a.png" width="200px">|
|Sobel Depth|<img src="https://user-images.githubusercontent.com/9071269/59957250-c4d7e800-9496-11e9-9041-61f461e71d62.png" width="200px">|
|Sobel Depth Thin|<img src="https://user-images.githubusercontent.com/9071269/59957251-c5707e80-9496-11e9-8b63-aae54a7cc2e7.png" width="200px">|
|Triangle Luminance|<img src="https://user-images.githubusercontent.com/9071269/59957253-c5707e80-9496-11e9-9126-06239021f329.png" width="200px">|

Added features:

|Feature|Screenshot|
|-|-|
|Edge Color Picker|<img src="https://user-images.githubusercontent.com/9071269/59956512-1a10fb00-9491-11e9-83ed-57e6dbc32e5d.gif" width="200px">|

<br>

## Installation

This effect require [Post Processing Stack v2](https://github.com/Unity-Technologies/PostProcessing/tree/v2) added to your project. You can add it by Package Manager or Asset Store.

**[Download](https://github.com/AGM-GR/EdgeDetection/releases)** lastest unity package version and add it to your proyect or clone/download this repository and place the `EdgeDetection` folder anywhere in your project and it will be available in your PostProcessing Volume Profile.

<br>

## Usage

The new effect should be available for a post processing profile with different injection points:

- `Add effect... > Unity Legacy > Edge Detection (Before Transparent)`
Will render the Edge Detect effect before transparent objects are rendered, recommended for Legacy renderer (doesn't work with Scriptable Render Pipelines at time of writing - september 2018)
- `Add effect... > Unity Legacy > Edge Detection (Before Stack)`
Will render the Edge Detect effect before the built-in Post Processing Stack effects, recommended for Scriptable Render Pipelines
- `Add effect... > Unity Legacy > Edge Detection (After Stack)`
Will render the Edge Detect effect after the built-in Post Processing Stack effects, if you want the edges to appear on top of everything

<br><br>

Thanks to [Jean Moreno](https://github.com/jean-moreno).
