# Unity-Custom-Mipmap

A set of scripts and shaders in Unity that can render a texture using a custom mipmap level.

## Technologies

* Unity
* HLSL
* C#

## Getting Started

### Prerequisites

* Unity 2020.3.30f1
* Universal RP 10.8.1

### Installation

Clone the repo.
```
git clone https://github.com/ruthvikkonda/Unity-Custom-Mipmap.git
```

## Usage

1. Open the ```Cube_Mipmap``` scene.

2. To adjust the mipmap level in the **editor**, click on the cube, expand the shader properties, and change the ```Mip Level``` value.
    
3. To adjust the mipmap level at **runtime**, open the ```SetMipLevel.cs``` script and change the float value to your desired level.

### Integrating into Your Project

1. Change active render pipeline to Universal Render Pipeline (URP).
   * https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@10.8/manual/InstallURPIntoAProject.html
     
2. If your materials are pink, upgrade shaders/materials accordingly.
     * https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@10.8/manual/upgrading-your-shaders.html
       
3. From the ```Assets/Scripts``` folder, copy over ```SetMipLevel.cs.```.
    
4. From the ```Assets/Shaders``` folder, copy over ```MipLit.shader```, ```MipLitInput.hlsl```, and ```MipSurfaceInput.hlsl```.

5. For your desired GameObject, navigate to its material and change its shader to ```MipLit```.

6. Attach your desired texture to the ```Albedo``` property.

&nbsp;

You can now change the mipmap level in the **editor** or at **runtime**.

7. To adjust it in the **editor**, change the ```Mip Level``` value at the top of the shader properties.

8. To adjust it at **runtime**, open the ```SetMipLevel.cs``` script and change the float value to your desired level.


## Contact

* **Ruthvik Konda** - ruthvikkkonda@gmail.com

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

* Unity’s Default URP Lit Shader
