# The Among Us In Real Life App    
Hello, if you here then your probibly looking to play among us with your friends in real-life. This app can help.    
_What does it do though?_ I'm glad you asked       

## Features:

1. [Role choosing](https://github.com/Medatur76/Among-Us-In-Real-Life-App#role-choosing-and-how-to-do-it)    
2. [Tasks](https://github.com/Medatur76/Among-Us-In-Real-Life-App#tasks) _Going to take a while_    
3. [Sabotage GUI](https://github.com/Medatur76/Among-Us-In-Real-Life-App#sabotage-gui) _May require maunual setup_


## Role Choosing and how to do it:

As we all know, there are 2 roles (I know, there are _6_ but you cant do them in _real life_, except for the medic which _will come out soon_).
If you dont know what they are then here:    
![Crewmate](https://github.com/Medatur76/Among-Us-In-Real-Life-App/blob/master/Among%20Us%20APP/Pictures/Crewmate.jpg)    
And    
![Imposter](https://github.com/Medatur76/Among-Us-In-Real-Life-App/blob/master/Among%20Us%20APP/Pictures/Imposter.jpg)     
This app can choose for you who is who. You can download it on sepreate divices or you can use one to tell everyone there role.
After the role are showed then comes the....

## Tasks

Task are the one way to win as crewmate. So we have em, if your using multiple divices for roles, then the tasks will apear after the role is found. If you dont hva multiple divices then you can use the print option. It will print out a list of the tasks. If you dont want to print em out, you can write em. There will be a section on tasks inwhitch you can do em. The only one that requires a divice to do it is the download task. _**NOTE**: For the download task, its is perferd you use a flashdrive that is [setup](https://github.com/Medatur76/Among-Us-In-Real-Life-App#flash-drive-setup) for the task_ The list of tasks are on the application!     

## Sabotage GUI

I have know idea how this is going to work, so for know, this part of the app will not work

## Flash Drive Setup

It does not take much, just add [Among Us In Real Life.zip](https://github.com/Medatur76/Among-Us-In-Real-Life-App/files/7774641/Among.Us.In.Real.Life.zip) after unziping it, to your flash drive. So it should look like this right now:     
![FirstPic](https://user-images.githubusercontent.com/90143210/147275195-66fd86f5-037b-41f3-9f99-6a9e217e19ea.png)
In the _Among Us In Real Life_ folder, there should be 2 files: _download.data_ and _player.data.json_ you can leave the download.data file along, thats for the task. You want to edit the player.data.json. The file should look like this (if it does not, FIX IT):
```JSON
{
	"player": "",
	"realname": "",
	"color": "",
	"accessories": {
		"hat": "",
		"shirt": "",
		"mask": 
	},
	"datafilecontent": "BrownMedatur76wedsIHuglhoKHhioheowijfiohUHOIHiojojihoCrewjjjwmateminiwwwwwa"
}
```    
Heres what you do:    
```JSON
{
	"player": "(Put your username here)",
	"realname": "(Put your reallife name here, its optional)",
	"color": "(Put your player color here)",
	"accessories": {
		"hat": "(there will be a list [here]())",
		"shirt": "(there will be a list [here]())",
		"mask": (if you want a mask, put true here, if not put false)
	},
	"datafilecontent": "(This can be what ever you want, just don't make it to long)"
}
```    
The colors here will not be there in the file, thats the README file.
And your done!
