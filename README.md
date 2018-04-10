# CS 4331-002 - Virtual Reality Project 2

We plan on creating a game where the user needs to evacuate a city/town in an severe weather scenario. In this sense, we are developing a project that includes resource-management aspects, while also incorporating evacuation scenarios.
 
## Video Demo
Video demonstration will go here.

## Project Report

### Project Planning
The majority of our research and planning is located on our [Wiki](https://github.com/joyellealina/VRGame/wiki/VR-Evacuation-Game---Home) page.

### Tools/Devices Used
- Unity 2017
- Github Desktop
- Visual Studio, VSCode, etc. (Any editor is fine)
- Oculus Rift & Touch Controllers
- Unity Oculus SDK

### We learned...
- How to collaborate as a team on a larger project
- How to use more advanced Unity features
- Advanced C# scripting
- How to integrate VR controls
- Basic AI Implementation

### Biggest issues

***Merge Conflicts***

Upon completing work on seperate branches, we ran into several issues when trying to merge everything into the master branch. Various scene aspects such as models, scripts and settings were not present. We were able to successfully merge one development branch into master by accepting all of the development branch changes since the master was a bare scene. To avoid future issues, we had to carefully commit and push our work, making sure to not work on the same thing or wait until something was completely done before moving onto the next feature.

***Use of Free Models and Aspects***

Due to time constraints and lack of experience, we were unable to produce any of our own 3D models for this project. This led to using free Unity aspects and models found online. The problem with this is limited functionality. We did our best to modify assets and models to best suit the use cases for this project. For the list of assets and models used, please navigate to our ***External Model Resources*** section.

***Testing***
After VR functionality was added, testing was placed onto one person since there was only one Oculus headset. Testing without the headset was difficult and took much longer than expected. Testing even small functionalities and scripts could take large amounts of time.

***AI***
Implementing the AI for the different tiers of boats was difficult and still does not fully work they way we want. We also had some AI implementation for the civillians: they would wander the town until they came into contact with flood water, they would then rush to safe locations on top of buildings. This functionality was in the game, but was erratic and added complexity that could not be resolved within the time frame. We plan to put this functionality back into the game after more research and testing.
  
### Contributors
  - [Joyelle Woodson](https://github.com/joyellealina)
  - [Derek Fritz](https://github.com/defritz)

### Work Distribution
  - Joyelle Woodson:
    * Creating Rain and Flood Scripts
    * Initial Boat AI Implementation
    * Initial Civillian AI Implementation (Removed for now...)
  - Derek Fritz:
    * Design of City and Terrain
    * UI Groundwork
    * VR / Touch Controller Functionality
    * Initial Resource Functionality
***
We'll put screenshots and explanations here!
***
### Timeline and Tasks
***Week 1***

- [x] Setup Unity environment (**Completed 3/20/2018**)
- [x] Submit Proposal (**Proposal Accepted 3/21/2018**)

***Week 2***

- [x] Create Wiki to start planning and reasearch (**Completed 3/26/2018**)
- [x] Plan out game idea and basic mechanics (**Completed 3/26/2018**)

***Week 3***

- [x] Setup city environment (**Completed 4/1/2018**)
- [x] Created button to start raining (**Completed 4/3/2018**)
- [x] Create button to spawn boats (**Completed 4/5/2018**)
- [x] Integrate VR functionality and controller support (**Completed on 4/6/2018**)
- [x] Simluate basic flooding scenario (**Completed on 4/6/2018**)
- [x] Add AI pathfinding to spawned boats (**Completed 4/7/2018**)
- [x] Add different tiers of Boat units (**Completed 4/7/2018**)

***Week 4***

- [x] Extend Boat AI to multiple points (**Completed 4/9/2018**)
- [x] Add Counter to Canvas (**Completed 4/9/2018**)

***To Be Completed For Project 3***
- [ ] Add basic character models
- [ ] Add AI pathfinding to character objects

 ***
 ### External Model/Asset Sources
- [Rain Effects](https://assetstore.unity.com/packages/vfx/particles/environment/rain-maker-2d-and-3d-rain-particle-system-for-unity-34938)
- [Low Poly Water](https://assetstore.unity.com/packages/tools/particles-effects/lowpoly-water-107563)
- [Low Poly Buildings](https://assetstore.unity.com/packages/3d/environments/urban/lowpoly-modern-city-buildings-set-64427)
- [Old Rowboat](https://www.turbosquid.com/FullPreview/Index.cfm/ID/675083)
- [Zodiac Project Boat](https://www.turbosquid.com/FullPreview/Index.cfm/ID/1142795)
- [Free Boat 3D Model](https://www.turbosquid.com/FullPreview/Index.cfm/ID/222609)
- [Streets](https://assetstore.unity.com/packages/3d/small-town-america-streets-free-59759)
