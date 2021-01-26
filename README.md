# FlappyBirdsSpinOff

[![Game Preview](https://img.youtube.com/vi/42w_Q89A4Ns/0.jpg)](https://www.youtube.com/watch?v=42w_Q89A4Ns)

This is just a demonstration repository for various types of Unity Architectures, We will be implementing a lot of these frequently and in the future I might go ahead and create the game all over again just to see the impact of changing a core Architecture like from Singleton to ScriptableObjects. 

This Repo at this time include a demo for: - 
  - Robust Singleton Pattern Implementation. 
  - Register and having a Global Function to call at a certain time ( Reset Function )
  - Magic...

# Upcoming Features.
  - Replacing Unity Native Functions with a Reset Like the interface, Think OnUpdate, OnStart, OnAwake(Maybe not tho)

*Wondering Why? Calls to 1000 Update Function within the native unity-managed bridge is far more costly than 1 Call from the Unity-Managed Bridge and this calls 1000 Update function, No setbacks. Stackoverflow maybe? We will try. 

Reference for this info and a book I strongly recommend to anyone plans to use unity: [Unity Game Optimization: Enhance and extend the performance of all aspects of your Unity games, 3rd Edition](https://www.amazon.com/Unity-Game-Optimization-Enhance-performance-dp-1838556516/dp/1838556516/ref=dp_ob_title_bk)

  - Mobile Inputs.
  - Variable Height for the obstacle and variable length between the obstacles.
  - Spawning the coins from poolable objects ordered from the script based on the state of the game and hardness level instead of just reactivating them all again.
  - Give me ideas.
  
# My Main Plan
  After this Repo is finished, and I'm just maintaining anything that can be annoying or giving bad information to people ( this is an educational and research repo after all ), I will start another one, FlappyBirdsSpinOff-ScriptableObjects? maybe. I will reference this work here [Unite Austin 2017 - Game Architecture with Scriptable Objects
](https://www.youtube.com/watch?v=raQ3iHhE_Kk&ab_channel=Unity) as I adored his work in this video, and I wanted to replicate all this work into a simple game to test out how everything, and after this plan is finished the open source community will have 2 different approaches to game design working side by side. Performance-wise, UI wise, which was easier to maintain. all Ranked up. 
 
 That's the plan for now but think after ScriptableObjects to convert the main core architecture of the application to something like a hand-made God-Class. some-people like this approach. Think MVC MVVC if possible or required, think of it as an entry point for me to implement over and over again with a different approach but same set of features. I will keep track of time I work on each one, along with side average FPS on my pc, and some specs. all to come soon.

# Singleton Tryout Stats.
Frametime : 0.9 - 1.2ms

Framerate: 1000FPS Average

Time Taken: 2 hours exactly to reach this point in this repo, both Readme and game will get updated every commit. with a new hour counter.

# Please
Don't use this files, or any other files on GitHub to make your Flappy birds game, this is open source I know you're entitled to do this, but for many reasons, I won't recommend using my files.

I'm creating them for educational purposes. so as far as I do use the best practices for Game Development, I'm completely ignoring the Game Design Perspective. the whatever-non-playable game that will come up from this repo, in the end, will be just what it is, a masterpiece ( Thanks, do not applause xD ) in development but junk in designing. And for this matter, don't waste money or manpower or even the price of thoughts into releasing another game in this genre. Use these files to help you develop with some advanced thinking in mind, I will be doing videos to how everything works and this is how this repo serves the educational part. See them and start designing and working on your own game. Your brain might have the next Minecraft idea. Markus Persson wouldn't have a net worth of 1 Billion$$ in 2019 if he made Flappy Birds.
