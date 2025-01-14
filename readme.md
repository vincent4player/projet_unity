# Flappy Dunk

**Flappy Dunk** sera un jeu en cours de developpement sous Unity où le joueur contrôlera un ballon et devra traverser des cerceaux pour marquer des points. Le gameplay reposera sur une seule interaction : un clic ou un tap pour faire sauter le ballon. Ce projet respectera des spécifications techniques pour inclure plusieurs scènes, des éléments d'interface utilisateur (UI), des événements aléatoires et la manipulation de prefabs.

---

## 📋 Spécifications techniques

### 1. Scènes
- **Menu principal** :
  - Contiendra un bouton "Jouer" et un affichage du meilleur score.
  - Permettra de naviguer vers la scène de jeu.
- **Scène de jeu** :
  - Le joueur contrôlera un ballon pour passer à travers des cerceaux.
  - Contiendra une interface de score en temps réel et un bouton pause.
  - En fonction des points obtenus le fond du jeux peux changer. 

### 2. Interface Utilisateur (UI)
- **Menu principal** :
  - **Bouton** : "Jouer" pour commencer la partie.
  - **Texte** : Titre du jeu et meilleur score enregistré.
- **Scène de jeu** :
  - **Texte dynamique** : Affichera le score en cours.
  - **Bouton image** : Une icône permettra de mettre le jeu en pause.

### 3. Événements aléatoires
- Les cerceaux apparaîtront à des positions verticales aléatoires.
- Les cerceaux pourront avoir des propriétés aléatoires (taille, mouvement).

### 4. Manipulation de prefabs
- **Prefab Cerceau** : Sera instancié dynamiquement pour générer des obstacles.
- **Prefab Effet de particule** : Jouera lorsqu'un cerceau sera traversé avec succès.
- Les cerceaux seront générés en boucle et se déplaceront pour simuler un défilement infini.

---

## 🎮 Gameplay

- **Interaction unique** : Le joueur cliquera ou tapera pour faire sauter le ballon.
- Si le ballon touche les cotés ou manque un cerceau, la partie se terminera.
- À chaque cerceau traversé, le score augmentera de 1 sauf si le ballon ne touche pas l'arceau il y aura un bonus multiplicateur 
---

## 🛠️ Architecture du projet

### Scripts principaux
- **GameController** :
  - Gèrera le score, la génération des cerceaux et la fin de partie.
  - Permettra de mettre le jeu en pause.
- **BallController** :
  - Gèrera les interactions (saut du ballon) et les collisions.
- **CerceauSpawner** :
  - Générera les cerceaux à des positions aléatoires.
- **UIManager** :
  - Mettra à jour les éléments de l'interface utilisateur.

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
   - Affichera le titre du jeu et le meilleur score.
   - Le bouton "Jouer" permettra de démarrer une partie.
2. **Scène de jeu** :
   - Le joueur contrôlera le ballon avec des clics/taps.
   - Les cerceaux seront générés dynamiquement.
3. **Fin de partie** :
   - Le score sera enregistré si c’est le meilleur.
   - Le joueur sera redirigé vers le menu principal.

---

## 📦 Fonctionnalités supplémentaires (optionnel)
- **Déblocage de skins** : Des apparences seront déverrouillées en atteignant certains scores.
- **Effets sonores** : Différents sons seront ajoutés pour le saut, le passage dans un cerceau et la fin de partie.
- **Difficulté progressive** : La vitesse des cerceaux augmentera, et leur taille diminuera au fil du temps.

---

## 🧰 Instructions pour lancer le projet

1. Le dépôt devra être cloné :
   ```bash
   git clone https://github.com/votre-utilisateur/flappy-dunk.git

2. Le projet devra être ouvert dans Unity.

3. En appuyant sur le bouton "Play", le jeu pourra être testé.

## 🏆 Objectifs pédagogiques

Ce projet sera conçu pour intégrer des concepts essentiels en développement de jeu vidéo avec Unity :

    ° Manipulation de scènes.

    ° Création et utilisation de prefabs.

    ° Gestion des événements aléatoires.
    
    ° Mise en place d'interfaces utilisateur dynamiques.
