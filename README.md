# CS 4331-002 - Virtual Reality Project 2/3 - Disaster Force Rescue Simulator

For Project 2, we have created a game which simulates a city being flooded. The player is put in charge of the rescue operation, where they must collect resources and build rescue units to retrieve the civilians safely.

For Project 3, we have expanded the scope of the original game by adding two additional scenearios that simulate acid rain and a tornado. Improvements have been made to character models and AI, allowing for more immersive behavior before and during these disaster scenarios. Civilian demographics have also been added, allowing the user to specify between several categories that impact the characteristics of the rescue targets. Finally, a time-based scoring system has been implemented that allows for you to keep track of your fastest rescue times.

![](/Presentation/Project_3_Screenshot.png)

## Table of Contents
* [Standalone Download](#standalone-download)
* [Video Demo](#video-demo)
* [Project Report 3](#project-report---project-3)
  * [Project 3 Proposal](#project-3-proposal)
  * [Tools/Devices Used](#toolsdevices-used)
  * [We Learned...](#we-learned-1)
  * [Contributors](#contributors-1)
  * [Work Distribution](#work-distribution)
  * [Screenshots](#screenshots)
  * [Timeline and Tasks](#timeline-and-tasks)
  * [External Model/Asset Sources](#external-modelasset-sources-in-addition-to-project-2-assets)
* [Project Report 2](#project-report---project-2)
  * [Project Planning](#project-planning)
  * [Tools/Device Used](#toolsdevices-used-1)
  * [We Learned...](#we-learned-1)
  * [Biggest Issues](#biggest-issues)
  * [Contributors](#contributors-1)
  * [Work Distribution](#work-distribution-1)
  * [Screenshots](#screenshots-1)
  * [Timeline and Tasks](#timeline-and-tasks-1)
  * [External Model/Asset Sources](#external-modelasset-sources)

## Standalone Download
[Link to download our game's standalone build (Project 2 Version)](https://mega.nz/#!Kq4zhYAI!C5Cr6akVIUc6un2S3niOCqdJakh8KnpARj7xkJEdQNo)

## Video Demo
[Link to our short video presentation (Project 2 Version)](https://youtu.be/akuz5iDR_eI)

## Project Report - Project 3

### Project 3 Proposal
Project 3 will serve as an improved version of Project 2 with an expanded scope. Some of the additions we plan on making are as follows:

***Note: Additional features may be added as suggestions arise. Complete implementation of the following depends on time constraints.***
- Greater differences in functionality between rescue units
- The ability to specify various aspects of the civilian demographics (age, profession, race, etc.)
- Additional weather scenarios (acid rain, huricane, etc.)
- Improvements to civilian modeling
- Implementation of civilian AI
- Scoring system that allows for competition

This game is fit for VR implementation as it allows the user to dynamically experience the disaster scenario as it happens, as well as observe first-hand the effects of their gameplay decisions.

### Tools/Devices Used
- [Unity](https://unity3d.com/)
- [Github Desktop](https://desktop.github.com/)
- [VSCode](https://code.visualstudio.com/) 
- [Oculus Rift & Touch Controllers](https://www.oculus.com/rift/)
- [Unity Oculus SDK](https://developer.oculus.com/downloads/package/oculus-utilities-for-unity-5/)

### We learned...
- How to collaborate as a team on a larger project
- How to use more advanced Unity features
- Advanced C# scripting
- How to integrate VR controls
- Basic AI Implementation

### Contributors
  - [Joyelle Woodson](https://github.com/joyellealina)
  - [Derek Fritz](https://github.com/defritz)
  
### Work Distribution
***Note: For original responsibilities for the Project 2 groundwork, find the Work Distribution section under the Project 2 Report***
  - Joyelle Woodson:
    * Expanding functionality of nav-meshes
    * Design and implementation of civilian modeling and AI
  - Derek Fritz:
    * Design and modeling of acid rain & tornado scenarios
    * Expansion of UI features (options, game modes, scores)
    * Implementation of scoring system

***

### Screenshots

With Project 3, we added two additional scenarios, simulating acid rain and a tornado in addition to the flooding scenario.

![](/Presentation/Flood.png)

In the acid rain scenario, the town has expanded their factories which resulted in greater pollutants. In this game mode, the player is subject to gradual damage from the acid rain over time, slowly draining their resource points and restricting their rescue options.

![](/Presentation/Acid%20Rain.png)

In the tornado scenario, the town finds itself in a drought which has resulted in a more barren terrain and leaving the civilians exposed to harsher elements. In this game mode a tornado roams the play area, destroying any rescue units or civilians that comes across its path.

![](/Presentation/Tornado.png)

With these two new scenarios, additional rescue units have been added. These include two tiers of land-based rescue cars and a helicopter, featuring high mobility but low capacity.

![](/Presentation/New%20Units.png)

Finally, large improvements have been made to the civilian modeling and AI. The civilian rescue targets are now fully modeled as individual people. These civilians roam between set waypoints (the red spheres you see in the image below), and then seek safety once disaster strikes.

![](/Presentation/Civilians.png)

### Timeline and Tasks

***Week 1***

- [x] Expand main menu to allow for new features (**Completed 4/26/2018**)
- [x] Begin planning new scenarios to simulate (**Completed 4/29/2018**)

***Week 2***

- [x] Improve character models (**Completed 5/2/2018**)
- [x] Add AI pathfinding to character objects (**Completed 5/2/2018**)
- [x] Add pathfinding to new weather scenarios (**Completed 5/6/2018**)

***Week 3***
- [x] Implement time-based scoring system (**Completed 5/7/2018**)
- [x] Establish functionality of new weather scenarios
- [ ] Implement civilian demographic features

 ### External Model/Asset Sources (In Addition to Project 2 Assets)
- [Car Models](https://assetstore.unity.com/packages/3d/vehicles/land/military-suvs-body-color-customizable-100132)
- [Helicopter Model](https://assetstore.unity.com/packages/3d/vehicles/land/police-car-helicopter-52496)
- [Particle Twister](https://assetstore.unity.com/packages/tools/particle-twister-27488)
- [UI Sound Effects](https://assetstore.unity.com/packages/audio/sound-fx/scifi-ui-sound-fx-27282)
- [Toony Tiny People](https://assetstore.unity.com/packages/3d/characters/toony-tiny-people-demo-113188)

***

## Project Report - Project 2

### Project Planning
The majority of our research and planning is located on our [Wiki](https://github.com/joyellealina/VRGame/wiki/VR-Evacuation-Game---Home) page.

### Tools/Devices Used
- [Unity](https://unity3d.com/)
- [Github Desktop](https://desktop.github.com/)
- [VSCode](https://code.visualstudio.com/) 
- [Oculus Rift & Touch Controllers](https://www.oculus.com/rift/)
- [Unity Oculus SDK](https://developer.oculus.com/downloads/package/oculus-utilities-for-unity-5/)

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

***Committing While Exceeding Github File Limit Size***

Whe importing one of our assets, we did not realize that it contained a file that exceeded GitHub's 100MB file size limit. We proceeded to make commits and when trying to push them to our repository, it would fail. This caused a snowball effect in following commits and took hours to resolve. The solution was to create a temporary branch at the commit where the bad file was first introduced, `rm` the file, and perform a rebase. With the file deleted at the first occcurrence, all following commits were recursivley ammended.
  
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

### Screenshots

***NOTE: The images below are from a slightly older version of the game that lack certain aesthetic improvements. However, the functionalities demonstrated remain the same.***

Here is a look at our player UI, which is anchored to the player's left touch controller. This allows them to look at and interact with the game menu dynamically. The "Begin Operation" button activates the rainfall and initiates the flooding. The three "Build" buttons allow the user to create rescue boat units in exchange for resources, which is represented by the gold bar at the bottom. Resources are obtained as the rescue units succesfully retrieve civilians.

![](/Presentation/1.png)
![](/Presentation/2.png)

Below we see the player's base of operations, where rescue units are spawned from and return to after a succesful operation.

![](/Presentation/3.png)

The following images display the flooding in process, as water levels increase over time.

![](/Presentation/4.png)
![](/Presentation/5.png)
![](/Presentation/6.png)

Here we can see several civilians taking refuge on top of the town's buildings, represented by the noticeable red orbs. The rescue units will target these civilians in need of saving and continue seeking them out until the boat's capacity is filled or all civilians have been rescued.

![](/Presentation/7.png)

When the player has enough resources the build a boat, the selected unit will spawn in front of the base.

![](/Presentation/8.png)

These units will track down civilians.

![](/Presentation/9.png)

And carry on with their mission after retrieving them.

![](/Presentation/10.png)
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
- [x] Add a start menu to the game (**Completed 4/10/2018**)

 ***
 ### External Model/Asset Sources
- [Rain Effects](https://assetstore.unity.com/packages/vfx/particles/environment/rain-maker-2d-and-3d-rain-particle-system-for-unity-34938)
- [Low Poly Water](https://assetstore.unity.com/packages/tools/particles-effects/lowpoly-water-107563)
- [Low Poly Buildings](https://assetstore.unity.com/packages/3d/environments/urban/lowpoly-modern-city-buildings-set-64427)
- [Old Rowboat](https://www.turbosquid.com/FullPreview/Index.cfm/ID/675083)
- [Zodiac Project Boat](https://www.turbosquid.com/FullPreview/Index.cfm/ID/1142795)
- [Free Boat 3D Model](https://www.turbosquid.com/FullPreview/Index.cfm/ID/222609)
- [Boat 3D Model](https://archive3d.net/?a=download&id=8ab68bde)
- [Streets](https://assetstore.unity.com/packages/3d/small-town-america-streets-free-59759)
- [Sci-Fi Texture Pack](https://assetstore.unity.com/packages/2d/textures-materials/sci-fi-texture-pack-1-23301)
- [Text Mesh Pro](https://assetstore.unity.com/packages/essentials/beta-projects/textmesh-pro-84126?aid=1101lPGj&utm_source=aff)
- [NavMesh Components](https://github.com/Unity-Technologies/NavMeshComponents)
- [Car Models](https://assetstore.unity.com/packages/3d/vehicles/land/military-suvs-body-color-customizable-100132)
- [Helicopter Model](https://assetstore.unity.com/packages/3d/vehicles/land/police-car-helicopter-52496)
- [Particle Twister](https://assetstore.unity.com/packages/tools/particle-twister-27488)
- [UI Sound Effects](https://assetstore.unity.com/packages/audio/sound-fx/scifi-ui-sound-fx-27282)
