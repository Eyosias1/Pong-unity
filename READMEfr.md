# SokoBan

Tags: C#, Unit
Status: Done

# **Nom du Jeu *:** Sokoban*

**Type de Jeu :** *2D, jeu vidéo de réflexion, 1 joueur*

**Description :** *Ce jeu que nous comptons implémenter est
inspiré du jeu Sokoban, jeu de réflexion, inventé au Japon.
Dans ce jeu, le joueur doit ranger des caisses sur des cases
cibles. Il peut se déplacer dans les quatre directions, et
pousser (mais pas tirer) une seule caisse à la fois. Une fois
toutes les caisses rangées, le niveau est réussi et le joueur passe
au niveau suivant, plus difficile en général.*

**Mécanismes à implémenter :**

- [ ]  *Modéliser le plateau de jeu, les caisses et le joueur*
- [ ]  *Gérer le mouvement du joueur*
- [ ]  *Gérer le mouvement des caisses*
- [ ]  *Gérer les collisions entre le joueur et les caisses*
- [ ]  *Gérer les collisions entre le joueur et le mur*
- [ ]  *Gérer les collisions entre les caisses et le mur*
- [ ]  *Ajouter des effets audios lorsqu’il y a un obstacle que l’on ne peut franchir*
- [ ]  *Ajouter des effets audios lorsque le joueur déplace une caisse*
- [ ]  *Ajouter un chrono pour connaitre le meilleur temps sur un niveau*
- [ ]  *Ajouter un menu avec bouton « jouer », « niveau » et « exit »*
- [ ]  *Ajouter un menu avec tous les niveaux*
- [ ]  *Ajouter une difficulté en imposant un nombre de déplacement possible*

## Détails d’implémentation

- **Développé la gestion des caisses** : Implémenté la classe **`Crate`** pour gérer les interactions et les déplacements des caisses dans le jeu.
- **Implémenté la détection des objectifs** : Conçu la classe **`Dot`** pour détecter et gérer les positions des objectifs où les caisses doivent être placées.
- **Coordonné la logique du jeu** : Créé la classe **`Game`** pour orchestrer les mécanismes principaux du jeu, incluant la gestion des niveaux et des interactions entre les éléments.
- **Administré les états du jeu** : Développé la classe **`GameManager`** pour contrôler les états du jeu, tels que le démarrage, la pause, et la fin des parties.
- **Conçu l'interface utilisateur** : Utilisé la classe **`MenuController`** pour gérer les interactions avec le menu principal, offrant une expérience utilisateur fluide et intuitive.
- **Contrôlé les mouvements du joueur** : Programmé la classe **`Player`** pour gérer les déplacements du personnage, incluant les contrôles et les interactions avec les caisses et les murs.

![Unity-game-gyphy.gif](assets/Unity-game-gyphy.gif)
