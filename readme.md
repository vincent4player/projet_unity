# Flappy Dunk

**Flappy Dunk** est un jeu développé sous Unity où le joueur contrôle un ballon et doit traverser des cerceaux pour marquer des points. Le gameplay repose sur une seule interaction : un clic ou un tap pour faire sauter le ballon. Ce projet respecte des spécifications techniques pour inclure plusieurs scènes, des éléments d'interface utilisateur (UI), des événements aléatoires et la manipulation de prefabs.

---

## 📋 Spécifications techniques

### 1. Scènes
- **Menu principal** :
  - Contient un bouton "Jouer" et un affichage du meilleur score.
  - Permet de naviguer vers la scène de jeu.
- **Scène de jeu** :
  - Le joueur contrôle un ballon pour passer à travers des cerceaux.
  - Contient une interface de score en temps réel et un bouton pause.

### 2. Interface Utilisateur (UI)
- **Menu principal** :
  - **Bouton** : "Jouer" pour commencer la partie.
  - **Texte** : Titre du jeu et meilleur score enregistré.
- **Scène de jeu** :
  - **Texte dynamique** : Affiche le score en cours.
  - **Bouton image** : Icône pour mettre le jeu en pause.

### 3. Événements aléatoires
- Les cerceaux apparaissent à des positions verticales aléatoires.
- Les cerceaux peuvent avoir des propriétés aléatoires (taille, mouvement).

### 4. Manipulation de prefabs
- **Prefab Cerceau** : Instancié dynamiquement pour générer des obstacles.
- **Prefab Effet de particule** : Joué lorsque le ballon traverse un cerceau avec succès.
- Les cerceaux sont générés en boucle et se déplacent pour simuler un défilement infini.

---

## 🎮 Gameplay

- **Interaction unique** : Cliquez ou tapez pour faire sauter le ballon.
- Si le ballon touche le sol ou manque un cerceau, la partie se termine.
- À chaque cerceau traversé, le score augmente.

---

## 🛠️ Architecture du projet

### Scripts principaux
- **GameController** :
  - Gère le score, la génération de cerceaux et la fin de partie.
  - Permet de mettre le jeu en pause.
- **BallController** :
  - Gère les interactions (saut du ballon) et les collisions.
- **CerceauSpawner** :
  - Génère les cerceaux à des positions aléatoires.
- **UIManager** :
  - Met à jour les éléments de l'interface utilisateur.

### Assets
- **Images** :
  - Ballon, cerceaux, fond d'écran, icône pause.
- **Prefabs** :
  - Cerceau, effet de particule.
- **Audio** :
  - Saut du ballon, passage dans un cerceau, fin de partie.

---

## 🚀 Flow du jeu

1. **Menu principal** :
   - Affiche le titre du jeu et le meilleur score.
   - Bouton "Jouer" pour démarrer une partie.
2. **Scène de jeu** :
   - Le joueur contrôle le ballon avec des clics/taps.
   - Les cerceaux sont générés dynamiquement.
3. **Fin de partie** :
   - Enregistre le score si c’est le meilleur.
   - Retourne au menu principal.

---

## 📦 Fonctionnalités supplémentaires (optionnel)
- **Déblocage de skins** : Déverrouillez des apparences en atteignant certains scores.
- **Effets sonores** : Sons pour le saut, le passage dans un cerceau et la fin de partie.
- **Difficulté progressive** : Augmentation de la vitesse des cerceaux et réduction de leur taille au fil du temps.

---


