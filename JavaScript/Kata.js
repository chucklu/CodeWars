var array = ["I love you","a little","a lot","passionately","madly","not at all"];

function howMuchILoveYou(nbPetals)
{
    var i = (nbPetals-1)%6;
    return array[i];
}
