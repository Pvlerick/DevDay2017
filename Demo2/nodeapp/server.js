'use strict';

const express = require('express');

// Constants
const PORT = 8080;
const HOST = '0.0.0.0';

// App
const app = express();
app.get('/', (req, res) => {
  res.json({
    "quotes": [
      "Yeah, piece of cake!",
      "I should have known those alien maggots booby-trapped this sub.",
      "It's time to abort your whole freaking species!",
      "My name's Duke Nukem.",
      "It's time to kick ass and chew bubble gum, and I'm all outta gum!",
      "I'm Duke Nukem, and I'm coming to get the rest of you alien bastards!",
      "Nobody steals our chicks... and lives!",
      "We meet again, Doctor Jones.",
      "I'm gonna put the smack dab on your ass.",
      "You're an inspiration for birth control.",
      "Cool!",
      "Groovy!",
      "See you in Hell!",
      "Holy cow!",
      "Shit happens.",
      "Holy shit!",
      "Looks like it's time for me to go postal!",
      "Where is it?",
      "Hmmm... looks like I have the CON!",
      "Born to be wiiiiiiiiild!",
      "This is KTIT, K-Tit! Playin' the breast - uhh, the best tunes in town!",
      "Shake it, baby!",
      "You guys suck!",
      "What? There's only one of you?",
      "Go ahead, make my day!",
      "So help me Duke.",
      "Yippie yay, motherf*cker.",
      "Yohoho and a bottle of jack!",
      "Harr matey, someone's gonna take a long walk off a short gang plank!",
      "You wanna dance?",
      "Nobody jacks with our independence!",
      "After a few days of R&R... I'll be ready for more action!",
      "Game over!",
      "I'm gonna get medieval on your asses!",
      "Terminated!",
      "Looks like cleanup on Aisle 4.",
      "What're you waiting for? Christmas?",
      "I'll be back.",
      "Hail to the king, baby!",
      "I'm not crying over this!",
      "Damn, that was annoying!",
      "Hmmm... book 'em, Danno!",
      "Let God sort 'em out!",
      "Hmmm... I'm going in!",
      "Hmmm, my kind of party! I wish I had time!",
      "Damn, I'm looking good!",
      "Suck it down!",
      "Damn, those alien bastards are gonna pay for shooting up my ride.",
      "Get back to work, you slacker!",
      "Hehehe, what a mess!",
      "No way I'm eating this shit.",
      "Nobody messes with my meat!",
      "Hmm, that's one 'Doomed' Space Marine.",
      "Hmm, don't have time to play with myself.",
      "Let's rock.",
      "Damn, you're ugly.",
      "Damn...",
      "Damn it.",
      "Who wants some?",
      "Come get some!",
      "Damn I'm good.",
      "Get that crap outta here.",
      "I guess he didn't escape from L.A.!",
      "I'll rip your head off and shit down your neck!",
      "Come on!",
      "Die, you son of a bitch!",
      "Your face, your ass... what's the difference?",
      "Blow it out your ass!",
      "You're pissing me off!",
      "Gonna rip 'em a new one!",
      "It's down to you and me, you one eyed freak!",
      "This really pisses me off!",
      "Ahhh... much better!",
      "Uh, this sucks.",
      "Guess again, freakshow. Duke's coming back to town, and the last thing that's gonna go through your mind before you die... is my size 13 boot!",
      "Ready for action.",
      "Bitchin'.",
      "I'm gonna kick your ass, bitch!",
      "Ooooh, that's gotta hurt!",
      "Where is it?",
      "I ain't afraid of no quake.",
      "Now this is the force to be reckoned with!",
      "Somebody's gonna freaking pay for screwing up my vacation!",
      "Damn! That's the second time those alien bastards shot up my ride!",
      "I think I'll climb aboard."
    ]
  });
});

app.listen(PORT, HOST);
console.log(`Running on http://${HOST}:${PORT}`);