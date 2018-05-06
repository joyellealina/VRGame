# CS 4331-002 - Virtual Reality Project 2/3 - Flood Fighter Rescue Simulator

For Project 2, we have created a game which simulates a city being flooded. The player is put in charge of the rescue operation, where they must collect resources and build rescue units to retrieve the civilians safely.

For Project 3, we plan on expanding the scope of the game by adding to the rescue unit functionality, adding additional weather scenarios, allowing the user to specify civilian population demographics, and creating a scoring system. For further details on the improvements we plan on making, please reference the **Project 3 Proposal** section below.

## Standalone Download
[Link to download our game's standalone build](https://mega.nz/#!Kq4zhYAI!C5Cr6akVIUc6un2S3niOCqdJakh8KnpARj7xkJEdQNo)

## Video Demo
[Link to our short video presentation](https://youtu.be/akuz5iDR_eI)

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

As it will be an extension to Project 2, the core development tools being used will remain the same (these can be found below in the **Tools/Devices Used** section of our Project 2 Report). The game will work on Windows/Mac systems that have Oculus VR compatability.

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

***To Be Completed For Project 3***
(Will Add to this List)
- [x] Improve character models (**Completed 5/2/2018**)
- [x] Add AI pathfinding to character objects (**Completed 5/2/2018**)
- [x] Begin planning new scenarios to simulate
- [ ] Add pathfinding to new weather scenarios

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
