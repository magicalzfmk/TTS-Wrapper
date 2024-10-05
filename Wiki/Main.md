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
	- ![img1](https://github.com/magicalzfmk/TTS-Wrapper/blob/main/Wiki/Images/Pasted%20image%2020230825094440.png?raw=true)
- Link displayes a GUI with all the features:
	- ![img2](https://github.com/magicalzfmk/TTS-Wrapper/blob/main/Wiki/Images/Pasted%20image%2020230825094800.png?raw=true)
- API endpoints are exposed as shown:
	- ![img3](https://github.com/magicalzfmk/TTS-Wrapper/blob/main/Wiki/Images/Pasted%20image%2020230825095130.png?raw=true)
	- Another API for generation Exposed Below (if scrolled)
	- ![img4](https://github.com/magicalzfmk/TTS-Wrapper/blob/main/Wiki/Images/Pasted%20image%2020230825095211.png?raw=true)
- Now i created a new WebApp using Visual Studio using .NET Core.
	- EX: ![img5](https://github.com/magicalzfmk/TTS-Wrapper/blob/main/Wiki/Images/Pasted%20image%2020230825095341.png?raw=true)
	- Code Attached.
- The App creates a webpage: 
	- ![img6](https://github.com/magicalzfmk/TTS-Wrapper/blob/main/Wiki/Images/Pasted%20image%2020230825095528.png?raw=true)
- API Page:
	- ![img7](https://github.com/magicalzfmk/TTS-Wrapper/blob/main/Wiki/Images/Pasted%20image%2020230825095842.png?raw=true)
- Code attached. Notes are also in notes for easier understanding.

## Training Voice Models
### Training Tortoise
- Using the Project Repo: [REPO](https://git.ecker.tech/mrq/ai-voice-cloning)
	- Note: Dont use the above repo in a project because of licencing issues
- [Youtube](https://www.youtube.com/watch?v=6sTsqSQYIzs)
- I downloaded the provided notebook to work in google collab.
	- ![img1](https://github.com/magicalzfmk/TTS-Wrapper/blob/main/Wiki/Images/Pasted%20image%2020230825094440.png?raw=true)
- Click on Training Icon in GUI:
	- ![img8](https://github.com/magicalzfmk/TTS-Wrapper/blob/main/Wiki/Images/Pasted%20image%2020230825100525.png?raw=true)
- Transcribe Dataset: (make sure to add voice samples in ai-voice-cloning/voices/Name/sample.wav.........)
	- ![img9](https://github.com/magicalzfmk/TTS-Wrapper/blob/main/Wiki/Images/Pasted%20image%2020230825100851.png?raw=true)
- Generating config.:
	- ![img10](https://github.com/magicalzfmk/TTS-Wrapper/blob/main/Wiki/Images/Pasted%20image%2020230825101314.png?raw=true)
- Train:
	- ![img11](https://github.com/magicalzfmk/TTS-Wrapper/blob/main/Wiki/Images/Pasted%20image%2020230825101615.png?raw=true)
- Now change model to trained on in settings (autoregressive to trained) and generate voice( make sure to choose Voice name as trained one)
	- ![img12](https://github.com/magicalzfmk/TTS-Wrapper/blob/main/Wiki/Images/Pasted%20image%2020230825101808.png?raw=true)
- USE THE TRAINED MODEL AS YOU WISH IN OTHER TORTOISE VERSIONS.

### Training RVC
- Using Github REPO: [Repo](https://github.com/RVC-Project/Retrieval-based-Voice-Conversion-WebUI)
- [Youtube](https://www.youtube.com/watch?v=9wu6LSue_dU&list=PLknlHTKYxuNshtQQQ0uyfulwfWYRA6TGn&index=2&t=987s)
#### Prerequisites
- 1 min of sample divided into atmost 10 sec audio files.
- Format: .wav
#### Steps
- I created a google collab environment to run RVC, by creating a server.
	- ![img13](https://github.com/magicalzfmk/TTS-Wrapper/blob/main/Wiki/Images/Pasted%20image%2020230825104721.png?raw=true)
	- This creates a GUI sharing server.
- Public Gradio Link Opens a GUI for RVC:
	- ![img14](https://github.com/magicalzfmk/TTS-Wrapper/blob/main/Wiki/Images/Pasted%20image%2020230825105027.png?raw=true)
- Go to training Tab:
	- ![img15](https://github.com/magicalzfmk/TTS-Wrapper/blob/main/Wiki/Images/Pasted%20image%2020230825105313.png?raw=true)
- Start Training:
	- ![img16](https://github.com/magicalzfmk/TTS-Wrapper/blob/main/Wiki/Images/Pasted%20image%2020230825105537.png?raw=true)
- Go back to model inference tab.
	- ![img17](https://github.com/magicalzfmk/TTS-Wrapper/blob/main/Wiki/Images/Pasted%20image%2020230825105827.png?raw=true)

## Tortoise-RVC Voices
- Realistic Voices made using tortoise and later RVC.
- MESSAGE ME IF DATA NEEDED, I WILL PROVIDE DRIVE LINK.
### Steps
- Train Bark Model on Voice Sample
- Train RVC on same Voice Samples
- Do TTS Via Tortoise And Process Through RVC For Final Output
- ![img18](https://github.com/magicalzfmk/TTS-Wrapper/blob/main/Wiki/Images/Pasted%20image%2020230825111846.png?raw=true)