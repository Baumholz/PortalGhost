# PortalGhost
VR Programmierung Unity SS22


**Synopsis**
PortalGhost is a cooperative, hybrid virtual reality game using a unique input system based on Electromyography (EMG).
You awake and find yourself in a confined space with no memory of how you got there and no possibility to leave. After having a look around, your prison turns out to be a laboratory complex, and judging by the skeleton in the corner, you will not be the first one to find a gruesome death within these walls.
Little did you know that the spirit of the deceased body is still trapped in this place, and his or her only chance of finding peace and moving on is to break the cycle and help you escape.
Find a way to work together, solve puzzles, discover supernatural powers within yourself and experience VR presence on a new level!

Will you be able to break free?

**Goals and Motivation**
With this game we wanted to give the players the feeling of being capable of supernatural powers and influencing the environment with them. For the VR player, these powers manifest themselves as telekinesis. How telekinesis is activatable and how it functions is explained in the next section. But in order for it to work properly, the player has to learn the right use of these powers, meaning to find the best contraction and position of their arm muscles to use the power fluently. This gives a feeling of learning and mastering the powers. The ghost player sees the world only on their PC screen, but has the ability to fly and move through walls. Additionally, the ghost player has the power to create portals, visually connecting the VR player’s room to the view of the ghost. This is mainly done to support the VR player. Portals are fully rendered in the VR view, giving the impression of a hole or window opening to another room that is otherwise not physically connected to it. Together with possibly distorted physics due to unconventional portal alignment, this leaves the VR player with the feeling that the boundaries of physical space are dissolving.

**Game mechanics and interaction**
One player controls the ghost by using keyboard and mouse, experiencing the game world on a screen. The other player controls the human character via VR headset connected to the same system.
The ghost can pass through walls and other objects and is able to open a portal for the VR player, which mirrors what the ghost sees at that moment. This way, the human character, not being able to access other areas of the level, can see and interact with objects that are normally out of reach.
The VR player has EMG sensors placed on the biceps and the forearm as well as a vive tracking device to track the hand position. When focusing the view on an object and raising the arm, this object gets selected and starts elevating. The player can then activate his or her power to move the selected object in a 3D space. When the power is active, the player can pull objects towards him- or herself by contracting the biceps, or push them away by stretching the arm straight forward and contracting the forearm. 
In the game there are some puzzles that need to be solved with the help of this mechanic. Objects have to be actively pulled through the portal or pressure plates are triggered by means of weight and key recognition of these objects. There are also integrated buttons that can be pressed by pushing them with the activated power, as well as finding codes that are hidden behind movable objects in the level, to ultimately solve a number puzzle with them. That makes working together necessary for achieving the final goal of escaping the complex.

**Hardware setup**
Only one PC, all of the following components are connected to this PC. A screen, mouse and keyboard. One VR headset and three lighthouses. A vive tracker mounted to the wrist of the player and a prototype EMG measurement microcontroller with wifi connectivity (provided by the Uni) connected to the biceps and forearm of the VR player. The coupled router establishes a connection for the data stream.

**Rationale**
Through the common restriction in movement and space availability VR-developers have to deal with, we decided to let the VR player access other parts of the game world with the help of the ghost player and progress the levels by using an elevator.
To activate the telekinesis power, we planned to use the EMG on the bizeps for pull and the triceps for push, combined with a vive tracker on the arm. However, using the triceps for the pull did not work as anticipated. The signals coming from the EMG were often irregular and unstable. That is  why we decided to use the forearm to activate the pull instead.
Because the VR player also needs the ability to select an object, we thought about the implementation of eye tracking. This way, players have the feeling of really focusing on the object that they try to move. Even though this sounded like a great idea in the beginning, we realized that players are actually not 100% aware of what their eyes are doing. In fact, humans move their eyes around four times per second to get an idea of the current surroundings. This might result in random object selection. Because of that, we decided to use the central position of the headset. The object will then be highlighted so that the player knows which item is selected. With this solution, we were also able to avoid displaying a crosshair, which would have lowered the feeling of presence.
For the avatar, we used a model of a flying head and hand. This simple presentation of the player has the benefit of avoiding the uncanny valley effect, and also the advantage, that there is no offset of the VR player’s fore- and upper arm and the avatar in the virtual world, which could be problematic when using a full bodied avatar model.
One condition for the game was to use unconventional ways to communicate between the players. To achieve that, we did not only use the portal mechanics, but also decided to implement non verbal and non text-based communication between the two players, specifically sound coming from the portal that was placed by the ghost, and audio feedback when using the kinetic power. We also decided to implement audio in the game surroundings, like hearing the motor of a refrigerator when going near it, or the buzzing of a ceiling lamp.
We chose to use a static portal constrained to one position for the VR player space, to reduce portal computations and conceal VR tracking issues. 

**Main Limitations and Next Steps
Limitations**
The EMG accuracy is improvable: It didn’t work with triceps so we needed to use the forearm.
Portal functionality improved, the release implementation misses some features mainly because of time constraints:
free portal placement on the VR player side
decoupling the portal camera from the VR rig
moving selected objects within the room shown by the portal instead of instantly pulling them through
moving objects from the VR players side through the portal
Not quite perfect object selection due to implementation and design decision of the spherecast solution without using a VR crosshair.
Limited movement space for the VR Player - less possibilities for the level design
Next Steps
Introduction into the story, intro scene, finishing animation per level
Ingame-communication between the two players via few audio cues (location of portal, rattle sound)
More levels
More puzzles (plug in pipe, board over pit)
More and better interactable objects (e.g. breaking bottles - water physics)
Improve portal and object/power interaction: Move objects from the player through the portal; continuous movement of objects from one side to the other; power control of objects on the other side of portal
Improve ghost movement
Polishing

**Statement of Contribution**
Ludwig Trauner
Ghost character movement and actions
Multiple portal iterations (2D/3D)
Final portal visualization with shader solution
Analyze portal physics to determine correct behavior
Incorporate VR tracking countermeasures to mitigate unwanted results
Portal interactability
Portal ray-/spherecast selection
Manuele Schneckenburger
add particle effects
add avatar design and animation (not used in final)
analyzing and developing portal physics with Ludwig and team
Portal development based on other examples (mostly not used in final)
Portal placement
Interaction
Shaders
Christian Schmalzbauer
Data management via ScriptableObjects
Gaze selection and outlining of objects
Main menu, game state system and settings
Implementation audio system and -samples
Initial polishing (animated, clicking buttons, buzzing, flickering light)
Niklas Hirsch
Puzzle/Level Design - Brainstorming (with Niklas Esch)
EMG Setup and Implementation
Implemented Telekinesis powers (activate, deactive, push, pull and move around objects)
Vive Tracker Setup and Implementation
Audio implementation for telekinesis
Hand & Head avatar implementation (with Niklas Esch)
modified VR movement speed
Niklas Esch
Level Design and implementation
Puzzle-design and implementation
Ghost and human collider system
Video recording, cutting and editing
Hand & Head avatar implementation (together with Niklas Hirsch)

**Repository**
Link to our repository on GitHub:
https://github.com/NiklasHirsch/PortalGhost
