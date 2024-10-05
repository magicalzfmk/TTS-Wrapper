# Important
## Links
- [Cogqui](https://tts.readthedocs.io/en/dev/index.html) 
- [RVC Github For API](https://github.com/JarodMica/rvc-tts-pipeline)
- [Another one for Above](https://github.com/JarodMica/audiobook_maker) 
# Projects
- [[Tortoise-RVC TTS project]]
## Tortoise TTS .NET WebApp
- Platform : .NET Core
- Server Created via: [Tortoise WebUI](https://git.ecker.tech/mrq/ai-voice-cloning/issues?type=all&state=open&labels=&milestone=0&project=0&assignee=0&poster=0&q=gnu)
### How?
- Using the Project Repo: [REPO](https://git.ecker.tech/mrq/ai-voice-cloning)
	- Note: Dont use the above repo in a project because of licencing issues
- I downloaded the provided notebook to work in google collab.
	- ![[Pasted image 20230825094440.png]]
- Link displayes a GUI with all the features:
	- ![[Pasted image 20230825094800.png]]
- API endpoints are exposed as shown:
	- ![[Pasted image 20230825095130.png]]
	- Another API for generation Exposed Below (if scrolled)
	- ![[Pasted image 20230825095211.png]]
- Now i created a new WebApp using Visual Studio using .NET Core.
	- EX: ![[Pasted image 20230825095341.png]]
	- Code Attached.
- The App creates a webpage: 
	- ![[Pasted image 20230825095528.png]]
- API Page:
	- ![[Pasted image 20230825095842.png]]
- Code attached. Notes are also in notes for easier understanding.

## Training Voice Models
### Training Tortoise
- Using the Project Repo: [REPO](https://git.ecker.tech/mrq/ai-voice-cloning)
	- Note: Dont use the above repo in a project because of licencing issues
- [Youtube](https://www.youtube.com/watch?v=6sTsqSQYIzs)
- I downloaded the provided notebook to work in google collab.
	- ![[Pasted image 20230825094440.png]]
- Click on Training Icon in GUI:
	- ![[Pasted image 20230825100525.png]]
- Transcribe Dataset: (make sure to add voice samples in ai-voice-cloning/voices/Name/sample.wav.........)
	- ![[Pasted image 20230825100851.png]]
- Generating config.:
	- ![[Pasted image 20230825101314.png]]
- Train:
	- ![[Pasted image 20230825101615.png]]
- Now change model to trained on in settings (autoregressive to trained) and generate voice( make sure to choose Voice name as trained one)
	- ![[Pasted image 20230825101808.png]]
- USE THE TRAINED MODEL AS YOU WISH IN OTHER TORTOISE VERSIONS.
	- IF YOU NEED THE TRAINED VOICES BY ME, **THEN INFORM ME AND I WILL GIVE DRIVE LINK**.

### Training RVC
- Using Github REPO: [Repo](https://github.com/RVC-Project/Retrieval-based-Voice-Conversion-WebUI)
- [Youtube](https://www.youtube.com/watch?v=9wu6LSue_dU&list=PLknlHTKYxuNshtQQQ0uyfulwfWYRA6TGn&index=2&t=987s)
#### Prerequisites
- 1 min of sample divided into atmost 10 sec audio files.
- Format: .wav
#### Steps
- I created a google collab environment to run RVC, by creating a server.
	- ![[Pasted image 20230825104721.png]]
	- This creates a GUI sharing server.
- Public Gradio Link Opens a GUI for RVC:
	- ![[Pasted image 20230825105027.png]]
- Go to training Tab:
	- ![[Pasted image 20230825105313.png]]
- Start Training:
	- ![[Pasted image 20230825105537.png]]
- Go back to model inference tab.
	- ![[Pasted image 20230825105827.png]]

## Tortoise-RVC Voices
- Realistic Voices made using tortoise and later RVC.
- MESSAGE ME IF DATA NEEDED, I WILL PROVIDE DRIVE LINK.
### Steps
- Train Bark Model on Voice Sample
- Train RVC on same Voice Samples
- Do TTS Via Tortoise And Process Through RVC For Final Output
- ![[Pasted image 20230825111846.png]]