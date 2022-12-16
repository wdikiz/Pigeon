<p align="center">
  <a href="" target="blank">
    <img src="https://raw.githubusercontent.com/wdikiz/wdikiz/3b3ef1590e0d58f359ff6105bb0089d6d129b7fb/projects/Logo%20blue.svg" width="320" alt="Pigeon Logo Blue" />
  </a>
</p>

<p align="center">
 Email Client for Windows. Simple, Robust and user friendly. Created in Windows Forms C#
 library
</p>


## Goals

L'objectif principal de ce projet est de <strong>est répondre au besoin des utilisateurs en matière de traitement et envoie des mails.</strong> **En principe, le projet, c'est un projet qui s'inscrit dans le cursus scolaire et l'utilisateur sera principalement une école primaire**.

## Features and strengths

1. Features and strengths
2. Supports custom message content
3. Support Richetexte format
4. Support many SMTP service provider
5. Supports message editing, previewing, message management
6. Support for importing users via files (txt, excel, csv(soon))
7. Small and beautiful visual interface, support various light and dark appearance styles
8. Support global font size setting
9. Supports Basic Authentication to SMTP server
10. Supports Anonymous connection to SMTP Server


## Captures d'écran

<br>

<p align="center">
  <a href="https://raw.githubusercontent.com/wdikiz/wdikiz/main/projects/Sp.png">
   <img alt="Pigeon" src="https://raw.githubusercontent.com/wdikiz/wdikiz/main/projects/Sp.png">
  </a>
</p>

<br>

<p align="center">
<a href="https://raw.githubusercontent.com/wdikiz/wdikiz/main/projects/Main.png">
<img alt="Pigeon-Smtp Screen" src= "https://raw.githubusercontent.com/wdikiz/wdikiz/main/projects/Main.png">
  </a>
</p>

<br>

<p align="center">
<a href="https://raw.githubusercontent.com/wdikiz/wdikiz/main/projects/Smtp.png">
<img alt="Pigeon-Main Screen" src= "https://raw.githubusercontent.com/wdikiz/wdikiz/main/projects/Smtp.png">
  </a>
</p>





<br>


<br>


## Project Download

<a href="https://github.com/wdikiz/Pigeon/releases">**Pigeon Project**</a>.


## SMTP configuration 

The SMTP server need to be configured in order to work properly.

1. Choose a service provider or choose to enter manual informations
2. In my example, i choose `Google Service`. **if this is the first time same information(eg. server, port) will be automatically filled**
3. Enter your username mainly `your email adresse`
4. Enter your password **(refere to the section password configuration)**
5. Check `Mémoriser mes informations`
6. **IMPORTANT** finally click on `Enregistrer`.

## Password Configuration

Each service provider have his own password connection methode as a example i will choose Google service

## Requirements
**IMPORTANT : 2-Step-Verification need to be activated in order to use Google App Password.**
```c#
    1.  Go to your Google Account.
    2. Select Security.
    3. Under "Signing in to Google," select App Passwords. You may need to sign in. If you don’t have this option, it might be because:
        3.1 -Step Verification is not set up for your account.
        3.2 -Step Verification is only set up for security keys.
        3.3 Your account is through work, school, or other organization.
        3.4 You turned on Advanced Protection.
    4. At the bottom, choose Select app and choose the app you using and then Select device and choose the device you’re using and then Generate.
    5. Follow the instructions to enter the App Password. The App Password is the 16-character code in the yellow bar on your device.
    6. Tap Done.

Tip: Most of the time, you’ll only have to enter an App Password once per app or device, so don’t worry about memorizing it.

```

## Video tutorial

 <video src="https://raw.githubusercontent.com/wdikiz/wdikiz/main/assets/tuto%20pour%20pigeon.mp4" controls="controls" muted="muted" playsinline="playsinline"></video> 


## Some small technical points used

```python
C#
SMTP protocole
Thread Pool
Times tasks
Regex
```


## TODO

- Enable CSV Compatiility
- Enable SMTP statut test
- Add Dark mode


## Troubles and challenges
```
The Smtp configuration depends on each service provider, also on needs for user , for huge SMTP process , you may need a powerfull SMTP service provder.```
