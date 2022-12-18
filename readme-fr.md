<p align="center">
  <a href="" target="blank">
    <img src="https://raw.githubusercontent.com/wdikiz/wdikiz/3b3ef1590e0d58f359ff6105bb0089d6d129b7fb/projects/Logo%20blue.svg" width="320" alt="Pigeon Logo Blue" />
  </a>
</p>

<p align="center">
  Client de messagerie pour Windows. Simple, robuste et convivial. Créé en Windows Forms C#
</p>


## Objectifs

L'objectif principal de ce projet est de <strong>est répondre au besoin des utilisateurs en matière de traitement et envoie des mails.</strong> **En principe, le projet, c'est un projet qui s'inscrit dans le cursus scolaire et l'utilisateur sera principalement une école primaire**.

## Caractéristiques et points forts

1. Prise en charge du contenu des messages personnalisés
2. Prise en charge du format Richetexte
3. Supporte de nombreux fournisseurs de services SMTP
4. Prise en charge de l'édition et de la prévisualisation des messages, ainsi que de leur gestion.
5. Support pour l'importation d'utilisateurs via des fichiers (txt, excel, csv(bientôt))
6. Interface visuelle petite et belle, supportant divers styles d'apparence claire et sombre.
8. Prise en charge du réglage global de la taille de la police
8. Supporte l'authentification de base au serveur SMTP.
9. Supporte la connexion anonyme au serveur SMTP


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


## Téléchargement du projet

<a href="https://github.com/wdikiz/Pigeon/releases">**Projet Pigeon**</a>.


## Configuration SMTP 

Le serveur SMTP doit être configuré afin de fonctionner correctement.

1. Choisissez un fournisseur de services ou choisissez d'entrer les informations manuellement.
2. Dans mon exemple, j'ai choisi `Google Service`. **Si c'est la première fois, les mêmes informations (ex. serveur, port) seront automatiquement remplies**.
3. Entrez votre nom d'utilisateur principalement `votre adresse email`.
4. Entrez votre mot de passe **(référez-vous à la section configuration du mot de passe) **.
5. Cochez `Mémoriser mes informations`.
6. **IMPORTANT** enfin cliquez sur `Enregistrer`.

## Password Configuration

Each service provider have his own password connection methode as a example i will choose Google service

## Exigences
**IMPORTANT : La vérification en 2 étapes doit être activée pour pouvoir utiliser le mot de passe Google App**.
```c#
    1.  Accédez à votre compte Google.
    2. Sélectionnez Sécurité.
    3. Sous "Connexion à Google", sélectionnez Mots de passe d'application. Vous devrez peut-être vous connecter. Si vous n'avez pas cette option, c'est peut-être parce que :
        3.1 -La vérification par étapes n'est pas configurée pour votre compte.
        3.2 -La vérification par étape est seulement configurée pour les clés de sécurité.
        3.3 Votre compte provient de votre travail, de votre école ou d'une autre organisation.
        3.4 Vous avez activé la protection avancée.
    4. En bas, choisissez Sélectionner l'application et choisissez l'application que vous utilisez, puis sélectionnez l'appareil et choisissez l'appareil que vous utilisez, puis Générez.
    5. Suivez les instructions pour saisir le mot de passe de l'application. Le mot de passe de l'application est le code à 16 caractères figurant dans la barre jaune de votre appareil.
    6. Appuyez sur Terminé.

Conseil : la plupart du temps, vous n'aurez à saisir un mot de passe d'application qu'une seule fois par application ou appareil, alors ne vous souciez pas de le mémoriser.

```

## Tutoriel vidéo

 <video src="" controls="controls" muted="muted" playsinline="playsinline">
</video> 

<div align="center">
      <a href="https://www.youtube.com/watch?v=P4jsLM0Y2q0">
     <img 
      src="https://raw.githubusercontent.com/wdikiz/wdikiz/main/assets/videothumbtn.png" 
      alt="Video tuto" 
      style="width:100%;">
      </a>
    </div>
    
## Quelques petits points techniques utilisés

``python
C#
Protocole SMTP
Pool de threads
Temps de tâches
Regex
```


## TODO

- Activer la compatibilité CSV
- Activer le test de statut SMTP
- Ajouter le mode sombre


## Difficultés et défis
```
La configuration du SMTP dépend de chaque fournisseur de service, ainsi que des besoins de l'utilisateur, pour un processus SMTP important, vous pouvez avoir besoin d'un fournisseur de service SMTP puissant.
