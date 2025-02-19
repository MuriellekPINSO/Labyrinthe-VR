# 🏛️ **Labyrinthe VR - Exploration en Réalité Virtuelle**  

## 📌 **Description du Projet**  
Labyrinthe VR est une expérience immersive en réalité virtuelle où le joueur explore un labyrinthe complexe à la recherche de la sortie. Des indices sont dissimulés dans l’environnement pour l’aider à progresser, et un minuteur ajoute un défi supplémentaire. L’application peut être utilisée avec un casque VR ou directement sur un smartphone pour une navigation fluide.  

## 🎮 **Fonctionnalités Principales**  
- **Exploration interactive** : Déplace-toi librement dans un labyrinthe 3D détaillé.  
- **Deux modes de jeu** : Compatible avec les casques VR (Google Cardboard) et accessible sur smartphone.  
- **Mécanique de déplacement fluide** : Grâce au **Mini First Person Controller**, l’utilisateur peut avancer, reculer et tourner la tête pour explorer l’environnement.  
- **Indices visuels et sonores** : Des statuettes interactives émettent des effets audio lorsqu’elles sont dans le champ de vision du joueur.  
- **Défi chronométré** : Un minuteur oblige le joueur à trouver la sortie avant la fin du temps imparti. En cas d’échec, il est redirigé à l’entrée du labyrinthe pour recommencer.  

## 🛠️ **Technologies Utilisées**  
- **Unity 6** (moteur de jeu)  
- **Blender** (modélisation du labyrinthe)  
- **Google VR** (prise en charge de la réalité virtuelle)  
- **Mini First Person Controller** (mécanique de déplacement)  
- **C#** (programmation du gameplay et des interactions)  

## 📥 **Installation et Lancement**  
### 🔹 **Prérequis**  
- Unity installé (Version 6)
- Un smartphone Android ou un casque VR compatible  
- Cloner le projet avec :  
  ```bash
  git clone https://github.com/ton-profil/labyrinthe-vr.git
  cd labyrinthe-vr
  ```

### 🔹 **Exécution**  
1. **Ouvrir le projet** avec Unity.  
2. **Vérifier les dépendances** : Assurez-vous que Google VR et les autres packages sont bien installés.  
3. **Lancer la scène principale** pour tester le jeu dans l’éditeur.  
4. **Construire l’application** pour Android (`File > Build Settings > Android > Build & Run`).  

## 📱 **Commandes et Navigation**  
| Action | Commande |
|--------|----------|
| Se déplacer | Incliner le smartphone ou utiliser le joystick (VR) |
| Tourner la tête | Bouger la tête (VR) ou glisser l’écran (mobile) |
| Activer un indice | Regarder une statuette |
| Rejouer après échec | Automatique (redirigé à l’entrée) |

## 📌 **Améliorations Futures**  
✅ Ajout de niveaux plus complexes  
✅ Personnalisation des avatars et des environnements  
✅ Mode multijoueur coopératif  
 
