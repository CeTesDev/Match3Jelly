
mergeInto(LibraryManager.library, {

    gameLoadedLib: function () {
        //post action game loaded to the platfrom (the game finished loading)
        parent.postMessage("gameLoaded", "*");
        console.log("PlaysiveSDK Debug - Load Action (gameLoaded)");
    },

    gamePostScoreLib: function (score) {
        //post action of the score, this is done by game over state in the game
        //this will end the game and will raise the ui of the parent activity 
        if (score != undefined && score != null) {
            parent.postMessage(score, "*");
            console.log("PlaysiveSDK Debug - Post Action (postScore: " + score + ")");
        }
    }

});