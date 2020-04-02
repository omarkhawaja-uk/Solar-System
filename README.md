# **Omar Khawaja** | Project  | VR Astrophysics Project

[My Project Website](https://omarprojects.weebly.com/)

* All videos can be viewed at my website. 
* The main Project files have been uploaded here. Due to large amount of files, 
 I have only uploaded the files of significance. And have included the final **build** that can be run. 

![Overview](https://i.imgur.com/TeWGkE0.jpg "")

## RUN 
* Download the entire folder ```Solar System Windows```
from the following [DOWNLOAD LINK](https://drive.google.com/file/d/1DHoBQy4NioiSTVh8YJQKr00FxY5Akgfu/view?usp=sharing)
(*file size too big for Github*).
Unzip the folder and click on the application ```VR```


* Space Ship Mode :rocket::
For movement use the keys W,A,SD and your mouse to look around. 
```
W = Forward
A = Left
S = Backwards
D = Right
```

* Solar System Mode 🌌:
Look around using the mouse.
Press Keys: 1,2,3,4,5,6,7 
To switch between Planets (except for Earth, go onto Earth & Moon mode). 
```
1 = Mercury 
2 = Venus 
3 = Mars
4 = Jupiter
5 = Saturn
6 = Uranus
7 = Neptune
```
Press the 'TAB' button to switch back to the main camera view. 

* Earth & Moon Mode :earth_africa::
Close-up of the the Moon orbiting the Earth. 

***NOTE: TO SWITCH BETWEEN ANY OF THE THREE MODES YOU MUST CLOSE THE SIMULATION AND OPEN IT UP AGAIN. WINDOWS ONLY***
 
 
# Main Scripts
### Physics Scripts
### Set

```
SetInitialOrbitalVelocity.sc
``` 

* Calculates and sets the intial velocity. 
* Calculates Periods and rotational velocity.
* Allows for the input of Inclination and Axial tilt. 


### Gravity 

```
Gravity.sc
``` 
* Calculates the Gravitional Force between all bodies, and is attached to all bodies. 

### Initialising Bodies

```
InitialisingBodies.sc
``` 
* Intilises the Perihilion distances, and sets the order for which the Planets and Moon(s) are 'Started' in the simulation. 

### Other Scripts

```Data.cs```

```CamFollow.cs```

```Flying.cs```

```PlanetName.cs```

```LoadScene.cs```

```LoadSceneVideoTimer.cs```

```RestartScene.cs```

```PlanetCameras.cs```

### Old Scripts

```SetInitialOrbitalVelocity-old```
My old script has been attached for reference only. 


## Space Ship

* Files pertaning to my Space Ship / Shuttle (to be used for final Group Project). 

The file named:
```
Omar Shuttle Prefab.prefab
```
Is the Prefab that containts the 3D Shuttle, 'Engines', the Camera set-up and other neccesary components. 

Animation files as well as the controller files

The following script:

```
Flying.sc
``` 
controls the movements of the Space Ship.

### Scenes 

* Scene files. 

### Planets

* Planet prefabs. 

### Galaxy Effects

* Galaxy intro effect.

### Sun Effects

* Sun prefab and sun effects. 
